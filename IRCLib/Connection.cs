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
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

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
        // TcpClient used for connection.
        private TcpClient _con;

        // The underlying network stream.
        private readonly NetworkStream _stream;

        // Buffer that users can put text/commands in, that will be transmitted.
        //private List<string> _sbuffer;

        // Buffer containing messages from the server that users can retrieve at will.
        //private List<string> _rbuffer;

        /// <summary>
        /// Boolean value telling whether or not the TcpClient is connected.
        /// </summary>
        public bool Connected;

        /// <summary>
        /// Boolean value telling whether or not the connection successfully registered with the server.
        /// </summary>
        public bool Registered;
        public Connection(ConnectionConfig conf)
        {
            Connected = false;
            Registered = false;

            // Create TCP connection to the server.
            try
            {
                _con = new TcpClient(conf.Server, conf.Port);
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

            // Attempt to register the connection (and ignore server messages for now.).
            _stream = _con.GetStream();

            Send("PASS " + conf.Password);
            // Nicks loop go here.
            var approved = false;
            while (approved == false)
            {
                foreach (var nick in conf.Nicks)
                {
                    Send("NICK " + nick);
                }
                
            }
            Send("USER " + conf.Username + " hostname servername :" + conf.Realname);
        }

        /// <summary>
        /// Converts a string to ASCII bytes and sends it over the connection. Messages should only be single lines.
        /// </summary>
        /// <param name="message">The message to convert into ASCII bytes.</param>
        /// <exception cref="Exception">Throws an exception if the stream is not writeable.</exception>
        /// TODO: Convert to async so we don't need to wait for the stream writing.
        public void Send(string message)
        {
            if (Connected)
            {
                if (_stream.CanWrite)
                {
                    var bytes = Encoding.ASCII.GetBytes(message);
                    _stream.Write(bytes, 0, bytes.Length);
                }
                else
                {
                    throw new Exception("Connection._stream is no longer writeable, is it alive?");
                }
            }
            else
            {
                throw new Exception("The connection is not alive.");
            }
        }

        /// <summary>
        /// Returns a line from the connection.
        /// </summary>
        /// <returns></returns>
        public string ReadLine()
        {
            var sr = new StreamReader(_stream);
            return sr.ReadLine();
        }
    }
}
