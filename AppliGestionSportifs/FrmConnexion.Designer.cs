namespace AppliGestionSportifs
{
    partial class FrmConnexion
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
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.btnCreerCompte = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblMDP = new System.Windows.Forms.Label();
            this.btnChanMDP = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(471, 408);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(342, 37);
            this.txtLogin.TabIndex = 0;
            // 
            // txtMdp
            // 
            this.txtMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMdp.Location = new System.Drawing.Point(471, 511);
            this.txtMdp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(342, 37);
            this.txtMdp.TabIndex = 1;
            // 
            // btnConnexion
            // 
            this.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.Location = new System.Drawing.Point(1117, 310);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(239, 74);
            this.btnConnexion.TabIndex = 2;
            this.btnConnexion.Text = "CONNEXION";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // btnCreerCompte
            // 
            this.btnCreerCompte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreerCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreerCompte.Location = new System.Drawing.Point(1117, 391);
            this.btnCreerCompte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreerCompte.Name = "btnCreerCompte";
            this.btnCreerCompte.Size = new System.Drawing.Size(239, 74);
            this.btnCreerCompte.TabIndex = 3;
            this.btnCreerCompte.Text = "CREER UN COMPTE";
            this.btnCreerCompte.UseVisualStyleBackColor = true;
            this.btnCreerCompte.Click += new System.EventHandler(this.btnCreerCompte_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(4, 0);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(161, 31);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Identifiant :";
            // 
            // lblMDP
            // 
            this.lblMDP.AutoSize = true;
            this.lblMDP.BackColor = System.Drawing.Color.Transparent;
            this.lblMDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMDP.ForeColor = System.Drawing.Color.White;
            this.lblMDP.Location = new System.Drawing.Point(12, 1);
            this.lblMDP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMDP.Name = "lblMDP";
            this.lblMDP.Size = new System.Drawing.Size(213, 31);
            this.lblMDP.TabIndex = 5;
            this.lblMDP.Text = "Mot De Passe :";
            // 
            // btnChanMDP
            // 
            this.btnChanMDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChanMDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChanMDP.Location = new System.Drawing.Point(1117, 485);
            this.btnChanMDP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChanMDP.Name = "btnChanMDP";
            this.btnChanMDP.Size = new System.Drawing.Size(239, 70);
            this.btnChanMDP.TabIndex = 6;
            this.btnChanMDP.Text = "MODIFIER MOT DE PASSE";
            this.btnChanMDP.UseVisualStyleBackColor = true;
            this.btnChanMDP.Click += new System.EventHandler(this.btnChanMDP_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Location = new System.Drawing.Point(471, 362);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 38);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.lblMDP);
            this.panel2.Location = new System.Drawing.Point(471, 466);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 38);
            this.panel2.TabIndex = 8;
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppliGestionSportifs.Properties.Resources.fond_login_bon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1592, 796);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChanMDP);
            this.Controls.Add(this.btnCreerCompte);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmConnexion";
            this.Text = "FrmConnexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Button btnCreerCompte;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblMDP;
        private System.Windows.Forms.Button btnChanMDP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}