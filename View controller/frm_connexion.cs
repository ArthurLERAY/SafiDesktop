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
            var userConnected = LoginRAO.getLogin("test", "test");

        }
    }
}
