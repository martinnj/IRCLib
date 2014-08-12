using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace IRCClient.SubForms
{
    public partial class SettingsForm : Form
    {
        // Styles used for the init file.
        readonly Style _greenItalicStyle = new TextStyle(new SolidBrush(Color.Green), null, FontStyle.Italic);
        readonly Style _purplePlainStyle = new TextStyle(new SolidBrush(Color.MediumPurple), null, FontStyle.Regular);
        readonly Style _blueBoldStyle = new TextStyle(new SolidBrush(Color.Blue), null, FontStyle.Bold);

        public SettingsForm()
        {
            InitializeComponent();
            AcceptButton = okBtn;
            CancelButton = cancelBtn;
            fastColoredTextBox1.Text = File.ReadAllText("configs/fircc.init");
        }

        private void fastColoredTextBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            // Clear style of changed range
            e.ChangedRange.ClearStyle(_greenItalicStyle);
            // Highlighting
            e.ChangedRange.SetStyle(_greenItalicStyle, @"//.*$", RegexOptions.Multiline); // C style comments.
            e.ChangedRange.SetStyle(_purplePlainStyle, @"#.*$");                          // Room names.
            e.ChangedRange.SetStyle(_blueBoldStyle, @"(CONNECT|NICK|MSG|JOIN)");          // My simple commands.
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            // Save the settings and then
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
