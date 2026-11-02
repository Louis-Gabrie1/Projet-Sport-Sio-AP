using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliGestionSportifs
{
    public partial class FrmGestion : Form
    {
        private int idSportifActuel = -1;
        public FrmGestion()
        {
            InitializeComponent();
        }

        private void FrmGestion_Load(object sender, EventArgs e)
        {
            cbNiveauExp.Items.Add("Débutant");
            cbNiveauExp.Items.Add("Confirmé");
            cbNiveauExp.Items.Add("Avancé");
            cbNiveauExp.Items.Add("Professionnel");

            // Remplir les sports imposés
            cbNomSport.Items.Add("Football");
            cbNomSport.Items.Add("Tennis");
            cbNomSport.Items.Add("Judo");
            cbNomSport.Items.Add("Natation");
            cbNomSport.Items.Add("Basketball");
            cbNomSport.Items.Add("Rugby");
            cbNomSport.Items.Add("Course");

            listViewResult.View = View.Details;
            listViewResult.GridLines = true;
            listViewResult.FullRowSelect = true;

            // Ajout des colonnes correspondant à la table bdSport
            listViewResult.Columns.Add("ID", 50);
            listViewResult.Columns.Add("Nom", 150);
            listViewResult.Columns.Add("Prénom", 150);
            listViewResult.Columns.Add("Ville", 150);
            listViewResult.Columns.Add("Niveau", 150);
            listViewResult.Columns.Add("Sport", 150);

            // Charger la liste des sportifs au démarrage
            //ActualiserListe();
        }

        private void ActualiserListe()
        {
            // On vide la ListView actuelle
            listViewResult.Items.Clear();

            // On se connecte à la base de données
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Sportif", cnx);

                // On lit les données et on remplit la liste
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        ListViewItem item = new ListViewItem(rdr["id"].ToString());
                        item.SubItems.Add(rdr["nom"].ToString());
                        item.SubItems.Add(rdr["pren"].ToString());
                        item.SubItems.Add(rdr["ville"].ToString());
                        item.SubItems.Add(rdr["nivExp"].ToString());
                        item.SubItems.Add(rdr["nomSport"].ToString());

                        listViewResult.Items.Add(item);
                    }
                }
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;

                // Requête d'insertion
                cmd.CommandText = "INSERT INTO Sportif (nom, pren, dateNais, rue, cp, ville, nivExp, nomSport) " +
                                  "VALUES (@nom, @pren, @dateNais, @rue, @cp, @ville, @nivExp, @nomSport)";

                // Récupération des valeurs depuis les composants
                cmd.Parameters.AddWithValue("@nom", txtNom.Text.Trim());
                cmd.Parameters.AddWithValue("@pren", txtPrenom.Text.Trim());
                cmd.Parameters.AddWithValue("@dateNais", dtpDateNaissance.Value.ToString("yyyy-MM-dd")); // DateTimePicker
                cmd.Parameters.AddWithValue("@rue", txtRue.Text.Trim());
                cmd.Parameters.AddWithValue("@cp", txtCP.Text.Trim());
                cmd.Parameters.AddWithValue("@ville", txtVille.Text.Trim());
                cmd.Parameters.AddWithValue("@nivExp", cbNiveauExp.Text); // ComboBox
                cmd.Parameters.AddWithValue("@nomSport", cbNomSport.Text); // ComboBox

                cmd.ExecuteNonQuery();
                MessageBox.Show("Sportif ajouté avec succès !");

                
                ActualiserListe();

            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (idSportifActuel == -1)
            {
                MessageBox.Show("Veuillez sélectionner un sportif à modifier.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cnx;

                // Requête de mise à jour correspondant aux colonnes de la base de données
                cmd.CommandText = "UPDATE Sportif SET nom = @nom, pren = @pren, dateNais = @dateNais, " +
                                  "rue = @rue, cp = @cp, ville = @ville, nivExp = @nivExp, nomSport = @nomSport " +
                                  "WHERE id = @id";

                // Récupération des valeurs depuis les composants
                cmd.Parameters.AddWithValue("@nom", txtNom.Text.Trim());
                cmd.Parameters.AddWithValue("@pren", txtPrenom.Text.Trim());
                cmd.Parameters.AddWithValue("@dateNais", dtpDateNaissance.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@rue", txtRue.Text.Trim());
                cmd.Parameters.AddWithValue("@cp", txtCP.Text.Trim());
                cmd.Parameters.AddWithValue("@ville", txtVille.Text.Trim());
                cmd.Parameters.AddWithValue("@nivExp", cbNiveauExp.Text);
                cmd.Parameters.AddWithValue("@nomSport", cbNomSport.Text);

                // l'ID pour cibler la bonne ligne
                cmd.Parameters.AddWithValue("@id", idSportifActuel);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Le sportif a été modifié avec succès !");

               
                ActualiserListe();

               
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Veuillez saisir l'ID du sportif à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Afficher la boîte de dialogue
            DialogResult reponse = MessageBox.Show(
                "Êtes-vous sûr de vouloir supprimer définitivement le sportif portant l'ID " + txtID.Text + " ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            // Si l'utilisateur clique sur "Oui", on exécute la requête
            if (reponse == DialogResult.Yes)
            {
                string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
                using (MySqlConnection cnx = new MySqlConnection(chaine))
                {
                    cnx.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = cnx;

                    // Requête DELETE utilisant l'ID saisi dans la TextBox
                    cmd.CommandText = "DELETE FROM Sportif WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", txtID.Text.Trim());

                    // ExecuteNonQuery retourne le nombre de lignes supprimées
                    int lignesSupprimees = cmd.ExecuteNonQuery();

                    // On vérifie si un sportif a bien été supprimé
                    if (lignesSupprimees > 0)
                    {
                        MessageBox.Show("Le sportif a été supprimé avec succès !");
                        txtID.Clear(); // nettoyage

                        // MAJ
                        ActualiserListe();
                    }
                    else
                    {
                        MessageBox.Show("Aucun sportif trouvé avec cet ID.");
                    }
                }
            }
        }

        private void listViewResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewResult.SelectedItems.Count > 0)
            {
                // On récupère l'ID et on le stocke dans la variable
                idSportifActuel = Convert.ToInt32(listViewResult.SelectedItems[0].Text);

                // Remplissage automatique des cases de l'onglet Gestion pour faciliter la modification
                txtNom.Text = listViewResult.SelectedItems[0].SubItems[1].Text;
                txtPrenom.Text = listViewResult.SelectedItems[0].SubItems[2].Text;
                txtVille.Text = listViewResult.SelectedItems[0].SubItems[3].Text;
                cbNiveauExp.Text = listViewResult.SelectedItems[0].SubItems[4].Text;
                cbNomSport.Text = listViewResult.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            listViewResult.View = View.Details;
            listViewResult.GridLines = true; // visual quadrillage
            listViewResult.FullRowSelect = true; // selectionne la ligne

            // CRÉER LES COLONNES 
            if (listViewResult.Columns.Count == 0)
            {
                listViewResult.Columns.Add("ID", 30);
                listViewResult.Columns.Add("Nom", 100);
                listViewResult.Columns.Add("Prénom", 100);
                listViewResult.Columns.Add("Ville", 100);
                listViewResult.Columns.Add("Niveau", 100);
                listViewResult.Columns.Add("Sport", 100);
            }

            
            listViewResult.Items.Clear();

            string chaine = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            using (MySqlConnection cnx = new MySqlConnection(chaine))
            {
                cnx.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Sportif", cnx);

                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        // On crée une ligne en commençant par l'ID
                        ListViewItem item = new ListViewItem(rdr["id"].ToString());

                        // On ajoute les autres colonnes de la table à cette ligne
                        item.SubItems.Add(rdr["nom"].ToString());
                        item.SubItems.Add(rdr["pren"].ToString());
                        item.SubItems.Add(rdr["ville"].ToString());
                        item.SubItems.Add(rdr["nivExp"].ToString());
                        item.SubItems.Add(rdr["nomSport"].ToString());

                        // On ajoute la ligne terminée dans ton composant
                        listViewResult.Items.Add(item);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }
    }
    }



