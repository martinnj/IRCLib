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

using System.Collections.Generic;

namespace IRCLib
{
    public class ConnectionConfig
    {
        /// <summary>
        /// Hostname or IP for the IRC server to connect to.
        /// </summary>
        public string Server;
        /// <summary>
        /// Port number used for the TCP connection.
        /// </summary>
        public int Port;
        /// <summary>
        /// Server password. Optional but should be set for security.
        /// </summary>
        public string Password;
        /// <summary>
        /// Username to register with the server.
        /// </summary>
        public string Username;
        /// <summary>
        /// The real name to register with the server.
        /// </summary>
        public string Realname;
        /// <summary>
        /// List of nicks to attempt to register with.
        /// </summary>
        /// <remarks>
        /// Will first try to register Nicks[0], then Nicks[1] etc.
        /// If one succeeds, no more attempts are made, if all the nicks are
        /// taken, a GUID will be generated and used.
        /// </remarks>
        public List<string> Nicks;

        public ConnectionConfig(string server,
                                int    port,
                                string password,
                                string username,
                                string realname,
                                List<string> nicks)
        {
            Server = server;
            Port = port;
            Password = password;
            Username = username;
            Realname = realname;
            Nicks = nicks;
        }
    }
}
