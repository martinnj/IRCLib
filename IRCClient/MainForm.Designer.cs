namespace IRCClient
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainsplitter = new System.Windows.Forms.SplitContainer();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomlist = new System.Windows.Forms.TreeView();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flankerIRCClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iRCLibToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONnetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainsplitter)).BeginInit();
            this.mainsplitter.Panel1.SuspendLayout();
            this.mainsplitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(880, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainsplitter
            // 
            this.mainsplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainsplitter.Location = new System.Drawing.Point(0, 24);
            this.mainsplitter.Name = "mainsplitter";
            // 
            // mainsplitter.Panel1
            // 
            this.mainsplitter.Panel1.Controls.Add(this.roomlist);
            this.mainsplitter.Size = new System.Drawing.Size(880, 445);
            this.mainsplitter.SplitterDistance = 147;
            this.mainsplitter.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minimizeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.minimizeToolStripMenuItem.Text = "Minimize";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // roomlist
            // 
            this.roomlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomlist.Location = new System.Drawing.Point(0, 0);
            this.roomlist.Name = "roomlist";
            this.roomlist.Size = new System.Drawing.Size(147, 445);
            this.roomlist.TabIndex = 0;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.licenseToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem1.Image")));
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.initScriptToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("preferencesToolStripMenuItem.Image")));
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // initScriptToolStripMenuItem
            // 
            this.initScriptToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("initScriptToolStripMenuItem.Image")));
            this.initScriptToolStripMenuItem.Name = "initScriptToolStripMenuItem";
            this.initScriptToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.initScriptToolStripMenuItem.Text = "Init Script";
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flankerIRCClientToolStripMenuItem,
            this.iRCLibToolStripMenuItem,
            this.jSONnetToolStripMenuItem});
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.licenseToolStripMenuItem.Text = "Licenses";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // flankerIRCClientToolStripMenuItem
            // 
            this.flankerIRCClientToolStripMenuItem.Name = "flankerIRCClientToolStripMenuItem";
            this.flankerIRCClientToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.flankerIRCClientToolStripMenuItem.Text = "Flanker IRC Client";
            // 
            // iRCLibToolStripMenuItem
            // 
            this.iRCLibToolStripMenuItem.Name = "iRCLibToolStripMenuItem";
            this.iRCLibToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.iRCLibToolStripMenuItem.Text = "Flanker IRCLib";
            // 
            // jSONnetToolStripMenuItem
            // 
            this.jSONnetToolStripMenuItem.Name = "jSONnetToolStripMenuItem";
            this.jSONnetToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.jSONnetToolStripMenuItem.Text = "JSON.net";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 491);
            this.Controls.Add(this.mainsplitter);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Flankers IRC Client";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainsplitter.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainsplitter)).EndInit();
            this.mainsplitter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer mainsplitter;
        private System.Windows.Forms.TreeView roomlist;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flankerIRCClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iRCLibToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONnetToolStripMenuItem;
    }
}

