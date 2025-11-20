/*
    Programmeur:   Jean De La Croix Haba, Jerry Bostel Dountio Douanla, Ibrahima Elimane Dosso
    Date:           Novembre 2025

    Solution:     VentesVoitures
    Projet:       VentesVoitures.csproj

    Namespace:    {TransactionNS}
    
    Phase D:      Validation des propriétés et gestion des dates
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Globalization;


namespace TransactionNS
{
    /// <summary>
    /// Classe métier représentant une transaction de vente de Voiture
    /// </summary>
    public class Transaction
    {
        #region variables statiques pour tenir compte des numeros de transaction : Phase E  
        public static int NombreTransactions = 0;
        public const string DELIMITEUR = ";";
        private CultureInfo cultureInfoENCA = new CultureInfo("en-CA");
        #endregion

        #region Champs privés pour les dates
        private DateTime dateLivraisonDateTime;
        private DateTime datePaiementDateTime;
        #endregion

        #region Declatation des regex : Phase E 

        // Regex pour valider le code postal canadien (format A1A 1A1 ou A1A1A1)
        private const string REGEX_CODE_POSTAL = "^[A-Za-z]\\d[A-Za-z]\\s?\\d[A-Za-z]\\d$";
        // Regex pour valider le numéro de téléphone canadien 123-456-7890 
        private const string REGEX_TELEPHONE = @"^\(\d{3}\)-\d{3}-\d{4}$";

        #endregion

        #region Énumération des codes d'erreurs
        private enum CodesErreurs
        {
            NomObligatoire,
            PrenomObligatoire,
            AdresseObligatoire,
            CodePostalObligatoire,
            TelephoneObligatoire,
            MarqueObligatoire,
            ModeleObligatoire,
            ModeleInvalide,
            TypeVoitureObligatoire,
            AnneeObligatoire,
            AnneeInvalide,
            PrixInvalide,
            PrixNeCorrespondPas,
            DateLivraisonInvalide,
            ErreurIndeterminee
        }
        #endregion

        #region Tableau des messages d'erreurs
        private string[] tMessagesErreurs;

        /// <summary>
        /// Initialise les messages d'erreurs correspondant aux codes d'erreurs
        /// </summary>
        private void InitMessagesErreurs()
        {
            tMessagesErreurs = new string[Enum.GetValues(typeof(CodesErreurs)).Length];

            tMessagesErreurs[(int)CodesErreurs.NomObligatoire] = "Le nom est obligatoire.";
            tMessagesErreurs[(int)CodesErreurs.PrenomObligatoire] = "Le prénom est obligatoire.";
            tMessagesErreurs[(int)CodesErreurs.AdresseObligatoire] = "L'adresse est obligatoire.";
            tMessagesErreurs[(int)CodesErreurs.CodePostalObligatoire] = "Le code postal est obligatoire.";
            tMessagesErreurs[(int)CodesErreurs.TelephoneObligatoire] = "Le numéro de téléphone est obligatoire.";
            tMessagesErreurs[(int)CodesErreurs.MarqueObligatoire] = "La marque est obligatoire.";
            tMessagesErreurs[(int)CodesErreurs.ModeleObligatoire] = "Le modèle est obligatoire.";
            tMessagesErreurs[(int)CodesErreurs.ModeleInvalide] = "Le modèle spécifié n'est pas valide.";
            tMessagesErreurs[(int)CodesErreurs.TypeVoitureObligatoire] = "Le type de voiture est obligatoire.";
            tMessagesErreurs[(int)CodesErreurs.AnneeObligatoire] = "L'année est obligatoire.";
            tMessagesErreurs[(int)CodesErreurs.AnneeInvalide] = "L'année spécifiée n'est pas valide.";
            tMessagesErreurs[(int)CodesErreurs.PrixInvalide] = "Le prix doit être un nombre positif supérieur à zéro.";
            tMessagesErreurs[(int)CodesErreurs.PrixNeCorrespondPas] = "Le prix ne correspond pas au modèle et à l'année sélectionnés.";
            tMessagesErreurs[(int)CodesErreurs.DateLivraisonInvalide] = "La date de livraison doit se situer dans les 15 jours précédant ou suivant la date d'aujourd'hui.";
            tMessagesErreurs[(int)CodesErreurs.ErreurIndeterminee] = "Une erreur indéterminée s'est produite.";
        }
        #endregion

        #region Champs privés
        private long idInt;
        private string nomStr;
        private string prenomStr;
        private string adresseStr;
        private string codePostalStr;
        private string telephoneStr;
        private string marqueStr;          // Marque réelle: Honda, Toyota, Nissan, etc.
        private string modeleStr;          // Modèle: CX-3, Altima, Civic, etc.
        private string typeVoitureStr;     // Type: Berline, SUV, etc.
        private string anneeStr;
        private decimal prixDecimal;

        private string[] tModele;
        private string[] tAnnee;
        private decimal[,] tPrix;
        #endregion

        #region Initialisation des tableaux
        /// <summary>
        /// Initialise le tableau des modèles disponibles
        /// </summary>
        private void InitModele()
        {
            try
            {
                string chemin = "..\\..\\Data\\Modeles.data";
                using (StreamReader reader = new StreamReader(chemin))
                { 
                 string ligne=reader.ReadLine();
                    int nombre=int.Parse(ligne);
                    tModele= new string[nombre];
                    for(int i=0; i<nombre; i++)
                    {
                        tModele[i] = reader.ReadLine();
                    }
                }
            }
            catch (FormatException ex)
            {
                throw new FormatException("Erreur dans le fichier Modele", ex);
            }
            catch (FileNotFoundException ex)
            { throw new FileNotFoundException("Le fichier Modele n'est pas disponible", ex); }
            catch (Exception ex)
            {
                throw new Exception("Erreur inderterminée",ex);
            }
        }

        /// <summary>
        /// Initialise le tableau des années disponibles
        /// </summary>
        private void InitAnnee()
        {
            try
            {
                string chemin = "..\\..\\Data\\Annee.data";
                using (StreamReader reader = new StreamReader(chemin))
                {
                    string ligne = reader.ReadLine();
                    int nombre = int.Parse(ligne);
                    tAnnee = new string[nombre];
                    for (int i = 0; i < nombre; i++)
                    {
                        tAnnee[i] = reader.ReadLine();
                    }
                }


            }
            catch (FormatException ex)
            {
                throw new FormatException("Erreur dans le fichier Annee", ex);
            }
            catch (FileNotFoundException ex)
            { throw new FileNotFoundException("Le fichier Annee n'est pas disponible", ex); }
            catch (Exception ex)
            {
                throw new Exception("Erreur inderterminée", ex);
            }
        }

        /// <summary>
        /// Initialise la matrice des prix selon les modèles et années
        /// </summary>
        private void InitPrix()
        {
            try
            {
                string chemin = "..\\..\\Data\\Prix.data";
                CultureInfo culture = CultureInfo.GetCultureInfo("en_CA");
                int nbModele = tModele.Length;
                int nbAnnee = tAnnee.Length;
                tPrix = new decimal[nbAnnee, nbModele];
                using(StreamReader reader = new StreamReader(chemin))
                {
                    for(int i = 0;i < nbAnnee; i++)
                    {
                        for( int j = 0;j < nbModele; j++)
                        {
                            string line = reader.ReadLine();
                            if(line == null)
                            {
                                throw new Exception("Le fichier des prix ne contient pas assez de ligne");
                            }
                            tPrix[i,j]=decimal.Parse(line,culture);
        
                        }     
                    }
                }

            }
            catch (FormatException ex)
            {
                throw new FormatException("Erreur dans le fichier Prix", ex);
            }
            catch (FileNotFoundException ex)
            { throw new FileNotFoundException("Le fichier Prix n'est pas disponible", ex); }
            catch (Exception ex)
            {
                throw new Exception("Erreur inderterminée", ex);
            }
        }
        #endregion

        #region Propriétés avec validation : Ajout Phase E

        /// <summary>
        /// Obtient l'identifiant unique de la transaction (lecture seule)
        /// </summary>
        public long ID
        {
            get { return idInt; }
            
        }

        /// <summary>
        /// Obtient ou définit le nom du client (obligatoire, non vide)
        /// </summary>
        public string Nom
        {
            get
            {
                return nomStr;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value != String.Empty)
                    {
                        nomStr = value;
                    }
                    else
                    {
                        throw new ArgumentException(tMessagesErreurs[(int)CodesErreurs.NomObligatoire]);
                    }
                }
                else
                {
                    throw new ArgumentNullException(tMessagesErreurs[(int)CodesErreurs.NomObligatoire]);
                }
            }
        }

        /// <summary>
        /// Obtient ou définit le prénom du client (obligatoire, non vide)
        /// </summary>
        public string Prenom
        {
            get
            {
                return prenomStr;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value != String.Empty)
                    {
                        prenomStr = value;
                    }
                    else
                    {
                        throw new ArgumentException(tMessagesErreurs[(int)CodesErreurs.PrenomObligatoire]);
                    }
                }
                else
                {
                    throw new ArgumentNullException(tMessagesErreurs[(int)CodesErreurs.PrenomObligatoire]);
                }
            }
        }

        /// <summary>
        /// Obtient ou définit l'adresse du client (obligatoire, non vide)
        /// </summary>
        public string Adresse
        {
            get
            {
                return adresseStr;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value != String.Empty)
                    {
                        adresseStr = value;
                    }
                    else
                    {
                        throw new ArgumentException(tMessagesErreurs[(int)CodesErreurs.AdresseObligatoire]);
                    }
                }
                else
                {
                    throw new ArgumentNullException(tMessagesErreurs[(int)CodesErreurs.AdresseObligatoire]);
                }
            }
        }

        /// <summary>
        /// Obtient ou définit le code postal du client (obligatoire, non vide)
        /// </summary>
        public string CodePostal
        {
            get
            {
                return codePostalStr;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value != String.Empty)
                    {
                        codePostalStr = value;
                    }
                    else
                    {
                        throw new ArgumentException(tMessagesErreurs[(int)CodesErreurs.CodePostalObligatoire]);
                    }
                }
                else
                {
                    throw new ArgumentNullException(tMessagesErreurs[(int)CodesErreurs.CodePostalObligatoire]);
                }

                // Validation du format du code postal canadien

                #region Validation sans regex : Phase E
                if (!Regex.IsMatch(value, REGEX_CODE_POSTAL))
                {
                    throw new ArgumentException("Le format du code postal est invalide. Il doit être au format A1A 1A1 ou A1A1A1.");
                }
                #endregion
                codePostalStr = value;
            }
        }

        /// <summary>
        /// Obtient ou définit le numéro de téléphone du client (obligatoire, non vide)
        /// </summary>
        public string Telephone
        {
            get
            {
                return telephoneStr;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value != String.Empty)
                    {
                        telephoneStr = value;
                    }
                    else
                    {
                        throw new ArgumentException(tMessagesErreurs[(int)CodesErreurs.TelephoneObligatoire]);
                    }
                }
                else
                {
                    throw new ArgumentNullException(tMessagesErreurs[(int)CodesErreurs.TelephoneObligatoire]);
                }

                // Validation du format du numéro de téléphone canadien

                #region REGEX TELEPHONE : Phase E
                if (!Regex.IsMatch(value, REGEX_TELEPHONE))
                {
                    throw new ArgumentException("Le format du numéro de téléphone est invalide. Il doit être au format (123)-456-7890.");
                }
                telephoneStr= value;
                #endregion
            }
        }

        /// <summary>
        /// Obtient ou définit la marque du véhicule (Honda, Toyota, Nissan, Ford, etc.)
        /// </summary>
        public string Marque
        {
            get
            {
                return marqueStr;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value != String.Empty)
                    {
                        marqueStr = value;
                    }
                    else
                    {
                        throw new ArgumentException(tMessagesErreurs[(int)CodesErreurs.MarqueObligatoire]);
                    }
                }
                else
                {
                    throw new ArgumentNullException(tMessagesErreurs[(int)CodesErreurs.MarqueObligatoire]);
                }
            }
        }

        /// <summary>
        /// Obtient ou définit le modèle spécifique du véhicule
        /// Doit correspondre à un modèle valide dans le tableau: CX-3, Altima, Civic, etc.
        /// </summary>
        public string Modele
        {
            get
            {
                return modeleStr;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (Array.IndexOf(tModele, value) != -1)
                    {
                        modeleStr = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException(tMessagesErreurs[(int)CodesErreurs.ModeleInvalide]);
                    }
                }
                else
                {
                    throw new ArgumentNullException(tMessagesErreurs[(int)CodesErreurs.ModeleObligatoire]);
                }
            }
        }

        /// <summary>
        /// Obtient ou définit le type de voiture (Berline, SUV, Camionnette, etc.)
        /// </summary>
        public string TypeVoiture
        {
            get
            {
                return typeVoitureStr;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value != String.Empty)
                    {
                        typeVoitureStr = value;
                    }
                    else
                    {
                        throw new ArgumentException(tMessagesErreurs[(int)CodesErreurs.TypeVoitureObligatoire]);
                    }
                }
                else
                {
                    throw new ArgumentNullException(tMessagesErreurs[(int)CodesErreurs.TypeVoitureObligatoire]);
                }
            }
        }

        /// <summary>
        /// Obtient ou définit l'année du véhicule
        /// Doit correspondre à une année valide dans le tableau
        /// </summary>
        public string Annee
        {
            get
            {
                return anneeStr;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (Array.IndexOf(tAnnee, value) != -1)
                    {
                        anneeStr = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException(tMessagesErreurs[(int)CodesErreurs.AnneeInvalide]);
                    }
                }
                else
                {
                    throw new ArgumentNullException(tMessagesErreurs[(int)CodesErreurs.AnneeObligatoire]);
                }
            }
        }

        /// <summary>
        /// Obtient ou définit le prix de la transaction
        /// Le prix doit être positif et supérieur à zéro
        /// Si modèle et année sont définis, le prix doit correspondre au prix du tableau
        /// </summary>
        public decimal Prix
        {
            get
            {
                return prixDecimal;
            }
            set
            {
                if (value > 0)
                {
                    // Vérifier si le modèle et l'année sont déjà définis
                    if (!String.IsNullOrEmpty(modeleStr) && !String.IsNullOrEmpty(anneeStr))
                    {
                        int indiceModele = Array.IndexOf(tModele, modeleStr);
                        int indiceAnnee = Array.IndexOf(tAnnee, anneeStr);

                        // Vérifier si le prix correspond au prix du tableau
                        if (tPrix[indiceAnnee, indiceModele] == value)
                        {
                            prixDecimal = value;
                        }
                        else
                        {
                            throw new ArgumentException(tMessagesErreurs[(int)CodesErreurs.PrixNeCorrespondPas]);
                        }
                    }
                    else
                    {
                        // Si modèle ou année non définis, on accepte le prix
                        prixDecimal = value;
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException(tMessagesErreurs[(int)CodesErreurs.PrixInvalide]);
                }
            }
        }

        /// <summary>
        /// Obtient ou définit la date de livraison
        /// La date doit se situer dans les 15 jours précédant ou suivant aujourd'hui
        /// Calcule automatiquement la date de paiement (30 jours après la livraison)
        /// </summary>
        public DateTime DateLivraison
        {
            get
            {
                return dateLivraisonDateTime;
            }
            set
            {
                DateTime dateAujourdhui = DateTime.Today;
                DateTime dateMinimum = dateAujourdhui.AddDays(-15);
                DateTime dateMaximum = dateAujourdhui.AddDays(15);

                if (value >= dateMinimum && value <= dateMaximum)
                {
                    dateLivraisonDateTime = value;
                    // Calcul automatique de la date de paiement (30 jours après la livraison)
                    datePaiementDateTime = dateLivraisonDateTime.AddDays(30);
                }
                else
                {
                    throw new ArgumentOutOfRangeException(tMessagesErreurs[(int)CodesErreurs.DateLivraisonInvalide]);
                }
            }
        }

        /// <summary>
        /// Obtient la date due pour le paiement (lecture seule)
        /// La date de paiement est calculée automatiquement : date de livraison + 30 jours
        /// </summary>
        public DateTime DateDuePaiement
        {
            get
            {
                return datePaiementDateTime;
            }
        }

        #endregion

        #region Méthodes auxiliaires

        /// <summary>
        /// Obtient le tableau des années disponibles
        /// </summary>
        public string[] GetAnnee()
        {
            return tAnnee;
        }

        /// <summary>
        /// Obtient le tableau des modèles disponibles
        /// </summary>
        public string[] GetModel()
        {
            return tModele;
        }

        /// <summary>
        /// Obtient le prix pour un index d'année et un index de modèle spécifiques
        /// </summary>
        /// <param name="annee">Index de l'année (0-9)</param>
        /// <param name="model">Index du modèle (0-6)</param>
        /// <returns>Prix correspondant</returns>
        public decimal GetPrix(int annee, int model)
        {
            if (annee < 0 || annee >= tAnnee.Length)
            {
                throw new ArgumentOutOfRangeException("L'index de l'année est erroné.");
            }

            if (model < 0 || model >= tModele.Length)
            {
                throw new ArgumentOutOfRangeException("L'index du modèle est erroné.");
            }

            return tPrix[annee, model];
        }

        /// <summary>
        /// Obtient le prix pour une année et un modèle spécifiques (par nom)
        /// </summary>
        /// <param name="annee">Année sous forme de chaîne</param>
        /// <param name="model">Modèle sous forme de chaîne</param>
        /// <returns>Prix correspondant</returns>
        public decimal GetPrix(string annee, string model)
        {
            int anneeIndex = Array.IndexOf(tAnnee, annee);
            int modelIndex = Array.IndexOf(tModele, model);

            if (anneeIndex == -1)
            {
                throw new ArgumentException("Année invalide.", nameof(annee));
            }

            if (modelIndex == -1)
            {
                throw new ArgumentException("Modèle invalide.", nameof(model));
            }

            return tPrix[anneeIndex, modelIndex];
        }

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// Initialise les tableaux et les messages d'erreurs
        /// </summary>
        public Transaction()
        {
            // Génération automatique de l'ID
            idInt = new Random().Next(1000, 9999);

            // Initialisation des tableaux
            InitAnnee();
            InitModele();
            InitPrix();
            InitMessagesErreurs();
        }

        /// <summary>
        /// Constructeur avec paramètres pour initialiser une transaction complète
        /// </summary>
        public Transaction(string nomPrinc, string prenomPrinc, string adressePrinc,
                          string codePostalPrinc, string telephonePrinc, string marquePrinc,
                          string modelePrinc, string typeVoiturePrinc, string anneePrinc,
                          DateTime dateLivraisonPrinc, decimal prixPrinc)
        {
            // Génération automatique de l'ID
            idInt = new Random().Next(1000, 9999);

            // Initialisation des tableaux et messages d'erreurs
            InitAnnee();
            InitModele();
            InitPrix();
            InitMessagesErreurs();

            // Initialisation via les propriétés (avec validation)
            Nom = nomPrinc;
            Prenom = prenomPrinc;
            Adresse = adressePrinc;
            CodePostal = codePostalPrinc;
            Telephone = telephonePrinc;
            Marque = marquePrinc;
            Modele = modelePrinc;
            TypeVoiture = typeVoiturePrinc;
            Annee = anneePrinc;
            DateLivraison = dateLivraisonPrinc;
            Prix = prixPrinc;
        }

        #endregion

        #region Méthodes d'enregistrement

        /// <summary>
        /// Enregistre la transaction courante dans le système
        /// </summary>
        public void Enregistrer()
        {
            // Incrémenter le nombre de transactions

            #region Incrémentation de  variable statique : Phase E
            NombreTransactions++;
            #endregion

            if (!TransactionCompletee())
                throw new Exception("Certaines données obligatoires sont manquantes.");

            // Générer l’ID basé sur l’horodatage
            idInt = Math.Abs((int)DateTime.Now.Ticks);

            string chemin = "..\\..\\Data\\Transactions.data";

            try
            {
                using (StreamWriter sw = new StreamWriter(chemin, true))
                {
                    string ligne =
                        ID + DELIMITEUR.ToString() +
                        Nom + DELIMITEUR +
                        Prenom + DELIMITEUR +
                        Adresse + DELIMITEUR +
                        CodePostal + DELIMITEUR +
                        Telephone + DELIMITEUR +
                        TypeVoiture + DELIMITEUR +
                        Marque + DELIMITEUR +
                        Modele + DELIMITEUR +
                        Annee + DELIMITEUR +
                        Prix.ToString(cultureInfoENCA) + DELIMITEUR +
                        DateLivraison.ToShortDateString() + DELIMITEUR +
                        DateDuePaiement.ToShortDateString();

                    sw.WriteLine(ligne);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erreur lors de l’enregistrement : " + ex.Message);
            }
        }

        /// <summary>
        /// Enregistre une transaction avec les paramètres fournis
        /// </summary>
        public void Enregistrer(string nomPrinc, string prenomPrinc, string adressePrinc,
                               string codePostalPrinc, string telephonePrinc, string marquePrinc,
                               string modelePrinc, string typeVoiturePrinc, string anneePrinc,
                               DateTime dateLivraisonPrinc, decimal prixPrinc)
        {
            // Initialisation via les propriétés
            Nom = nomPrinc;
            Prenom = prenomPrinc;
            Adresse = adressePrinc;
            CodePostal = codePostalPrinc;
            Telephone = telephonePrinc;
            Marque = marquePrinc;
            Modele = modelePrinc;
            TypeVoiture = typeVoiturePrinc;
            Annee = anneePrinc;
            DateLivraison = dateLivraisonPrinc;
            Prix = prixPrinc;

            // Appel de la méthode Enregistrer sans paramètre
            Enregistrer();
        }

        #endregion

        #region validation la transaction
        public bool TransactionCompletee()
        {
            return !string.IsNullOrWhiteSpace(Nom)
                && !string.IsNullOrWhiteSpace(Prenom)
                && !string.IsNullOrWhiteSpace(Adresse)
                && !string.IsNullOrWhiteSpace(CodePostal)
                && !string.IsNullOrWhiteSpace(Telephone)
                && !string.IsNullOrWhiteSpace(Marque)
                && !string.IsNullOrWhiteSpace(Modele)
                && !string.IsNullOrWhiteSpace(Annee)
                && !string.IsNullOrWhiteSpace(TypeVoiture)
                && Prix > 0
                && DateLivraison != DateTime.MinValue
                && DateDuePaiement != DateTime.MinValue;
        }
        #endregion



    }
}