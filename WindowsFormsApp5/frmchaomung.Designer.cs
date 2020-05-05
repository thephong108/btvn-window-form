namespace WindowsFormsApp5
{
    partial class frmchaomung
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtsubmit = new System.Windows.Forms.Button();
            this.tên = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(297, 88);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(160, 22);
            this.txtTen.TabIndex = 2;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(297, 187);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(160, 22);
            this.txtLop.TabIndex = 3;
            // 
            // txtsubmit
            // 
            this.txtsubmit.Location = new System.Drawing.Point(314, 262);
            this.txtsubmit.Name = "txtsubmit";
            this.txtsubmit.Size = new System.Drawing.Size(75, 23);
            this.txtsubmit.TabIndex = 4;
            this.txtsubmit.Text = "submit";
            this.txtsubmit.UseVisualStyleBackColor = true;
            this.txtsubmit.Click += new System.EventHandler(this.txtsubmit_Click);
            // 
            // tên
            // 
            this.tên.AutoSize = true;
            this.tên.Location = new System.Drawing.Point(189, 88);
            this.tên.Name = "tên";
            this.tên.Size = new System.Drawing.Size(28, 17);
            this.tên.TabIndex = 5;
            this.tên.Text = "tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "lớp";
            // 
            // frmchaomung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tên);
            this.Controls.Add(this.txtsubmit);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtTen);
            this.Name = "frmchaomung";
            this.Text = "chaomung";
            this.Load += new System.EventHandler(this.frmchaomung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Button txtsubmit;
        private System.Windows.Forms.Label tên;
        private System.Windows.Forms.Label label1;
    }
}

