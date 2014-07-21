using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRCClient
{
    /// <summary>
    /// Class containing the settings used by the IRC client.
    /// </summary>
    public class ClientSettings
    {
        // Related to the window
        public Point ClientLocation;
        public Point ClientSize;
        public Boolean StartState; // Turn into an enum type.

        // Information for the default font and realted shit.
        public FontFamily ClientFontFamily;
        public FontStyle ClientFontStyle;
        public int ClientFontSize;

        // Parse non-char bytes in IRC messages to RTF according to
        // http://stackoverflow.com/questions/23230480/irc-recieving-0x02-value-treat-as-formatting
        public bool ParseToRichText;
    }
}
