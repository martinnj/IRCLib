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
