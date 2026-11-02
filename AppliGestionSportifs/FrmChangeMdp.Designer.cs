namespace AppliGestionSportifs
{
    partial class FrmChangeMdp
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtAncienMdp = new System.Windows.Forms.TextBox();
            this.txtNouveauMdp = new System.Windows.Forms.TextBox();
            this.txtConfirmMdp = new System.Windows.Forms.TextBox();
            this.btnValiderChangement = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMdpActuelle = new System.Windows.Forms.Label();
            this.lblNouveauMdp = new System.Windows.Forms.Label();
            this.lblConfirmMdp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(137, 107);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(259, 29);
            this.txtLogin.TabIndex = 0;
            // 
            // txtAncienMdp
            // 
            this.txtAncienMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAncienMdp.Location = new System.Drawing.Point(137, 188);
            this.txtAncienMdp.Name = "txtAncienMdp";
            this.txtAncienMdp.Size = new System.Drawing.Size(259, 29);
            this.txtAncienMdp.TabIndex = 1;
            // 
            // txtNouveauMdp
            // 
            this.txtNouveauMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNouveauMdp.Location = new System.Drawing.Point(137, 266);
            this.txtNouveauMdp.Name = "txtNouveauMdp";
            this.txtNouveauMdp.Size = new System.Drawing.Size(259, 29);
            this.txtNouveauMdp.TabIndex = 2;
            // 
            // txtConfirmMdp
            // 
            this.txtConfirmMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmMdp.Location = new System.Drawing.Point(137, 344);
            this.txtConfirmMdp.Name = "txtConfirmMdp";
            this.txtConfirmMdp.Size = new System.Drawing.Size(259, 29);
            this.txtConfirmMdp.TabIndex = 3;
            // 
            // btnValiderChangement
            // 
            this.btnValiderChangement.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnValiderChangement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderChangement.ForeColor = System.Drawing.Color.White;
            this.btnValiderChangement.Location = new System.Drawing.Point(121, 395);
            this.btnValiderChangement.Name = "btnValiderChangement";
            this.btnValiderChangement.Size = new System.Drawing.Size(303, 64);
            this.btnValiderChangement.TabIndex = 4;
            this.btnValiderChangement.Text = "VALIDER LA MODIFICATION";
            this.btnValiderChangement.UseVisualStyleBackColor = false;
            this.btnValiderChangement.Click += new System.EventHandler(this.btnValiderChangement_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(185, 88);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(143, 17);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Taper votre identifiant :";
            // 
            // lblMdpActuelle
            // 
            this.lblMdpActuelle.AutoSize = true;
            this.lblMdpActuelle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdpActuelle.Location = new System.Drawing.Point(151, 169);
            this.lblMdpActuelle.Name = "lblMdpActuelle";
            this.lblMdpActuelle.Size = new System.Drawing.Size(214, 17);
            this.lblMdpActuelle.TabIndex = 6;
            this.lblMdpActuelle.Text = "Taper votre mot de passe actuelle :";
            // 
            // lblNouveauMdp
            // 
            this.lblNouveauMdp.AutoSize = true;
            this.lblNouveauMdp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNouveauMdp.Location = new System.Drawing.Point(154, 247);
            this.lblNouveauMdp.Name = "lblNouveauMdp";
            this.lblNouveauMdp.Size = new System.Drawing.Size(219, 17);
            this.lblNouveauMdp.TabIndex = 7;
            this.lblNouveauMdp.Text = "Taper votre nouveau mot de passe :";
            // 
            // lblConfirmMdp
            // 
            this.lblConfirmMdp.AutoSize = true;
            this.lblConfirmMdp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmMdp.Location = new System.Drawing.Point(151, 325);
            this.lblConfirmMdp.Name = "lblConfirmMdp";
            this.lblConfirmMdp.Size = new System.Drawing.Size(244, 17);
            this.lblConfirmMdp.TabIndex = 8;
            this.lblConfirmMdp.Text = "Confirmer votre nouveau mot de passe :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtLogin);
            this.panel1.Controls.Add(this.btnValiderChangement);
            this.panel1.Controls.Add(this.lblConfirmMdp);
            this.panel1.Controls.Add(this.txtAncienMdp);
            this.panel1.Controls.Add(this.lblNouveauMdp);
            this.panel1.Controls.Add(this.txtNouveauMdp);
            this.panel1.Controls.Add(this.lblMdpActuelle);
            this.panel1.Controls.Add(this.txtConfirmMdp);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Location = new System.Drawing.Point(377, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 473);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Modification du mot de passe";
            // 
            // FrmChangeMdp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1230, 681);
            this.Controls.Add(this.panel1);
            this.Name = "FrmChangeMdp";
            this.Text = "FrmChangeMdp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtAncienMdp;
        private System.Windows.Forms.TextBox txtNouveauMdp;
        private System.Windows.Forms.TextBox txtConfirmMdp;
        private System.Windows.Forms.Button btnValiderChangement;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMdpActuelle;
        private System.Windows.Forms.Label lblNouveauMdp;
        private System.Windows.Forms.Label lblConfirmMdp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}