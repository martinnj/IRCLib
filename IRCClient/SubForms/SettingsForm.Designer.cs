namespace IRCClient.SubForms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.appearenceTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.parseRtfChk = new System.Windows.Forms.CheckBox();
            this.timestampChk = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.topOpsChk = new System.Windows.Forms.CheckBox();
            this.markOpsChk = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sampleLbl = new System.Windows.Forms.Label();
            this.changeFontBtn = new System.Windows.Forms.Button();
            this.generalTab = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.useIdentChk = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.debugWindowChk = new System.Windows.Forms.CheckBox();
            this.notificationTab = new System.Windows.Forms.TabPage();
            this.useNotifySoundsChk = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.triggerWordList = new System.Windows.Forms.DataGridView();
            this.triggerwordCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.notifyAllRadio = new System.Windows.Forms.RadioButton();
            this.notifyNickRadio = new System.Windows.Forms.RadioButton();
            this.notifyPmRadio = new System.Windows.Forms.RadioButton();
            this.notifyNeverRadio = new System.Windows.Forms.RadioButton();
            this.startupscriptTab = new System.Windows.Forms.TabPage();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tabControl1.SuspendLayout();
            this.appearenceTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.generalTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.notificationTab.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.triggerWordList)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.startupscriptTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(864, 566);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.Location = new System.Drawing.Point(783, 566);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.appearenceTab);
            this.tabControl1.Controls.Add(this.generalTab);
            this.tabControl1.Controls.Add(this.notificationTab);
            this.tabControl1.Controls.Add(this.startupscriptTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 548);
            this.tabControl1.TabIndex = 2;
            // 
            // appearenceTab
            // 
            this.appearenceTab.Controls.Add(this.groupBox3);
            this.appearenceTab.Controls.Add(this.groupBox2);
            this.appearenceTab.Controls.Add(this.groupBox1);
            this.appearenceTab.Location = new System.Drawing.Point(4, 22);
            this.appearenceTab.Name = "appearenceTab";
            this.appearenceTab.Size = new System.Drawing.Size(919, 522);
            this.appearenceTab.TabIndex = 1;
            this.appearenceTab.Text = "Appearance";
            this.appearenceTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.parseRtfChk);
            this.groupBox3.Controls.Add(this.timestampChk);
            this.groupBox3.Location = new System.Drawing.Point(4, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 65);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nick list";
            // 
            // parseRtfChk
            // 
            this.parseRtfChk.AutoSize = true;
            this.parseRtfChk.Location = new System.Drawing.Point(6, 42);
            this.parseRtfChk.Name = "parseRtfChk";
            this.parseRtfChk.Size = new System.Drawing.Size(167, 17);
            this.parseRtfChk.TabIndex = 2;
            this.parseRtfChk.Text = "Parse RTF Bytes in messages";
            this.parseRtfChk.UseVisualStyleBackColor = true;
            // 
            // timestampChk
            // 
            this.timestampChk.AutoSize = true;
            this.timestampChk.Location = new System.Drawing.Point(6, 19);
            this.timestampChk.Name = "timestampChk";
            this.timestampChk.Size = new System.Drawing.Size(153, 17);
            this.timestampChk.TabIndex = 1;
            this.timestampChk.Text = "Show message timestamps";
            this.timestampChk.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.topOpsChk);
            this.groupBox2.Controls.Add(this.markOpsChk);
            this.groupBox2.Location = new System.Drawing.Point(463, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 65);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nick list";
            // 
            // topOpsChk
            // 
            this.topOpsChk.AutoSize = true;
            this.topOpsChk.Location = new System.Drawing.Point(6, 42);
            this.topOpsChk.Name = "topOpsChk";
            this.topOpsChk.Size = new System.Drawing.Size(239, 17);
            this.topOpsChk.TabIndex = 2;
            this.topOpsChk.Text = "Move channel operators to the top of nick list";
            this.topOpsChk.UseVisualStyleBackColor = true;
            // 
            // markOpsChk
            // 
            this.markOpsChk.AutoSize = true;
            this.markOpsChk.Location = new System.Drawing.Point(6, 19);
            this.markOpsChk.Name = "markOpsChk";
            this.markOpsChk.Size = new System.Drawing.Size(187, 17);
            this.markOpsChk.TabIndex = 0;
            this.markOpsChk.Text = "Mark channel operators in nick list";
            this.markOpsChk.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sampleLbl);
            this.groupBox1.Controls.Add(this.changeFontBtn);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font in Chat Window";
            // 
            // sampleLbl
            // 
            this.sampleLbl.AutoSize = true;
            this.sampleLbl.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleLbl.Location = new System.Drawing.Point(120, 24);
            this.sampleLbl.Name = "sampleLbl";
            this.sampleLbl.Size = new System.Drawing.Size(700, 15);
            this.sampleLbl.TabIndex = 1;
            this.sampleLbl.Text = "This is a font sample, so you can tell how the font you choose looks, or how the " +
    "default one looks.";
            // 
            // changeFontBtn
            // 
            this.changeFontBtn.Location = new System.Drawing.Point(7, 20);
            this.changeFontBtn.Name = "changeFontBtn";
            this.changeFontBtn.Size = new System.Drawing.Size(107, 23);
            this.changeFontBtn.TabIndex = 0;
            this.changeFontBtn.Text = "Change Font";
            this.changeFontBtn.UseVisualStyleBackColor = true;
            this.changeFontBtn.Click += new System.EventHandler(this.changeFontBtn_Click);
            // 
            // generalTab
            // 
            this.generalTab.Controls.Add(this.groupBox5);
            this.generalTab.Controls.Add(this.groupBox4);
            this.generalTab.Location = new System.Drawing.Point(4, 22);
            this.generalTab.Name = "generalTab";
            this.generalTab.Padding = new System.Windows.Forms.Padding(3);
            this.generalTab.Size = new System.Drawing.Size(919, 522);
            this.generalTab.TabIndex = 0;
            this.generalTab.Text = "General";
            this.generalTab.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.useIdentChk);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(912, 47);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ident Server";
            // 
            // useIdentChk
            // 
            this.useIdentChk.AutoSize = true;
            this.useIdentChk.Location = new System.Drawing.Point(6, 19);
            this.useIdentChk.Name = "useIdentChk";
            this.useIdentChk.Size = new System.Drawing.Size(206, 17);
            this.useIdentChk.TabIndex = 0;
            this.useIdentChk.Text = "Enable Ident server (Not implemented)";
            this.useIdentChk.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.debugWindowChk);
            this.groupBox4.Location = new System.Drawing.Point(3, 56);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(912, 47);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Miscellaneous";
            // 
            // debugWindowChk
            // 
            this.debugWindowChk.AutoSize = true;
            this.debugWindowChk.Location = new System.Drawing.Point(6, 19);
            this.debugWindowChk.Name = "debugWindowChk";
            this.debugWindowChk.Size = new System.Drawing.Size(231, 17);
            this.debugWindowChk.TabIndex = 0;
            this.debugWindowChk.Text = "Keep a debug window for all IRC messages";
            this.debugWindowChk.UseVisualStyleBackColor = true;
            // 
            // notificationTab
            // 
            this.notificationTab.Controls.Add(this.useNotifySoundsChk);
            this.notificationTab.Controls.Add(this.groupBox7);
            this.notificationTab.Controls.Add(this.groupBox6);
            this.notificationTab.Location = new System.Drawing.Point(4, 22);
            this.notificationTab.Name = "notificationTab";
            this.notificationTab.Padding = new System.Windows.Forms.Padding(3);
            this.notificationTab.Size = new System.Drawing.Size(919, 522);
            this.notificationTab.TabIndex = 3;
            this.notificationTab.Text = "Notifications";
            this.notificationTab.UseVisualStyleBackColor = true;
            // 
            // useNotifySoundsChk
            // 
            this.useNotifySoundsChk.AutoSize = true;
            this.useNotifySoundsChk.Location = new System.Drawing.Point(10, 7);
            this.useNotifySoundsChk.Name = "useNotifySoundsChk";
            this.useNotifySoundsChk.Size = new System.Drawing.Size(151, 17);
            this.useNotifySoundsChk.TabIndex = 2;
            this.useNotifySoundsChk.Text = "Use sound for notifications";
            this.useNotifySoundsChk.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.triggerWordList);
            this.groupBox7.Location = new System.Drawing.Point(3, 149);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(913, 367);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Also notify me when these words appear (case insensitive)";
            // 
            // triggerWordList
            // 
            this.triggerWordList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.triggerWordList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.triggerwordCol});
            this.triggerWordList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.triggerWordList.Location = new System.Drawing.Point(3, 16);
            this.triggerWordList.Name = "triggerWordList";
            this.triggerWordList.Size = new System.Drawing.Size(907, 348);
            this.triggerWordList.TabIndex = 0;
            // 
            // triggerwordCol
            // 
            this.triggerwordCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.triggerwordCol.HeaderText = "Trigger Word";
            this.triggerwordCol.Name = "triggerwordCol";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.notifyAllRadio);
            this.groupBox6.Controls.Add(this.notifyNickRadio);
            this.groupBox6.Controls.Add(this.notifyPmRadio);
            this.groupBox6.Controls.Add(this.notifyNeverRadio);
            this.groupBox6.Location = new System.Drawing.Point(3, 30);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(913, 113);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Notify me when...";
            // 
            // notifyAllRadio
            // 
            this.notifyAllRadio.AutoSize = true;
            this.notifyAllRadio.Location = new System.Drawing.Point(7, 86);
            this.notifyAllRadio.Name = "notifyAllRadio";
            this.notifyAllRadio.Size = new System.Drawing.Size(164, 17);
            this.notifyAllRadio.TabIndex = 3;
            this.notifyAllRadio.TabStop = true;
            this.notifyAllRadio.Text = "Anyone writes in a room I\'m in";
            this.notifyAllRadio.UseVisualStyleBackColor = true;
            // 
            // notifyNickRadio
            // 
            this.notifyNickRadio.AutoSize = true;
            this.notifyNickRadio.Location = new System.Drawing.Point(7, 66);
            this.notifyNickRadio.Name = "notifyNickRadio";
            this.notifyNickRadio.Size = new System.Drawing.Size(122, 17);
            this.notifyNickRadio.TabIndex = 2;
            this.notifyNickRadio.TabStop = true;
            this.notifyNickRadio.Text = "When I\'m mentioned";
            this.notifyNickRadio.UseVisualStyleBackColor = true;
            // 
            // notifyPmRadio
            // 
            this.notifyPmRadio.AutoSize = true;
            this.notifyPmRadio.Location = new System.Drawing.Point(7, 43);
            this.notifyPmRadio.Name = "notifyPmRadio";
            this.notifyPmRadio.Size = new System.Drawing.Size(134, 17);
            this.notifyPmRadio.TabIndex = 1;
            this.notifyPmRadio.TabStop = true;
            this.notifyPmRadio.Text = "On Personal Messages";
            this.notifyPmRadio.UseVisualStyleBackColor = true;
            // 
            // notifyNeverRadio
            // 
            this.notifyNeverRadio.AutoSize = true;
            this.notifyNeverRadio.Location = new System.Drawing.Point(7, 20);
            this.notifyNeverRadio.Name = "notifyNeverRadio";
            this.notifyNeverRadio.Size = new System.Drawing.Size(54, 17);
            this.notifyNeverRadio.TabIndex = 0;
            this.notifyNeverRadio.TabStop = true;
            this.notifyNeverRadio.Text = "Never";
            this.notifyNeverRadio.UseVisualStyleBackColor = true;
            // 
            // startupscriptTab
            // 
            this.startupscriptTab.Controls.Add(this.fastColoredTextBox1);
            this.startupscriptTab.Location = new System.Drawing.Point(4, 22);
            this.startupscriptTab.Name = "startupscriptTab";
            this.startupscriptTab.Size = new System.Drawing.Size(919, 522);
            this.startupscriptTab.TabIndex = 2;
            this.startupscriptTab.Text = "Startup Script";
            this.startupscriptTab.UseVisualStyleBackColor = true;
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(242, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(0, 0);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.Size = new System.Drawing.Size(919, 522);
            this.fastColoredTextBox1.TabIndex = 0;
            this.fastColoredTextBox1.Text = "// Initscript goes in here ^_^";
            this.fastColoredTextBox1.Zoom = 100;
            this.fastColoredTextBox1.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fastColoredTextBox1_TextChanged);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 601);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Preferences";
            this.tabControl1.ResumeLayout(false);
            this.appearenceTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.generalTab.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.notificationTab.ResumeLayout(false);
            this.notificationTab.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.triggerWordList)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.startupscriptTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage generalTab;
        private System.Windows.Forms.TabPage appearenceTab;
        private System.Windows.Forms.TabPage startupscriptTab;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button changeFontBtn;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label sampleLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox topOpsChk;
        private System.Windows.Forms.CheckBox timestampChk;
        private System.Windows.Forms.CheckBox markOpsChk;
        private System.Windows.Forms.TabPage notificationTab;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox parseRtfChk;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox debugWindowChk;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox useIdentChk;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton notifyPmRadio;
        private System.Windows.Forms.RadioButton notifyNeverRadio;
        private System.Windows.Forms.RadioButton notifyAllRadio;
        private System.Windows.Forms.RadioButton notifyNickRadio;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox useNotifySoundsChk;
        private System.Windows.Forms.DataGridView triggerWordList;
        private System.Windows.Forms.DataGridViewTextBoxColumn triggerwordCol;
    }
}