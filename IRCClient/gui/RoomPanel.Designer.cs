namespace IRCClient.gui
{
    partial class RoomPanel
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
            this.RoomSplitter = new System.Windows.Forms.SplitContainer();
            this.UserList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.RoomSplitter)).BeginInit();
            this.RoomSplitter.Panel2.SuspendLayout();
            this.RoomSplitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoomSplitter
            // 
            this.RoomSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomSplitter.Location = new System.Drawing.Point(0, 0);
            this.RoomSplitter.Name = "RoomSplitter";
            // 
            // RoomSplitter.Panel2
            // 
            this.RoomSplitter.Panel2.Controls.Add(this.UserList);
            this.RoomSplitter.Size = new System.Drawing.Size(729, 536);
            this.RoomSplitter.SplitterDistance = 550;
            this.RoomSplitter.TabIndex = 0;
            // 
            // UserList
            // 
            this.UserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserList.FormattingEnabled = true;
            this.UserList.Location = new System.Drawing.Point(0, 0);
            this.UserList.MultiColumn = true;
            this.UserList.Name = "UserList";
            this.UserList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.UserList.Size = new System.Drawing.Size(175, 536);
            this.UserList.TabIndex = 0;
            // 
            // RoomPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RoomSplitter);
            this.Name = "RoomPanel";
            this.Size = new System.Drawing.Size(729, 536);
            this.RoomSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RoomSplitter)).EndInit();
            this.RoomSplitter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer RoomSplitter;
        private System.Windows.Forms.ListBox UserList;
    }
}
