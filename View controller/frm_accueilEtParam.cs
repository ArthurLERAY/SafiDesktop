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
    public partial class frm_accueilEtParam : Form
    {
        public frm_accueilEtParam()
        {
            InitializeComponent();
            

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
            SetupDataGridView();
            PopulateDataGridView();

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

        private void SetupDataGridView()
        {
           
            DataGridView myDataGridView = this.dgvFiches;
            myDataGridView.ColumnCount = 5;
           
            myDataGridView.GridColor = Color.Black;
            myDataGridView.RowHeadersVisible = false;

            myDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            myDataGridView.MultiSelect = false;
         
           
        }

        private void PopulateDataGridView()
        {
            DataGridView myDataGridView = this.dgvFiches;
            string[] row0 = { "11/22/1968", "29", "Revolution 9",
            "Beatles", "The Beatles [White Album]" };
            string[] row1 = { "1960", "6", "Fools Rush In",
            "Frank Sinatra", "Nice 'N' Easy" };
            string[] row2 = { "11/11/1971", "1", "One of These Days",
            "Pink Floyd", "Meddle" };
            string[] row3 = { "1988", "7", "Where Is My Mind?",
            "Pixies", "Surfer Rosa" };
            string[] row4 = { "5/1981", "9", "Can't Find My Mind",
            "Cramps", "Psychedelic Jungle" };
            string[] row5 = { "6/10/2003", "13",
            "Scatterbrain. (As Dead As Leaves.)",
            "Radiohead", "Hail to the Thief" };
            string[] row6 = { "6/30/1992", "3", "Dress", "P J Harvey", "Dry" };

            myDataGridView.Rows.Add(row0);
            myDataGridView.Rows.Add(row1);
            myDataGridView.Rows.Add(row2);
            myDataGridView.Rows.Add(row3);
            myDataGridView.Rows.Add(row4);
            myDataGridView.Rows.Add(row5);
            myDataGridView.Rows.Add(row6);

            myDataGridView.Columns[0].DisplayIndex = 3;
            myDataGridView.Columns[1].DisplayIndex = 4;
            myDataGridView.Columns[2].DisplayIndex = 0;
            myDataGridView.Columns[3].DisplayIndex = 1;
            myDataGridView.Columns[4].DisplayIndex = 2;
        }


       
    }
}

