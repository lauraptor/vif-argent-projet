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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppli));
            this.lblDateDep = new System.Windows.Forms.Label();
            this.tabcTransaction = new System.Windows.Forms.TabControl();
            this.tabAjoutTransac = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.clbPersonne = new System.Windows.Forms.CheckedListBox();
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
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.lboPersonne = new System.Windows.Forms.ListBox();
            this.cboxRecette = new System.Windows.Forms.CheckBox();
            this.cboxPercue = new System.Windows.Forms.CheckBox();
            this.lblCout = new System.Windows.Forms.Label();
            this.lblDescri = new System.Windows.Forms.Label();
            this.lblType1 = new System.Windows.Forms.Label();
            this.lblCodeType = new System.Windows.Forms.Label();
            this.labelTpe = new System.Windows.Forms.Label();
            this.cboDateTransac = new System.Windows.Forms.ComboBox();
            this.tabSupTransac = new System.Windows.Forms.TabPage();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCodeSupr = new System.Windows.Forms.Label();
            this.dtgSupprimer = new System.Windows.Forms.DataGridView();
            this.tabModifTransac = new System.Windows.Forms.TabPage();
            this.dtgModif = new System.Windows.Forms.DataGridView();
            this.tabRécap = new System.Windows.Forms.TabPage();
            this.dgvRecap = new System.Windows.Forms.DataGridView();
            this.btnRecapRaz = new System.Windows.Forms.Button();
            this.btnRecapRecherche = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbRecapEgal = new System.Windows.Forms.RadioButton();
            this.rdbRecapSup = new System.Windows.Forms.RadioButton();
            this.rdbRecapInf = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbRecapEntrant = new System.Windows.Forms.RadioButton();
            this.rdbRecapSortant = new System.Windows.Forms.RadioButton();
            this.dtpRecapSup = new System.Windows.Forms.DateTimePicker();
            this.dtpRecapInf = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRecapPercu = new System.Windows.Forms.CheckBox();
            this.txtRecapLib = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecapMontant = new System.Windows.Forms.TextBox();
            this.tabPerso = new System.Windows.Forms.TabPage();
            this.btnAjoutPersonne = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBudgetPre = new System.Windows.Forms.Button();
            this.tabcTransaction.SuspendLayout();
            this.tabAjoutTransac.SuspendLayout();
            this.tab1a12.SuspendLayout();
            this.tabSupTransac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSupprimer)).BeginInit();
            this.tabModifTransac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgModif)).BeginInit();
            this.tabRécap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecap)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPerso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
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
            this.tabcTransaction.Size = new System.Drawing.Size(716, 412);
            this.tabcTransaction.TabIndex = 1;
            // 
            // tabAjoutTransac
            // 
            this.tabAjoutTransac.Controls.Add(this.label1);
            this.tabAjoutTransac.Controls.Add(this.clbPersonne);
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
            this.tabAjoutTransac.Size = new System.Drawing.Size(708, 386);
            this.tabAjoutTransac.TabIndex = 0;
            this.tabAjoutTransac.Text = "Ajout d\'une transaction";
            this.tabAjoutTransac.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sélection personne";
            // 
            // clbPersonne
            // 
            this.clbPersonne.FormattingEnabled = true;
            this.clbPersonne.Location = new System.Drawing.Point(420, 53);
            this.clbPersonne.Name = "clbPersonne";
            this.clbPersonne.Size = new System.Drawing.Size(224, 139);
            this.clbPersonne.TabIndex = 13;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(151, 16);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(121, 20);
            this.dtpDate.TabIndex = 12;
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
            this.txtMontant.MaxLength = 7;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(121, 20);
            this.txtMontant.TabIndex = 5;
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontant_KeyPress);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(151, 52);
            this.txtDescription.MaxLength = 30;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(121, 20);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescription_KeyPress);
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
            this.tab1a12.Controls.Add(this.btnDernier);
            this.tab1a12.Controls.Add(this.btnSuivant);
            this.tab1a12.Controls.Add(this.btnPrecedent);
            this.tab1a12.Controls.Add(this.btnPremier);
            this.tab1a12.Controls.Add(this.lboPersonne);
            this.tab1a12.Controls.Add(this.cboxRecette);
            this.tab1a12.Controls.Add(this.cboxPercue);
            this.tab1a12.Controls.Add(this.lblCout);
            this.tab1a12.Controls.Add(this.lblDescri);
            this.tab1a12.Controls.Add(this.lblType1);
            this.tab1a12.Controls.Add(this.lblCodeType);
            this.tab1a12.Controls.Add(this.labelTpe);
            this.tab1a12.Controls.Add(this.cboDateTransac);
            this.tab1a12.Location = new System.Drawing.Point(4, 22);
            this.tab1a12.Name = "tab1a12";
            this.tab1a12.Padding = new System.Windows.Forms.Padding(3);
            this.tab1a12.Size = new System.Drawing.Size(708, 386);
            this.tab1a12.TabIndex = 1;
            this.tab1a12.Text = "Affichage 1 à 1";
            this.tab1a12.UseVisualStyleBackColor = true;
            this.tab1a12.Enter += new System.EventHandler(this.tab1a12_Enter);
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(464, 353);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(145, 23);
            this.btnDernier.TabIndex = 25;
            this.btnDernier.Text = ">>";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(343, 353);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(115, 23);
            this.btnSuivant.TabIndex = 24;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(216, 353);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(121, 23);
            this.btnPrecedent.TabIndex = 23;
            this.btnPrecedent.Text = "<";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(90, 353);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(120, 23);
            this.btnPremier.TabIndex = 22;
            this.btnPremier.Text = "<<";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // lboPersonne
            // 
            this.lboPersonne.FormattingEnabled = true;
            this.lboPersonne.Location = new System.Drawing.Point(90, 165);
            this.lboPersonne.Name = "lboPersonne";
            this.lboPersonne.Size = new System.Drawing.Size(517, 147);
            this.lboPersonne.TabIndex = 21;
            // 
            // cboxRecette
            // 
            this.cboxRecette.AutoSize = true;
            this.cboxRecette.Enabled = false;
            this.cboxRecette.Location = new System.Drawing.Point(464, 131);
            this.cboxRecette.Name = "cboxRecette";
            this.cboxRecette.Size = new System.Drawing.Size(64, 17);
            this.cboxRecette.TabIndex = 20;
            this.cboxRecette.Text = "Recette";
            this.cboxRecette.UseVisualStyleBackColor = true;
            // 
            // cboxPercue
            // 
            this.cboxPercue.AutoSize = true;
            this.cboxPercue.BackColor = System.Drawing.Color.White;
            this.cboxPercue.Enabled = false;
            this.cboxPercue.Location = new System.Drawing.Point(464, 89);
            this.cboxPercue.Name = "cboxPercue";
            this.cboxPercue.Size = new System.Drawing.Size(60, 17);
            this.cboxPercue.TabIndex = 19;
            this.cboxPercue.Text = "Perçue";
            this.cboxPercue.UseVisualStyleBackColor = false;
            // 
            // lblCout
            // 
            this.lblCout.AutoSize = true;
            this.lblCout.Location = new System.Drawing.Point(397, 90);
            this.lblCout.Name = "lblCout";
            this.lblCout.Size = new System.Drawing.Size(35, 13);
            this.lblCout.TabIndex = 18;
            this.lblCout.Text = "label5";
            // 
            // lblDescri
            // 
            this.lblDescri.AutoSize = true;
            this.lblDescri.Location = new System.Drawing.Point(93, 131);
            this.lblDescri.Name = "lblDescri";
            this.lblDescri.Size = new System.Drawing.Size(35, 13);
            this.lblDescri.TabIndex = 17;
            this.lblDescri.Text = "label4";
            // 
            // lblType1
            // 
            this.lblType1.AutoSize = true;
            this.lblType1.Location = new System.Drawing.Point(93, 93);
            this.lblType1.Name = "lblType1";
            this.lblType1.Size = new System.Drawing.Size(35, 13);
            this.lblType1.TabIndex = 16;
            this.lblType1.Text = "label3";
            // 
            // lblCodeType
            // 
            this.lblCodeType.AutoSize = true;
            this.lblCodeType.Location = new System.Drawing.Point(93, 57);
            this.lblCodeType.Name = "lblCodeType";
            this.lblCodeType.Size = new System.Drawing.Size(35, 13);
            this.lblCodeType.TabIndex = 15;
            this.lblCodeType.Text = "label2";
            // 
            // labelTpe
            // 
            this.labelTpe.AutoSize = true;
            this.labelTpe.Location = new System.Drawing.Point(87, 70);
            this.labelTpe.Name = "labelTpe";
            this.labelTpe.Size = new System.Drawing.Size(0, 13);
            this.labelTpe.TabIndex = 14;
            // 
            // cboDateTransac
            // 
            this.cboDateTransac.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cboDateTransac.FormattingEnabled = true;
            this.cboDateTransac.Location = new System.Drawing.Point(464, 18);
            this.cboDateTransac.Name = "cboDateTransac";
            this.cboDateTransac.Size = new System.Drawing.Size(121, 21);
            this.cboDateTransac.TabIndex = 13;
            // 
            // tabSupTransac
            // 
            this.tabSupTransac.Controls.Add(this.btnSupprimer);
            this.tabSupTransac.Controls.Add(this.txtCode);
            this.tabSupTransac.Controls.Add(this.lblCodeSupr);
            this.tabSupTransac.Controls.Add(this.dtgSupprimer);
            this.tabSupTransac.Location = new System.Drawing.Point(4, 22);
            this.tabSupTransac.Name = "tabSupTransac";
            this.tabSupTransac.Size = new System.Drawing.Size(708, 386);
            this.tabSupTransac.TabIndex = 2;
            this.tabSupTransac.Text = "Suppression d\'une transaction";
            this.tabSupTransac.UseVisualStyleBackColor = true;
            this.tabSupTransac.Enter += new System.EventHandler(this.tabSupTransac_Enter);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(331, 328);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(238, 330);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(36, 20);
            this.txtCode.TabIndex = 6;
            // 
            // lblCodeSupr
            // 
            this.lblCodeSupr.AutoSize = true;
            this.lblCodeSupr.Location = new System.Drawing.Point(48, 333);
            this.lblCodeSupr.Name = "lblCodeSupr";
            this.lblCodeSupr.Size = new System.Drawing.Size(175, 13);
            this.lblCodeSupr.TabIndex = 5;
            this.lblCodeSupr.Text = "Code de la transactions à supprimer";
            // 
            // dtgSupprimer
            // 
            this.dtgSupprimer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSupprimer.Location = new System.Drawing.Point(3, 3);
            this.dtgSupprimer.Name = "dtgSupprimer";
            this.dtgSupprimer.ReadOnly = true;
            this.dtgSupprimer.Size = new System.Drawing.Size(702, 282);
            this.dtgSupprimer.TabIndex = 4;
            // 
            // tabModifTransac
            // 
            this.tabModifTransac.Controls.Add(this.dtgModif);
            this.tabModifTransac.Location = new System.Drawing.Point(4, 22);
            this.tabModifTransac.Name = "tabModifTransac";
            this.tabModifTransac.Size = new System.Drawing.Size(708, 386);
            this.tabModifTransac.TabIndex = 3;
            this.tabModifTransac.Text = "Modification d\'une transaction";
            this.tabModifTransac.UseVisualStyleBackColor = true;
            // 
            // dtgModif
            // 
            this.dtgModif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgModif.Location = new System.Drawing.Point(3, 3);
            this.dtgModif.Name = "dtgModif";
            this.dtgModif.Size = new System.Drawing.Size(702, 272);
            this.dtgModif.TabIndex = 1;
            // 
            // tabRécap
            // 
            this.tabRécap.Controls.Add(this.dgvRecap);
            this.tabRécap.Controls.Add(this.btnRecapRaz);
            this.tabRécap.Controls.Add(this.btnRecapRecherche);
            this.tabRécap.Controls.Add(this.panel2);
            this.tabRécap.Controls.Add(this.panel1);
            this.tabRécap.Controls.Add(this.dtpRecapSup);
            this.tabRécap.Controls.Add(this.dtpRecapInf);
            this.tabRécap.Controls.Add(this.label4);
            this.tabRécap.Controls.Add(this.cbRecapPercu);
            this.tabRécap.Controls.Add(this.txtRecapLib);
            this.tabRécap.Controls.Add(this.label3);
            this.tabRécap.Controls.Add(this.label2);
            this.tabRécap.Controls.Add(this.txtRecapMontant);
            this.tabRécap.Location = new System.Drawing.Point(4, 22);
            this.tabRécap.Name = "tabRécap";
            this.tabRécap.Size = new System.Drawing.Size(708, 386);
            this.tabRécap.TabIndex = 4;
            this.tabRécap.Text = "Récapiltulatif";
            this.tabRécap.UseVisualStyleBackColor = true;
            // 
            // dgvRecap
            // 
            this.dgvRecap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecap.Location = new System.Drawing.Point(3, 102);
            this.dgvRecap.Name = "dgvRecap";
            this.dgvRecap.ReadOnly = true;
            this.dgvRecap.Size = new System.Drawing.Size(698, 281);
            this.dgvRecap.TabIndex = 31;
            // 
            // btnRecapRaz
            // 
            this.btnRecapRaz.Location = new System.Drawing.Point(583, 69);
            this.btnRecapRaz.Name = "btnRecapRaz";
            this.btnRecapRaz.Size = new System.Drawing.Size(118, 23);
            this.btnRecapRaz.TabIndex = 30;
            this.btnRecapRaz.Text = "Effacer les filtres";
            this.btnRecapRaz.UseVisualStyleBackColor = true;
            this.btnRecapRaz.Click += new System.EventHandler(this.btnRecapRaz_Click);
            // 
            // btnRecapRecherche
            // 
            this.btnRecapRecherche.Location = new System.Drawing.Point(583, 29);
            this.btnRecapRecherche.Name = "btnRecapRecherche";
            this.btnRecapRecherche.Size = new System.Drawing.Size(118, 23);
            this.btnRecapRecherche.TabIndex = 29;
            this.btnRecapRecherche.Text = "Rechercher";
            this.btnRecapRecherche.UseVisualStyleBackColor = true;
            this.btnRecapRecherche.Click += new System.EventHandler(this.btnRecapRecherche_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbRecapEgal);
            this.panel2.Controls.Add(this.rdbRecapSup);
            this.panel2.Controls.Add(this.rdbRecapInf);
            this.panel2.Location = new System.Drawing.Point(2, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 23);
            this.panel2.TabIndex = 28;
            // 
            // rdbRecapEgal
            // 
            this.rdbRecapEgal.AutoSize = true;
            this.rdbRecapEgal.Location = new System.Drawing.Point(40, 3);
            this.rdbRecapEgal.Name = "rdbRecapEgal";
            this.rdbRecapEgal.Size = new System.Drawing.Size(31, 17);
            this.rdbRecapEgal.TabIndex = 16;
            this.rdbRecapEgal.TabStop = true;
            this.rdbRecapEgal.Text = "=";
            this.rdbRecapEgal.UseVisualStyleBackColor = true;
            // 
            // rdbRecapSup
            // 
            this.rdbRecapSup.AutoSize = true;
            this.rdbRecapSup.Location = new System.Drawing.Point(77, 3);
            this.rdbRecapSup.Name = "rdbRecapSup";
            this.rdbRecapSup.Size = new System.Drawing.Size(31, 17);
            this.rdbRecapSup.TabIndex = 15;
            this.rdbRecapSup.TabStop = true;
            this.rdbRecapSup.Text = ">";
            this.rdbRecapSup.UseVisualStyleBackColor = true;
            // 
            // rdbRecapInf
            // 
            this.rdbRecapInf.AutoSize = true;
            this.rdbRecapInf.Location = new System.Drawing.Point(3, 3);
            this.rdbRecapInf.Name = "rdbRecapInf";
            this.rdbRecapInf.Size = new System.Drawing.Size(31, 17);
            this.rdbRecapInf.TabIndex = 14;
            this.rdbRecapInf.TabStop = true;
            this.rdbRecapInf.Text = "<";
            this.rdbRecapInf.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbRecapEntrant);
            this.panel1.Controls.Add(this.rdbRecapSortant);
            this.panel1.Location = new System.Drawing.Point(194, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 24);
            this.panel1.TabIndex = 27;
            // 
            // rdbRecapEntrant
            // 
            this.rdbRecapEntrant.AutoSize = true;
            this.rdbRecapEntrant.Location = new System.Drawing.Point(3, 3);
            this.rdbRecapEntrant.Name = "rdbRecapEntrant";
            this.rdbRecapEntrant.Size = new System.Drawing.Size(59, 17);
            this.rdbRecapEntrant.TabIndex = 7;
            this.rdbRecapEntrant.TabStop = true;
            this.rdbRecapEntrant.Text = "Entrant";
            this.rdbRecapEntrant.UseVisualStyleBackColor = true;
            // 
            // rdbRecapSortant
            // 
            this.rdbRecapSortant.AutoSize = true;
            this.rdbRecapSortant.Location = new System.Drawing.Point(68, 3);
            this.rdbRecapSortant.Name = "rdbRecapSortant";
            this.rdbRecapSortant.Size = new System.Drawing.Size(59, 17);
            this.rdbRecapSortant.TabIndex = 8;
            this.rdbRecapSortant.TabStop = true;
            this.rdbRecapSortant.Text = "Sortant";
            this.rdbRecapSortant.UseVisualStyleBackColor = true;
            // 
            // dtpRecapSup
            // 
            this.dtpRecapSup.Location = new System.Drawing.Point(332, 32);
            this.dtpRecapSup.Name = "dtpRecapSup";
            this.dtpRecapSup.Size = new System.Drawing.Size(200, 20);
            this.dtpRecapSup.TabIndex = 26;
            // 
            // dtpRecapInf
            // 
            this.dtpRecapInf.Location = new System.Drawing.Point(126, 32);
            this.dtpRecapInf.Name = "dtpRecapInf";
            this.dtpRecapInf.Size = new System.Drawing.Size(200, 20);
            this.dtpRecapInf.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Dates";
            // 
            // cbRecapPercu
            // 
            this.cbRecapPercu.AutoSize = true;
            this.cbRecapPercu.Location = new System.Drawing.Point(126, 77);
            this.cbRecapPercu.Name = "cbRecapPercu";
            this.cbRecapPercu.Size = new System.Drawing.Size(54, 17);
            this.cbRecapPercu.TabIndex = 23;
            this.cbRecapPercu.Text = "Perçu";
            this.cbRecapPercu.UseVisualStyleBackColor = true;
            // 
            // txtRecapLib
            // 
            this.txtRecapLib.Location = new System.Drawing.Point(332, 74);
            this.txtRecapLib.Name = "txtRecapLib";
            this.txtRecapLib.Size = new System.Drawing.Size(200, 20);
            this.txtRecapLib.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Libellé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Montant";
            // 
            // txtRecapMontant
            // 
            this.txtRecapMontant.Location = new System.Drawing.Point(2, 32);
            this.txtRecapMontant.Name = "txtRecapMontant";
            this.txtRecapMontant.Size = new System.Drawing.Size(100, 20);
            this.txtRecapMontant.TabIndex = 19;
            // 
            // tabPerso
            // 
            this.tabPerso.Controls.Add(this.btnAjoutPersonne);
            this.tabPerso.Controls.Add(this.txtTel);
            this.tabPerso.Controls.Add(this.txtPrenom);
            this.tabPerso.Controls.Add(this.txtNom);
            this.tabPerso.Controls.Add(this.lblTitre);
            this.tabPerso.Controls.Add(this.lblTel);
            this.tabPerso.Controls.Add(this.lblNom);
            this.tabPerso.Controls.Add(this.lblPrenom);
            this.tabPerso.Location = new System.Drawing.Point(4, 22);
            this.tabPerso.Name = "tabPerso";
            this.tabPerso.Size = new System.Drawing.Size(708, 386);
            this.tabPerso.TabIndex = 5;
            this.tabPerso.Text = "Gestion des personnes";
            this.tabPerso.UseVisualStyleBackColor = true;
            // 
            // btnAjoutPersonne
            // 
            this.btnAjoutPersonne.Location = new System.Drawing.Point(555, 336);
            this.btnAjoutPersonne.Name = "btnAjoutPersonne";
            this.btnAjoutPersonne.Size = new System.Drawing.Size(133, 39);
            this.btnAjoutPersonne.TabIndex = 14;
            this.btnAjoutPersonne.Text = "Ajout de la personne";
            this.btnAjoutPersonne.UseVisualStyleBackColor = true;
            this.btnAjoutPersonne.Click += new System.EventHandler(this.btnAjoutPersonne_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(287, 219);
            this.txtTel.MaxLength = 12;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(249, 20);
            this.txtTel.TabIndex = 13;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(287, 159);
            this.txtPrenom.MaxLength = 20;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(249, 20);
            this.txtPrenom.TabIndex = 12;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(287, 100);
            this.txtNom.MaxLength = 30;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(249, 20);
            this.txtNom.TabIndex = 11;
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(213, 30);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(249, 20);
            this.lblTitre.TabIndex = 10;
            this.lblTitre.Text = "Formulaire d\'ajout d\'une personne";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(92, 220);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(80, 16);
            this.lblTel.TabIndex = 9;
            this.lblTel.Text = "Téléphone :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(92, 101);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(43, 16);
            this.lblNom.TabIndex = 8;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(92, 160);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(61, 16);
            this.lblPrenom.TabIndex = 7;
            this.lblPrenom.Text = "Prénom :";
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // btnBudgetPre
            // 
            this.btnBudgetPre.Location = new System.Drawing.Point(12, 430);
            this.btnBudgetPre.Name = "btnBudgetPre";
            this.btnBudgetPre.Size = new System.Drawing.Size(716, 25);
            this.btnBudgetPre.TabIndex = 2;
            this.btnBudgetPre.Text = "Passer au budget prévisionnel";
            this.btnBudgetPre.UseVisualStyleBackColor = true;
            this.btnBudgetPre.Click += new System.EventHandler(this.btnBudgetPre_Click);
            // 
            // frmAppli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 462);
            this.Controls.Add(this.btnBudgetPre);
            this.Controls.Add(this.tabcTransaction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAppli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vif Argent";
            this.Activated += new System.EventHandler(this.frmAppli_Load);
            this.Load += new System.EventHandler(this.frmAppli_Load);
            this.tabcTransaction.ResumeLayout(false);
            this.tabAjoutTransac.ResumeLayout(false);
            this.tabAjoutTransac.PerformLayout();
            this.tab1a12.ResumeLayout(false);
            this.tab1a12.PerformLayout();
            this.tabSupTransac.ResumeLayout(false);
            this.tabSupTransac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSupprimer)).EndInit();
            this.tabModifTransac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgModif)).EndInit();
            this.tabRécap.ResumeLayout(false);
            this.tabRécap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPerso.ResumeLayout(false);
            this.tabPerso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
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
        private System.Windows.Forms.CheckedListBox clbPersonne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Button btnAjoutPersonne;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button btnBudgetPre;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.ListBox lboPersonne;
        private System.Windows.Forms.CheckBox cboxRecette;
        private System.Windows.Forms.CheckBox cboxPercue;
        private System.Windows.Forms.Label lblCout;
        private System.Windows.Forms.Label lblDescri;
        private System.Windows.Forms.Label lblType1;
        private System.Windows.Forms.Label lblCodeType;
        private System.Windows.Forms.Label labelTpe;
        private System.Windows.Forms.ComboBox cboDateTransac;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCodeSupr;
        private System.Windows.Forms.DataGridView dtgSupprimer;
        private System.Windows.Forms.DataGridView dtgModif;
        private System.Windows.Forms.DataGridView dgvRecap;
        private System.Windows.Forms.Button btnRecapRaz;
        private System.Windows.Forms.Button btnRecapRecherche;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbRecapEgal;
        private System.Windows.Forms.RadioButton rdbRecapSup;
        private System.Windows.Forms.RadioButton rdbRecapInf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbRecapEntrant;
        private System.Windows.Forms.RadioButton rdbRecapSortant;
        private System.Windows.Forms.DateTimePicker dtpRecapSup;
        private System.Windows.Forms.DateTimePicker dtpRecapInf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbRecapPercu;
        private System.Windows.Forms.TextBox txtRecapLib;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRecapMontant;
    }
}

