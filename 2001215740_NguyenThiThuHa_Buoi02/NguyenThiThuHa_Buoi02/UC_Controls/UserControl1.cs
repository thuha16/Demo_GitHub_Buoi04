using System;
using System.Windows.Forms;

namespace UC_Controls
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public void SetStudentInfo(string maSV, string tenSV, string ngaySinh, string gioiTinh, string maLop, string cmnd)
        {
            lb_ma.Text = maSV;
            lb_hoten.Text = tenSV;
            lb_ngaysinh.Text = ngaySinh;
            lb_gioitinh.Text = gioiTinh;
            lb_malop.Text = maLop;
            lb_cmnd.Text = cmnd;
        }
    }
}
