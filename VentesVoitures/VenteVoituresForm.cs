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
        Transaction otransac;
        Types oTypes;
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

                modeleComboBox.Items.AddRange(otransac.GetModel());
                modeleComboBox.SelectedIndex = 0;

                anneeComboBox.Items.AddRange(otransac.GetAnnee());
                anneeComboBox.SelectedIndex = 0;

                oTypes = new Types();
                string[] types = oTypes.GetTypesModeles(CodesTypes.Types);
                string[] modeles = oTypes.GetTypesModeles(CodesTypes.Modeles);


            }
            catch (Exception ex) {
                MessageBox.Show(g.tMessages[3]);
            }


        }
        #endregion

        #region Obtenir le prix
        private void modeleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                if (modeleComboBox.SelectedIndex != -1 && anneeComboBox.SelectedIndex != -1)
                {
                    prixTextBox.Text = otransac.GetPrix(anneeComboBox.SelectedIndex, modeleComboBox.SelectedIndex).ToString("C2");
                }
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
    }

}
