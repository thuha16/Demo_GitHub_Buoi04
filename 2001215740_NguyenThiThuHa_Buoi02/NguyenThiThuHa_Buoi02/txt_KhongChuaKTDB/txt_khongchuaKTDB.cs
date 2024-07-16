using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace txt_KhongChuaKTDB
{
    public class txt_khongchuaKTDB:TextBox
    {
        ErrorProvider error;
        public txt_khongchuaKTDB()
        {
            this.KeyPress += txt_khongchuaKTDB_KeyPress;
            error = new ErrorProvider();
        }

        void txt_khongchuaKTDB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar)&& !char.IsControl(e.KeyChar))
            {
                error.Clear();
               

            }
            else
            {
                error.SetError(this,"Không được chứa kí tự đặc biệt");
               
            }
        }
    }
}
