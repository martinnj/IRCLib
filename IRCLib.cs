using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IRCLib
{
    /// <summary>
    /// Enum type for the possibe replies an IRC server might send back.
    /// </summary>
    public enum Replies
    {
        // ReSharper disable InconsistentNaming

        // Registration replies.
        RPL_WELCOME          = 001,
        RPL_YOURHOST         = 002,
        RPL_CREATED          = 003,
        RPL_MYINFO           = 004,
        RPL_BOUNCE           = 005,

        // Error replies.
        ERR_NOSUCHNICK       = 401,
        ERR_NOSUCHSERVER     = 402,
        ERR_NOSUCHCHANNEL    = 403,
        ERR_CANNOTSENDTOCHAN = 404,
        ERR_TOOMANYCHANNELS  = 405,
        ERR_WASNOSUCHNICK    = 406,
        ERR_TOOMANYTARGETS   = 407,
        ERR_NOSUCHSERVICE    = 408,
        ERR_NOORIGIN = 409
        // ReSharper restore InconsistentNaming
    };

    /// <summary>
    /// Baseclass for the entire library. So far, might change. you know. :)
    /// </summary>
    public class IRCLib
    {
    }
}
