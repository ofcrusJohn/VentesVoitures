/*
    Programmeur:   Jean De La Croix Haba, Jerry Bostel Dountio Douanla, Ibrahima Elimane Dosso
    Date:           Septembre

    Solution:     VentesVoitures
    Projet:       VentesVoitures.csproj

    Namespace:    {TransactionNS}
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionNS
{
    /// <summary>
    /// Classe métier représentant une transaction de vente de Voiture
    /// </summary>
    public class Transaction
    {
        #region Champs privés

        private int idInt;
        private string nomStr;
        private string prenomStr;
        private string adresseStr;
        private string telephoneStr;
        private string marqueStr;
        private DateTime dateLivraisonDateTime;
        private decimal prixDecimal;

        private string[] tModele;
        private string[] tAnnee;
        private decimal[,] tPrix;
        


        #endregion

        #region initialisation des tableaux
        //Initialisation des tableaux

        private void InitModele()
        {
            tModele = new string[7] { "CX-3", "Altima", "Elantra", "Primera", "Rav4", "Focus", "Civic" };

        }

       
        private void InitAnnee()
        {
            tAnnee = new string[10] { "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025" };
        }
        private void InitPrix()
        {
            tPrix = new decimal[10, 7]
            {
                 // Année : 2016
                { 25000.00M, 27000.00M, 23000.00M, 26000.00M, 32000.00M, 21000.00M, 24000.00M },
                // Année : 2017
                { 26000.00M, 28000.00M, 24000.00M, 27000.00M, 33000.00M, 22000.00M, 25000.00M },
                // Année : 2018
                { 27000.00M, 29000.00M, 25000.00M, 28000.00M, 34000.00M, 23000.00M, 26000.00M },
                // Année : 2019
                { 28000.00M, 30000.00M, 26000.00M, 29000.00M, 35000.00M, 24000.00M, 27000.00M },
                // Année : 2020
                { 30000.00M, 32000.00M, 28000.00M, 31000.00M, 37000.00M, 26000.00M, 29000.00M },
                // Année : 2021
                { 32000.00M, 34000.00M, 30000.00M, 33000.00M, 39000.00M, 28000.00M, 31000.00M },
                // Année : 2022
                { 34000.00M, 36000.00M, 32000.00M, 35000.00M, 41000.00M, 30000.00M, 33000.00M },
                // Année : 2023
                { 36000.00M, 38000.00M, 34000.00M, 37000.00M, 43000.00M, 32000.00M, 35000.00M },
                // Année : 2024
                { 38000.00M, 40000.00M, 36000.00M, 39000.00M, 45000.00M, 34000.00M, 37000.00M },
                // Année : 2025
                { 40000.00M, 42000.00M, 38000.00M, 41000.00M, 47000.00M, 36000.00M, 39000.00M }

            };
        }

        #endregion

        #region Propriétés

        /// <summary>
        /// Obtient l'identifiant unique de la transaction (lecture seule)
        /// </summary>
        public int ID
        {
            get { return idInt; }
        }

        /// <summary>
        /// Obtient ou définit le nom du client
        /// </summary>
        public string Nom
        {
            get { return nomStr; }
            set { nomStr = value; }
        }

        /// <summary>
        /// Obtient ou définit le prénom du client
        /// </summary>
        public string Prenom
        {
            get { return prenomStr; }
            set { prenomStr = value; }
        }

        /// <summary>
        /// Obtient ou définit l'adresse du client
        /// </summary>
        public string Adresse
        {
            get { return adresseStr; }
            set { adresseStr = value; }
        }

        /// <summary>
        /// Obtient ou définit le numéro de téléphone du client
        /// </summary>
        public string Telephone
        {
            get { return telephoneStr; }
            set { telephoneStr = value; }
        }

        /// <summary>
        /// Obtient ou définit la date de livraison prévue
        /// </summary>
        public DateTime DateLivraison
        {
            get { return dateLivraisonDateTime; }
            set { dateLivraisonDateTime = value; }
        }

        /// <summary>
        /// Obtient ou définit le prix total de la transaction
        /// </summary>
        public decimal Prix
        {
            get { return prixDecimal; }
            set { prixDecimal = value; }
        }


        public string[] GetAnnee()
        {
            return tAnnee;
        }

        public string[] GetModel()
        {
            return tModele;
        }

       


        /// <summary>
        /// 
        /// </summary>
        /// <param name="annee">de 2016-2025->0-9</param>
        /// <param name="model">de 0 à 6 comme index </param>
        /// <returns>Prix du modele correspondant à l'année</returns>
        public decimal GetPrix(int annee, int model)
        {
            if (annee < 0 || annee > tAnnee.Length)
            {
                throw new ArgumentOutOfRangeException("l'Index de l'année est erronnée.");
            }

            if (model < 0 || model > tModele.Length)
            {
                throw new ArgumentOutOfRangeException("l'Index du modèle est erronnée.");
            }


            return tPrix[annee, model];

        }

        /// <summary>
        /// retourne le prix selon l'année et le modèle
        /// </summary>
        /// <param name="annee"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public decimal GetPrix(string annee, string model)
        {
            int anneeIndex = Array.IndexOf(tAnnee, annee);
            int modelIndex = Array.IndexOf(tModele, model);

            if (anneeIndex == -1)
            {
                throw new ArgumentException("Année  invalide." + nameof(annee));
            }

            if (modelIndex == -1)
            {
                throw new ArgumentException("Modèle invalide." + nameof(model));
            }
            return tPrix[anneeIndex, modelIndex];
        }
        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Transaction()
        {
            // Génération automatique de l'ID (à améliorer ultérieurement)
            idInt = new Random().Next(1000, 9999);

            InitAnnee();
            InitModele();
            InitPrix();
            
        }

        /// <summary>
        /// Constructeur avec paramètres pour initialiser une transaction complète
        /// </summary>
        /// <param name="nomPrinc">Nom du client</param>
        /// <param name="prenomPrinc">Prénom du client</param>
        /// <param name="adressePrinc">Adresse du client</param>
        /// <param name="telephonePrinc">Téléphone du client</param>
        /// <param name="marquePrinc">Marque des Voiture</param>
        /// <param name="dateLivraisonPrinc">Date de livraison</param>
        /// <param name="prixPrinc">Prix total</param>
        public Transaction(string nomPrinc, string prenomPrinc, string adressePrinc,
                          string telephonePrinc,DateTime dateLivraisonPrinc, decimal prixPrinc)
        {
            // Génération automatique de l'ID
            idInt = new Random().Next(1000, 9999);

            // Initialisation via les propriétés
            Nom = nomPrinc;
            Prenom = prenomPrinc;
            Adresse = adressePrinc;
            Telephone = telephonePrinc;
            DateLivraison = dateLivraisonPrinc;
            Prix = prixPrinc;
        }

        #endregion

        #region Méthodes

        /// <summary>
        /// Enregistre la transaction courante dans le système
        /// </summary>
        public void Enregistrer()
        {
            Console.WriteLine("=== Transaction Enregistrée ===");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Client: {Prenom} {Nom}");
            Console.WriteLine($"Adresse: {Adresse}");
            Console.WriteLine($"Téléphone: {Telephone}");
            Console.WriteLine($"Date de livraison: {DateLivraison:dd/MM/yyyy}");
            Console.WriteLine($"Prix total: {Prix:C}");
            Console.WriteLine("==============================");
        }

        /// <summary>
        /// Enregistre une transaction avec les paramètres fournis
        /// </summary>
        /// <param name="nomPrinc">Nom du client</param>
        /// <param name="prenomPrinc">Prénom du client</param>
        /// <param name="adressePrinc">Adresse du client</param>
        /// <param name="telephonePrinc">Téléphone du client</param>
        /// <param name="marquePrinc">Marque des Voiture</param>
        /// <param name="dateLivraisonPrinc">Date de livraison</param>
        /// <param name="prixPrinc">Prix total</param>
        public void Enregistrer(string nomPrinc, string prenomPrinc, string adressePrinc,
                               string telephonePrinc, string marquePrinc,
                               DateTime dateLivraisonPrinc, decimal prixPrinc)
        {
            // Initialisation via les propriétés
            Nom = nomPrinc;
            Prenom = prenomPrinc;
            Adresse = adressePrinc;
            Telephone = telephonePrinc;
            DateLivraison = dateLivraisonPrinc;
            Prix = prixPrinc;

            // Appel de la méthode Enregistrer sans paramètre
            Enregistrer();
        }

        #endregion
    }
}
