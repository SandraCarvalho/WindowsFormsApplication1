namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.olaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.talToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.miraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.olaToolStripMenuItem,
            this.queToolStripMenuItem,
            this.talToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(282, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // olaToolStripMenuItem
            // 
            this.olaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miraToolStripMenuItem});
            this.olaToolStripMenuItem.Name = "olaToolStripMenuItem";
            this.olaToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.olaToolStripMenuItem.Text = "&ola";
            // 
            // queToolStripMenuItem
            // 
            this.queToolStripMenuItem.Name = "queToolStripMenuItem";
            this.queToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.queToolStripMenuItem.Text = "que";
            this.queToolStripMenuItem.Click += new System.EventHandler(this.queToolStripMenuItem_Click);
            // 
            // talToolStripMenuItem
            // 
            this.talToolStripMenuItem.Name = "talToolStripMenuItem";
            this.talToolStripMenuItem.Size = new System.Drawing.Size(38, 24);
            this.talToolStripMenuItem.Text = "tal";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // miraToolStripMenuItem
            // 
            this.miraToolStripMenuItem.Name = "miraToolStripMenuItem";
            this.miraToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.miraToolStripMenuItem.Text = "mira";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "o";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem olaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem talToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ToolStripMenuItem miraToolStripMenuItem;
    }
}

