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
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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
        readonly ClientSettings _settings;

        public SettingsForm(ClientSettings settings)
        {
            InitializeComponent();
            _settings = settings;
            AcceptButton = okBtn;
            CancelButton = cancelBtn;

            // Load settings into all the controls.
            // Appereance
            sampleLbl.Font = new Font(_settings.ClientFontFamily, _settings.ClientFontSize, _settings.ClientFontStyle);
            fontDialog1.Font = new Font(_settings.ClientFontFamily, _settings.ClientFontSize, _settings.ClientFontStyle);

            timestampChk.Checked = _settings.ClientShowTimeStamps;
            parseRtfChk.Checked = _settings.ClientParseToRichText;
            markOpsChk.Checked = _settings.ClientMarkOps;
            topOpsChk.Checked = _settings.ClientMoveOpsUp;

            // General
            useIdentChk.Checked = _settings.ClientUseIdentServer;
            debugWindowChk.Checked = _settings.ClientKeepDebugWindow;

            // Notifications
            useNotifySoundsChk.Checked = _settings.ClientUseNotificationSound;
            switch (_settings.ClientNotications)
            {
                case ClientSettings.NotificatonSettings.NoMessages:
                    notifyNeverRadio.Checked = true;
                    break;
                case ClientSettings.NotificatonSettings.PersonalMessages:
                    notifyPmRadio.Checked = true;
                    break;
                case ClientSettings.NotificatonSettings.MentionedMessages:
                    notifyNickRadio.Checked = true;
                    break;
                case ClientSettings.NotificatonSettings.AllMessages:
                    notifyAllRadio.Checked = true;
                    break;
            }
            foreach (var trigger in _settings.ClientNotificationTriggers)
            {
                var cell = new DataGridViewTextBoxCell {Value = trigger};
                var row = new DataGridViewRow();
                row.Cells.Add(cell);
                triggerWordList.Rows.Add(row);
            }
            
            // Startup script
            fastColoredTextBox1.Text = File.ReadAllText(ClientSettings.ClientInitScriptPath);
        }

        private void fastColoredTextBox1_TextChanged(object sender, TextChangedEventArgs e)
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
            // Save settings from controls into settings object and to file.

            // Appereance
            _settings.ClientFontFamily = sampleLbl.Font.FontFamily;
            _settings.ClientFontSize = sampleLbl.Font.Size;
            _settings.ClientFontStyle = sampleLbl.Font.Style;

            _settings.ClientShowTimeStamps = timestampChk.Checked;
            _settings.ClientParseToRichText = parseRtfChk.Checked;
            _settings.ClientMarkOps = markOpsChk.Checked;
            _settings.ClientMoveOpsUp = topOpsChk.Checked;

            // General
            _settings.ClientUseIdentServer = useIdentChk.Checked;
            _settings.ClientKeepDebugWindow = debugWindowChk.Checked;

            // Notifications
            _settings.ClientUseNotificationSound = useNotifySoundsChk.Checked;
            if (notifyNeverRadio.Checked) { _settings.ClientNotications = ClientSettings.NotificatonSettings.NoMessages; }
            if (notifyPmRadio.Checked) { _settings.ClientNotications = ClientSettings.NotificatonSettings.PersonalMessages; }
            if (notifyNickRadio.Checked) { _settings.ClientNotications = ClientSettings.NotificatonSettings.MentionedMessages; }
            if (notifyAllRadio.Checked) { _settings.ClientNotications = ClientSettings.NotificatonSettings.AllMessages; }
            _settings.ClientNotificationTriggers.Clear();
            foreach (var row in triggerWordList.Rows.Cast<DataGridViewRow>().TakeWhile(row => row.Cells[0].Value != null))
            {
                _settings.ClientNotificationTriggers.Add(row.Cells[0].Value.ToString());
            }
            ClientSettings.SaveToFile(ClientSettings.ClientConfigPath, _settings);

            // Save the initscript.
            File.WriteAllText(ClientSettings.ClientInitScriptPath, fastColoredTextBox1.Text);

            // Confirm the result for parent and close.
            DialogResult = DialogResult.OK;
            Close();
        }

        private void changeFontBtn_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != DialogResult.OK) return;
            _settings.ClientFontFamily = fontDialog1.Font.FontFamily;
            _settings.ClientFontStyle = fontDialog1.Font.Style;
            _settings.ClientFontSize = fontDialog1.Font.Size;
            sampleLbl.Font = fontDialog1.Font;
        }
    }
}
