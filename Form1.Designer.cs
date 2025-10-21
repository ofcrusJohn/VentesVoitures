namespace VentesVoitures
{
    partial class Form1
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
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.clientGroupBox = new System.Windows.Forms.GroupBox();
            this.marquelabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.telephoneLabel = new System.Windows.Forms.Label();
            this.codePostalLabel = new System.Windows.Forms.Label();
            this.adresseLabel = new System.Windows.Forms.Label();
            this.prenomLabel = new System.Windows.Forms.Label();
            this.NomLabel = new System.Windows.Forms.Label();
            this.marquecomboBox = new System.Windows.Forms.ComboBox();
            this.typeVoitureComboBox = new System.Windows.Forms.ComboBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.adresseTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.codePostalTextBox = new System.Windows.Forms.TextBox();
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
            this.venteMenuMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.clientGroupBox.SuspendLayout();
            this.transactionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // venteMenuMenuStrip
            // 
            this.venteMenuMenuStrip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.venteMenuMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fcherToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.venteMenuMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.venteMenuMenuStrip.Name = "venteMenuMenuStrip";
            this.venteMenuMenuStrip.Size = new System.Drawing.Size(872, 24);
            this.venteMenuMenuStrip.TabIndex = 0;
            this.venteMenuMenuStrip.Text = "menuStrip1";
            // 
            // fcherToolStripMenuItem
            // 
            this.fcherToolStripMenuItem.Name = "fcherToolStripMenuItem";
            this.fcherToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fcherToolStripMenuItem.Text = "&Fichier";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "&Aide";
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
            this.clientGroupBox.Controls.Add(this.marquelabel);
            this.clientGroupBox.Controls.Add(this.typeLabel);
            this.clientGroupBox.Controls.Add(this.telephoneLabel);
            this.clientGroupBox.Controls.Add(this.codePostalLabel);
            this.clientGroupBox.Controls.Add(this.adresseLabel);
            this.clientGroupBox.Controls.Add(this.prenomLabel);
            this.clientGroupBox.Controls.Add(this.NomLabel);
            this.clientGroupBox.Controls.Add(this.marquecomboBox);
            this.clientGroupBox.Controls.Add(this.typeVoitureComboBox);
            this.clientGroupBox.Controls.Add(this.prenomTextBox);
            this.clientGroupBox.Controls.Add(this.adresseTextBox);
            this.clientGroupBox.Controls.Add(this.telephoneTextBox);
            this.clientGroupBox.Controls.Add(this.codePostalTextBox);
            this.clientGroupBox.Controls.Add(this.nomTextBox);
            this.clientGroupBox.Location = new System.Drawing.Point(12, 286);
            this.clientGroupBox.Name = "clientGroupBox";
            this.clientGroupBox.Size = new System.Drawing.Size(428, 302);
            this.clientGroupBox.TabIndex = 2;
            this.clientGroupBox.TabStop = false;
            this.clientGroupBox.Text = "Client";
            // 
            // marquelabel
            // 
            this.marquelabel.AutoSize = true;
            this.marquelabel.Location = new System.Drawing.Point(35, 268);
            this.marquelabel.Name = "marquelabel";
            this.marquelabel.Size = new System.Drawing.Size(49, 13);
            this.marquelabel.TabIndex = 15;
            this.marquelabel.Text = "Marque :";
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
            // marquecomboBox
            // 
            this.marquecomboBox.FormattingEnabled = true;
            this.marquecomboBox.Location = new System.Drawing.Point(151, 265);
            this.marquecomboBox.Name = "marquecomboBox";
            this.marquecomboBox.Size = new System.Drawing.Size(265, 21);
            this.marquecomboBox.TabIndex = 8;
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
            // adresseTextBox
            // 
            this.adresseTextBox.Location = new System.Drawing.Point(151, 102);
            this.adresseTextBox.Name = "adresseTextBox";
            this.adresseTextBox.Size = new System.Drawing.Size(265, 20);
            this.adresseTextBox.TabIndex = 5;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(151, 181);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(265, 20);
            this.telephoneTextBox.TabIndex = 2;
            // 
            // codePostalTextBox
            // 
            this.codePostalTextBox.Location = new System.Drawing.Point(151, 141);
            this.codePostalTextBox.Name = "codePostalTextBox";
            this.codePostalTextBox.Size = new System.Drawing.Size(265, 20);
            this.codePostalTextBox.TabIndex = 1;
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
            this.transactionGroupBox.Size = new System.Drawing.Size(375, 183);
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
            // 
            // modeleComboBox
            // 
            this.modeleComboBox.FormattingEnabled = true;
            this.modeleComboBox.Location = new System.Drawing.Point(131, 78);
            this.modeleComboBox.Name = "modeleComboBox";
            this.modeleComboBox.Size = new System.Drawing.Size(213, 21);
            this.modeleComboBox.TabIndex = 2;
            // 
            // livraisonDateTimePicker
            // 
            this.livraisonDateTimePicker.Location = new System.Drawing.Point(129, 40);
            this.livraisonDateTimePicker.Name = "livraisonDateTimePicker";
            this.livraisonDateTimePicker.Size = new System.Drawing.Size(216, 20);
            this.livraisonDateTimePicker.TabIndex = 1;
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
            this.enregistrerButton.Location = new System.Drawing.Point(446, 496);
            this.enregistrerButton.Name = "enregistrerButton";
            this.enregistrerButton.Size = new System.Drawing.Size(182, 92);
            this.enregistrerButton.TabIndex = 4;
            this.enregistrerButton.Text = "&Enregistrer";
            this.enregistrerButton.UseVisualStyleBackColor = true;
            // 
            // quitterButton
            // 
            this.quitterButton.Location = new System.Drawing.Point(639, 496);
            this.quitterButton.Name = "quitterButton";
            this.quitterButton.Size = new System.Drawing.Size(182, 92);
            this.quitterButton.TabIndex = 5;
            this.quitterButton.Text = "&Quitter";
            this.quitterButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 611);
            this.Controls.Add(this.quitterButton);
            this.Controls.Add(this.enregistrerButton);
            this.Controls.Add(this.transactionGroupBox);
            this.Controls.Add(this.clientGroupBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.venteMenuMenuStrip);
            this.MainMenuStrip = this.venteMenuMenuStrip;
            this.Name = "Form1";
            this.Text = "Ventes de voitures";
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
        private System.Windows.Forms.ComboBox marquecomboBox;
        private System.Windows.Forms.ComboBox typeVoitureComboBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox adresseTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.TextBox codePostalTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Label marquelabel;
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
    }
}

