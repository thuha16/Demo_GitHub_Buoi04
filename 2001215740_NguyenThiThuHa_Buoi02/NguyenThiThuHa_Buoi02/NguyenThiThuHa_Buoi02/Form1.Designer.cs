namespace NguyenThiThuHa_Buoi02
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
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_khongchuaKTDB1 = new txt_KhongChuaKTDB.txt_khongchuaKTDB();
            this.txtMail1 = new txt_Email.txtMail();
            this.txtNhapSo1 = new TextBox_NhapSo.txtNhapSo();
            this.txtChuHoa1 = new TextBox_ChuHoa.txtChuHoa();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 178);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(484, 22);
            this.statusBar1.TabIndex = 0;
            this.statusBar1.Text = "Xin chao nguoi dung...";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem3});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "View";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 2;
            this.menuItem3.Text = "Edit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chỉ nhập Số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập chữ hoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Không chứa kí tự đặc biệt";
            // 
            // txt_khongchuaKTDB1
            // 
            this.txt_khongchuaKTDB1.Location = new System.Drawing.Point(145, 157);
            this.txt_khongchuaKTDB1.Name = "txt_khongchuaKTDB1";
            this.txt_khongchuaKTDB1.Size = new System.Drawing.Size(100, 20);
            this.txt_khongchuaKTDB1.TabIndex = 7;
            // 
            // txtMail1
            // 
            this.txtMail1.Location = new System.Drawing.Point(145, 119);
            this.txtMail1.Name = "txtMail1";
            this.txtMail1.Size = new System.Drawing.Size(100, 20);
            this.txtMail1.TabIndex = 5;
            // 
            // txtNhapSo1
            // 
            this.txtNhapSo1.Location = new System.Drawing.Point(145, 30);
            this.txtNhapSo1.Name = "txtNhapSo1";
            this.txtNhapSo1.Size = new System.Drawing.Size(100, 20);
            this.txtNhapSo1.TabIndex = 2;
            // 
            // txtChuHoa1
            // 
            this.txtChuHoa1.Location = new System.Drawing.Point(145, 77);
            this.txtChuHoa1.Name = "txtChuHoa1";
            this.txtChuHoa1.Size = new System.Drawing.Size(100, 20);
            this.txtChuHoa1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 200);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_khongchuaKTDB1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMail1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhapSo1);
            this.Controls.Add(this.txtChuHoa1);
            this.Controls.Add(this.statusBar1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        public System.Windows.Forms.MainMenu mainMenu1;
        private TextBox_ChuHoa.txtChuHoa txtChuHoa1;
        private TextBox_NhapSo.txtNhapSo txtNhapSo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private txt_Email.txtMail txtMail1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private txt_KhongChuaKTDB.txt_khongchuaKTDB txt_khongchuaKTDB1;
    }
}

