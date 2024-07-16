namespace NguyenThiThuHa_Buoi02
{
    partial class Form_TTSinhVien
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
            this.txt_sv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.userControl11 = new UC_Controls.UserControl1();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // txt_sv
            // 
            this.txt_sv.Location = new System.Drawing.Point(269, 22);
            this.txt_sv.Name = "txt_sv";
            this.txt_sv.Size = new System.Drawing.Size(167, 20);
            this.txt_sv.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm Thông Tin SInh Viên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(85, 105);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(593, 203);
            this.userControl11.TabIndex = 3;
            // 
            // Form_TTSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 388);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_sv);
            this.Controls.Add(this.label1);
            this.Name = "Form_TTSinhVien";
            this.Text = "Form_TTSinhVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sv;
        private System.Windows.Forms.Button button1;
        private UC_Controls.UserControl1 userControl11;
    }
}