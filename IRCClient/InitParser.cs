using System;
using System.Collections.Generic;
using System.Linq;

namespace IRCClient
{
    // Class that provides the ability to parse an initscript from the IRC client into predetermined lines.
    class InitParser
    {
        /// <summary>
        /// Variables containing all parsed lines.
        /// </summary>
        /// <remarks>Lines with invalid tokens are ignored.</remarks>
        public List<InitLine> InitLines;

        // Struct that every line should be parsed into.
        public struct InitLine
        {
            public LineType Type;
            public List<string> ArgsList;
        }

        // Indicating what type of script line is returned.
        public enum LineType
        {
            Connect,
            Nick,
            Message,
            Join
        }

        /// <summary>
        /// Constructor for the InitParser. Pass an init script as a string to it and let it work :)
        /// </summary>
        /// <param name="initScript">The script to parse.</param>
        public InitParser(string initScript)
        {
            InitLines = new List<InitLine>();
            var lines = initScript.Split(new [] { "\r\n", "\n" }, StringSplitOptions.None);
            foreach (var tryParse in lines.Select(TryParse).Where(tryParse => tryParse != null))
            {
                InitLines.Add((InitLine) tryParse);
            }
        }

        /// <summary>
        /// Attempt to parse a string into a normal initscript line.
        /// </summary>
        /// <param name="input">The string with the line to parse.</param>
        /// <returns>An InitLine object with for the line or null if an errir occured.</returns>
        public InitLine? TryParse(string input)
        {
            var tokens = input.Split(new [] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length < 2) { return null; }

            var line = new InitLine();

            // TODO: Parse args in case, then we can also check number of arguments etc, syntax stuff!
            switch (tokens[0].ToUpper())
            {
                case "CONNECT":
                    line.Type = LineType.Connect;
                    break;
                case "NICK":
                    line.Type = LineType.Nick;
                    break;
                case "MESSAGE":
                    line.Type = LineType.Message;
                    break;
                case "JOIN":
                    line.Type = LineType.Join;
                    break;
                default:
                    return null;
            }
            for (var i = 1; i < tokens.Length; i++)
            {
                line.ArgsList.Add(tokens[i]);
            }

            return line;
        }
    }
}
