using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IRCLib
{
    /// <summary>
    /// Represents a line recieved from an IRC server, used to parse the line into meaningfull fields.
    /// </summary>
    public class IRCLine
    {
        private string _exp = "^(?:[:@]([^\\s]+) )?([^\\s]+)(?: ((?:[^:\\s][^\\s]* ?)*))?(?: ?:(.*))?$";
        /// <summary>
        /// List of all the values in the line, the first entry is the entire line.
        /// </summary>
        public readonly List<string> Values;

        /// <summary>
        /// The entire line.
        /// </summary>
        public readonly string Line;

        /// <summary>
        /// The sender of the message.
        /// </summary>
        public readonly string Sender;

        /// <summary>
        /// The numeric contained in the message.
        /// </summary>
        public readonly string Numeric;

        /// <summary>
        /// The indended recipient of the message.
        /// </summary>
        public readonly string Reciever;

        /// <summary>
        /// The actual message.
        /// </summary>
        public readonly string Message;
        public IRCLine(string line)
        {
            var match = Regex.Match(line, _exp, RegexOptions.IgnoreCase);
            Values = new List<string>();
            if (match.Success)
            {
                foreach (var grp in match.Groups)
                {
                    Values.Add(grp.ToString());
                }
            }
        }
    }
}
