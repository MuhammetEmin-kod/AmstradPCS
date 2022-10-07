using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WindowsFormsApp1.ServiceReference1;
using WindowsFormsApp1.ServiceReference2;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginCrudsSoapClient s1 = new LoginCrudsSoapClient();
            MessagesCrudSoapClient c1=new MessagesCrudSoapClient();
            dataGridView1.DataSource = c1.MessageList();
            dataGridView2.DataSource = s1.UserShow();
        }
    }
}


