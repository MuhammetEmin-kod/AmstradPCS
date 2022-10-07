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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UIArayuzForm
{
    public partial class LoginP : Form
    {
        public LoginP()
        {
            InitializeComponent();
        }



        LoginCrudsSoapClient lgnc = new LoginCrudsSoapClient();
        public string usrnm="";
        private void btn_Log_Click(object sender, EventArgs e)
        {

            if (lgnc.Login(txt_Usrnm.Text, txt_Pass.Text) == 1)
            {
                MdiAnaForm nsw = new MdiAnaForm();
                nsw.StartPosition = FormStartPosition.CenterScreen;
                nsw.ShowDialog();
                usrnm= txt_Usrnm.Text;
            }
            else if (lgnc.Login(txt_Usrnm.Text, txt_Pass.Text) == 2)
            {
                AdminsP adp = new AdminsP();
                adp.StartPosition = FormStartPosition.CenterScreen;
                adp.ShowDialog();
                usrnm = txt_Usrnm.Text;

            }
            else
            {
                MessageBox.Show("Wrong username or password!!!");
            }
        }

        private void btn_Regst_Click(object sender, EventArgs e)
        {
            RegisterP rp = new RegisterP();
            rp.StartPosition = FormStartPosition.CenterParent;
            rp.ShowDialog();
        }
    }
}
