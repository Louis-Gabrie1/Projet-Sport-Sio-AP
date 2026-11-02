namespace AppliGestionSportifs
{
    partial class FrmGestion
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
            this.listViewResult = new System.Windows.Forms.ListView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.cbNiveauExp = new System.Windows.Forms.ComboBox();
            this.cbNomSport = new System.Windows.Forms.ComboBox();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNiv = new System.Windows.Forms.Label();
            this.lblSport = new System.Windows.Forms.Label();
            this.grpboxInfo = new System.Windows.Forms.GroupBox();
            this.grpboxSportif = new System.Windows.Forms.GroupBox();
            this.grpboxActions = new System.Windows.Forms.GroupBox();
            this.grpboxInfo.SuspendLayout();
            this.grpboxSportif.SuspendLayout();
            this.grpboxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewResult
            // 
            this.listViewResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewResult.HideSelection = false;
            this.listViewResult.Location = new System.Drawing.Point(28, 24);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(1044, 319);
            this.listViewResult.TabIndex = 0;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            this.listViewResult.SelectedIndexChanged += new System.EventHandler(this.listViewResult_SelectedIndexChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.LightGreen;
            this.btnAjouter.FlatAppearance.BorderSize = 3;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(35, 23);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(153, 59);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "AJOUTER";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnModifier.FlatAppearance.BorderSize = 3;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(35, 88);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(153, 59);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "MODIFIER";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Tomato;
            this.btnSupprimer.FlatAppearance.BorderSize = 3;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(35, 157);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(153, 59);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "SUPPRIMER";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(131, 79);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(137, 26);
            this.txtNom.TabIndex = 4;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(131, 111);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(137, 26);
            this.txtPrenom.TabIndex = 5;
            // 
            // txtRue
            // 
            this.txtRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRue.Location = new System.Drawing.Point(617, 38);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(137, 26);
            this.txtRue.TabIndex = 6;
            // 
            // txtCP
            // 
            this.txtCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCP.Location = new System.Drawing.Point(615, 80);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(139, 26);
            this.txtCP.TabIndex = 7;
            // 
            // txtVille
            // 
            this.txtVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVille.Location = new System.Drawing.Point(615, 121);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(139, 26);
            this.txtVille.TabIndex = 8;
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateNaissance.Location = new System.Drawing.Point(49, 162);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(252, 26);
            this.dtpDateNaissance.TabIndex = 9;
            // 
            // cbNiveauExp
            // 
            this.cbNiveauExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNiveauExp.FormattingEnabled = true;
            this.cbNiveauExp.Location = new System.Drawing.Point(350, 255);
            this.cbNiveauExp.Name = "cbNiveauExp";
            this.cbNiveauExp.Size = new System.Drawing.Size(121, 28);
            this.cbNiveauExp.TabIndex = 10;
            // 
            // cbNomSport
            // 
            this.cbNomSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNomSport.FormattingEnabled = true;
            this.cbNomSport.Location = new System.Drawing.Point(630, 252);
            this.cbNomSport.Name = "cbNomSport";
            this.cbNomSport.Size = new System.Drawing.Size(121, 28);
            this.cbNomSport.TabIndex = 11;
            // 
            // btnAfficher
            // 
            this.btnAfficher.BackColor = System.Drawing.Color.Plum;
            this.btnAfficher.FlatAppearance.BorderSize = 3;
            this.btnAfficher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficher.Location = new System.Drawing.Point(35, 222);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(153, 59);
            this.btnAfficher.TabIndex = 12;
            this.btnAfficher.Text = "AFFICHER";
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(131, 41);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(66, 26);
            this.txtID.TabIndex = 13;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(45, 82);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(55, 20);
            this.lblNom.TabIndex = 14;
            this.lblNom.Text = "Nom :";
            this.lblNom.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(45, 117);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(80, 20);
            this.lblPrenom.TabIndex = 15;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRue.Location = new System.Drawing.Point(483, 38);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(128, 20);
            this.lblRue.TabIndex = 16;
            this.lblRue.Text = "Adresse (rue) :";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.Location = new System.Drawing.Point(483, 80);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(126, 20);
            this.lblCP.TabIndex = 17;
            this.lblCP.Text = "Code Postale :";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.Location = new System.Drawing.Point(483, 124);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(58, 20);
            this.lblVille.TabIndex = 18;
            this.lblVille.Text = "Ville : ";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(45, 44);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(38, 20);
            this.lblID.TabIndex = 19;
            this.lblID.Text = "ID :";
            // 
            // lblNiv
            // 
            this.lblNiv.AutoSize = true;
            this.lblNiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiv.Location = new System.Drawing.Point(165, 260);
            this.lblNiv.Name = "lblNiv";
            this.lblNiv.Size = new System.Drawing.Size(179, 20);
            this.lblNiv.TabIndex = 20;
            this.lblNiv.Text = "Niveau d\'expérience :";
            this.lblNiv.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSport
            // 
            this.lblSport.AutoSize = true;
            this.lblSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSport.Location = new System.Drawing.Point(561, 255);
            this.lblSport.Name = "lblSport";
            this.lblSport.Size = new System.Drawing.Size(63, 20);
            this.lblSport.TabIndex = 21;
            this.lblSport.Text = "Sport :";
            // 
            // grpboxInfo
            // 
            this.grpboxInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.grpboxInfo.Controls.Add(this.lblID);
            this.grpboxInfo.Controls.Add(this.lblVille);
            this.grpboxInfo.Controls.Add(this.lblCP);
            this.grpboxInfo.Controls.Add(this.lblRue);
            this.grpboxInfo.Controls.Add(this.lblPrenom);
            this.grpboxInfo.Controls.Add(this.lblNom);
            this.grpboxInfo.Controls.Add(this.txtID);
            this.grpboxInfo.Controls.Add(this.dtpDateNaissance);
            this.grpboxInfo.Controls.Add(this.txtVille);
            this.grpboxInfo.Controls.Add(this.txtCP);
            this.grpboxInfo.Controls.Add(this.txtRue);
            this.grpboxInfo.Controls.Add(this.txtPrenom);
            this.grpboxInfo.Controls.Add(this.txtNom);
            this.grpboxInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpboxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxInfo.Location = new System.Drawing.Point(67, 38);
            this.grpboxInfo.Name = "grpboxInfo";
            this.grpboxInfo.Size = new System.Drawing.Size(906, 208);
            this.grpboxInfo.TabIndex = 22;
            this.grpboxInfo.TabStop = false;
            this.grpboxInfo.Text = "Informations personnelles";
            // 
            // grpboxSportif
            // 
            this.grpboxSportif.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpboxSportif.Controls.Add(this.listViewResult);
            this.grpboxSportif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpboxSportif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxSportif.Location = new System.Drawing.Point(68, 325);
            this.grpboxSportif.Name = "grpboxSportif";
            this.grpboxSportif.Size = new System.Drawing.Size(1129, 348);
            this.grpboxSportif.TabIndex = 23;
            this.grpboxSportif.TabStop = false;
            this.grpboxSportif.Text = "Liste des sportifs";
            // 
            // grpboxActions
            // 
            this.grpboxActions.BackColor = System.Drawing.Color.Gainsboro;
            this.grpboxActions.Controls.Add(this.btnAfficher);
            this.grpboxActions.Controls.Add(this.btnSupprimer);
            this.grpboxActions.Controls.Add(this.btnModifier);
            this.grpboxActions.Controls.Add(this.btnAjouter);
            this.grpboxActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxActions.Location = new System.Drawing.Point(1009, 38);
            this.grpboxActions.Name = "grpboxActions";
            this.grpboxActions.Size = new System.Drawing.Size(214, 291);
            this.grpboxActions.TabIndex = 24;
            this.grpboxActions.TabStop = false;
            this.grpboxActions.Text = "Actions";
            // 
            // FrmGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1235, 673);
            this.Controls.Add(this.grpboxActions);
            this.Controls.Add(this.grpboxSportif);
            this.Controls.Add(this.grpboxInfo);
            this.Controls.Add(this.lblSport);
            this.Controls.Add(this.lblNiv);
            this.Controls.Add(this.cbNomSport);
            this.Controls.Add(this.cbNiveauExp);
            this.Name = "FrmGestion";
            this.Text = "Gestion des sportifs";
            this.Load += new System.EventHandler(this.FrmGestion_Load);
            this.grpboxInfo.ResumeLayout(false);
            this.grpboxInfo.PerformLayout();
            this.grpboxSportif.ResumeLayout(false);
            this.grpboxActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.ComboBox cbNiveauExp;
        private System.Windows.Forms.ComboBox cbNomSport;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNiv;
        private System.Windows.Forms.Label lblSport;
        private System.Windows.Forms.GroupBox grpboxInfo;
        private System.Windows.Forms.GroupBox grpboxSportif;
        private System.Windows.Forms.GroupBox grpboxActions;
    }
}