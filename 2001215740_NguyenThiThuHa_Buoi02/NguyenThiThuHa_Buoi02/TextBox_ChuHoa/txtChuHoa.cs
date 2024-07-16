using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBox_ChuHoa 
{
    public class txtChuHoa : TextBox
    {
        public txtChuHoa()
        {
            this.KeyPress += txtNhapSo_KeyPress;
        }

        void txtNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsUpper(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }

}
