namespace SAFI_Dekstop
{
    partial class frm_accueilEtParam
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tac_accueilParam = new System.Windows.Forms.TabControl();
            this.tap_Accueil = new System.Windows.Forms.TabPage();
            this.etatFiche = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgv_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_numFiche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_montantTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_fiche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tap_param = new System.Windows.Forms.TabPage();
            this.tac_fraisAutoSimul = new System.Windows.Forms.TabControl();
            this.tap_frais = new System.Windows.Forms.TabPage();
            this.gpx_frais = new System.Windows.Forms.GroupBox();
            this.btn_enregistrerFrais = new System.Windows.Forms.Button();
            this.lbl_coutParKm = new System.Windows.Forms.Label();
            this.lbl_coutParNuitHotel = new System.Windows.Forms.Label();
            this.lbl_coutParNuitRelais = new System.Windows.Forms.Label();
            this.lbl_coutParRepas = new System.Windows.Forms.Label();
            this.lbl_deplacement = new System.Windows.Forms.Label();
            this.lbl_nuitee = new System.Windows.Forms.Label();
            this.lbl_relaisEtape = new System.Windows.Forms.Label();
            this.lbl_repasMidi = new System.Windows.Forms.Label();
            this.gbx_choixRegion = new System.Windows.Forms.GroupBox();
            this.btn_validerChoixRegion = new System.Windows.Forms.Button();
            this.lbx_choixRegion = new System.Windows.Forms.ListBox();
            this.tap_automatisation = new System.Windows.Forms.TabPage();
            this.btn_simulation = new System.Windows.Forms.Button();
            this.dgv_paramAutomatisation = new System.Windows.Forms.DataGridView();
            this.col_activationParam = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_nomParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tap_gestionUtilisateurs = new System.Windows.Forms.TabPage();
            this.btn_ajouterUnUtilisateur = new System.Windows.Forms.Button();
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.dgv_utilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_activerDesactiver = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgv_mettreAJour = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btn_recherche = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tac_accueilParam.SuspendLayout();
            this.tap_Accueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etatFiche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tap_param.SuspendLayout();
            this.tac_fraisAutoSimul.SuspendLayout();
            this.tap_frais.SuspendLayout();
            this.gpx_frais.SuspendLayout();
            this.gbx_choixRegion.SuspendLayout();
            this.tap_automatisation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paramAutomatisation)).BeginInit();
            this.tap_gestionUtilisateurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.SuspendLayout();
            // 
            // tac_accueilParam
            // 
            this.tac_accueilParam.Controls.Add(this.tap_Accueil);
            this.tac_accueilParam.Controls.Add(this.tap_param);
            this.tac_accueilParam.Controls.Add(this.tap_gestionUtilisateurs);
            this.tac_accueilParam.Location = new System.Drawing.Point(12, 12);
            this.tac_accueilParam.Name = "tac_accueilParam";
            this.tac_accueilParam.SelectedIndex = 0;
            this.tac_accueilParam.Size = new System.Drawing.Size(955, 486);
            this.tac_accueilParam.TabIndex = 0;
            // 
            // tap_Accueil
            // 
            this.tap_Accueil.Controls.Add(this.etatFiche);
            this.tap_Accueil.Controls.Add(this.dataGridView1);
            this.tap_Accueil.Location = new System.Drawing.Point(4, 22);
            this.tap_Accueil.Name = "tap_Accueil";
            this.tap_Accueil.Padding = new System.Windows.Forms.Padding(3);
            this.tap_Accueil.Size = new System.Drawing.Size(947, 460);
            this.tap_Accueil.TabIndex = 0;
            this.tap_Accueil.Text = "Accueil";
            this.tap_Accueil.UseVisualStyleBackColor = true;
            // 
            // etatFiche
            // 
            chartArea1.Name = "etatFiche";
            this.etatFiche.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.etatFiche.Legends.Add(legend1);
            this.etatFiche.Location = new System.Drawing.Point(116, 122);
            this.etatFiche.Name = "etatFiche";
            series1.ChartArea = "etatFiche";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "etatFiche";
            this.etatFiche.Series.Add(series1);
            this.etatFiche.Size = new System.Drawing.Size(221, 216);
            this.etatFiche.TabIndex = 3;
            this.etatFiche.Text = "etatFiche";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_nom,
            this.dgv_numFiche,
            this.dgv_montantTotal,
            this.dgv_fiche});
            this.dataGridView1.Location = new System.Drawing.Point(383, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 93);
            this.dataGridView1.TabIndex = 2;
            // 
            // dgv_nom
            // 
            this.dgv_nom.HeaderText = "Nom";
            this.dgv_nom.Name = "dgv_nom";
            // 
            // dgv_numFiche
            // 
            this.dgv_numFiche.HeaderText = "Numéro de fiche";
            this.dgv_numFiche.Name = "dgv_numFiche";
            // 
            // dgv_montantTotal
            // 
            this.dgv_montantTotal.HeaderText = "Montant total";
            this.dgv_montantTotal.Name = "dgv_montantTotal";
            // 
            // dgv_fiche
            // 
            this.dgv_fiche.HeaderText = "Voir fiche";
            this.dgv_fiche.Name = "dgv_fiche";
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
            // btn_enregistrerFrais
            // 
            this.btn_enregistrerFrais.Location = new System.Drawing.Point(189, 211);
            this.btn_enregistrerFrais.Name = "btn_enregistrerFrais";
            this.btn_enregistrerFrais.Size = new System.Drawing.Size(127, 29);
            this.btn_enregistrerFrais.TabIndex = 8;
            this.btn_enregistrerFrais.Text = "Enregistrer";
            this.btn_enregistrerFrais.UseVisualStyleBackColor = true;
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
            // lbl_coutParNuitHotel
            // 
            this.lbl_coutParNuitHotel.AutoSize = true;
            this.lbl_coutParNuitHotel.Location = new System.Drawing.Point(293, 104);
            this.lbl_coutParNuitHotel.Name = "lbl_coutParNuitHotel";
            this.lbl_coutParNuitHotel.Size = new System.Drawing.Size(41, 13);
            this.lbl_coutParNuitHotel.TabIndex = 6;
            this.lbl_coutParNuitHotel.Text = "€ / nuit";
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
            // lbl_coutParRepas
            // 
            this.lbl_coutParRepas.AutoSize = true;
            this.lbl_coutParRepas.Location = new System.Drawing.Point(293, 39);
            this.lbl_coutParRepas.Name = "lbl_coutParRepas";
            this.lbl_coutParRepas.Size = new System.Drawing.Size(50, 13);
            this.lbl_coutParRepas.TabIndex = 4;
            this.lbl_coutParRepas.Text = "€ / repas";
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
            // lbl_nuitee
            // 
            this.lbl_nuitee.AutoSize = true;
            this.lbl_nuitee.Location = new System.Drawing.Point(19, 104);
            this.lbl_nuitee.Name = "lbl_nuitee";
            this.lbl_nuitee.Size = new System.Drawing.Size(122, 13);
            this.lbl_nuitee.TabIndex = 2;
            this.lbl_nuitee.Text = "Nuitée (hôtel) : maximum";
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
            // lbl_repasMidi
            // 
            this.lbl_repasMidi.AutoSize = true;
            this.lbl_repasMidi.Location = new System.Drawing.Point(19, 39);
            this.lbl_repasMidi.Name = "lbl_repasMidi";
            this.lbl_repasMidi.Size = new System.Drawing.Size(111, 13);
            this.lbl_repasMidi.TabIndex = 0;
            this.lbl_repasMidi.Text = "Repas midi : maximum";
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
            // btn_validerChoixRegion
            // 
            this.btn_validerChoixRegion.Location = new System.Drawing.Point(390, 24);
            this.btn_validerChoixRegion.Name = "btn_validerChoixRegion";
            this.btn_validerChoixRegion.Size = new System.Drawing.Size(110, 30);
            this.btn_validerChoixRegion.TabIndex = 1;
            this.btn_validerChoixRegion.Text = "Valider";
            this.btn_validerChoixRegion.UseVisualStyleBackColor = true;
            // 
            // lbx_choixRegion
            // 
            this.lbx_choixRegion.FormattingEnabled = true;
            this.lbx_choixRegion.Location = new System.Drawing.Point(15, 24);
            this.lbx_choixRegion.Name = "lbx_choixRegion";
            this.lbx_choixRegion.Size = new System.Drawing.Size(315, 30);
            this.lbx_choixRegion.TabIndex = 0;
            this.lbx_choixRegion.SelectedIndexChanged += new System.EventHandler(this.Lbx_choixRegion_SelectedIndexChanged);
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
            // col_activationParam
            // 
            this.col_activationParam.HeaderText = "Activer / Désactiver";
            this.col_activationParam.Name = "col_activationParam";
            this.col_activationParam.Width = 140;
            // 
            // col_nomParam
            // 
            this.col_nomParam.HeaderText = "Nom du paramètre";
            this.col_nomParam.Name = "col_nomParam";
            this.col_nomParam.Width = 140;
            // 
            // tap_gestionUtilisateurs
            // 
            this.tap_gestionUtilisateurs.Controls.Add(this.btn_ajouterUnUtilisateur);
            this.tap_gestionUtilisateurs.Controls.Add(this.dgv_users);
            this.tap_gestionUtilisateurs.Controls.Add(this.btn_recherche);
            this.tap_gestionUtilisateurs.Controls.Add(this.textBox1);
            this.tap_gestionUtilisateurs.Location = new System.Drawing.Point(4, 22);
            this.tap_gestionUtilisateurs.Name = "tap_gestionUtilisateurs";
            this.tap_gestionUtilisateurs.Padding = new System.Windows.Forms.Padding(3);
            this.tap_gestionUtilisateurs.Size = new System.Drawing.Size(947, 460);
            this.tap_gestionUtilisateurs.TabIndex = 2;
            this.tap_gestionUtilisateurs.Text = "Gestion des utilisateurs";
            this.tap_gestionUtilisateurs.UseVisualStyleBackColor = true;
            // 
            // btn_ajouterUnUtilisateur
            // 
            this.btn_ajouterUnUtilisateur.Location = new System.Drawing.Point(680, 376);
            this.btn_ajouterUnUtilisateur.Name = "btn_ajouterUnUtilisateur";
            this.btn_ajouterUnUtilisateur.Size = new System.Drawing.Size(137, 23);
            this.btn_ajouterUnUtilisateur.TabIndex = 7;
            this.btn_ajouterUnUtilisateur.Text = "Ajouter un utilisateur";
            this.btn_ajouterUnUtilisateur.UseVisualStyleBackColor = true;
            this.btn_ajouterUnUtilisateur.Click += new System.EventHandler(this.Btn_ajouterUnUtilisateur_Click);
            // 
            // dgv_users
            // 
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_utilisateur,
            this.dgv_activerDesactiver,
            this.dgv_mettreAJour});
            this.dgv_users.Location = new System.Drawing.Point(130, 106);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.Size = new System.Drawing.Size(580, 240);
            this.dgv_users.TabIndex = 6;
            this.dgv_users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_users_CellContentClick);
            // 
            // dgv_utilisateur
            // 
            this.dgv_utilisateur.HeaderText = "Utilisateur";
            this.dgv_utilisateur.Name = "dgv_utilisateur";
            // 
            // dgv_activerDesactiver
            // 
            this.dgv_activerDesactiver.HeaderText = "Activer/désactiver";
            this.dgv_activerDesactiver.Name = "dgv_activerDesactiver";
            this.dgv_activerDesactiver.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_activerDesactiver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgv_mettreAJour
            // 
            this.dgv_mettreAJour.HeaderText = "Mettre à jour";
            this.dgv_mettreAJour.Name = "dgv_mettreAJour";
            this.dgv_mettreAJour.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_mettreAJour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btn_recherche
            // 
            this.btn_recherche.Location = new System.Drawing.Point(370, 62);
            this.btn_recherche.Name = "btn_recherche";
            this.btn_recherche.Size = new System.Drawing.Size(75, 23);
            this.btn_recherche.TabIndex = 5;
            this.btn_recherche.Text = "Rechercher";
            this.btn_recherche.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 4;
            // 
            // frm_accueilEtParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 589);
            this.Controls.Add(this.tac_accueilParam);
            this.Name = "frm_accueilEtParam";
            this.Text = "SafiRepay";
            this.Load += new System.EventHandler(this.Frm_accueilEtParam_Load);
            this.tac_accueilParam.ResumeLayout(false);
            this.tap_Accueil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.etatFiche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tap_param.ResumeLayout(false);
            this.tac_fraisAutoSimul.ResumeLayout(false);
            this.tap_frais.ResumeLayout(false);
            this.gpx_frais.ResumeLayout(false);
            this.gpx_frais.PerformLayout();
            this.gbx_choixRegion.ResumeLayout(false);
            this.tap_automatisation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paramAutomatisation)).EndInit();
            this.tap_gestionUtilisateurs.ResumeLayout(false);
            this.tap_gestionUtilisateurs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart etatFiche;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_numFiche;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_montantTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_fiche;
        private System.Windows.Forms.TabPage tap_gestionUtilisateurs;
        private System.Windows.Forms.Button btn_ajouterUnUtilisateur;
        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.Button btn_recherche;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_utilisateur;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_activerDesactiver;
        private System.Windows.Forms.DataGridViewButtonColumn dgv_mettreAJour;
    }
}

