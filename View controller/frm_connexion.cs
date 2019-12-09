using SAFI_Dekstop.RAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAFI_Dekstop
{
    public partial class frm_connexion : Form
    {
        public frm_connexion()
        {
            InitializeComponent();
        }

        private void Lkl_mdpOublie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form FormMdpOublieOpen = new frm_mdpOublie();
            FormMdpOublieOpen.Show();
            
        }

        private void Frm_connexion_Load(object sender, EventArgs e)
        {
          
        }

        private void Btn_submit_Click(object sender, EventArgs e)
        {
            try {
                string username = tbx_identifiantConnexion.Text;
                string pwd = tbx_pwd.Text;

                User userWantsConnection = User.getLogin(username, pwd);
                //UserWantsConnection est forcément différent de null
                //Si Connection ok
                if (userWantsConnection != null)
                {
                    //Revenir au Dashboard qui montre les données de user connect
                    Hide();
                }
            }
            catch { MessageBox.Show("Connexion impossible"); }
        }
        private void Frm_connexion_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.Exit();
        }
    }
}
