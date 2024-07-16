using System;
using System.IO;
using System.Windows.Forms;
using UC_Controls;

namespace NguyenThiThuHa_Buoi02
{
    public partial class Form_TTSinhVien : Form
    {
        
        public Form_TTSinhVien()
        {
            InitializeComponent();

            // Khởi tạo UserControl1 và thêm vào Form
            UC = new UserControl(); // Sửa lại tên UserControl1 nếu cần thiết
            UC.Dock = DockStyle.Fill; // Đặt DockStyle cho UserControl1
            userControl11.Controls.Add(UC); // panelUserControl là Panel trên Form_TTSinhVien để chứa UserControl1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "SinhVien.txt";

            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    if ((line = sr.ReadLine()) != null)
                    {
                        string[] fields = line.Split(',');
                        string maSV = fields[0];
                        string tenSV = fields[1];
                        string ngaySinh = fields[2];
                        string gioiTinh = fields[3];
                        string maLop = fields[4];
                        string cmnd = fields[5];

                        // Gọi phương thức SetStudentInfo trên UserControl1 để hiển thị thông tin sinh viên
                        UC.SetStudentInfo(maSV, tenSV, ngaySinh, gioiTinh, maLop, cmnd);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
