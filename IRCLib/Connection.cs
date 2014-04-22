/* Copyright (C) 2014  Martin Jørgensen, http://flanker.dk
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>
 */

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace IRCLib
{
    /// <summary>
    /// Class representing a connection to an IRC server.
    /// </summary>
    /// <remarks>
    /// This class will register the connection using a provided config
    /// and do nothing else. It is up to the user or using classes to
    /// keep the connection alive (ping messages etc).
    /// </remarks>
    public class Connection
    {
        // The underlying network stream.
        private  NetworkStream _stream;

        // Semaphore controlling access to the network stream.
        private  Semaphore _streamlock;

        // Constructor thread
        private readonly Thread _constructor;

        // Configuration.
        private readonly ConnectionConfig _conf;

        // Threads for reading and writing.
        private Thread _rThread;
        private Thread _wThread;

        // Buffer that users can put text/commands in, that will be transmitted.
        private ConcurrentQueue<string> _sbuffer;

        // Buffer containing messages from the server that users can retrieve at will.
        private ConcurrentQueue<string> _rbuffer;

        /// <summary>
        /// Boolean value telling whether or not the TcpClient is connected.
        /// </summary>
        public bool Connected;

        /// <summary>
        /// Boolean value telling whether or not the connection successfully registered with the server.
        /// </summary>
        public bool Registered;

        /// <summary>
        /// Constructor for the class. Note that the connection might not be established, even when this call returns.
        /// Check the Registered variable.
        /// </summary>
        /// <param name="conf"></param>
        public Connection(ConnectionConfig conf)
        {
            _conf = conf;
            _constructor = new Thread(Handshake);
            _constructor.Start();
        }

        private void Handshake()
        {
            if (!ValidConfig(_conf))
            {
                throw new InvalidConfigException("The configuration was invalid, please recheck.");
            }

            TcpClient con;
            Connected = false;
            Registered = false;

            // Create TCP connection to the server.
            try
            {
                con = new TcpClient(_conf.Server, _conf.Port);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw new ArgumentOutOfRangeException(
                    "The portnumber was outside the portrange " + IPEndPoint.MinPort + "-" + IPEndPoint.MaxPort, ex);
            }
            catch (SocketException ex)
            {
                throw new Exception("SocketException upon connection attempt, errorcode=" + ex.ErrorCode,ex);
            }
            Connected = true;
            // Attempt to register the connection (and ignore server messages for now.).
            _stream = con.GetStream();

            _streamlock = new Semaphore(1,1);
            _rbuffer = new ConcurrentQueue<string>();
            _sbuffer = new ConcurrentQueue<string>();

            _wThread = new Thread(WriteWorker);
            _rThread = new Thread(ReadWorker);
            _wThread.Start();
            _rThread.Start();

            try
            {
                Send("PASS " + _conf.Password);
            }
            catch (NoConnectionException ex)
            {
                throw new NoConnectionException("Unable to send PASS command.",ex);
            }

            // I know its not recommended practice to send USER before NICK, bit my code is a bit sloppy, so I need it.
            Send("USER " + _conf.Username + " hostname servername :" + _conf.Realname);

            // Nicks loop go here.
            var approved = false;
            while (!approved)
            {
                foreach (var nick in _conf.Nicks)
                {
                    Send("NICK " + nick);

                    // Allow server 3 seconds to reply.
                    Thread.Sleep(3000);
                    // TODO: Find a better way to do this.

                    var reads = _rbuffer.ToArray();
                    if (!RecievedWelcome(reads)) continue;
                    approved = true;
                    break;
                }
                if (approved) continue;
                // Since the chance of a GUID collision is sooooooooooooooo small, I always assume the guid gets approved :)
                var gnick = "IRC" + Guid.NewGuid().ToString().Substring(0, 6);
                Send("NICK " + gnick);
                Send("NOTICE " + gnick + " No nicks in your configuration got approved by the server, temporary nick assigned: " + gnick);
                approved = true;
            }
            
            Registered = true;
            Thread.CurrentThread.Abort();
        }

        /// <summary>
        /// Checks an array of strings (assumed to be IRC messages) if a welcome message is among them.
        /// </summary>
        /// <param name="messages"></param>
        /// <returns></returns>
        private static bool RecievedWelcome(IEnumerable<string> messages)
        {
            foreach (var message in messages)
            {
                var line = new IRCLine(message);
                var cmd = line.Command;
                int reply;
                var suc = int.TryParse(cmd, out reply);
                if (suc && (IRCReplies)reply == IRCReplies.RPL_WELCOME)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Converts a string to ASCII bytes and sends it over the connection. Messages should only be single lines and no longer than 510 characters.
        /// </summary>
        /// <param name="message">The message to convert into ASCII bytes. Message must be at most 510 chars and not contain CRLF.</param>
        /// <exception cref="Exception">Throws an exception if the stream is not writeable.</exception>
        public void Send(string message)
        {
            if (Connected)
            {
                _sbuffer.Enqueue(message);
            }
            else
            {
                throw new NoConnectionException("The connection is not alive.");
            }
        }

        /// <summary>
        /// Returns a line from the connection.
        /// </summary>
        /// <returns>A line with data from the stream, or null if no data is present.</returns>
        public string ReadLine()
        {
            if (_rbuffer.Count <= 0) return null;
            string message;
            _rbuffer.TryDequeue(out message);
            return message;
        }

        /// <summary>
        /// Causes the connection to close and terminate child threads.
        /// </summary>
        public void Close(string quitMessage)
        {
            Send("QUIT " + quitMessage);
            Thread.Sleep(1000); // Give reader and writer a chance to finish up :)
            _rThread.Abort();
            _wThread.Abort();
            _constructor.Abort();
            _stream.Dispose();
        }

        /// <summary>
        /// Flushes the read/write buffers and the network stream.
        /// </summary>
        public void Flush()
        {
            _sbuffer = new ConcurrentQueue<string>();
            _rbuffer = new ConcurrentQueue<string>();
            _stream.Flush();
        }

        /// <summary>
        /// Checks wether a ConnectionConfig is valid or not.
        /// </summary>
        /// <remarks>
        /// There is 4 criteria:
        /// 1) There must be at least one nick in the Nicks list.
        /// 2) The port must be between IPEndPoint.MinPort and IPEndPoint.MaxPort.
        /// 3) The servername must be at least 5 chars long.
        /// 4) The username must be at least 1 char long.
        /// </remarks>
        /// <param name="conf">The configuration to validate.</param>
        /// <returns>A boolean value indicating the validity of the configuration. True = Valid.</returns>
        private static bool ValidConfig(ConnectionConfig conf)
        {
            var res = (conf.Nicks.Count > 0);
            res = res && ((conf.Port > IPEndPoint.MinPort) && (conf.Port < IPEndPoint.MaxPort));
            res = res && (conf.Server.Length > 4);
            res = res && (conf.Username.Length > 0);
            return res;
        }

        /// <summary>
        /// Endless loop that reads the stream and puts any data in the read buffer.
        /// throws NoConnectionException if the stream is closed.
        /// </summary>
        private void ReadWorker()
        {
            var sr = new StreamReader(_stream);
            while (true)
            {
                if (_stream.DataAvailable)
                {
                    _streamlock.WaitOne(-1);
                    try
                    {
                        var message = sr.ReadLine();
                        if (message != null)
                            _rbuffer.Enqueue(Encoding.ASCII.GetString(Encoding.ASCII.GetBytes(message)));
                        // Casting to byte and then string to overcome encoding issues... I hope.
                    }
                    catch (Exception ex)
                    {
                        throw new NoConnectionException("An exception occured when reading from the stream.", ex);
                    }
                    _streamlock.Release();
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
        }

        /// <summary>
        /// Endless loop that writes the write buffer to the stream, throws NoConnectionException
        /// if the stream is cant write.
        /// </summary>
        public void WriteWorker()
        {
            while (true)
            {
                if (_sbuffer.Count > 0)
                {
                    _streamlock.WaitOne(-1);
                    try
                    {
                        string message;
                        _sbuffer.TryDequeue(out message);
                        if (message.Length > 510)
                        {
                            message = message.Substring(0, 510);
                        }
                        if (!message.EndsWith("\r\n"))
                        {
                            message = message + "\r\n";
                        }
                        var bytes = Encoding.ASCII.GetBytes(message);
                        _stream.Write(bytes, 0, bytes.Length);
                    }
                    catch (ObjectDisposedException ex)
                    {
                        throw new NoConnectionException("The stream have been closed.", ex);
                    }
                    _streamlock.Release();
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
        }
    }
}
