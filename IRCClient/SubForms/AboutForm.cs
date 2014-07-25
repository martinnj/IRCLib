using System;
using System.Windows.Forms;

namespace IRCClient.SubForms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            AppVersionLabel.Text = @"Application Version: " +
                                   System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            var objType = typeof (IRCLib.Connection);
            LibVersionLabel.Text = @"IRCLib Version: " +
                                   Type.GetType(objType.AssemblyQualifiedName).Assembly.GetName().Version;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/martinnj/IRCLib");
        }
    }
}
