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
    public partial class safi_dekstop : Form
    {
        public safi_dekstop()
        {
            InitializeComponent();
        }

        private void Btn_simulation_Click(object sender, EventArgs e)
        {
            Form FormSimulationOpen = new frm_simulation();
            FormSimulationOpen.Show();
        }
    }
}
