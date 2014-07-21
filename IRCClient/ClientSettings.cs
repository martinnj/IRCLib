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
using System.Drawing;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

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
        public FormWindowState ClientStartState;

        // Information for the default font and realted shit.
        public FontFamily ClientFontFamily;
        public FontStyle ClientFontStyle;
        public int ClientFontSize;

        // Parse non-char bytes in IRC messages to RTF according to
        // http://stackoverflow.com/questions/23230480/irc-recieving-0x02-value-treat-as-formatting
        public bool ParseToRichText;

        // Use ident server, //TODO: Make an Ident implementation
        public bool UseIdentServer;

        /// <summary>
        /// Default constructor, chooses a bunch of default settings.
        /// </summary>
        public ClientSettings()
        {
            ClientLocation = new Point(0,0);
            ClientSize = new Point(800,800);
            ClientStartState = FormWindowState.Normal;

            ClientFontFamily = new FontFamily("Consolas");
            ClientFontStyle = FontStyle.Regular;
            ClientFontSize = 10;

            ParseToRichText = true;

            UseIdentServer = false;
        }

        /// <summary>
        /// Returns a settings object using the values found in a valid settings file.
        /// </summary>
        /// <remarks>Throws IOException, ArgumentException and Exception when appropriate.</remarks>
        /// <param name="filename">Path to a json file with valid settings.</param>
        /// <returns>A ClientSettings object with the settings from the file.</returns>
        public ClientSettings LoadFromFile(string filename)
        {
            if (!File.Exists(filename)) throw new ArgumentException("File: \"" + filename + "\" does not exist.");
            try
            {
                var json = File.ReadAllText(filename, new UTF8Encoding());
                return JsonConvert.DeserializeObject<ClientSettings>(json);
            }
            catch (IOException ex)
            {
                // Under assumption that IO exception arise from the file read.
                throw new IOException("Error opening settings file.", ex);
            }
            catch (Exception ex)
            {
                // Under assumption that the file read will only cause IOExceptions.
                throw new Exception("Error parsing settings file.", ex);
            }
        }

        /// <summary>
        /// Save a ClientSettings object to a json file.
        /// </summary>
        /// <param name="filename">Path to the file the settings should be saved in.</param>
        /// <param name="settings">Instance of the settings to save.</param>
        public void SaveToFile(string filename, ClientSettings settings)
        {
            try
            {
                var json = JsonConvert.SerializeObject(settings);
                File.WriteAllText(filename, json, new UTF8Encoding());
            }
            catch (IOException ex)
            {
                // Under assumption that IO exception arise from the file read.
                throw new IOException("Error saving settings file.", ex);
            }
            catch (Exception ex)
            {
                // Under assumption that the file read will only cause IOExceptions.
                throw new Exception("Error parsing settings to file.", ex);
            }
        }
    }
}
