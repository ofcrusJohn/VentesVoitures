/*
    Programmeur:    Jean De La Croix Haba,Jerry Bostel Dountio Douanla,Ibrahima Elimane Dosso
    Date:           Septembre
  
    Solution:     VentesVoitures
    Projet:       VentesVoitures.csproj

    Namespace:      {typesNs}
  
*/

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
        Marques = 1
    }
    #endregion


    public class Types
    {
        #region Attributs privés

        /// Tableau contenant les types de voitures
        private string[] tTypes;

        /// Tableau contenant les modèles de voitures
        private string[] tMarques;

        #endregion

        #region Constructeur

        /// Constructeur par défaut qui initialise les tableaux de types et modèles
        public Types()
        {
            InitTypes();
            InitMarques();
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
        private void InitMarques()
        {
            tMarques = new string[5] { "Peugeot", "Renault", "Dacia", "Volkswagen", "Citroen" };
        }

        #endregion

        #region Méthodes publiques

        /// Retourne le tableau de types ou de modèles selon le paramètre spécifié
        public string[] GetTypesMarques(CodesTypes type)
        {
            switch (type)
            {
                case CodesTypes.Types:
                    return tTypes;

                case CodesTypes.Marques:
                    return tMarques;

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
