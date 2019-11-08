namespace SAFI_Dekstop
{
    partial class safi_dekstop
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tac_accueilParam = new System.Windows.Forms.TabControl();
            this.tap_Accueil = new System.Windows.Forms.TabPage();
            this.tap_param = new System.Windows.Forms.TabPage();
            this.tap_automatisation = new System.Windows.Forms.TabPage();
            this.dgv_paramAutomatisation = new System.Windows.Forms.DataGridView();
            this.col_nomParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_activationParam = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_simulation = new System.Windows.Forms.Button();
            this.tap_frais = new System.Windows.Forms.TabPage();
            this.gbx_choixRegion = new System.Windows.Forms.GroupBox();
            this.lbx_choixRegion = new System.Windows.Forms.ListBox();
            this.btn_validerChoixRegion = new System.Windows.Forms.Button();
            this.gpx_frais = new System.Windows.Forms.GroupBox();
            this.lbl_repasMidi = new System.Windows.Forms.Label();
            this.lbl_relaisEtape = new System.Windows.Forms.Label();
            this.lbl_nuitee = new System.Windows.Forms.Label();
            this.lbl_deplacement = new System.Windows.Forms.Label();
            this.lbl_coutParRepas = new System.Windows.Forms.Label();
            this.lbl_coutParNuitRelais = new System.Windows.Forms.Label();
            this.lbl_coutParNuitHotel = new System.Windows.Forms.Label();
            this.lbl_coutParKm = new System.Windows.Forms.Label();
            this.btn_enregistrerFrais = new System.Windows.Forms.Button();
            this.tac_fraisAutoSimul = new System.Windows.Forms.TabControl();
            this.tac_accueilParam.SuspendLayout();
            this.tap_param.SuspendLayout();
            this.tap_automatisation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paramAutomatisation)).BeginInit();
            this.tap_frais.SuspendLayout();
            this.gbx_choixRegion.SuspendLayout();
            this.gpx_frais.SuspendLayout();
            this.tac_fraisAutoSimul.SuspendLayout();
            this.SuspendLayout();
            // 
            // tac_accueilParam
            // 
            this.tac_accueilParam.Controls.Add(this.tap_Accueil);
            this.tac_accueilParam.Controls.Add(this.tap_param);
            this.tac_accueilParam.Location = new System.Drawing.Point(12, 12);
            this.tac_accueilParam.Name = "tac_accueilParam";
            this.tac_accueilParam.SelectedIndex = 0;
            this.tac_accueilParam.Size = new System.Drawing.Size(955, 486);
            this.tac_accueilParam.TabIndex = 0;
            // 
            // tap_Accueil
            // 
            this.tap_Accueil.Location = new System.Drawing.Point(4, 22);
            this.tap_Accueil.Name = "tap_Accueil";
            this.tap_Accueil.Padding = new System.Windows.Forms.Padding(3);
            this.tap_Accueil.Size = new System.Drawing.Size(947, 460);
            this.tap_Accueil.TabIndex = 0;
            this.tap_Accueil.Text = "Accueil";
            this.tap_Accueil.UseVisualStyleBackColor = true;
            // 
            // tap_param
            // 
            this.tap_param.Controls.Add(this.tac_fraisAutoSimul);
            this.tap_param.Location = new System.Drawing.Point(4, 22);
            this.tap_param.Name = "tap_param";
            this.tap_param.Padding = new System.Windows.Forms.Padding(3);
            this.tap_param.Size = new System.Drawing.Size(947, 460);
            this.tap_param.TabIndex = 1;
            this.tap_param.Text = "Paramétrage";
            this.tap_param.UseVisualStyleBackColor = true;
            // 
            // tap_automatisation
            // 
            this.tap_automatisation.Controls.Add(this.btn_simulation);
            this.tap_automatisation.Controls.Add(this.dgv_paramAutomatisation);
            this.tap_automatisation.Location = new System.Drawing.Point(4, 22);
            this.tap_automatisation.Name = "tap_automatisation";
            this.tap_automatisation.Padding = new System.Windows.Forms.Padding(3);
            this.tap_automatisation.Size = new System.Drawing.Size(914, 389);
            this.tap_automatisation.TabIndex = 2;
            this.tap_automatisation.Text = "Automatisation";
            this.tap_automatisation.UseVisualStyleBackColor = true;
            // 
            // dgv_paramAutomatisation
            // 
            this.dgv_paramAutomatisation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_paramAutomatisation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_activationParam,
            this.col_nomParam});
            this.dgv_paramAutomatisation.Location = new System.Drawing.Point(6, 6);
            this.dgv_paramAutomatisation.Name = "dgv_paramAutomatisation";
            this.dgv_paramAutomatisation.Size = new System.Drawing.Size(870, 323);
            this.dgv_paramAutomatisation.TabIndex = 0;
            // 
            // col_nomParam
            // 
            this.col_nomParam.HeaderText = "Nom du paramètre";
            this.col_nomParam.Name = "col_nomParam";
            this.col_nomParam.Width = 140;
            // 
            // col_activationParam
            // 
            this.col_activationParam.HeaderText = "Activer / Désactiver";
            this.col_activationParam.Name = "col_activationParam";
            this.col_activationParam.Width = 140;
            // 
            // btn_simulation
            // 
            this.btn_simulation.Location = new System.Drawing.Point(742, 350);
            this.btn_simulation.Name = "btn_simulation";
            this.btn_simulation.Size = new System.Drawing.Size(134, 33);
            this.btn_simulation.TabIndex = 1;
            this.btn_simulation.Text = "Simulation";
            this.btn_simulation.UseVisualStyleBackColor = true;
            this.btn_simulation.Click += new System.EventHandler(this.Btn_simulation_Click);
            // 
            // tap_frais
            // 
            this.tap_frais.Controls.Add(this.gpx_frais);
            this.tap_frais.Controls.Add(this.gbx_choixRegion);
            this.tap_frais.Location = new System.Drawing.Point(4, 22);
            this.tap_frais.Name = "tap_frais";
            this.tap_frais.Padding = new System.Windows.Forms.Padding(3);
            this.tap_frais.Size = new System.Drawing.Size(914, 389);
            this.tap_frais.TabIndex = 0;
            this.tap_frais.Text = "Frais";
            this.tap_frais.UseVisualStyleBackColor = true;
            // 
            // gbx_choixRegion
            // 
            this.gbx_choixRegion.Controls.Add(this.btn_validerChoixRegion);
            this.gbx_choixRegion.Controls.Add(this.lbx_choixRegion);
            this.gbx_choixRegion.Location = new System.Drawing.Point(29, 19);
            this.gbx_choixRegion.Name = "gbx_choixRegion";
            this.gbx_choixRegion.Size = new System.Drawing.Size(868, 76);
            this.gbx_choixRegion.TabIndex = 0;
            this.gbx_choixRegion.TabStop = false;
            this.gbx_choixRegion.Text = "Choix de région :";
            // 
            // lbx_choixRegion
            // 
            this.lbx_choixRegion.FormattingEnabled = true;
            this.lbx_choixRegion.Location = new System.Drawing.Point(15, 24);
            this.lbx_choixRegion.Name = "lbx_choixRegion";
            this.lbx_choixRegion.Size = new System.Drawing.Size(315, 30);
            this.lbx_choixRegion.TabIndex = 0;
            // 
            // btn_validerChoixRegion
            // 
            this.btn_validerChoixRegion.Location = new System.Drawing.Point(390, 24);
            this.btn_validerChoixRegion.Name = "btn_validerChoixRegion";
            this.btn_validerChoixRegion.Size = new System.Drawing.Size(110, 30);
            this.btn_validerChoixRegion.TabIndex = 1;
            this.btn_validerChoixRegion.Text = "Valider";
            this.btn_validerChoixRegion.UseVisualStyleBackColor = true;
            // 
            // gpx_frais
            // 
            this.gpx_frais.Controls.Add(this.btn_enregistrerFrais);
            this.gpx_frais.Controls.Add(this.lbl_coutParKm);
            this.gpx_frais.Controls.Add(this.lbl_coutParNuitHotel);
            this.gpx_frais.Controls.Add(this.lbl_coutParNuitRelais);
            this.gpx_frais.Controls.Add(this.lbl_coutParRepas);
            this.gpx_frais.Controls.Add(this.lbl_deplacement);
            this.gpx_frais.Controls.Add(this.lbl_nuitee);
            this.gpx_frais.Controls.Add(this.lbl_relaisEtape);
            this.gpx_frais.Controls.Add(this.lbl_repasMidi);
            this.gpx_frais.Location = new System.Drawing.Point(31, 103);
            this.gpx_frais.Name = "gpx_frais";
            this.gpx_frais.Size = new System.Drawing.Size(865, 255);
            this.gpx_frais.TabIndex = 1;
            this.gpx_frais.TabStop = false;
            this.gpx_frais.Text = "Modification des frais :";
            // 
            // lbl_repasMidi
            // 
            this.lbl_repasMidi.AutoSize = true;
            this.lbl_repasMidi.Location = new System.Drawing.Point(19, 39);
            this.lbl_repasMidi.Name = "lbl_repasMidi";
            this.lbl_repasMidi.Size = new System.Drawing.Size(111, 13);
            this.lbl_repasMidi.TabIndex = 0;
            this.lbl_repasMidi.Text = "Repas midi : maximum";
            // 
            // lbl_relaisEtape
            // 
            this.lbl_relaisEtape.AutoSize = true;
            this.lbl_relaisEtape.Location = new System.Drawing.Point(19, 71);
            this.lbl_relaisEtape.Name = "lbl_relaisEtape";
            this.lbl_relaisEtape.Size = new System.Drawing.Size(118, 13);
            this.lbl_relaisEtape.TabIndex = 1;
            this.lbl_relaisEtape.Text = "Relais étape : maximum";
            // 
            // lbl_nuitee
            // 
            this.lbl_nuitee.AutoSize = true;
            this.lbl_nuitee.Location = new System.Drawing.Point(19, 104);
            this.lbl_nuitee.Name = "lbl_nuitee";
            this.lbl_nuitee.Size = new System.Drawing.Size(122, 13);
            this.lbl_nuitee.TabIndex = 2;
            this.lbl_nuitee.Text = "Nuitée (hôtel) : maximum";
            // 
            // lbl_deplacement
            // 
            this.lbl_deplacement.AutoSize = true;
            this.lbl_deplacement.Location = new System.Drawing.Point(19, 135);
            this.lbl_deplacement.Name = "lbl_deplacement";
            this.lbl_deplacement.Size = new System.Drawing.Size(143, 13);
            this.lbl_deplacement.TabIndex = 3;
            this.lbl_deplacement.Text = "Déplacement : Kilométrage à";
            // 
            // lbl_coutParRepas
            // 
            this.lbl_coutParRepas.AutoSize = true;
            this.lbl_coutParRepas.Location = new System.Drawing.Point(293, 39);
            this.lbl_coutParRepas.Name = "lbl_coutParRepas";
            this.lbl_coutParRepas.Size = new System.Drawing.Size(50, 13);
            this.lbl_coutParRepas.TabIndex = 4;
            this.lbl_coutParRepas.Text = "€ / repas";
            // 
            // lbl_coutParNuitRelais
            // 
            this.lbl_coutParNuitRelais.AutoSize = true;
            this.lbl_coutParNuitRelais.Location = new System.Drawing.Point(293, 71);
            this.lbl_coutParNuitRelais.Name = "lbl_coutParNuitRelais";
            this.lbl_coutParNuitRelais.Size = new System.Drawing.Size(41, 13);
            this.lbl_coutParNuitRelais.TabIndex = 5;
            this.lbl_coutParNuitRelais.Text = "€ / nuit";
            // 
            // lbl_coutParNuitHotel
            // 
            this.lbl_coutParNuitHotel.AutoSize = true;
            this.lbl_coutParNuitHotel.Location = new System.Drawing.Point(293, 104);
            this.lbl_coutParNuitHotel.Name = "lbl_coutParNuitHotel";
            this.lbl_coutParNuitHotel.Size = new System.Drawing.Size(41, 13);
            this.lbl_coutParNuitHotel.TabIndex = 6;
            this.lbl_coutParNuitHotel.Text = "€ / nuit";
            // 
            // lbl_coutParKm
            // 
            this.lbl_coutParKm.AutoSize = true;
            this.lbl_coutParKm.Location = new System.Drawing.Point(293, 135);
            this.lbl_coutParKm.Name = "lbl_coutParKm";
            this.lbl_coutParKm.Size = new System.Drawing.Size(38, 13);
            this.lbl_coutParKm.TabIndex = 7;
            this.lbl_coutParKm.Text = "€ / km";
            // 
            // btn_enregistrerFrais
            // 
            this.btn_enregistrerFrais.Location = new System.Drawing.Point(189, 211);
            this.btn_enregistrerFrais.Name = "btn_enregistrerFrais";
            this.btn_enregistrerFrais.Size = new System.Drawing.Size(127, 29);
            this.btn_enregistrerFrais.TabIndex = 8;
            this.btn_enregistrerFrais.Text = "Enregistrer";
            this.btn_enregistrerFrais.UseVisualStyleBackColor = true;
            // 
            // tac_fraisAutoSimul
            // 
            this.tac_fraisAutoSimul.Controls.Add(this.tap_frais);
            this.tac_fraisAutoSimul.Controls.Add(this.tap_automatisation);
            this.tac_fraisAutoSimul.Location = new System.Drawing.Point(11, 17);
            this.tac_fraisAutoSimul.Name = "tac_fraisAutoSimul";
            this.tac_fraisAutoSimul.SelectedIndex = 0;
            this.tac_fraisAutoSimul.Size = new System.Drawing.Size(922, 415);
            this.tac_fraisAutoSimul.TabIndex = 0;
            // 
            // safi_dekstop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 589);
            this.Controls.Add(this.tac_accueilParam);
            this.Name = "safi_dekstop";
            this.Text = "SAFI_Deskstop";
            this.tac_accueilParam.ResumeLayout(false);
            this.tap_param.ResumeLayout(false);
            this.tap_automatisation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paramAutomatisation)).EndInit();
            this.tap_frais.ResumeLayout(false);
            this.gbx_choixRegion.ResumeLayout(false);
            this.gpx_frais.ResumeLayout(false);
            this.gpx_frais.PerformLayout();
            this.tac_fraisAutoSimul.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tac_accueilParam;
        private System.Windows.Forms.TabPage tap_Accueil;
        private System.Windows.Forms.TabPage tap_param;
        private System.Windows.Forms.TabControl tac_fraisAutoSimul;
        private System.Windows.Forms.TabPage tap_frais;
        private System.Windows.Forms.GroupBox gpx_frais;
        private System.Windows.Forms.Button btn_enregistrerFrais;
        private System.Windows.Forms.Label lbl_coutParKm;
        private System.Windows.Forms.Label lbl_coutParNuitHotel;
        private System.Windows.Forms.Label lbl_coutParNuitRelais;
        private System.Windows.Forms.Label lbl_coutParRepas;
        private System.Windows.Forms.Label lbl_deplacement;
        private System.Windows.Forms.Label lbl_nuitee;
        private System.Windows.Forms.Label lbl_relaisEtape;
        private System.Windows.Forms.Label lbl_repasMidi;
        private System.Windows.Forms.GroupBox gbx_choixRegion;
        private System.Windows.Forms.Button btn_validerChoixRegion;
        private System.Windows.Forms.ListBox lbx_choixRegion;
        private System.Windows.Forms.TabPage tap_automatisation;
        private System.Windows.Forms.Button btn_simulation;
        private System.Windows.Forms.DataGridView dgv_paramAutomatisation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_activationParam;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nomParam;
    }
}

