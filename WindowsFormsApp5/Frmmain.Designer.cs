namespace WindowsFormsApp5
{
    partial class Frmmain
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
            this.chaoMungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinhTongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhTổngbt1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chaoMungToolStripMenuItem,
            this.tinhTongToolStripMenuItem,
            this.tínhTổngbt1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chaoMungToolStripMenuItem
            // 
            this.chaoMungToolStripMenuItem.Name = "chaoMungToolStripMenuItem";
            this.chaoMungToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.chaoMungToolStripMenuItem.Text = "chao mung";
            this.chaoMungToolStripMenuItem.Click += new System.EventHandler(this.chaoMungToolStripMenuItem_Click);
            // 
            // tinhTongToolStripMenuItem
            // 
            this.tinhTongToolStripMenuItem.Name = "tinhTongToolStripMenuItem";
            this.tinhTongToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.tinhTongToolStripMenuItem.Text = "tinh tong";
            this.tinhTongToolStripMenuItem.Click += new System.EventHandler(this.tinhTongToolStripMenuItem_Click);
            // 
            // tínhTổngbt1ToolStripMenuItem
            // 
            this.tínhTổngbt1ToolStripMenuItem.Name = "tínhTổngbt1ToolStripMenuItem";
            this.tínhTổngbt1ToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.tínhTổngbt1ToolStripMenuItem.Text = "tính tổng_bt1";
            this.tínhTổngbt1ToolStripMenuItem.Click += new System.EventHandler(this.tínhTổngbt1ToolStripMenuItem_Click);
            // 
            // Frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmmain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chaoMungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tinhTongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhTổngbt1ToolStripMenuItem;
    }
}