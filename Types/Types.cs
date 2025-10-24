using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesNs
{
    #region Énumération CodesTypes
    /// Énumération publique pour identifier le type de données à retourner
    public enum CodesTypes
    {
        Types = 0,
        Modeles = 1
    }
    #endregion


    public class Types
    {
        #region Attributs privés

        /// Tableau contenant les types de voitures
        private string[] tTypes;

        /// Tableau contenant les modèles de voitures
        private string[] tModeles;

        #endregion

        #region Constructeur

        /// Constructeur par défaut qui initialise les tableaux de types et modèles
        public Types()
        {
            InitTypes();
            InitModeles();
        }

        #endregion

        #region Méthodes d'initialisation

        /// Initialise le tableau des types de voitures
        private void InitTypes()
        {
            tTypes = new string[]
            {
                "Berline",
                "VUS",
                "Camionnette",
                "Sport",
                "Luxe",
                "Compacte",
                "Sous-compacte"
            };
        }

        /// Initialise le tableau des modèles de voitures
        private void InitModeles()
        {
            tModeles = new string[]
            {
                "Civic",
                "Accord",
                "CR-V",
                "Pilot",
                "Odyssey",
                "F-150",
                "Silverado",
                "Ram 1500",
                "Corolla",
                "Camry",
                "RAV4",
                "Highlander"
            };
        }

        #endregion

        #region Méthodes publiques

        /// Retourne le tableau de types ou de modèles selon le paramètre spécifié
        public string[] GetTypesModeles(CodesTypes type)
        {
            switch (type)
            {
                case CodesTypes.Types:
                    return tTypes;

                case CodesTypes.Modeles:
                    return tModeles;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type),
                        type,
                        "Le code de type spécifié n'est pas valide. Utilisez CodesTypes.Types ou CodesTypes.Modeles."
                    );
            }
        }

        #endregion
    }
}
