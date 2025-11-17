using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ce = VentesVoitures.VentesVoituresGeneraleClass.CodesErreurs;

namespace VentesVoitures
{
    /// <summary>
    /// Classe générale contenant les messages d'erreurs 
    /// </summary>
    internal class VentesVoituresGeneraleClass
    {
        #region Enumeration

        public enum CodesErreurs
        {
            ErreurAnnee,
            ErreurModele,
            ErreurPrix,
            ErreurIndeterminee,
        }

        #endregion

        #region Déclaration

        public static string[] tMessages;

        #endregion


        #region Initialisation 

      public static void InitMessagesErrreurs()
        {
            tMessages = new string[4];

            tMessages[(int)ce.ErreurAnnee] = "Erreur relié à l'année de la voiture";
            tMessages[(int)ce.ErreurModele] = "Erreur relié au Modele";
            tMessages[(int)ce.ErreurPrix] = "Erreur relié au Prix";
            tMessages[(int)ce.ErreurIndeterminee] = "Erreur Inderterminé ....";
        }
        #endregion
    }
}
