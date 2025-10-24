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

                modeleComboBox.SelectedIndex = 0;
                anneeComboBox.SelectedIndex = 0;
                typeVoitureComboBox.SelectedIndex = 0;

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
    }

}
