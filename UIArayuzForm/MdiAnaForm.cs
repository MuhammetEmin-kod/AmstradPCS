using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIArayuzForm
{
    public partial class MdiAnaForm : Form
    {
        public MdiAnaForm()
        {
            InitializeComponent();
        }
        private void RunForm(Form frm)
        {
            panel2.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(frm);
            frm.Show();


        }
        private void btn_cpc_Click(object sender, EventArgs e)
        {
            AmsCpcP a1 = new AmsCpcP();
            RunForm(a1);
        }



        private void btn_pcw_Click(object sender, EventArgs e)
        {
            AmsPcwP a2 = new AmsPcwP();
            RunForm(a2);
            
        }

        private void btn_ng_Click(object sender, EventArgs e)
        {
            AmsNcP a3 = new AmsNcP();
            RunForm(a3);
        }

        private void btn_gx_Click(object sender, EventArgs e)
        {
            AmsGxP a4 = new AmsGxP();
            RunForm(a4);
        }

        private void btn_Nws_Click(object sender, EventArgs e)
        {
            NewsP a5 = new NewsP();
            RunForm(a5);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
