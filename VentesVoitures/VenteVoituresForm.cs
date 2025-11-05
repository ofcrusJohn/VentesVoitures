/*
    Programmeur:   Jean De La Croix Haba, Jerry Bostel Dountio Douanla, Ibrahima Elimane Dosso
    Date:           Septembre

    Solution:     VentesVoitures
    Projet:       VentesVoitures.csproj

    Namespace:    {VentesVoitures}
    
    CORRECTION:   Ajout des assignations manquantes et validation complète
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransactionNS;
using TypesNs;
using ce = VentesVoitures.VentesVoituresGeneraleClass.CodesErreurs;
using g = VentesVoitures.VentesVoituresGeneraleClass;

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

                // Initialiser le DateTimePicker avec la date d'aujourd'hui
                livraisonDateTimePicker.Value = DateTime.Today;

                // Masquer le label de paiement au départ
                paiementDuTitreLabel.Visible = false;
                paiementDuLabel.Visible = false;
            }
            catch (ArgumentOutOfRangeException es)
            {
                MessageBox.Show(es.ToString());
            }
            catch (Exception)
            {
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

        #region Validation des contrôles
        /// <summary>
        /// Valide tous les contrôles du formulaire avant l'enregistrement
        /// Retourne true si tous les champs sont valides, false sinon
        /// </summary>
        private bool ValidationControle()
        {
            // Validation du nom
            if (string.IsNullOrWhiteSpace(nomTextBox.Text))
            {
                MessageBox.Show("Le nom est obligatoire.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nomTextBox.Focus();
                return false;
            }

            // Validation du prénom
            if (string.IsNullOrWhiteSpace(prenomTextBox.Text))
            {
                MessageBox.Show("Le prénom est obligatoire.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prenomTextBox.Focus();
                return false;
            }

            // Validation de l'adresse
            if (string.IsNullOrWhiteSpace(adresseMaskedTextBox.Text))
            {
                MessageBox.Show("L'adresse est obligatoire.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                adresseMaskedTextBox.Focus();
                return false;
            }

            // Validation du code postal
            if (string.IsNullOrWhiteSpace(codePostalMaskedTextBox.Text) ||
                codePostalMaskedTextBox.Text.Contains("_"))
            {
                MessageBox.Show("Le code postal est obligatoire et doit être complet.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                codePostalMaskedTextBox.Focus();
                return false;
            }

            // Validation du téléphone
            if (string.IsNullOrWhiteSpace(telephoneMaskedTextBox.Text) ||
                telephoneMaskedTextBox.Text.Contains("_"))
            {
                MessageBox.Show("Le numéro de téléphone est obligatoire et doit être complet.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                telephoneMaskedTextBox.Focus();
                return false;
            }

            // Validation de la marque
            if (marqueComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("La marque est obligatoire.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                marqueComboBox.Focus();
                return false;
            }

            // Validation du modèle
            if (modeleComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Le modèle est obligatoire.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                modeleComboBox.Focus();
                return false;
            }

            // Validation du type de voiture
            if (typeVoitureComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Le type de voiture est obligatoire.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                typeVoitureComboBox.Focus();
                return false;
            }

            // Validation de l'année
            if (anneeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("L'année est obligatoire.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                anneeComboBox.Focus();
                return false;
            }

            // Validation du prix
            if (string.IsNullOrWhiteSpace(prixTextBox.Text))
            {
                MessageBox.Show("Le prix est obligatoire.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prixTextBox.Focus();
                return false;
            }

            // Validation de la date de livraison
            DateTime dateMin = DateTime.Today.AddDays(-15);
            DateTime dateMax = DateTime.Today.AddDays(15);

            if (livraisonDateTimePicker.Value < dateMin || livraisonDateTimePicker.Value > dateMax)
            {
                MessageBox.Show("La date de livraison doit être dans les 15 jours avant ou après aujourd'hui.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                livraisonDateTimePicker.Focus();
                return false;
            }

            // Tous les champs sont valides
            return true;
        }
        #endregion

        #region Enregistrer Fichier
        private void fcherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Étape 1 : Validation de tous les champs
                if (!ValidationControle())
                {
                    return; // Arrêter si la validation échoue
                }

                // Étape 2 : Récupération et nettoyage des données
                string nom = nomTextBox.Text.Trim();
                string prenom = prenomTextBox.Text.Trim();
                string adresse = adresseMaskedTextBox.Text.Trim();
                string codePostal = codePostalMaskedTextBox.Text.Trim();
                string telephone = telephoneMaskedTextBox.Text.Trim();
                string marque = marqueComboBox.Text.Trim();
                string modele = modeleComboBox.Text.Trim();
                string typeVoiture = typeVoitureComboBox.Text.Trim();
                string annee = anneeComboBox.Text.Trim();

                // Étape 3 : Conversion du prix
                decimal prix = 0;
                string prixTexte = prixTextBox.Text.Trim();
                if (!decimal.TryParse(prixTexte, NumberStyles.Currency, CultureInfo.CurrentCulture, out prix) || prix <= 0)
                {
                    MessageBox.Show("Le prix est invalide ou manquant.",
                                    "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    prixTextBox.Focus();
                    return;
                }

                // Étape 4 : Récupération de la date de livraison
                DateTime dateLivraison = livraisonDateTimePicker.Value;

                // Étape 5 : Création et initialisation de la transaction
                Transaction transactionEnCours = new Transaction();

                // Assignation de toutes les propriétés
                // La validation se fait automatiquement dans les setters
                transactionEnCours.Nom = nom;
                transactionEnCours.Prenom = prenom;
                transactionEnCours.Adresse = adresse;
                transactionEnCours.CodePostal = codePostal;
                transactionEnCours.Telephone = telephone;
                transactionEnCours.Marque = marque;
                transactionEnCours.Modele = modele;
                transactionEnCours.TypeVoiture = typeVoiture;
                transactionEnCours.Annee = annee;
                transactionEnCours.DateLivraison = dateLivraison;
                transactionEnCours.Prix = prix;

                // Étape 6 : Enregistrer la transaction
                transactionEnCours.Enregistrer();

                // Étape 7 : Récupérer et afficher la date de paiement
                DateTime dateDuePaiement = transactionEnCours.DateDuePaiement;
                paiementDuLabel.Text =dateDuePaiement.ToString("D");

                paiementDuLabel.Visible = true;
                paiementDuTitreLabel.Visible=true;

                //afficher dans le label la date de paiement dû


                // Étape 8 : Message de confirmation
                MessageBox.Show("La transaction a été enregistrée avec succès !\n\n" +
                               $"ID Transaction: {transactionEnCours.ID}\n" +
                               $"Client: {prenom} {nom}\n" +
                               $"Véhicule: {marque} {modele} {annee}\n" +
                               $"Prix: {prix:C}\n" +
                               $"Date de paiement: {dateDuePaiement:D}",
                               "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Étape 9 : Réinitialisation du formulaire
                ReinitialiserFormulaire();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Erreur de validation : Un champ obligatoire est manquant.\n" + ex.Message,
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #region Réinitialisation du formulaire
        /// <summary>
        /// Réinitialise tous les contrôles du formulaire à leurs valeurs par défaut
        /// </summary>
        private void ReinitialiserFormulaire()
        {
            // Réinitialiser les TextBox
            nomTextBox.Clear();
            prenomTextBox.Clear();
            adresseMaskedTextBox.Clear();
            codePostalMaskedTextBox.Clear();
            telephoneMaskedTextBox.Clear();
            prixTextBox.Clear();

            // Réinitialiser les ComboBox
            marqueComboBox.SelectedIndex = 0;
            modeleComboBox.SelectedIndex = 0;
            anneeComboBox.SelectedIndex = 0;
            typeVoitureComboBox.SelectedIndex = 0;

            // Réinitialiser le DateTimePicker
            livraisonDateTimePicker.Value = DateTime.Today;

            //// Masquer le label de date de paiement
            //datePaiementLabel.Visible = false;

            // Remettre le focus sur le premier champ
            nomTextBox.Focus();
        }
        #endregion

        #region Focus maskedTextBox
        private void GestionMaskedTextBox(object sender, EventArgs e)
        {
            // Si mon sender est un MaskedTextBox
            if (sender is MaskedTextBox monMasked)
            {
                // On sélectionne tout le contenu
                monMasked.SelectAll();
            }
        }
        #endregion

        #region Validation du DateTimePicker
        private void livraisonDateTimePicker_Validating(object sender, CancelEventArgs e)
        {
            DateTime dateSaisie = livraisonDateTimePicker.Value;
            DateTime dateMin = DateTime.Today.AddDays(-15);
            DateTime dateMax = DateTime.Today.AddDays(15);

            if (dateSaisie >= dateMin && dateSaisie <= dateMax)
            {
                // Date valide - afficher au format Long
                livraisonDateTimePicker.Format = DateTimePickerFormat.Long;
            }
            else
            {
                // Date invalide - réinitialiser à aujourd'hui
                livraisonDateTimePicker.Value = DateTime.Today;
                livraisonDateTimePicker.Format = DateTimePickerFormat.Long;
                MessageBox.Show("Erreur s'est produit pendant l'enregistrement.Communiquer avec la personne ressource."+
                    "La date doitse situer dans les 15 jours avant ou après la date d'aujourd'hui.",
                    "Date invalide",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                e.Cancel = true; // Annule la validation pour garder le focus
            }
        }
        #endregion

      
    }
}