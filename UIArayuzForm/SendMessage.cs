using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIArayuzForm.ServiceReference2;

namespace UIArayuzForm
{
    public partial class SendMessage : Form
    {
        public SendMessage()
        {
            InitializeComponent();
        }

        private void btn_sndms_Click(object sender, EventArgs e)
        {
            string usrname = "";
            using (LoginP l1=new LoginP())
            {
                usrname= l1.usrnm;
            }
            MessagesCrudSoapClient ms = new MessagesCrudSoapClient();
            MessageBox.Show(ms.AddedMessage(usrname, Convert.ToInt32(this.Text), txt_msg.Text));
            MdiAnaForm m1 = new MdiAnaForm();
            m1.ShowDialog();
      
        }
    }
}
