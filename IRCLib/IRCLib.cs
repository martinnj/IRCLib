/* Copyright (C) 2014  Martin Jørgensen, http://martinnj.dk
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
    /// <summary>
    /// Enum type for the possibe replies an IRC server might send back.
    /// </summary>
    public enum IRCReplies
    {
        // ReSharper disable InconsistentNaming

        // Own hacked number
        NOTICE                  = 000,

        // Registration replies.
        RPL_WELCOME             = 001,
        RPL_YOURHOST            = 002,
        RPL_CREATED             = 003,
        RPL_MYINFO              = 004,
        RPL_ISUPPORT            = 005,

        // Error replies.
        ERR_NOSUCHNICK          = 401,
        ERR_NOSUCHSERVER        = 402,
        ERR_NOSUCHCHANNEL       = 403,
        ERR_CANNOTSENDTOCHAN    = 404,
        ERR_TOOMANYCHANNELS     = 405,
        ERR_WASNOSUCHNICK       = 406,
        ERR_TOOMANYTARGETS      = 407,
        ERR_NOORIGIN            = 409,
        ERR_NORECIPIENT         = 411,
        ERR_NOTEXTTOSEND        = 412,
        ERR_NOTOPLEVEL          = 413,
        ERR_WILDTOPLEVEL        = 414,

        ERR_ERR_NONICKNAMEGIVEN = 431,
        ERR_ERRONEUSNICKNAME    = 432,
        ERR_NICKNAMEINUSE       = 433,
        ERR_NICKCOLLISION       = 436
        // ReSharper restore InconsistentNaming
    };
}
