namespace SAFI_Dekstop
{
    partial class frm_mdpOublie
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
            this.lbl_entrerMdp = new System.Windows.Forms.Label();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.btn_annulerEmail = new System.Windows.Forms.Button();
            this.btn_validerEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_entrerMdp
            // 
            this.lbl_entrerMdp.AutoSize = true;
            this.lbl_entrerMdp.Location = new System.Drawing.Point(91, 55);
            this.lbl_entrerMdp.Name = "lbl_entrerMdp";
            this.lbl_entrerMdp.Size = new System.Drawing.Size(288, 13);
            this.lbl_entrerMdp.TabIndex = 0;
            this.lbl_entrerMdp.Text = "Entrez votre e-mail afin de créer un nouveau mot de passe :";
            // 
            // tbx_email
            // 
            this.tbx_email.Location = new System.Drawing.Point(101, 108);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(277, 20);
            this.tbx_email.TabIndex = 1;
            // 
            // btn_annulerEmail
            // 
            this.btn_annulerEmail.Location = new System.Drawing.Point(120, 195);
            this.btn_annulerEmail.Name = "btn_annulerEmail";
            this.btn_annulerEmail.Size = new System.Drawing.Size(61, 24);
            this.btn_annulerEmail.TabIndex = 2;
            this.btn_annulerEmail.Text = "Annuler";
            this.btn_annulerEmail.UseVisualStyleBackColor = true;
            this.btn_annulerEmail.Click += new System.EventHandler(this.Btn_annulerEmail_Click);
            // 
            // btn_validerEmail
            // 
            this.btn_validerEmail.Location = new System.Drawing.Point(278, 195);
            this.btn_validerEmail.Name = "btn_validerEmail";
            this.btn_validerEmail.Size = new System.Drawing.Size(61, 24);
            this.btn_validerEmail.TabIndex = 3;
            this.btn_validerEmail.Text = "Valider";
            this.btn_validerEmail.UseVisualStyleBackColor = true;
            // 
            // frm_mdpOublie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 250);
            this.Controls.Add(this.btn_validerEmail);
            this.Controls.Add(this.btn_annulerEmail);
            this.Controls.Add(this.tbx_email);
            this.Controls.Add(this.lbl_entrerMdp);
            this.Name = "frm_mdpOublie";
            this.Text = "Mot de passe oublié";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_entrerMdp;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.Button btn_annulerEmail;
        private System.Windows.Forms.Button btn_validerEmail;
    }
}