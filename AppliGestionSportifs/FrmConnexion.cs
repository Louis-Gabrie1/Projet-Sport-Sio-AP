using AppliSportAP;
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
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtMdp.Text))
            {
                MessageBox.Show("Veuillez saisir votre login et votre mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();

                // On compte s'il y a un utilisateur avec ce duo login/mot de passe
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Utilisateur WHERE login = @login AND mdp = @mdp", cnx);
                cmd.Parameters.AddWithValue("@login", txtLogin.Text.Trim());
                cmd.Parameters.AddWithValue("@mdp", txtMdp.Text);

                // ExecuteScalar retourne la première valeur de la requête 
                int nbUtilisateurs = Convert.ToInt32(cmd.ExecuteScalar());

                if (nbUtilisateurs > 0)
                {
                    // Les informations valides ! ouvre application
                    this.Hide(); // Cache fenêtre

                    FrmMenu frmPrincipal = new FrmMenu();
                    frmPrincipal.ShowDialog(); 

                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Login ou mot de passe incorrect.", "Accès refusé", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCreerCompte_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtMdp.Text))
            {
                MessageBox.Show("Veuillez remplir le login et le mot de passe pour créer un compte.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();

                // Vérification de l'unicité du login
                MySqlCommand cmdCheck = new MySqlCommand("SELECT COUNT(*) FROM Utilisateur WHERE login = @login", cnx);
                cmdCheck.Parameters.AddWithValue("@login", txtLogin.Text.Trim());

                int loginExistant = Convert.ToInt32(cmdCheck.ExecuteScalar());

                if (loginExistant > 0)
                {
                    MessageBox.Show("Ce login est déjà utilisé. Veuillez en choisir un autre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // On arrête là si le login existe déjà
                }

                //  Si on arrive ici, le login est validé, on crée le compte
                MySqlCommand cmdInsert = new MySqlCommand("INSERT INTO Utilisateur (login, mdp) VALUES (@login, @mdp)", cnx);
                cmdInsert.Parameters.AddWithValue("@login", txtLogin.Text.Trim());
                cmdInsert.Parameters.AddWithValue("@mdp", txtMdp.Text); 

                cmdInsert.ExecuteNonQuery();

                MessageBox.Show("Compte créé avec succès ! Vous pouvez maintenant vous connecter.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

             
                txtMdp.Clear();
            }
        }

        private void btnChanMDP_Click(object sender, EventArgs e)
        {
            FrmChangeMdp unObjectSport = new FrmChangeMdp();
            unObjectSport.Show();
        }
    }
}
