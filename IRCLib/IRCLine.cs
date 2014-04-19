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
        /// <summary>
        /// The entire line.
        /// </summary>
        public readonly string Line;

        /// <summary>
        /// The message prefix.
        /// </summary>
        public readonly string Prefix;

        /// <summary>
        /// The command contained in the message.
        /// </summary>
        public readonly string Command;

        /// <summary>
        /// The message parameters.
        /// </summary>
        public readonly List<string> Params;

        /// <summary>
        /// Default (and only) constructor. Parses an IRC message line into meaningfull fields.
        /// </summary>
        /// <param name="line">The IRC message to parse.</param>
        public IRCLine(string line)
        {
            Line = line;
            var parts = line.Split(' ');
            var part = 0;
            if (parts[part].StartsWith(":"))
            {
                Prefix = parts[part].Remove(0, 1);
                part++;
                Command = parts[part];
            }
            else
            {
                Command = parts[part];
            }
            part++;

            Params = new List<string>();
            for (var p = part; p < parts.Length; p++)
            {
                if (!parts[p].StartsWith(":"))
                {
                    Params.Add(parts[p]);
                }
                else
                {
                    var sb = new StringBuilder();
                    sb.Append(parts[p].Remove(0, 1));
                    p++;
                    while (p < parts.Length)
                    {
                        sb.Append(" ");
                        sb.Append(parts[p]);
                        p++;
                    }
                    Params.Add(sb.ToString());
                }
            }
        }
    }
}
