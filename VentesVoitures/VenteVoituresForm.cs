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

                modeleComboBox.Items.AddRange(oTypes.GetTypesModeles(CodesTypes.Modeles));
                
                typeVoitureComboBox.Items.AddRange(oTypes.GetTypesModeles(CodesTypes.Types));

                anneeComboBox.Items.AddRange(otransac.GetAnnee());

                marqueComboBox.Items.AddRange(otransac.GetMarque());

                modeleComboBox.SelectedIndex = 0;
                anneeComboBox.SelectedIndex = 0;
                typeVoitureComboBox.SelectedIndex = 0;
                marqueComboBox.SelectedIndex = 0;

            }
            catch (ArgumentOutOfRangeException es)
            {
                MessageBox.Show(es.ToString());
            }
            catch (Exception ex) {
                MessageBox.Show(g.tMessages[(int)ce.ErreurIndeterminee]);
            }


        }
        #endregion

        #region Obtenir le prix
        private void modeleComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
           VentesVoituresAboutBox about=new VentesVoituresAboutBox();
            about.ShowDialog();
        }
        #endregion


        #region validation des contrôles
        private void ValidationControle()
        {
            ////Validation de tous les contrôles
            //if (string.IsNullOrEmpty(prixTextBox.Text))
            //    MessageBox.Show("Le prix est obligatoire");
            //if (anneeComboBox.SelectedIndex == -1)
            //    MessageBox.Show("l'annee est obligatoire");
               
            //if (modeleComboBox.SelectedIndex == -1)
            //    MessageBox.Show("le modele est obligatoire");
         
            //if (string.IsNullOrEmpty(nomTextBox.Text))
            //    MessageBox.Show("le nom est obligatoire");
          
            //if (string.IsNullOrEmpty(prenomTextBox.Text))
            //    MessageBox.Show("le prenom est obligatoire");
            
            //if (string.IsNullOrEmpty(adresseMaskedTextBox.Text))
            //    MessageBox.Show("l'adresse est obligatoire");
          
            //if (string.IsNullOrEmpty(codePostalMaskedTextBox.Text))
            //    MessageBox.Show("le code postal est obligatoire");
         
            //if (string.IsNullOrEmpty(telephoneMaskedTextBox.Text))
            //    MessageBox.Show("le telephone est obligatoire");
        
            //if (livraisonDateTimePicker.Value.Date < DateTime.Today)
            //    MessageBox.Show("Date de livraison éronné");
        
            //if (typeVoitureComboBox.SelectedIndex == -1)
            //    MessageBox.Show("Type de voirture éronné");
            //if (marqueComboBox.SelectedIndex == -1)
            //    MessageBox.Show("Marque éronnée");
           
        }
        #endregion



        #region Enregistrer Fichier Ibrahima 
        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Try catch de validation 
            try
            {
                ValidationControle();



                //TO DO LIST JERRY 

                //Transmission de données technique 1 
                //Technique 2 : Transmettre donnée (voir pseudo code phase C)
                //Technique 3: Transmettre donnée (voir pseudo code phase C)
            }
            catch (ArgumentException ex)
            {

                MessageBox.Show("Erreur de validation" + ex);
            }
        }

        #endregion

        #region focus maskedTextBox
        private void GestionMaskedTextBox(object sender, EventArgs e)
        {
            //SI mon sender est un masked
            if (sender is MaskedTextBox monMasked)
            {
                //On ajoute le focus
                monMasked.SelectAll();
            }
        }
        #endregion
    }

}
