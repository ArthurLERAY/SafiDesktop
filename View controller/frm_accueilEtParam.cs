using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAFI_Dekstop.RAO;

namespace SAFI_Dekstop
{
    public partial class frm_accueilEtParam : Form
    {
        //Attributs de la classe
        public User user;

        //Methodes de la classe
        public frm_accueilEtParam(User userNew=null)
        {
            InitializeComponent();
            this.user = userNew;
        }

        private void Btn_simulation_Click(object sender, EventArgs e)
        {
            Form FormSimulationOpen = new frm_simulation();
            FormSimulationOpen.Show();
        }

        private void Frm_accueilEtParam_Load(object sender, EventArgs e)
        {
            // Passer le frm_connexion au premier plan 
            Form FormConnexionOpen = new frm_connexion();
            FormConnexionOpen.ShowDialog();
            
         
        }

        private void Btn_ajouterUnUtilisateur_Click(object sender, EventArgs e)
        {
            Form ajoutUsersOpen = new frm_ajoutUser();
            ajoutUsersOpen.Show();
        }

        private void Dgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_users[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                Form modifUserOpen = new frm_modificationUtilisateur();
                modifUserOpen.Show();
            }
        }

        private void Lbx_choixRegion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
