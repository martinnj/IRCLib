﻿/* Copyright (C) 2014  Martin Jørgensen, http://martinnj.dk
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

namespace IRCLib
{
    /// <summary>
    /// Exception for use by the Connection class, when the underlying stream have died.
    /// </summary>
    public class NoConnectionException : Exception
    {
        public NoConnectionException()
        {
        }

        public NoConnectionException(string message)
            : base(message)
        {
        }

        public NoConnectionException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    public class InvalidConfigException : Exception
    {
        public InvalidConfigException()
        {
        }

        public InvalidConfigException(string message)
            : base(message)
        {
        }

        public InvalidConfigException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
