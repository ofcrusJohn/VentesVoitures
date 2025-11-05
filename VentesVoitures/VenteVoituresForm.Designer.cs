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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.paiementDuTitreLabel = new System.Windows.Forms.Label();
            this.paiementDuLabel = new System.Windows.Forms.Label();
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
            this.venteMenuMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.venteMenuMenuStrip.Size = new System.Drawing.Size(920, 24);
            this.venteMenuMenuStrip.TabIndex = 0;
            this.venteMenuMenuStrip.Text = "menuStrip1";
            // 
            // fcherToolStripMenuItem
            // 
            this.fcherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem});
            this.fcherToolStripMenuItem.Name = "fcherToolStripMenuItem";
            this.fcherToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fcherToolStripMenuItem.Text = "&Fichier";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer ";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.fcherToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "&Aide";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aProposToolStripMenuItem.Text = "À propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.AProposToolStripMenuItem_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::VentesVoitures.Properties.Resources.logo_de_concessionnaire_de_voitures_de_sport_de_magasin_automobile_431254_original;
            this.LogoPictureBox.Location = new System.Drawing.Point(12, 27);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(848, 238);
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
            this.clientGroupBox.Location = new System.Drawing.Point(12, 286);
            this.clientGroupBox.Name = "clientGroupBox";
            this.clientGroupBox.Size = new System.Drawing.Size(428, 302);
            this.clientGroupBox.TabIndex = 2;
            this.clientGroupBox.TabStop = false;
            this.clientGroupBox.Text = "Client";
            // 
            // marqueComboBox
            // 
            this.marqueComboBox.FormattingEnabled = true;
            this.marqueComboBox.Location = new System.Drawing.Point(151, 274);
            this.marqueComboBox.Name = "marqueComboBox";
            this.marqueComboBox.Size = new System.Drawing.Size(265, 21);
            this.marqueComboBox.TabIndex = 16;
            // 
            // marqueTextBox
            // 
            this.marqueTextBox.AutoSize = true;
            this.marqueTextBox.Location = new System.Drawing.Point(35, 276);
            this.marqueTextBox.Name = "marqueTextBox";
            this.marqueTextBox.Size = new System.Drawing.Size(46, 13);
            this.marqueTextBox.TabIndex = 15;
            this.marqueTextBox.Text = "Marque:";
            // 
            // adresseMaskedTextBox
            // 
            this.adresseMaskedTextBox.Location = new System.Drawing.Point(151, 100);
            this.adresseMaskedTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adresseMaskedTextBox.Name = "adresseMaskedTextBox";
            this.adresseMaskedTextBox.Size = new System.Drawing.Size(265, 20);
            this.adresseMaskedTextBox.TabIndex = 6;
            this.adresseMaskedTextBox.Enter += new System.EventHandler(this.GestionMaskedTextBox);
            // 
            // codePostalMaskedTextBox
            // 
            this.codePostalMaskedTextBox.Location = new System.Drawing.Point(151, 139);
            this.codePostalMaskedTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codePostalMaskedTextBox.Mask = "L0L-0L0";
            this.codePostalMaskedTextBox.Name = "codePostalMaskedTextBox";
            this.codePostalMaskedTextBox.Size = new System.Drawing.Size(265, 20);
            this.codePostalMaskedTextBox.TabIndex = 6;
            this.codePostalMaskedTextBox.Enter += new System.EventHandler(this.GestionMaskedTextBox);
            // 
            // telephoneMaskedTextBox
            // 
            this.telephoneMaskedTextBox.Location = new System.Drawing.Point(151, 179);
            this.telephoneMaskedTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.telephoneMaskedTextBox.Mask = "(000) 000 0000";
            this.telephoneMaskedTextBox.Name = "telephoneMaskedTextBox";
            this.telephoneMaskedTextBox.Size = new System.Drawing.Size(265, 20);
            this.telephoneMaskedTextBox.TabIndex = 6;
            this.telephoneMaskedTextBox.Enter += new System.EventHandler(this.GestionMaskedTextBox);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(35, 229);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(84, 13);
            this.typeLabel.TabIndex = 14;
            this.typeLabel.Text = "Type de voiture:";
            // 
            // telephoneLabel
            // 
            this.telephoneLabel.AutoSize = true;
            this.telephoneLabel.Location = new System.Drawing.Point(35, 184);
            this.telephoneLabel.Name = "telephoneLabel";
            this.telephoneLabel.Size = new System.Drawing.Size(64, 13);
            this.telephoneLabel.TabIndex = 13;
            this.telephoneLabel.Text = "Téléphone :";
            // 
            // codePostalLabel
            // 
            this.codePostalLabel.AutoSize = true;
            this.codePostalLabel.Location = new System.Drawing.Point(35, 144);
            this.codePostalLabel.Name = "codePostalLabel";
            this.codePostalLabel.Size = new System.Drawing.Size(70, 13);
            this.codePostalLabel.TabIndex = 12;
            this.codePostalLabel.Text = "Code Postal :";
            // 
            // adresseLabel
            // 
            this.adresseLabel.AutoSize = true;
            this.adresseLabel.Location = new System.Drawing.Point(35, 105);
            this.adresseLabel.Name = "adresseLabel";
            this.adresseLabel.Size = new System.Drawing.Size(51, 13);
            this.adresseLabel.TabIndex = 11;
            this.adresseLabel.Text = "Adresse :";
            // 
            // prenomLabel
            // 
            this.prenomLabel.AutoSize = true;
            this.prenomLabel.Location = new System.Drawing.Point(35, 66);
            this.prenomLabel.Name = "prenomLabel";
            this.prenomLabel.Size = new System.Drawing.Size(49, 13);
            this.prenomLabel.TabIndex = 10;
            this.prenomLabel.Text = "Prénom :";
            // 
            // NomLabel
            // 
            this.NomLabel.AutoSize = true;
            this.NomLabel.Location = new System.Drawing.Point(35, 31);
            this.NomLabel.Name = "NomLabel";
            this.NomLabel.Size = new System.Drawing.Size(32, 13);
            this.NomLabel.TabIndex = 9;
            this.NomLabel.Text = "Nom:";
            // 
            // typeVoitureComboBox
            // 
            this.typeVoitureComboBox.FormattingEnabled = true;
            this.typeVoitureComboBox.Location = new System.Drawing.Point(151, 226);
            this.typeVoitureComboBox.Name = "typeVoitureComboBox";
            this.typeVoitureComboBox.Size = new System.Drawing.Size(265, 21);
            this.typeVoitureComboBox.TabIndex = 7;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.Location = new System.Drawing.Point(151, 63);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(265, 20);
            this.prenomTextBox.TabIndex = 6;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(151, 24);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(265, 20);
            this.nomTextBox.TabIndex = 0;
            // 
            // transactionGroupBox
            // 
            this.transactionGroupBox.Controls.Add(this.paiementDuLabel);
            this.transactionGroupBox.Controls.Add(this.paiementDuTitreLabel);
            this.transactionGroupBox.Controls.Add(this.prixLabel);
            this.transactionGroupBox.Controls.Add(this.anneeLabel);
            this.transactionGroupBox.Controls.Add(this.modeleLabel);
            this.transactionGroupBox.Controls.Add(this.prixTextBox);
            this.transactionGroupBox.Controls.Add(this.anneeComboBox);
            this.transactionGroupBox.Controls.Add(this.modeleComboBox);
            this.transactionGroupBox.Controls.Add(this.livraisonDateTimePicker);
            this.transactionGroupBox.Controls.Add(this.dateLivraisonLabel);
            this.transactionGroupBox.Location = new System.Drawing.Point(446, 286);
            this.transactionGroupBox.Name = "transactionGroupBox";
            this.transactionGroupBox.Size = new System.Drawing.Size(375, 220);
            this.transactionGroupBox.TabIndex = 3;
            this.transactionGroupBox.TabStop = false;
            this.transactionGroupBox.Text = "Transaction";
            // 
            // prixLabel
            // 
            this.prixLabel.AutoSize = true;
            this.prixLabel.Location = new System.Drawing.Point(34, 161);
            this.prixLabel.Name = "prixLabel";
            this.prixLabel.Size = new System.Drawing.Size(30, 13);
            this.prixLabel.TabIndex = 7;
            this.prixLabel.Text = "Prix :";
            // 
            // anneeLabel
            // 
            this.anneeLabel.AutoSize = true;
            this.anneeLabel.Location = new System.Drawing.Point(34, 120);
            this.anneeLabel.Name = "anneeLabel";
            this.anneeLabel.Size = new System.Drawing.Size(47, 13);
            this.anneeLabel.TabIndex = 6;
            this.anneeLabel.Text = "Année  :";
            // 
            // modeleLabel
            // 
            this.modeleLabel.AutoSize = true;
            this.modeleLabel.Location = new System.Drawing.Point(34, 82);
            this.modeleLabel.Name = "modeleLabel";
            this.modeleLabel.Size = new System.Drawing.Size(48, 13);
            this.modeleLabel.TabIndex = 5;
            this.modeleLabel.Text = "Modele :";
            // 
            // prixTextBox
            // 
            this.prixTextBox.Location = new System.Drawing.Point(131, 158);
            this.prixTextBox.Name = "prixTextBox";
            this.prixTextBox.Size = new System.Drawing.Size(211, 20);
            this.prixTextBox.TabIndex = 4;
            // 
            // anneeComboBox
            // 
            this.anneeComboBox.FormattingEnabled = true;
            this.anneeComboBox.Location = new System.Drawing.Point(131, 117);
            this.anneeComboBox.Name = "anneeComboBox";
            this.anneeComboBox.Size = new System.Drawing.Size(212, 21);
            this.anneeComboBox.TabIndex = 3;
            this.anneeComboBox.SelectedIndexChanged += new System.EventHandler(this.ModeleComboBox_SelectedIndexChanged);
            // 
            // modeleComboBox
            // 
            this.modeleComboBox.FormattingEnabled = true;
            this.modeleComboBox.Location = new System.Drawing.Point(131, 78);
            this.modeleComboBox.Name = "modeleComboBox";
            this.modeleComboBox.Size = new System.Drawing.Size(213, 21);
            this.modeleComboBox.TabIndex = 2;
            this.modeleComboBox.SelectedIndexChanged += new System.EventHandler(this.ModeleComboBox_SelectedIndexChanged);
            // 
            // livraisonDateTimePicker
            // 
            this.livraisonDateTimePicker.Location = new System.Drawing.Point(129, 40);
            this.livraisonDateTimePicker.Name = "livraisonDateTimePicker";
            this.livraisonDateTimePicker.Size = new System.Drawing.Size(216, 20);
            this.livraisonDateTimePicker.TabIndex = 1;
            this.livraisonDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.livraisonDateTimePicker_Validating);
            // 
            // dateLivraisonLabel
            // 
            this.dateLivraisonLabel.AutoSize = true;
            this.dateLivraisonLabel.Location = new System.Drawing.Point(23, 42);
            this.dateLivraisonLabel.Name = "dateLivraisonLabel";
            this.dateLivraisonLabel.Size = new System.Drawing.Size(92, 13);
            this.dateLivraisonLabel.TabIndex = 0;
            this.dateLivraisonLabel.Text = "Date de livraison :";
            // 
            // enregistrerButton
            // 
            this.enregistrerButton.Location = new System.Drawing.Point(446, 515);
            this.enregistrerButton.Name = "enregistrerButton";
            this.enregistrerButton.Size = new System.Drawing.Size(182, 73);
            this.enregistrerButton.TabIndex = 4;
            this.enregistrerButton.Text = "&Enregistrer";
            this.enregistrerButton.UseVisualStyleBackColor = true;
            this.enregistrerButton.Click += new System.EventHandler(this.fcherToolStripMenuItem_Click);
            // 
            // quitterButton
            // 
            this.quitterButton.Location = new System.Drawing.Point(634, 512);
            this.quitterButton.Name = "quitterButton";
            this.quitterButton.Size = new System.Drawing.Size(187, 76);
            this.quitterButton.TabIndex = 5;
            this.quitterButton.Text = "&Quitter";
            this.quitterButton.UseVisualStyleBackColor = true;
            this.quitterButton.Click += new System.EventHandler(this.Quitter_click);
            // 
            // paiementDuTitreLabel
            // 
            this.paiementDuTitreLabel.AutoSize = true;
            this.paiementDuTitreLabel.Location = new System.Drawing.Point(36, 194);
            this.paiementDuTitreLabel.Name = "paiementDuTitreLabel";
            this.paiementDuTitreLabel.Size = new System.Drawing.Size(80, 13);
            this.paiementDuTitreLabel.TabIndex = 8;
            this.paiementDuTitreLabel.Text = "Paiement dû le:";
            this.paiementDuTitreLabel.Visible = false;
            // 
            // paiementDuLabel
            // 
            this.paiementDuLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paiementDuLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paiementDuLabel.Location = new System.Drawing.Point(131, 193);
            this.paiementDuLabel.Name = "paiementDuLabel";
            this.paiementDuLabel.Size = new System.Drawing.Size(207, 20);
            this.paiementDuLabel.TabIndex = 9;
            this.paiementDuLabel.Visible = false;
            // 
            // VenteVoituresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 694);
            this.Controls.Add(this.quitterButton);
            this.Controls.Add(this.enregistrerButton);
            this.Controls.Add(this.transactionGroupBox);
            this.Controls.Add(this.clientGroupBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.venteMenuMenuStrip);
            this.MainMenuStrip = this.venteMenuMenuStrip;
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
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label paiementDuLabel;
        private System.Windows.Forms.Label paiementDuTitreLabel;
    }
}

