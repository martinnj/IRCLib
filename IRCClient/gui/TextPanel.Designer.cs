namespace IRCClient.gui
{
    partial class TextPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ChatTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChatTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.AutoCompleteBracketsList = new char[] {
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
            this.ChatTextBox.AutoScrollMinSize = new System.Drawing.Size(2, 14);
            this.ChatTextBox.BackBrush = null;
            this.ChatTextBox.CharHeight = 14;
            this.ChatTextBox.CharWidth = 8;
            this.ChatTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ChatTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ChatTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChatTextBox.IsReplaceMode = false;
            this.ChatTextBox.Location = new System.Drawing.Point(0, 0);
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.ChatTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ChatTextBox.ShowLineNumbers = false;
            this.ChatTextBox.Size = new System.Drawing.Size(634, 432);
            this.ChatTextBox.TabIndex = 1;
            this.ChatTextBox.Zoom = 100;
            // 
            // TextPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChatTextBox);
            this.Name = "TextPanel";
            this.Size = new System.Drawing.Size(634, 432);
            ((System.ComponentModel.ISupportInitialize)(this.ChatTextBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox ChatTextBox;

    }
}
