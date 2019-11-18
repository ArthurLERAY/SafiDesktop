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

        private void Lbl_mdpOublie_Click(object sender, EventArgs e)
        {
            Form FormMdpOublieOpen = new frm_mdpOublie();
            FormMdpOublieOpen.Show();
        }
    }
}
