using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Projet
{
    public partial class frmPrevisionnel : Form
    {
        OleDbConnection connec = new OleDbConnection();
        public static DataSet ds = new DataSet();

        public frmPrevisionnel()
        {
            InitializeComponent();
        }

        private void frmPrevisionnel_Load(object sender, EventArgs e)
        {
            connec.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=X:\Projet_D21\vif-argent-projet-master\vif-argent-projet-master\budget1.mdb";
            connec.Open();

            DataTable schemaTable = connec.GetOleDbSchemaTable(
                OleDbSchemaGuid.Tables,
                new object[] { null, null, null, "TABLE" });

            DataSetFill(schemaTable);

            //Remplissage de la comboBox des Postes
            ComboBoxFill(cboPoste, "Poste", "libPoste", "codePoste");


            //Remplissage de la comboBox Périodicité
            ComboBoxFill(cboPeriode, "Periodicite", "libPer", "codePer");

            //Remplissage de la comboBox Bénéficiaires
            ComboBoxFill(cboBenef, "Personne", "pnPersonne", "codePersonne");

            //Remplissage de la combobox  des Postes de l'onglet revenu
            ComboBoxFill(cboPosteRev, "Poste", "libPoste", "codePoste");
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            int code = 0;
            int per = 0;
            string table = "";
            if (s == btnValider)
            {
                if (txtJour.Text == String.Empty || txtMontant.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez remplir toutes les informations");
                }
                else
                {
                    //Récupération du code du poste
                    code = (int)cboPoste.SelectedItem;
                    //Récupération du code de périodicité
                    per = (int)cboPeriode.SelectedItem;
                    //Definition de la Table
                    table = "PostePeriodique";
                }
            }

            if (code != 0 && per != 0 && table != String.Empty)
            {
                try
                {
                    connec.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=X:\Projet_D21\vif-argent-projet-master\vif-argent-projet-master\budget1.mdb";
                    connec.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connec;
                    command.CommandType = CommandType.Text;

                    //Création de la requète d'ajout
                    string ajout = "insert into " + table + " values (" + code + "," + txtMontant.Text + "," + per + "," + txtJour.Text + ")";
                    MessageBox.Show(ajout);
                    command.CommandText = ajout;
                    //command.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.GetType().ToString());
                }

                finally
                {
                    if (connec.State == ConnectionState.Open)
                    {
                        connec.Close();
                    }
                }
            }

        }

        private void txtMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // autorise à entrer une virgule ',' pour les décimales (et une seule)
            if (e.KeyChar == ',' && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtJour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            frmAjoutPoste poste = new frmAjoutPoste();
            poste.Show();
        }


        //Remplit la ComboBox donnee en parametre avec la table nomTable par la colonne ColonneAffichee, et la colonne cachee colonneCachee
        private void ComboBoxFill(ComboBox cb, string nomTable, string ColonneAffichee, string colonneCachee)
        {
            cb.DataSource = ds.Tables[nomTable];
            cb.DisplayMember = ColonneAffichee;
            cb.ValueMember = colonneCachee;
        }

        //Remplit la DataTable donnee en parametre
        public void DataSetFill(DataTable schemaTable)
        {
            string nomTable;
            string requete;
            foreach (DataRow ligne in schemaTable.Rows)
            {
                nomTable = ligne[2].ToString();
                requete = "SELECT * FROM [" + nomTable + "]";
                //MessageBox.Show(requete);
                OleDbCommand cd = new OleDbCommand(requete, connec);

                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cd;

                da.Fill(ds, nomTable);
            }
            //MessageBox.Show(ds.Tables.Count.ToString());
        }

        private void txtPrelevement_TextChanged(object sender, EventArgs e)
        {
            int top = 15;
            int left = 15;
            //grpEcheance.Show();
            int nb = 0;
            if (txtPrelevement.Text != String.Empty)
            {
                nb = int.Parse(txtPrelevement.Text);
            }
            for (int i = 0; i < nb; i++)
            {
                DateTimePicker dt = new DateTimePicker();
                
                dt.Top = 30 * i + top;
                dt.Left = left;
                
                grpEcheance.Controls.Add(dt);
            }
        }

        private void txtPrelevement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
