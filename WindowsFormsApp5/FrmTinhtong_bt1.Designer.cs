namespace WindowsFormsApp5
{
    partial class FrmTinhtong_bt1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lbltinhtong = new System.Windows.Forms.Label();
            this.btntinhtong = new System.Windows.Forms.Button();
            this.btnlamlai = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "a :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "b :";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(200, 83);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(200, 159);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 3;
            // 
            // lbltinhtong
            // 
            this.lbltinhtong.AutoSize = true;
            this.lbltinhtong.Location = new System.Drawing.Point(74, 234);
            this.lbltinhtong.Name = "lbltinhtong";
            this.lbltinhtong.Size = new System.Drawing.Size(0, 17);
            this.lbltinhtong.TabIndex = 4;
            // 
            // btntinhtong
            // 
            this.btntinhtong.Location = new System.Drawing.Point(59, 295);
            this.btntinhtong.Name = "btntinhtong";
            this.btntinhtong.Size = new System.Drawing.Size(75, 23);
            this.btntinhtong.TabIndex = 5;
            this.btntinhtong.Text = "tính tổng";
            this.btntinhtong.UseVisualStyleBackColor = true;
            this.btntinhtong.Click += new System.EventHandler(this.btntinhtong_Click);
            // 
            // btnlamlai
            // 
            this.btnlamlai.Location = new System.Drawing.Point(187, 295);
            this.btnlamlai.Name = "btnlamlai";
            this.btnlamlai.Size = new System.Drawing.Size(75, 23);
            this.btnlamlai.TabIndex = 6;
            this.btnlamlai.Text = "làm lại";
            this.btnlamlai.UseVisualStyleBackColor = true;
            this.btnlamlai.Click += new System.EventHandler(this.btnlamlai_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(341, 295);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // FrmTinhtong_bt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnlamlai);
            this.Controls.Add(this.btntinhtong);
            this.Controls.Add(this.lbltinhtong);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTinhtong_bt1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lbltinhtong;
        private System.Windows.Forms.Button btntinhtong;
        private System.Windows.Forms.Button btnlamlai;
        private System.Windows.Forms.Button btnthoat;
    }
}