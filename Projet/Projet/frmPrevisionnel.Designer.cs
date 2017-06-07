namespace Projet
{
    partial class frmPrevisionnel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrevisionnel));
            this.tabcPrevision = new System.Windows.Forms.TabControl();
            this.tabPosteFixe = new System.Windows.Forms.TabPage();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.txtJour = new System.Windows.Forms.TextBox();
            this.cboPeriode = new System.Windows.Forms.ComboBox();
            this.cboPoste = new System.Windows.Forms.ComboBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblJour = new System.Windows.Forms.Label();
            this.lblPeriodicite = new System.Windows.Forms.Label();
            this.lblPoste = new System.Windows.Forms.Label();
            this.tabPostePonctuel = new System.Windows.Forms.TabPage();
            this.btnPonctuel = new System.Windows.Forms.Button();
            this.grpEcheance = new System.Windows.Forms.GroupBox();
            this.txtPrelevement = new System.Windows.Forms.TextBox();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.txtIntitule = new System.Windows.Forms.TextBox();
            this.lblPrelevement = new System.Windows.Forms.Label();
            this.lblCom = new System.Windows.Forms.Label();
            this.lblIntitule = new System.Windows.Forms.Label();
            this.tabRevenu = new System.Windows.Forms.TabPage();
            this.txtJourDuMois = new System.Windows.Forms.TextBox();
            this.txtMontantRev = new System.Windows.Forms.TextBox();
            this.txtPosteRev = new System.Windows.Forms.TextBox();
            this.lblJourDuMois = new System.Windows.Forms.Label();
            this.lblMontantRev = new System.Windows.Forms.Label();
            this.lblBenef = new System.Windows.Forms.Label();
            this.lblPosteRev = new System.Windows.Forms.Label();
            this.cboBenef = new System.Windows.Forms.ComboBox();
            this.tabcPrevision.SuspendLayout();
            this.tabPosteFixe.SuspendLayout();
            this.tabPostePonctuel.SuspendLayout();
            this.tabRevenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcPrevision
            // 
            this.tabcPrevision.Controls.Add(this.tabPosteFixe);
            this.tabcPrevision.Controls.Add(this.tabPostePonctuel);
            this.tabcPrevision.Controls.Add(this.tabRevenu);
            this.tabcPrevision.Location = new System.Drawing.Point(8, 12);
            this.tabcPrevision.Name = "tabcPrevision";
            this.tabcPrevision.SelectedIndex = 0;
            this.tabcPrevision.Size = new System.Drawing.Size(660, 446);
            this.tabcPrevision.TabIndex = 0;
            // 
            // tabPosteFixe
            // 
            this.tabPosteFixe.Controls.Add(this.btnNouveau);
            this.tabPosteFixe.Controls.Add(this.txtJour);
            this.tabPosteFixe.Controls.Add(this.cboPeriode);
            this.tabPosteFixe.Controls.Add(this.cboPoste);
            this.tabPosteFixe.Controls.Add(this.btnValider);
            this.tabPosteFixe.Controls.Add(this.txtMontant);
            this.tabPosteFixe.Controls.Add(this.lblMontant);
            this.tabPosteFixe.Controls.Add(this.lblJour);
            this.tabPosteFixe.Controls.Add(this.lblPeriodicite);
            this.tabPosteFixe.Controls.Add(this.lblPoste);
            this.tabPosteFixe.Location = new System.Drawing.Point(4, 22);
            this.tabPosteFixe.Name = "tabPosteFixe";
            this.tabPosteFixe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPosteFixe.Size = new System.Drawing.Size(652, 420);
            this.tabPosteFixe.TabIndex = 0;
            this.tabPosteFixe.Text = "Poste Fixe";
            this.tabPosteFixe.UseVisualStyleBackColor = true;
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(498, 27);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(69, 21);
            this.btnNouveau.TabIndex = 9;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // txtJour
            // 
            this.txtJour.Location = new System.Drawing.Point(186, 146);
            this.txtJour.Name = "txtJour";
            this.txtJour.Size = new System.Drawing.Size(36, 20);
            this.txtJour.TabIndex = 8;
            this.txtJour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJour_KeyPress);
            // 
            // cboPeriode
            // 
            this.cboPeriode.FormattingEnabled = true;
            this.cboPeriode.Location = new System.Drawing.Point(186, 88);
            this.cboPeriode.Name = "cboPeriode";
            this.cboPeriode.Size = new System.Drawing.Size(220, 21);
            this.cboPeriode.TabIndex = 7;
            // 
            // cboPoste
            // 
            this.cboPoste.FormattingEnabled = true;
            this.cboPoste.Location = new System.Drawing.Point(186, 27);
            this.cboPoste.Name = "cboPoste";
            this.cboPoste.Size = new System.Drawing.Size(220, 21);
            this.cboPoste.TabIndex = 6;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(442, 342);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(173, 34);
            this.btnValider.TabIndex = 5;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(186, 206);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(96, 20);
            this.txtMontant.TabIndex = 4;
            this.txtMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontant_KeyPress);
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Location = new System.Drawing.Point(40, 209);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(55, 13);
            this.lblMontant.TabIndex = 3;
            this.lblMontant.Text = "Montant ?";
            // 
            // lblJour
            // 
            this.lblJour.AutoSize = true;
            this.lblJour.Location = new System.Drawing.Point(40, 149);
            this.lblJour.Name = "lblJour";
            this.lblJour.Size = new System.Drawing.Size(75, 13);
            this.lblJour.TabIndex = 2;
            this.lblJour.Text = "Jour du mois ?";
            // 
            // lblPeriodicite
            // 
            this.lblPeriodicite.AutoSize = true;
            this.lblPeriodicite.Location = new System.Drawing.Point(40, 91);
            this.lblPeriodicite.Name = "lblPeriodicite";
            this.lblPeriodicite.Size = new System.Drawing.Size(56, 13);
            this.lblPeriodicite.TabIndex = 1;
            this.lblPeriodicite.Text = "Périodicité";
            // 
            // lblPoste
            // 
            this.lblPoste.AutoSize = true;
            this.lblPoste.Location = new System.Drawing.Point(40, 30);
            this.lblPoste.Name = "lblPoste";
            this.lblPoste.Size = new System.Drawing.Size(67, 13);
            this.lblPoste.TabIndex = 0;
            this.lblPoste.Text = "Quel poste ?";
            // 
            // tabPostePonctuel
            // 
            this.tabPostePonctuel.Controls.Add(this.btnPonctuel);
            this.tabPostePonctuel.Controls.Add(this.grpEcheance);
            this.tabPostePonctuel.Controls.Add(this.txtPrelevement);
            this.tabPostePonctuel.Controls.Add(this.txtCom);
            this.tabPostePonctuel.Controls.Add(this.txtIntitule);
            this.tabPostePonctuel.Controls.Add(this.lblPrelevement);
            this.tabPostePonctuel.Controls.Add(this.lblCom);
            this.tabPostePonctuel.Controls.Add(this.lblIntitule);
            this.tabPostePonctuel.Location = new System.Drawing.Point(4, 22);
            this.tabPostePonctuel.Name = "tabPostePonctuel";
            this.tabPostePonctuel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPostePonctuel.Size = new System.Drawing.Size(652, 420);
            this.tabPostePonctuel.TabIndex = 1;
            this.tabPostePonctuel.Text = "Poste Ponctuel";
            this.tabPostePonctuel.UseVisualStyleBackColor = true;
            // 
            // btnPonctuel
            // 
            this.btnPonctuel.Location = new System.Drawing.Point(496, 383);
            this.btnPonctuel.Name = "btnPonctuel";
            this.btnPonctuel.Size = new System.Drawing.Size(133, 31);
            this.btnPonctuel.TabIndex = 7;
            this.btnPonctuel.Text = "Valider";
            this.btnPonctuel.UseVisualStyleBackColor = true;
            // 
            // grpEcheance
            // 
            this.grpEcheance.Location = new System.Drawing.Point(23, 135);
            this.grpEcheance.Name = "grpEcheance";
            this.grpEcheance.Size = new System.Drawing.Size(606, 242);
            this.grpEcheance.TabIndex = 6;
            this.grpEcheance.TabStop = false;
            this.grpEcheance.Text = "Echéances prévues";
            // 
            // txtPrelevement
            // 
            this.txtPrelevement.Location = new System.Drawing.Point(184, 95);
            this.txtPrelevement.Name = "txtPrelevement";
            this.txtPrelevement.Size = new System.Drawing.Size(36, 20);
            this.txtPrelevement.TabIndex = 5;
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(184, 56);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(197, 20);
            this.txtCom.TabIndex = 4;
            // 
            // txtIntitule
            // 
            this.txtIntitule.Location = new System.Drawing.Point(184, 18);
            this.txtIntitule.Name = "txtIntitule";
            this.txtIntitule.Size = new System.Drawing.Size(197, 20);
            this.txtIntitule.TabIndex = 3;
            // 
            // lblPrelevement
            // 
            this.lblPrelevement.AutoSize = true;
            this.lblPrelevement.Location = new System.Drawing.Point(20, 98);
            this.lblPrelevement.Name = "lblPrelevement";
            this.lblPrelevement.Size = new System.Drawing.Size(134, 13);
            this.lblPrelevement.TabIndex = 2;
            this.lblPrelevement.Text = "Nombre de prélèvements ?";
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Location = new System.Drawing.Point(20, 59);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(77, 13);
            this.lblCom.TabIndex = 1;
            this.lblCom.Text = "Commentaire ?";
            // 
            // lblIntitule
            // 
            this.lblIntitule.AutoSize = true;
            this.lblIntitule.Location = new System.Drawing.Point(20, 21);
            this.lblIntitule.Name = "lblIntitule";
            this.lblIntitule.Size = new System.Drawing.Size(47, 13);
            this.lblIntitule.TabIndex = 0;
            this.lblIntitule.Text = "Intitulé ?";
            // 
            // tabRevenu
            // 
            this.tabRevenu.Controls.Add(this.cboBenef);
            this.tabRevenu.Controls.Add(this.txtJourDuMois);
            this.tabRevenu.Controls.Add(this.txtMontantRev);
            this.tabRevenu.Controls.Add(this.txtPosteRev);
            this.tabRevenu.Controls.Add(this.lblJourDuMois);
            this.tabRevenu.Controls.Add(this.lblMontantRev);
            this.tabRevenu.Controls.Add(this.lblBenef);
            this.tabRevenu.Controls.Add(this.lblPosteRev);
            this.tabRevenu.Location = new System.Drawing.Point(4, 22);
            this.tabRevenu.Name = "tabRevenu";
            this.tabRevenu.Size = new System.Drawing.Size(652, 420);
            this.tabRevenu.TabIndex = 2;
            this.tabRevenu.Text = "Revenu";
            this.tabRevenu.UseVisualStyleBackColor = true;
            // 
            // txtJourDuMois
            // 
            this.txtJourDuMois.Location = new System.Drawing.Point(179, 212);
            this.txtJourDuMois.Name = "txtJourDuMois";
            this.txtJourDuMois.Size = new System.Drawing.Size(42, 20);
            this.txtJourDuMois.TabIndex = 7;
            // 
            // txtMontantRev
            // 
            this.txtMontantRev.Location = new System.Drawing.Point(179, 153);
            this.txtMontantRev.Name = "txtMontantRev";
            this.txtMontantRev.Size = new System.Drawing.Size(100, 20);
            this.txtMontantRev.TabIndex = 6;
            // 
            // txtPosteRev
            // 
            this.txtPosteRev.Location = new System.Drawing.Point(179, 42);
            this.txtPosteRev.Name = "txtPosteRev";
            this.txtPosteRev.Size = new System.Drawing.Size(249, 20);
            this.txtPosteRev.TabIndex = 4;
            // 
            // lblJourDuMois
            // 
            this.lblJourDuMois.AutoSize = true;
            this.lblJourDuMois.Location = new System.Drawing.Point(26, 215);
            this.lblJourDuMois.Name = "lblJourDuMois";
            this.lblJourDuMois.Size = new System.Drawing.Size(75, 13);
            this.lblJourDuMois.TabIndex = 3;
            this.lblJourDuMois.Text = "Jour du mois ?";
            // 
            // lblMontantRev
            // 
            this.lblMontantRev.AutoSize = true;
            this.lblMontantRev.Location = new System.Drawing.Point(26, 156);
            this.lblMontantRev.Name = "lblMontantRev";
            this.lblMontantRev.Size = new System.Drawing.Size(55, 13);
            this.lblMontantRev.TabIndex = 2;
            this.lblMontantRev.Text = "Montant ?";
            // 
            // lblBenef
            // 
            this.lblBenef.AutoSize = true;
            this.lblBenef.Location = new System.Drawing.Point(26, 102);
            this.lblBenef.Name = "lblBenef";
            this.lblBenef.Size = new System.Drawing.Size(71, 13);
            this.lblBenef.TabIndex = 1;
            this.lblBenef.Text = "Bénéficiaire ?";
            // 
            // lblPosteRev
            // 
            this.lblPosteRev.AutoSize = true;
            this.lblPosteRev.Location = new System.Drawing.Point(26, 45);
            this.lblPosteRev.Name = "lblPosteRev";
            this.lblPosteRev.Size = new System.Drawing.Size(67, 13);
            this.lblPosteRev.TabIndex = 0;
            this.lblPosteRev.Text = "Quel poste ?";
            // 
            // cboBenef
            // 
            this.cboBenef.FormattingEnabled = true;
            this.cboBenef.Location = new System.Drawing.Point(179, 99);
            this.cboBenef.Name = "cboBenef";
            this.cboBenef.Size = new System.Drawing.Size(249, 21);
            this.cboBenef.TabIndex = 8;
            // 
            // frmPrevisionnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 470);
            this.Controls.Add(this.tabcPrevision);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrevisionnel";
            this.Text = "Budget Prévisionnel";
            this.Load += new System.EventHandler(this.frmPrevisionnel_Load);
            this.tabcPrevision.ResumeLayout(false);
            this.tabPosteFixe.ResumeLayout(false);
            this.tabPosteFixe.PerformLayout();
            this.tabPostePonctuel.ResumeLayout(false);
            this.tabPostePonctuel.PerformLayout();
            this.tabRevenu.ResumeLayout(false);
            this.tabRevenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcPrevision;
        private System.Windows.Forms.TabPage tabPosteFixe;
        private System.Windows.Forms.TabPage tabPostePonctuel;
        private System.Windows.Forms.TextBox txtJour;
        private System.Windows.Forms.ComboBox cboPeriode;
        private System.Windows.Forms.ComboBox cboPoste;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblJour;
        private System.Windows.Forms.Label lblPeriodicite;
        private System.Windows.Forms.Label lblPoste;
        private System.Windows.Forms.TabPage tabRevenu;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.TextBox txtPrelevement;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.TextBox txtIntitule;
        private System.Windows.Forms.Label lblPrelevement;
        private System.Windows.Forms.Label lblCom;
        private System.Windows.Forms.Label lblIntitule;
        private System.Windows.Forms.GroupBox grpEcheance;
        private System.Windows.Forms.Button btnPonctuel;
        private System.Windows.Forms.TextBox txtJourDuMois;
        private System.Windows.Forms.TextBox txtMontantRev;
        private System.Windows.Forms.TextBox txtPosteRev;
        private System.Windows.Forms.Label lblJourDuMois;
        private System.Windows.Forms.Label lblMontantRev;
        private System.Windows.Forms.Label lblBenef;
        private System.Windows.Forms.Label lblPosteRev;
        private System.Windows.Forms.ComboBox cboBenef;
    }
}