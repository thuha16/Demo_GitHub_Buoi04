using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace txt_Email
{
    public class txtMail:TextBox
    {
       public txtMail()
        {
            this.Validated += txtMail_Validated;
        }

       void txtMail_Validated(object sender, EventArgs e)
       {
           try
           {
               MailAddress mail = new MailAddress(this.Text);
           }
           catch (Exception)
           {

               DialogResult r = MessageBox.Show("Mail không hợp lệ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           
       }

       
    }
}
