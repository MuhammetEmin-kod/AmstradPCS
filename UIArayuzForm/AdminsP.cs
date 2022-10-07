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
using UIArayuzForm.ServiceReference2;

namespace UIArayuzForm
{
    public partial class AdminsP : Form
    {
        public AdminsP()
        {
            InitializeComponent();
        }
        LoginCrudsSoapClient s1 = new LoginCrudsSoapClient();
        MessagesCrudSoapClient c1 = new MessagesCrudSoapClient();
        

        private void AdminsP_Load(object sender, EventArgs e)
        {
            dtg_Messg.DataSource = c1.MessageList();
            dtg_Usrs.DataSource = s1.UserShow();
        }



        private void bnt_uUsr_Click(object sender, EventArgs e)
        {
            MessageBox.Show(s1.ConfirmedLogin(txt_mUsrnm.Text));

        }

        private void btn_mMssg_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c1.ConfirmedMessages(Convert.ToInt32(txt_uID.Text)));
        }
        private void dtg_Usrs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_uName.Text = dtg_Usrs.SelectedRows[0].Cells[0].Value.ToString();
            txt_uSrnm.Text = dtg_Usrs.SelectedRows[0].Cells[1].Value.ToString();
            txt_uPhn.Text = dtg_Usrs.SelectedRows[0].Cells[2].Value.ToString();
            txt_uUsrnm.Text = dtg_Usrs.SelectedRows[0].Cells[3].Value.ToString();
            txt_uPass.Text = dtg_Usrs.SelectedRows[0].Cells[4].Value.ToString();
            txt_uStts.Text = dtg_Usrs.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void dtg_Messg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_uID.Text = dtg_Messg.SelectedRows[0].Cells[0].Value.ToString();
            txt_mUsrnm.Text = dtg_Messg.SelectedRows[0].Cells[1].Value.ToString();
            txt_mCtgrID.Text = dtg_Messg.SelectedRows[0].Cells[2].Value.ToString();
            lbl_mMssg.Text = dtg_Messg.SelectedRows[0].Cells[3].Value.ToString();
            txt_mStts.Text = dtg_Messg.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MdiAnaForm mdiAnaForm = new MdiAnaForm();
            mdiAnaForm.ShowDialog();
        }
    }
}
