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
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.TextPanelSplitter = new System.Windows.Forms.SplitContainer();
            this.ChannelText = new System.Windows.Forms.RichTextBox();
            this.TimestampBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TextPanelSplitter)).BeginInit();
            this.TextPanelSplitter.Panel1.SuspendLayout();
            this.TextPanelSplitter.Panel2.SuspendLayout();
            this.TextPanelSplitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(617, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 432);
            this.vScrollBar1.TabIndex = 0;
            // 
            // TextPanelSplitter
            // 
            this.TextPanelSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextPanelSplitter.Location = new System.Drawing.Point(0, 0);
            this.TextPanelSplitter.Name = "TextPanelSplitter";
            // 
            // TextPanelSplitter.Panel1
            // 
            this.TextPanelSplitter.Panel1.Controls.Add(this.TimestampBox);
            // 
            // TextPanelSplitter.Panel2
            // 
            this.TextPanelSplitter.Panel2.Controls.Add(this.ChannelText);
            this.TextPanelSplitter.Size = new System.Drawing.Size(617, 432);
            this.TextPanelSplitter.SplitterDistance = 117;
            this.TextPanelSplitter.TabIndex = 1;
            // 
            // ChannelText
            // 
            this.ChannelText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChannelText.Location = new System.Drawing.Point(0, 0);
            this.ChannelText.Name = "ChannelText";
            this.ChannelText.Size = new System.Drawing.Size(496, 432);
            this.ChannelText.TabIndex = 0;
            this.ChannelText.Text = "";
            // 
            // TimestampBox
            // 
            this.TimestampBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimestampBox.Location = new System.Drawing.Point(0, 0);
            this.TimestampBox.Name = "TimestampBox";
            this.TimestampBox.Size = new System.Drawing.Size(117, 432);
            this.TimestampBox.TabIndex = 0;
            this.TimestampBox.Text = "";
            // 
            // TextPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextPanelSplitter);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "TextPanel";
            this.Size = new System.Drawing.Size(634, 432);
            this.TextPanelSplitter.Panel1.ResumeLayout(false);
            this.TextPanelSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextPanelSplitter)).EndInit();
            this.TextPanelSplitter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.SplitContainer TextPanelSplitter;
        private System.Windows.Forms.RichTextBox ChannelText;
        private System.Windows.Forms.RichTextBox TimestampBox;
    }
}
