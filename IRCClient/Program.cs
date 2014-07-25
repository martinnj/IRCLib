using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRCClient
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var settings = new ClientSettings();
            if (File.Exists(ClientSettings.ClientConfigPath))
            {
                settings = ClientSettings.LoadFromFile(ClientSettings.ClientConfigPath);
            }
            else
            {
                ClientSettings.SaveToFile(ClientSettings.ClientConfigPath, settings);
            }

            // Parse settings block.
            var mainform = new MainForm(settings)
            {
                Location = settings.ClientLocation,
                Size = settings.ClientSize,
                WindowState = settings.ClientStartState
            };

            Application.Run(mainform);
        }
    }
}
