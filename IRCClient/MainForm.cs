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

using System;
using System.Windows.Forms;
using IRCClient.SubForms;

namespace IRCClient
{
    public partial class MainForm : Form
    {
        // Store the settings somewhere.
        public ClientSettings Settings;

        public MainForm(ClientSettings settings)
        {
            InitializeComponent();
            Settings = settings;
        }

        #region "Common methods, useful stuff and such"

        /// <summary>
        /// Saves the state of the window to the settings file.
        /// </summary>
        /// <remarks>Used to save things such as window size and visbility.</remarks>
        private void SaveClientState()
        {
            // Capture window settings and update the object.
            Settings.ClientLocation = Location;
            Settings.ClientSize = Size;
            Settings.ClientStartState = WindowState;
            // Save that shit! :)
            ClientSettings.SaveToFile(ClientSettings.ClientConfigPath, Settings);

        }
        #endregion


        #region "GUI Interaction - Things spawned by GUI interactions such as button pushes"

        // User clicked exit in the main menu strip.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // User clicked exit in the notification icon menu strip.
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Main window is requested to shut down, save the state.
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveClientState();
            Application.Exit();
        }
        // User click the about entry in the main menu strip.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutfrm = new AboutForm();
            aboutfrm.ShowDialog();
        }
        #endregion

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsfrm = new SettingsForm(Settings);
            if (settingsfrm.ShowDialog() == DialogResult.OK)
            {
                // Apply settings!
            }
        }


    }
}
