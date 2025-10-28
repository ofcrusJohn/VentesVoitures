using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionNS
{
    public class Transaction
    {
        #region Déeclation des tableaux

        private string[] tModele;
        private string[] tAnnee;
        private decimal[,] tPrix;


        #endregion

        #region initialisation des tableaux
        //Initialisation des tableaux

        private void InitModele()
        {
            tModele = new string[7] { "CX-3", "Altima", "Elantra", "Primera", "Rav4", "Focus","Civic" };

        }
        private void InitAnnee()
        {
            tAnnee = new string[10] { "2016", "2017","2018","2019","2020","2021","2022","2023","2024","2025" };
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

        #region Constructeur du le .dll

        /// <summary>
        /// Constructor par défaut:
        /// </summary>
        public Transaction()
        {
            InitAnnee();
            InitModele();
            InitPrix();
        }
        #endregion

        #region Getters
        public string[] GetAnnee()
        {
            return tAnnee;
        }

        public string[] GetModel()
        {
            return tModele;
        }

        //Surcharge GetPrix
        /// <summary>
        /// 
        /// </summary>
        /// <param name="annee">de 2016-2025->0-9</param>
        /// <param name="model">de 0 à 6 comme index </param>
        /// <returns>Prix du modele correspondant à l'année</returns>
       #region Surcharge GetPrix
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


        #endregion
        //Surcharge
       

        #region champs privés
        private int id;
        private string client;
        private decimal montant;
        private string modele;
        private int annee;
        private DateTime dateLivraison;
        #endregion

        #region Getters et setters
        public int Id
        {
            get { return id; }

        }
        public decimal Montant
        {
            get { return montant; }
            set { montant = value; }
        }
        public string Client
        {
            get { return client; }
            set { client = value; }
        }
        public string Modele
        {
            get { return modele; }
            set { modele = value; }
        }
        public int Annee
        {
            get { return annee; }
            set { annee = value; }
        }
        public DateTime DateLivraison
        {
            get { return dateLivraison; }
            set { dateLivraison = value; }
        }
        #endregion

        #region constructeur du champ privé
        public Transaction(int id, string client, decimal montant, int annee, string modele, DateTime livraisonDate)
        {
            this.id = id;
            Client = client;
            Montant = montant;
            Annee = annee;
            Modele = modele;
            DateLivraison = livraisonDate;
        }
        #endregion
        public void Enregistrer(int id, string client, decimal montant, int annee, string modele, DateTime livraisonDate)
        {
            this.id = id;
            Client = client;
            Montant = montant;
            Annee = annee;
            Modele = modele;
            DateLivraison = livraisonDate;


            Enregistrer();

        }
        public void Enregistrer()
        {
            Console.WriteLine(Client, Id, Montant, Modele, annee);
        }

    }
}
