namespace Projet
{
    partial class frmAppli
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
            this.lblDateDep = new System.Windows.Forms.Label();
            this.tabcTransaction = new System.Windows.Forms.TabControl();
            this.tabAjoutTransac = new System.Windows.Forms.TabPage();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAjoutType = new System.Windows.Forms.Button();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.rdbPercu = new System.Windows.Forms.CheckBox();
            this.rdbRecette = new System.Windows.Forms.CheckBox();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tab1a12 = new System.Windows.Forms.TabPage();
            this.tabSupTransac = new System.Windows.Forms.TabPage();
            this.tabModifTransac = new System.Windows.Forms.TabPage();
            this.tabRécap = new System.Windows.Forms.TabPage();
            this.tabPerso = new System.Windows.Forms.TabPage();
            this.tabcTransaction.SuspendLayout();
            this.tabAjoutTransac.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDateDep
            // 
            this.lblDateDep.AutoSize = true;
            this.lblDateDep.Location = new System.Drawing.Point(22, 22);
            this.lblDateDep.Name = "lblDateDep";
            this.lblDateDep.Size = new System.Drawing.Size(100, 13);
            this.lblDateDep.TabIndex = 0;
            this.lblDateDep.Text = "Date de la dépense";
            // 
            // tabcTransaction
            // 
            this.tabcTransaction.Controls.Add(this.tabAjoutTransac);
            this.tabcTransaction.Controls.Add(this.tab1a12);
            this.tabcTransaction.Controls.Add(this.tabSupTransac);
            this.tabcTransaction.Controls.Add(this.tabModifTransac);
            this.tabcTransaction.Controls.Add(this.tabRécap);
            this.tabcTransaction.Controls.Add(this.tabPerso);
            this.tabcTransaction.Location = new System.Drawing.Point(12, 12);
            this.tabcTransaction.Name = "tabcTransaction";
            this.tabcTransaction.SelectedIndex = 0;
            this.tabcTransaction.Size = new System.Drawing.Size(716, 388);
            this.tabcTransaction.TabIndex = 1;
            // 
            // tabAjoutTransac
            // 
            this.tabAjoutTransac.Controls.Add(this.dtpDate);
            this.tabAjoutTransac.Controls.Add(this.btnAjouter);
            this.tabAjoutTransac.Controls.Add(this.btnAjoutType);
            this.tabAjoutTransac.Controls.Add(this.cboType);
            this.tabAjoutTransac.Controls.Add(this.lblType);
            this.tabAjoutTransac.Controls.Add(this.rdbPercu);
            this.tabAjoutTransac.Controls.Add(this.rdbRecette);
            this.tabAjoutTransac.Controls.Add(this.txtMontant);
            this.tabAjoutTransac.Controls.Add(this.txtDescription);
            this.tabAjoutTransac.Controls.Add(this.lblMontant);
            this.tabAjoutTransac.Controls.Add(this.lblDescription);
            this.tabAjoutTransac.Controls.Add(this.lblDateDep);
            this.tabAjoutTransac.Location = new System.Drawing.Point(4, 22);
            this.tabAjoutTransac.Name = "tabAjoutTransac";
            this.tabAjoutTransac.Padding = new System.Windows.Forms.Padding(3);
            this.tabAjoutTransac.Size = new System.Drawing.Size(708, 362);
            this.tabAjoutTransac.TabIndex = 0;
            this.tabAjoutTransac.Text = "Ajout d\'une transaction";
            this.tabAjoutTransac.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd\'/\'MM\'/\'yyyy";
            this.dtpDate.Location = new System.Drawing.Point(151, 16);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 12;
            this.dtpDate.Value = new System.DateTime(2017, 5, 29, 16, 50, 30, 0);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(151, 220);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(121, 70);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAjoutType
            // 
            this.btnAjoutType.Location = new System.Drawing.Point(301, 167);
            this.btnAjoutType.Name = "btnAjoutType";
            this.btnAjoutType.Size = new System.Drawing.Size(31, 21);
            this.btnAjoutType.TabIndex = 10;
            this.btnAjoutType.Text = "...";
            this.btnAjoutType.UseVisualStyleBackColor = true;
            this.btnAjoutType.Click += new System.EventHandler(this.btnAjoutType_Click);
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(151, 167);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 21);
            this.cboType.TabIndex = 9;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(22, 170);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type";
            // 
            // rdbPercu
            // 
            this.rdbPercu.AutoSize = true;
            this.rdbPercu.Location = new System.Drawing.Point(151, 129);
            this.rdbPercu.Name = "rdbPercu";
            this.rdbPercu.Size = new System.Drawing.Size(54, 17);
            this.rdbPercu.TabIndex = 7;
            this.rdbPercu.Text = "Perçu";
            this.rdbPercu.UseVisualStyleBackColor = true;
            // 
            // rdbRecette
            // 
            this.rdbRecette.AutoSize = true;
            this.rdbRecette.Location = new System.Drawing.Point(25, 129);
            this.rdbRecette.Name = "rdbRecette";
            this.rdbRecette.Size = new System.Drawing.Size(64, 17);
            this.rdbRecette.TabIndex = 6;
            this.rdbRecette.Text = "Recette";
            this.rdbRecette.UseVisualStyleBackColor = true;
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(151, 86);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(121, 20);
            this.txtMontant.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(151, 52);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(121, 20);
            this.txtDescription.TabIndex = 4;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(22, 93);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(46, 13);
            this.lblMontant.TabIndex = 3;
            this.lblMontant.Text = "Montant";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(22, 59);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // tab1a12
            // 
            this.tab1a12.Location = new System.Drawing.Point(4, 22);
            this.tab1a12.Name = "tab1a12";
            this.tab1a12.Padding = new System.Windows.Forms.Padding(3);
            this.tab1a12.Size = new System.Drawing.Size(708, 362);
            this.tab1a12.TabIndex = 1;
            this.tab1a12.Text = "Affichage 1 à 1";
            this.tab1a12.UseVisualStyleBackColor = true;
            // 
            // tabSupTransac
            // 
            this.tabSupTransac.Location = new System.Drawing.Point(4, 22);
            this.tabSupTransac.Name = "tabSupTransac";
            this.tabSupTransac.Size = new System.Drawing.Size(708, 362);
            this.tabSupTransac.TabIndex = 2;
            this.tabSupTransac.Text = "Suppression d\'une transaction";
            this.tabSupTransac.UseVisualStyleBackColor = true;
            // 
            // tabModifTransac
            // 
            this.tabModifTransac.Location = new System.Drawing.Point(4, 22);
            this.tabModifTransac.Name = "tabModifTransac";
            this.tabModifTransac.Size = new System.Drawing.Size(708, 362);
            this.tabModifTransac.TabIndex = 3;
            this.tabModifTransac.Text = "Modification d\'une transaction";
            this.tabModifTransac.UseVisualStyleBackColor = true;
            // 
            // tabRécap
            // 
            this.tabRécap.Location = new System.Drawing.Point(4, 22);
            this.tabRécap.Name = "tabRécap";
            this.tabRécap.Size = new System.Drawing.Size(708, 362);
            this.tabRécap.TabIndex = 4;
            this.tabRécap.Text = "Récapiltulatif";
            this.tabRécap.UseVisualStyleBackColor = true;
            // 
            // tabPerso
            // 
            this.tabPerso.Location = new System.Drawing.Point(4, 22);
            this.tabPerso.Name = "tabPerso";
            this.tabPerso.Size = new System.Drawing.Size(708, 362);
            this.tabPerso.TabIndex = 5;
            this.tabPerso.Text = "Gestion des personnes";
            this.tabPerso.UseVisualStyleBackColor = true;
            // 
            // frmAppli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 412);
            this.Controls.Add(this.tabcTransaction);
            this.Name = "frmAppli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vif Argent";
            this.Load += new System.EventHandler(this.frmAppli_Load);
            this.tabcTransaction.ResumeLayout(false);
            this.tabAjoutTransac.ResumeLayout(false);
            this.tabAjoutTransac.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDateDep;
        private System.Windows.Forms.TabControl tabcTransaction;
        private System.Windows.Forms.TabPage tabAjoutTransac;
        private System.Windows.Forms.TabPage tab1a12;
        private System.Windows.Forms.TabPage tabSupTransac;
        private System.Windows.Forms.TabPage tabModifTransac;
        private System.Windows.Forms.TabPage tabRécap;
        private System.Windows.Forms.TabPage tabPerso;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAjoutType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.CheckBox rdbPercu;
        private System.Windows.Forms.CheckBox rdbRecette;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}

