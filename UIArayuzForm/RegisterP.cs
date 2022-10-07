using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIArayuzForm.ServiceReference1;

namespace UIArayuzForm
{
    public partial class RegisterP : Form
    {
        public RegisterP()
        {
            InitializeComponent();
        }

        private void btn_Rrgtr_Click(object sender, EventArgs e)
        {
            LoginCrudsSoapClient lc = new LoginCrudsSoapClient();
            MessageBox.Show( lc.Register(txt_Nm.Text, txt_Srnm.Text, msk_Phone.Text, txt_UsrNm.Text, txt_Pasw.Text));
            ControlClears.Clear(this);
        }

        private void btn_Cncl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
