using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


    }
}
