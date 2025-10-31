/*
    Programmeur:   Jean De La Croix Haba, Jerry Bostel Dountio Douanla, Ibrahima Elimane Dosso
    Date:           Septembre

    Solution:     VentesVoitures
    Projet:       VentesVoitures.csproj

    Namespace:    {VentesVoitures}
*/




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransactionNS;
using TypesNs;
using g = VentesVoitures.VentesVoituresGeneraleClass;
using ce = VentesVoitures.VentesVoituresGeneraleClass.CodesErreurs;

namespace VentesVoitures
{
    public partial class VenteVoituresForm : Form
    {


        #region Declaration
        private Transaction otransac;
        private Types oTypes;
        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur
        /// </summary>
        ///
        public VenteVoituresForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Initialisation
        private void VenteVoituresForm_Load(object sender, EventArgs e)
        {
            try
            {
                g.InitMessagesErrreurs();

                otransac = new Transaction();
                oTypes = new Types();

                modeleComboBox.Items.AddRange(otransac.GetModel());
                
                typeVoitureComboBox.Items.AddRange(oTypes.GetTypesMarques(CodesTypes.Types));

                anneeComboBox.Items.AddRange(otransac.GetAnnee());

                marqueComboBox.Items.AddRange(oTypes.GetTypesMarques(CodesTypes.Marques));

                modeleComboBox.SelectedIndex = 0;
                anneeComboBox.SelectedIndex = 0;
                typeVoitureComboBox.SelectedIndex = 0;
                marqueComboBox.SelectedIndex = 0;

            }
            catch (ArgumentOutOfRangeException es)
            {
                MessageBox.Show(es.ToString());
            }
            catch (Exception) {
                MessageBox.Show(g.tMessages[(int)ce.ErreurIndeterminee]);
            }


        }
        #endregion

        #region Obtenir le prix
        private void ModeleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (modeleComboBox.SelectedIndex != -1 && anneeComboBox.SelectedIndex != -1)
                {
                    prixTextBox.Text = otransac.GetPrix(anneeComboBox.SelectedIndex, modeleComboBox.SelectedIndex).ToString("C2");
                }
            }

            catch (ArgumentOutOfRangeException er)
            {
                MessageBox.Show(er.ToString());
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show(g.tMessages[(int)ce.ErreurPrix]);

            }

        }
        #endregion

        #region Fermer le formulaire
        private void Quitter_click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Menu Aide
        private void AProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentesVoituresAboutBox about = new VentesVoituresAboutBox();
            about.ShowDialog();
        }
        #endregion

        #region validation des contrôles
        private void ValidationControle()
        {
        //    //Validation de tous les contrôles
        //    if (string.IsNullOrEmpty(prixTextBox.Text))
        //        MessageBox.Show("Le prix est obligatoire");
        //    if (anneeComboBox.SelectedIndex == -1)
        //        MessageBox.Show("l'annee est obligatoire");
               
        //    if (modeleComboBox.SelectedIndex == -1)
        //        MessageBox.Show("le modele est obligatoire");
         
        //    if (string.IsNullOrEmpty(nomTextBox.Text))
        //        MessageBox.Show("le nom est obligatoire");
          
        //    if (string.IsNullOrEmpty(prenomTextBox.Text))
        //        MessageBox.Show("le prenom est obligatoire");
            
        //    if (string.IsNullOrEmpty(adresseMaskedTextBox.Text))
        //        MessageBox.Show("l'adresse est obligatoire");
          
        //    if (string.IsNullOrEmpty(codePostalMaskedTextBox.Text))
        //        MessageBox.Show("le code postal est obligatoire");
         
        //    if (string.IsNullOrEmpty(telephoneMaskedTextBox.Text))
        //        MessageBox.Show("le telephone est obligatoire");
        
        //    if (livraisonDateTimePicker.Value.Date < DateTime.Today)
        //        MessageBox.Show("Date de livraison éronné");
        
        //    if (typeVoitureComboBox.SelectedIndex == -1)
        //        MessageBox.Show("Type de voirture éronné");
        //    if (marqueComboBox.SelectedIndex == -1)
        //        MessageBox.Show("Marque éronnée");
           
        }
        #endregion

        #region Enregistrer Fichier Ibrahima 

        private void EnregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Étape 1 : Validation des champs
                ValidationControle();

                // Étape 2 : Récupération et nettoyage des données
                string nom = nomTextBox.Text.Trim();
                string prenom = prenomTextBox.Text.Trim();
                string adresse = adresseMaskedTextBox.Text.Trim();
                string telephone = telephoneMaskedTextBox.Text.Trim();
                string marque = marqueComboBox.Text.Trim();
                string modele = modeleComboBox.Text.Trim();
                string typeVoiture = typeVoitureComboBox.Text.Trim();

                // Étape 4 : Conversion du prix
                decimal prix = 0;
                string prixTexte = prixTextBox.Text.Replace("C$", "").Replace("$", "").Trim();
                if (!decimal.TryParse(prixTexte, out prix) || prix <= 0)
                {
                    MessageBox.Show("Le prix est invalide ou manquant.",
                                    "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Étape 5 : Récupération de la date de livraison
                DateTime dateLivraison = livraisonDateTimePicker.Value;
                if (dateLivraison < DateTime.Today)
                {
                    MessageBox.Show("La date de livraison ne peut pas être antérieure à aujourd'hui.",
                                    "Erreur de date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ============= Version 1 =============
                // Étape 6 : Création et enregistrement de la transaction
                Transaction oTransaction = new Transaction(
                    nom,
                    prenom,
                    adresse,
                    telephone,
                    dateLivraison,
                    prix
                );

                // Appel de la méthode Enregistrer()
                oTransaction.Enregistrer();


                // ============= Version 2 =============
                // Création de l'objet Transaction avec tous les paramètres
                Transaction oTrans1 = new Transaction(nom, prenom, adresse, telephone, dateLivraison, prix);

                // Appel de la méthode Enregistrer sans paramètre
                oTrans1.Enregistrer();


                // ============= Version 3 =============
                // Création d'un objet Transaction vide
                Transaction oTrans2 = new Transaction();

                // Affectation des valeurs via les propriétés
                oTrans2.Nom = nom;
                oTrans2.Prenom = prenom;
                oTrans2.Adresse = adresse;
                oTrans2.Telephone = telephone;
                oTrans2.DateLivraison = dateLivraison;
                oTrans2.Prix = prix;

                // Appel de la méthode Enregistrer sans paramètre
                oTrans2.Enregistrer();

                // Étape 7 : Message de confirmation
                MessageBox.Show("La transaction a été enregistrée avec succès !",
                                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Étape 8 : Réinitialisation du formulaire
                nomTextBox.Clear();
                prenomTextBox.Clear();
                adresseMaskedTextBox.Clear();
                telephoneMaskedTextBox.Clear();
                prixTextBox.Clear();
                marqueComboBox.SelectedIndex = 0;
                modeleComboBox.SelectedIndex = 0;
                anneeComboBox.SelectedIndex = 0;
                typeVoitureComboBox.SelectedIndex = 0;
                livraisonDateTimePicker.Value = DateTime.Today;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Erreur de validation : " + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Erreur de format : " + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur inattendue est survenue : " + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Focus maskedTextBox
        private void GestionMaskedTextBox(object sender, EventArgs e)
        {
            //Si mon sender est un masked
            if (sender is MaskedTextBox monMasked)
            {
                //On ajoute le focus
                monMasked.SelectAll();
            }
        }


        #endregion

       
    }

}
