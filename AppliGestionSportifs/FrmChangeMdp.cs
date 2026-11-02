using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliGestionSportifs
{
    public partial class FrmChangeMdp : Form
    {
        public FrmChangeMdp()
        {
            InitializeComponent();
        }

        private void btnValiderChangement_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) ||
        string.IsNullOrWhiteSpace(txtAncienMdp.Text) || //si rien saisie
        string.IsNullOrWhiteSpace(txtNouveauMdp.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //  Vérifier que l'utilisateur ne s'est pas trompé en tapant le nouveau mot de passe
            if (txtNouveauMdp.Text != txtConfirmMdp.Text)
            {
                MessageBox.Show("Les nouveaux mots de passe ne correspondent pas !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();

                // Vérifier si l'ancien mot de passe est correct dans la base
                MySqlCommand cmdCheck = new MySqlCommand("SELECT COUNT(*) FROM Utilisateur WHERE login = @login AND mdp = @ancienMdp", cnx);
                cmdCheck.Parameters.AddWithValue("@login", txtLogin.Text.Trim());
                cmdCheck.Parameters.AddWithValue("@ancienMdp", txtAncienMdp.Text);

                int utilisateurValide = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (utilisateurValide > 0)
                {
                    //  L'utilisateur est reconnu, on met à jour le mot de passe
                    MySqlCommand cmdUpdate = new MySqlCommand("UPDATE Utilisateur SET mdp = @nouveauMdp WHERE login = @login", cnx);
                    cmdUpdate.Parameters.AddWithValue("@login", txtLogin.Text.Trim());
                    cmdUpdate.Parameters.AddWithValue("@nouveauMdp", txtNouveauMdp.Text); // Le nouveau mot de passe

                    cmdUpdate.ExecuteNonQuery();

                    MessageBox.Show("Votre mot de passe a été modifié avec succès ! Vous pouvez maintenant vous connecter.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close(); // fermeture fenêtre
                }
                else
                {
                    MessageBox.Show("Login ou ancien mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
