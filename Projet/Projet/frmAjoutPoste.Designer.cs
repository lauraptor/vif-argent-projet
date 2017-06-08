namespace Projet
{
    partial class frmAjoutPoste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjoutPoste));
            this.lblNvPoste = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtPoste = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNvPoste
            // 
            this.lblNvPoste.AutoSize = true;
            this.lblNvPoste.Location = new System.Drawing.Point(23, 30);
            this.lblNvPoste.Name = "lblNvPoste";
            this.lblNvPoste.Size = new System.Drawing.Size(151, 13);
            this.lblNvPoste.TabIndex = 0;
            this.lblNvPoste.Text = "Rentrez votre nouveau poste :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(101, 71);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(172, 27);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtPoste
            // 
            this.txtPoste.Location = new System.Drawing.Point(180, 27);
            this.txtPoste.Name = "txtPoste";
            this.txtPoste.Size = new System.Drawing.Size(178, 20);
            this.txtPoste.TabIndex = 2;
            // 
            // frmAjoutPoste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 110);
            this.Controls.Add(this.txtPoste);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lblNvPoste);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAjoutPoste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajout de poste";
            this.Load += new System.EventHandler(this.frmAjoutPoste_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNvPoste;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtPoste;
    }
}