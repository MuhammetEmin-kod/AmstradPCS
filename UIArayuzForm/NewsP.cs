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
    public partial class NewsP : Form
    {
        public NewsP()
        {
            InitializeComponent();
        }

        private void NewsP_Load(object sender, EventArgs e)
        {
            MessagesCrudSoapClient mc = new MessagesCrudSoapClient();
            int arraylengt = 0;
            foreach (var item in mc.MessageList())
            {
                if (item.CategoryID == 5)
                {
                    arraylengt++;
                }
            }
            Label[] lDizi = new Label[arraylengt];

            int x = 9;
            int i = 0;
            foreach (var item in mc.MessageList())
            {
                if (item.CategoryID == 5)
                {
                    lDizi[i] = new Label();
                    lDizi[i].AutoSize = true;
                    lDizi[i].Text = item.Username + "   " + item.UserMessage;
                    lDizi[i].Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
                    lDizi[i].Location = new Point(12, x);
                    this.Controls.Add(lDizi[i]);
                    x += 20;
                    i++;
                }
            }


            Button b1 = new Button();
            b1.Text = "Send Message";
            b1.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);
            b1.Size = new Size(103, 27);
            b1.TextAlign = ContentAlignment.TopCenter;
            b1.Location = new Point(10, x);
            this.Controls.Add(b1);
            b1.Click += myButton_Click;




        }
        public void myButton_Click(object sender, EventArgs e)
        {
            SendMessage d1 = new SendMessage();
            d1.Text = "5";
            d1.StartPosition = FormStartPosition.CenterScreen;
            d1.ShowDialog();
        }
    }

}
