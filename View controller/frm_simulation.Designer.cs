namespace SAFI_Dekstop
{
    partial class frm_simulation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_simulation = new System.Windows.Forms.Label();
            this.btn_lancerSimulation = new System.Windows.Forms.Button();
            this.btn_validerSimulation = new System.Windows.Forms.Button();
            this.btn_annulerSimulation = new System.Windows.Forms.Button();
            this.lbl_couleurFichierAtraiter = new System.Windows.Forms.Label();
            this.lbl_fichiersAtraiter = new System.Windows.Forms.Label();
            this.lbl_coulerFichiersTraites = new System.Windows.Forms.Label();
            this.lbl_fichierstraites = new System.Windows.Forms.Label();
            this.lbl_couleurFichiersAtraiterAp = new System.Windows.Forms.Label();
            this.lbl_fichiersAtraiterAp = new System.Windows.Forms.Label();
            this.lbl_couleurFichiersTraitesAp = new System.Windows.Forms.Label();
            this.lbl_fichiersTraitesAp = new System.Windows.Forms.Label();
            this.pgb_avSimul = new System.Windows.Forms.ProgressBar();
            this.pgb_apSimul = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lbl_simulation
            // 
            this.lbl_simulation.AutoSize = true;
            this.lbl_simulation.Location = new System.Drawing.Point(357, 9);
            this.lbl_simulation.Name = "lbl_simulation";
            this.lbl_simulation.Size = new System.Drawing.Size(55, 13);
            this.lbl_simulation.TabIndex = 2;
            this.lbl_simulation.Text = "Simulation";
            // 
            // btn_lancerSimulation
            // 
            this.btn_lancerSimulation.Location = new System.Drawing.Point(312, 187);
            this.btn_lancerSimulation.Name = "btn_lancerSimulation";
            this.btn_lancerSimulation.Size = new System.Drawing.Size(182, 31);
            this.btn_lancerSimulation.TabIndex = 5;
            this.btn_lancerSimulation.Text = "Lancer la simulation";
            this.btn_lancerSimulation.UseVisualStyleBackColor = true;
            // 
            // btn_validerSimulation
            // 
            this.btn_validerSimulation.Location = new System.Drawing.Point(430, 448);
            this.btn_validerSimulation.Name = "btn_validerSimulation";
            this.btn_validerSimulation.Size = new System.Drawing.Size(132, 31);
            this.btn_validerSimulation.TabIndex = 6;
            this.btn_validerSimulation.Text = "Valider";
            this.btn_validerSimulation.UseVisualStyleBackColor = true;
            // 
            // btn_annulerSimulation
            // 
            this.btn_annulerSimulation.Location = new System.Drawing.Point(247, 448);
            this.btn_annulerSimulation.Name = "btn_annulerSimulation";
            this.btn_annulerSimulation.Size = new System.Drawing.Size(130, 31);
            this.btn_annulerSimulation.TabIndex = 7;
            this.btn_annulerSimulation.Text = "Annuler";
            this.btn_annulerSimulation.UseVisualStyleBackColor = true;
            this.btn_annulerSimulation.Click += new System.EventHandler(this.Btn_annulerSimulation_Click);
            // 
            // lbl_couleurFichierAtraiter
            // 
            this.lbl_couleurFichierAtraiter.AutoSize = true;
            this.lbl_couleurFichierAtraiter.BackColor = System.Drawing.Color.Red;
            this.lbl_couleurFichierAtraiter.Location = new System.Drawing.Point(231, 115);
            this.lbl_couleurFichierAtraiter.MinimumSize = new System.Drawing.Size(15, 5);
            this.lbl_couleurFichierAtraiter.Name = "lbl_couleurFichierAtraiter";
            this.lbl_couleurFichierAtraiter.Size = new System.Drawing.Size(15, 13);
            this.lbl_couleurFichierAtraiter.TabIndex = 8;
            // 
            // lbl_fichiersAtraiter
            // 
            this.lbl_fichiersAtraiter.AutoSize = true;
            this.lbl_fichiersAtraiter.Location = new System.Drawing.Point(285, 115);
            this.lbl_fichiersAtraiter.Name = "lbl_fichiersAtraiter";
            this.lbl_fichiersAtraiter.Size = new System.Drawing.Size(76, 13);
            this.lbl_fichiersAtraiter.TabIndex = 9;
            this.lbl_fichiersAtraiter.Text = "Fichier à traiter";
            // 
            // lbl_coulerFichiersTraites
            // 
            this.lbl_coulerFichiersTraites.AutoSize = true;
            this.lbl_coulerFichiersTraites.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_coulerFichiersTraites.Location = new System.Drawing.Point(231, 141);
            this.lbl_coulerFichiersTraites.MinimumSize = new System.Drawing.Size(15, 0);
            this.lbl_coulerFichiersTraites.Name = "lbl_coulerFichiersTraites";
            this.lbl_coulerFichiersTraites.Size = new System.Drawing.Size(15, 13);
            this.lbl_coulerFichiersTraites.TabIndex = 10;
            // 
            // lbl_fichierstraites
            // 
            this.lbl_fichierstraites.AutoSize = true;
            this.lbl_fichierstraites.Location = new System.Drawing.Point(285, 141);
            this.lbl_fichierstraites.Name = "lbl_fichierstraites";
            this.lbl_fichierstraites.Size = new System.Drawing.Size(74, 13);
            this.lbl_fichierstraites.TabIndex = 11;
            this.lbl_fichierstraites.Text = "Fichiers traités";
            // 
            // lbl_couleurFichiersAtraiterAp
            // 
            this.lbl_couleurFichiersAtraiterAp.AutoSize = true;
            this.lbl_couleurFichiersAtraiterAp.BackColor = System.Drawing.Color.Red;
            this.lbl_couleurFichiersAtraiterAp.Location = new System.Drawing.Point(231, 318);
            this.lbl_couleurFichiersAtraiterAp.MinimumSize = new System.Drawing.Size(15, 0);
            this.lbl_couleurFichiersAtraiterAp.Name = "lbl_couleurFichiersAtraiterAp";
            this.lbl_couleurFichiersAtraiterAp.Size = new System.Drawing.Size(15, 13);
            this.lbl_couleurFichiersAtraiterAp.TabIndex = 12;
            // 
            // lbl_fichiersAtraiterAp
            // 
            this.lbl_fichiersAtraiterAp.AutoSize = true;
            this.lbl_fichiersAtraiterAp.Location = new System.Drawing.Point(285, 318);
            this.lbl_fichiersAtraiterAp.Name = "lbl_fichiersAtraiterAp";
            this.lbl_fichiersAtraiterAp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_fichiersAtraiterAp.Size = new System.Drawing.Size(81, 13);
            this.lbl_fichiersAtraiterAp.TabIndex = 13;
            this.lbl_fichiersAtraiterAp.Text = "Fichiers à traiter";
            // 
            // lbl_couleurFichiersTraitesAp
            // 
            this.lbl_couleurFichiersTraitesAp.AutoSize = true;
            this.lbl_couleurFichiersTraitesAp.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_couleurFichiersTraitesAp.Location = new System.Drawing.Point(231, 346);
            this.lbl_couleurFichiersTraitesAp.MinimumSize = new System.Drawing.Size(15, 0);
            this.lbl_couleurFichiersTraitesAp.Name = "lbl_couleurFichiersTraitesAp";
            this.lbl_couleurFichiersTraitesAp.Size = new System.Drawing.Size(15, 13);
            this.lbl_couleurFichiersTraitesAp.TabIndex = 14;
            // 
            // lbl_fichiersTraitesAp
            // 
            this.lbl_fichiersTraitesAp.AutoSize = true;
            this.lbl_fichiersTraitesAp.Location = new System.Drawing.Point(285, 346);
            this.lbl_fichiersTraitesAp.Name = "lbl_fichiersTraitesAp";
            this.lbl_fichiersTraitesAp.Size = new System.Drawing.Size(74, 13);
            this.lbl_fichiersTraitesAp.TabIndex = 15;
            this.lbl_fichiersTraitesAp.Text = "Fichiers traités";
            // 
            // pgb_avSimul
            // 
            this.pgb_avSimul.Location = new System.Drawing.Point(275, 53);
            this.pgb_avSimul.Name = "pgb_avSimul";
            this.pgb_avSimul.Size = new System.Drawing.Size(244, 23);
            this.pgb_avSimul.Step = 1;
            this.pgb_avSimul.TabIndex = 16;
            // 
            // pgb_apSimul
            // 
            this.pgb_apSimul.Location = new System.Drawing.Point(275, 269);
            this.pgb_apSimul.Name = "pgb_apSimul";
            this.pgb_apSimul.Size = new System.Drawing.Size(244, 23);
            this.pgb_apSimul.Step = 1;
            this.pgb_apSimul.TabIndex = 17;
            // 
            // frm_simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 553);
            this.Controls.Add(this.pgb_apSimul);
            this.Controls.Add(this.pgb_avSimul);
            this.Controls.Add(this.lbl_fichiersTraitesAp);
            this.Controls.Add(this.lbl_couleurFichiersTraitesAp);
            this.Controls.Add(this.lbl_fichiersAtraiterAp);
            this.Controls.Add(this.lbl_couleurFichiersAtraiterAp);
            this.Controls.Add(this.lbl_fichierstraites);
            this.Controls.Add(this.lbl_coulerFichiersTraites);
            this.Controls.Add(this.lbl_fichiersAtraiter);
            this.Controls.Add(this.lbl_couleurFichierAtraiter);
            this.Controls.Add(this.btn_annulerSimulation);
            this.Controls.Add(this.btn_validerSimulation);
            this.Controls.Add(this.btn_lancerSimulation);
            this.Controls.Add(this.lbl_simulation);
            this.Name = "frm_simulation";
            this.Text = "SAFI_Dekstop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_simulation;
        private System.Windows.Forms.Button btn_lancerSimulation;
        private System.Windows.Forms.Button btn_validerSimulation;
        private System.Windows.Forms.Button btn_annulerSimulation;
        private System.Windows.Forms.Label lbl_couleurFichierAtraiter;
        private System.Windows.Forms.Label lbl_fichiersAtraiter;
        private System.Windows.Forms.Label lbl_coulerFichiersTraites;
        private System.Windows.Forms.Label lbl_fichierstraites;
        private System.Windows.Forms.Label lbl_couleurFichiersAtraiterAp;
        private System.Windows.Forms.Label lbl_fichiersAtraiterAp;
        private System.Windows.Forms.Label lbl_couleurFichiersTraitesAp;
        private System.Windows.Forms.Label lbl_fichiersTraitesAp;
        private System.Windows.Forms.ProgressBar pgb_avSimul;
        private System.Windows.Forms.ProgressBar pgb_apSimul;
    }
}