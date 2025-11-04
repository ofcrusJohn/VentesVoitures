namespace VentesVoitures
{
    partial class VenteVoituresForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.venteMenuMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.clientGroupBox = new System.Windows.Forms.GroupBox();
            this.marqueComboBox = new System.Windows.Forms.ComboBox();
            this.marqueTextBox = new System.Windows.Forms.Label();
            this.adresseMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.codePostalMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telephoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.codePostalLabel = new System.Windows.Forms.Label();
            this.adresseLabel = new System.Windows.Forms.Label();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.NomLabel = new System.Windows.Forms.Label();
            this.typeVoitureComboBox = new System.Windows.Forms.ComboBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.transactionGroupBox = new System.Windows.Forms.GroupBox();
            this.prixLabel = new System.Windows.Forms.Label();
            this.anneeLabel = new System.Windows.Forms.Label();
            this.modeleLabel = new System.Windows.Forms.Label();
            this.prixTextBox = new System.Windows.Forms.TextBox();
            this.anneeComboBox = new System.Windows.Forms.ComboBox();
            this.modeleComboBox = new System.Windows.Forms.ComboBox();
            this.livraisonDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLivraisonLabel = new System.Windows.Forms.Label();
            this.enregistrerButton = new System.Windows.Forms.Button();
            this.quitterButton = new System.Windows.Forms.Button();
            this.datePaiementLabel = new System.Windows.Forms.Label();
            this.venteMenuMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.clientGroupBox.SuspendLayout();
            this.transactionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // venteMenuMenuStrip
            // 
            this.venteMenuMenuStrip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.venteMenuMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.venteMenuMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fcherToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.venteMenuMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.venteMenuMenuStrip.Name = "venteMenuMenuStrip";
            this.venteMenuMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.venteMenuMenuStrip.Size = new System.Drawing.Size(1534, 38);
            this.venteMenuMenuStrip.TabIndex = 0;
            this.venteMenuMenuStrip.Text = "menuStrip1";
            // 
            // fcherToolStripMenuItem
            // 
            this.fcherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem});
            this.fcherToolStripMenuItem.Name = "fcherToolStripMenuItem";
            this.fcherToolStripMenuItem.Size = new System.Drawing.Size(66, 34);
            this.fcherToolStripMenuItem.Text = "&Fichier";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer ";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.EnregistrerToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(54, 34);
            this.aideToolStripMenuItem.Text = "&Aide";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.aProposToolStripMenuItem.Text = "À propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.AProposToolStripMenuItem_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::VentesVoitures.Properties.Resources.logo_de_concessionnaire_de_voitures_de_sport_de_magasin_automobile_431254_original;
            this.LogoPictureBox.Location = new System.Drawing.Point(16, 33);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(1131, 293);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 1;
            this.LogoPictureBox.TabStop = false;
            // 
            // clientGroupBox
            // 
            this.clientGroupBox.Controls.Add(this.marqueComboBox);
            this.clientGroupBox.Controls.Add(this.marqueTextBox);
            this.clientGroupBox.Controls.Add(this.adresseMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.codePostalMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.telephoneMaskedTextBox);
            this.clientGroupBox.Controls.Add(this.typeLabel);
            this.clientGroupBox.Controls.Add(this.telephoneLabel);
            this.clientGroupBox.Controls.Add(this.codePostalLabel);
            this.clientGroupBox.Controls.Add(this.adresseLabel);
            this.clientGroupBox.Controls.Add(this.prenomLabel);
            this.clientGroupBox.Controls.Add(this.NomLabel);
            this.clientGroupBox.Controls.Add(this.typeVoitureComboBox);
            this.clientGroupBox.Controls.Add(this.prenomTextBox);
            this.clientGroupBox.Controls.Add(this.nomTextBox);
            this.clientGroupBox.Location = new System.Drawing.Point(16, 352);
            this.clientGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.clientGroupBox.Name = "clientGroupBox";
            this.clientGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.clientGroupBox.Size = new System.Drawing.Size(571, 372);
            this.clientGroupBox.TabIndex = 2;
            this.clientGroupBox.TabStop = false;
            this.clientGroupBox.Text = "Client";
            // 
            // marqueComboBox
            // 
            this.marqueComboBox.FormattingEnabled = true;
            this.marqueComboBox.Location = new System.Drawing.Point(201, 337);
            this.marqueComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.marqueComboBox.Name = "marqueComboBox";
            this.marqueComboBox.Size = new System.Drawing.Size(352, 24);
            this.marqueComboBox.TabIndex = 16;
            // 
            // marqueTextBox
            // 
            this.marqueTextBox.AutoSize = true;
            this.marqueTextBox.Location = new System.Drawing.Point(47, 340);
            this.marqueTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.marqueTextBox.Name = "marqueTextBox";
            this.marqueTextBox.Size = new System.Drawing.Size(56, 16);
            this.marqueTextBox.TabIndex = 15;
            this.marqueTextBox.Text = "Marque:";
            // 
            // adresseMaskedTextBox
            // 
            this.adresseMaskedTextBox.Location = new System.Drawing.Point(201, 123);
            this.adresseMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adresseMaskedTextBox.Mask = "00000000000000";
            this.adresseMaskedTextBox.Name = "adresseMaskedTextBox";
            this.adresseMaskedTextBox.Size = new System.Drawing.Size(352, 22);
            this.adresseMaskedTextBox.TabIndex = 6;
            this.adresseMaskedTextBox.Enter += new System.EventHandler(this.GestionMaskedTextBox);
            // 
            // codePostalMaskedTextBox
            // 
            this.codePostalMaskedTextBox.Location = new System.Drawing.Point(201, 171);
            this.codePostalMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.codePostalMaskedTextBox.Mask = "00000";
            this.codePostalMaskedTextBox.Name = "codePostalMaskedTextBox";
            this.codePostalMaskedTextBox.Size = new System.Drawing.Size(352, 22);
            this.codePostalMaskedTextBox.TabIndex = 6;
            this.codePostalMaskedTextBox.Enter += new System.EventHandler(this.GestionMaskedTextBox);
            // 
            // telephoneMaskedTextBox
            // 
            this.telephoneMaskedTextBox.Location = new System.Drawing.Point(201, 220);
            this.telephoneMaskedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telephoneMaskedTextBox.Mask = "00 00 00 00 00 00";
            this.telephoneMaskedTextBox.Name = "telephoneMaskedTextBox";
            this.telephoneMaskedTextBox.Size = new System.Drawing.Size(352, 22);
            this.telephoneMaskedTextBox.TabIndex = 6;
            this.telephoneMaskedTextBox.Enter += new System.EventHandler(this.GestionMaskedTextBox);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(47, 282);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(104, 16);
            this.typeLabel.TabIndex = 14;
            this.typeLabel.Text = "Type de voiture:";
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(47, 226);
            this.telephoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(79, 16);
            this.telephoneLabel.TabIndex = 13;
            this.telephoneLabel.Text = "Téléphone :";
            // 
            // codePostalLabel
            // 
            this.codePostalLabel.AutoSize = true;
            this.codePostalLabel.Location = new System.Drawing.Point(47, 177);
            this.codePostalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codePostalLabel.Name = "codePostalLabel";
            this.codePostalLabel.Size = new System.Drawing.Size(87, 16);
            this.codePostalLabel.TabIndex = 12;
            this.codePostalLabel.Text = "Code Postal :";
            // 
            // adresseLabel
            // 
            this.adresseLabel.AutoSize = true;
            this.adresseLabel.Location = new System.Drawing.Point(47, 129);
            this.adresseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.adresseLabel.Name = "adresseLabel";
            this.adresseLabel.Size = new System.Drawing.Size(64, 16);
            this.adresseLabel.TabIndex = 11;
            this.adresseLabel.Text = "Adresse :";
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Location = new System.Drawing.Point(47, 81);
            this.prenomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(60, 16);
            this.prenomLabel.TabIndex = 10;
            this.prenomLabel.Text = "Prénom :";
            // 
            // NomLabel
            // 
            this.NomLabel.AutoSize = true;
            this.NomLabel.Location = new System.Drawing.Point(47, 38);
            this.NomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(39, 16);
            this.NomLabel.TabIndex = 9;
            this.NomLabel.Text = "Nom:";
            // 
            // typeVoitureComboBox
            // 
            this.typeVoitureComboBox.FormattingEnabled = true;
            this.typeVoitureComboBox.Location = new System.Drawing.Point(201, 278);
            this.typeVoitureComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.typeVoitureComboBox.Name = "typeVoitureComboBox";
            this.typeVoitureComboBox.Size = new System.Drawing.Size(352, 24);
            this.typeVoitureComboBox.TabIndex = 7;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.Location = new System.Drawing.Point(201, 78);
            this.prenomTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(352, 22);
            this.prenomTextBox.TabIndex = 6;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(201, 30);
            this.nomTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(352, 22);
            this.nomTextBox.TabIndex = 0;
            // 
            // transactionGroupBox
            // 
            this.transactionGroupBox.Controls.Add(this.prixLabel);
            this.transactionGroupBox.Controls.Add(this.anneeLabel);
            this.transactionGroupBox.Controls.Add(this.modeleLabel);
            this.transactionGroupBox.Controls.Add(this.prixTextBox);
            this.transactionGroupBox.Controls.Add(this.anneeComboBox);
            this.transactionGroupBox.Controls.Add(this.modeleComboBox);
            this.transactionGroupBox.Controls.Add(this.livraisonDateTimePicker);
            this.transactionGroupBox.Controls.Add(this.dateLivraisonLabel);
            this.transactionGroupBox.Location = new System.Drawing.Point(595, 352);
            this.transactionGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.transactionGroupBox.Name = "transactionGroupBox";
            this.transactionGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.transactionGroupBox.Size = new System.Drawing.Size(500, 225);
            this.transactionGroupBox.TabIndex = 3;
            this.transactionGroupBox.TabStop = false;
            this.transactionGroupBox.Text = "Transaction";
            // 
            // prixLabel
            // 
            this.prixLabel.AutoSize = true;
            this.prixLabel.Location = new System.Drawing.Point(45, 198);
            this.prixLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prixLabel.Name = "prixLabel";
            this.prixLabel.Size = new System.Drawing.Size(35, 16);
            this.prixLabel.TabIndex = 7;
            this.prixLabel.Text = "Prix :";
            // 
            // anneeLabel
            // 
            this.anneeLabel.AutoSize = true;
            this.anneeLabel.Location = new System.Drawing.Point(45, 148);
            this.anneeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.anneeLabel.Name = "anneeLabel";
            this.anneeLabel.Size = new System.Drawing.Size(55, 16);
            this.anneeLabel.TabIndex = 6;
            this.anneeLabel.Text = "Année  :";
            // 
            // modeleLabel
            // 
            this.modeleLabel.AutoSize = true;
            this.modeleLabel.Location = new System.Drawing.Point(45, 101);
            this.modeleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modeleLabel.Name = "modeleLabel";
            this.modeleLabel.Size = new System.Drawing.Size(59, 16);
            this.modeleLabel.TabIndex = 5;
            this.modeleLabel.Text = "Modele :";
            // 
            // prixTextBox
            // 
            this.prixTextBox.Location = new System.Drawing.Point(175, 194);
            this.prixTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.prixTextBox.Name = "prixTextBox";
            this.prixTextBox.Size = new System.Drawing.Size(280, 22);
            this.prixTextBox.TabIndex = 4;
            // 
            // anneeComboBox
            // 
            this.anneeComboBox.FormattingEnabled = true;
            this.anneeComboBox.Location = new System.Drawing.Point(175, 144);
            this.anneeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.anneeComboBox.Name = "anneeComboBox";
            this.anneeComboBox.Size = new System.Drawing.Size(281, 24);
            this.anneeComboBox.TabIndex = 3;
            this.anneeComboBox.SelectedIndexChanged += new System.EventHandler(this.ModeleComboBox_SelectedIndexChanged);
            // 
            // modeleComboBox
            // 
            this.modeleComboBox.FormattingEnabled = true;
            this.modeleComboBox.Location = new System.Drawing.Point(175, 96);
            this.modeleComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.modeleComboBox.Name = "modeleComboBox";
            this.modeleComboBox.Size = new System.Drawing.Size(283, 24);
            this.modeleComboBox.TabIndex = 2;
            this.modeleComboBox.SelectedIndexChanged += new System.EventHandler(this.ModeleComboBox_SelectedIndexChanged);
            // 
            // livraisonDateTimePicker
            // 
            this.livraisonDateTimePicker.Location = new System.Drawing.Point(172, 49);
            this.livraisonDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.livraisonDateTimePicker.Name = "livraisonDateTimePicker";
            this.livraisonDateTimePicker.Size = new System.Drawing.Size(287, 22);
            this.livraisonDateTimePicker.TabIndex = 1;
            this.livraisonDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.livraisonDateTimePicker_Validating);
            // 
            // dateLivraisonLabel
            // 
            this.dateLivraisonLabel.AutoSize = true;
            this.dateLivraisonLabel.Location = new System.Drawing.Point(31, 52);
            this.dateLivraisonLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLivraisonLabel.Name = "dateLivraisonLabel";
            this.dateLivraisonLabel.Size = new System.Drawing.Size(114, 16);
            this.dateLivraisonLabel.TabIndex = 0;
            this.dateLivraisonLabel.Text = "Date de livraison :";
            // 
            // enregistrerButton
            // 
            this.enregistrerButton.Location = new System.Drawing.Point(595, 610);
            this.enregistrerButton.Margin = new System.Windows.Forms.Padding(4);
            this.enregistrerButton.Name = "enregistrerButton";
            this.enregistrerButton.Size = new System.Drawing.Size(243, 113);
            this.enregistrerButton.TabIndex = 4;
            this.enregistrerButton.Text = "&Enregistrer";
            this.enregistrerButton.UseVisualStyleBackColor = true;
            // 
            // quitterButton
            // 
            this.quitterButton.Location = new System.Drawing.Point(852, 610);
            this.quitterButton.Margin = new System.Windows.Forms.Padding(4);
            this.quitterButton.Name = "quitterButton";
            this.quitterButton.Size = new System.Drawing.Size(243, 113);
            this.quitterButton.TabIndex = 5;
            this.quitterButton.Text = "&Quitter";
            this.quitterButton.UseVisualStyleBackColor = true;
            this.quitterButton.Click += new System.EventHandler(this.Quitter_click);
            // 
            // datePaiementLabel
            // 
            this.datePaiementLabel.AutoSize = true;
            this.datePaiementLabel.Location = new System.Drawing.Point(600, 739);
            this.datePaiementLabel.Name = "datePaiementLabel";
            this.datePaiementLabel.Size = new System.Drawing.Size(0, 20);
            this.datePaiementLabel.TabIndex = 6;
            this.datePaiementLabel.Visible = false;
            // 
            // VenteVoituresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 854);
            this.Controls.Add(this.datePaiementLabel);
            this.Controls.Add(this.quitterButton);
            this.Controls.Add(this.enregistrerButton);
            this.Controls.Add(this.transactionGroupBox);
            this.Controls.Add(this.clientGroupBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.venteMenuMenuStrip);
            this.MainMenuStrip = this.venteMenuMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VenteVoituresForm";
            this.Text = "Ventes de voitures";
            this.Load += new System.EventHandler(this.VenteVoituresForm_Load);
            this.venteMenuMenuStrip.ResumeLayout(false);
            this.venteMenuMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.clientGroupBox.ResumeLayout(false);
            this.clientGroupBox.PerformLayout();
            this.transactionGroupBox.ResumeLayout(false);
            this.transactionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip venteMenuMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.GroupBox clientGroupBox;
        private System.Windows.Forms.GroupBox transactionGroupBox;
        private System.Windows.Forms.Button enregistrerButton;
        private System.Windows.Forms.Button quitterButton;
        private System.Windows.Forms.ComboBox typeVoitureComboBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label telephoneLabel;
        private System.Windows.Forms.Label codePostalLabel;
        private System.Windows.Forms.Label adresseLabel;
        private System.Windows.Forms.Label prenomLabel;
        private System.Windows.Forms.Label NomLabel;
        private System.Windows.Forms.Label prixLabel;
        private System.Windows.Forms.Label anneeLabel;
        private System.Windows.Forms.Label modeleLabel;
        private System.Windows.Forms.TextBox prixTextBox;
        private System.Windows.Forms.ComboBox anneeComboBox;
        private System.Windows.Forms.ComboBox modeleComboBox;
        private System.Windows.Forms.DateTimePicker livraisonDateTimePicker;
        private System.Windows.Forms.Label dateLivraisonLabel;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox telephoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox codePostalMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox adresseMaskedTextBox;
        private System.Windows.Forms.Label marqueTextBox;
        private System.Windows.Forms.ComboBox marqueComboBox;
        private System.Windows.Forms.Label datePaiementLabel;
    }
}

