/*
    Programmeur:    Jean De La Croix Haba,Jerry Bostel Dountio Douanla,Ibrahima Elimane Dosso
    Date:           Septembre
  
    Solution:     VentesVoitures
    Projet:       VentesVoitures.csproj

    Namespace:      {typesNs}
    
    BUT: construis la phase h
*/



using System;
using System.Collections.Generic;
using System.IO;
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
            InitMarques();
            InitTypes();

        }

        #endregion

        #region Méthodes d'initialisation

        /// Initialise le tableau des types de voitures
        private void InitTypes()
        {
            try
            {
                string chemin = "..\\..\\Data\\Types.data";
                using (StreamReader sw = new StreamReader(chemin)) // UTF-8 BOM
                {
                    // 1 - lire le nombre de types
                    string ligne = sw.ReadLine();
                    int nombre = int.Parse(ligne);

                    // 2 - créer le tableau à la bonne taille
                    tTypes = new string[nombre];

                    // 3 - Lire chaque type
                    for (int i = 0; i < nombre; i++)
                    {
                        tTypes[i] = sw.ReadLine();
                    }
                }
            }
            catch (FormatException ex)
            {
                throw new FormatException("Erreur dans le fichier des types.", ex);
            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFoundException(
                   "Le fichier des types n'est pas disponible", ex
                );
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur indéterminée. Veuillez contacter la personne ressource.", ex);
            }
        }


        /// Initialise le tableau des modèles de voitures
        private void InitMarques()
        {
            try
            {
                string chemin = "..\\..\\Data\\Modeles.data";
                using (StreamReader sw = new StreamReader(chemin)) // UTF-8 BOM
                {
                    // 1 - lire le nombre de types
                    string ligne = sw.ReadLine();
                    int nombre = int.Parse(ligne);

                    // 2 - créer le tableau à la bonne taille
                    tMarques = new string[nombre];

                    // 3 - Lire chaque type
                    for (int i = 0; i < nombre; i++)
                    {
                        tMarques[i] = sw.ReadLine();
                    }
                }
            }
            catch (FormatException ex)
            {
                throw new FormatException("Erreur dans le fichier des Modeles.", ex);
            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFoundException(
                   "Le fichier des Modeles n'est pas disponible", ex
                );
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur indéterminée. Veuillez contacter la personne ressource.", ex);
            }
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
