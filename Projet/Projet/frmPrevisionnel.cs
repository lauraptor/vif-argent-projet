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

        public frmPrevisionnel()
        {
            InitializeComponent();
        }

        private void frmPrevisionnel_Load(object sender, EventArgs e)
        {
            try
            {
                connec.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Documents\Cours\Projet_A21\vif-argent-projet-testLocal\vif-argent-projet-test\budget1.mdb";
                connec.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connec;
                command.CommandType = CommandType.Text;

                //Remplissage de la comboBox des Postes
                command.CommandText = "select libposte from Poste";
                OleDbDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cboPoste.Items.Add(dr.GetString(0));

                    }

                    this.cboPoste.SelectedIndex = 0;
                    cboPoste.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                else
                {
                    MessageBox.Show("Pas de poste trouvés");
                }

                //Remplissage de la comboBox Périodicité
                command.CommandText = "select libPer from Periodicite";
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cboPeriode.Items.Add(dr.GetString(0));

                    }

                    this.cboPeriode.SelectedIndex = 0;
                    cboPeriode.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                else
                {
                    MessageBox.Show("Pas de périodicité trouvées");
                }

                //Remplissage de la comboBox Bénéficiaires
                command.CommandText = "select pnPersonne from Personne";
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cboBenef.Items.Add(dr.GetString(0));

                    }

                    this.cboBenef.SelectedIndex = 0;
                    cboBenef.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                else
                {
                    MessageBox.Show("Pas de bénéficiaires trouvés");
                }
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

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtJour.Text == String.Empty || txtMontant.Text == String.Empty)
            {
                MessageBox.Show("Veuillez remplir toutes les informations");
            }
            else
            {
                int code;
                int per;
                try
                {
                    connec.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Documents\Cours\Projet_A21\vif-argent-projet-testLocal\vif-argent-projet-test\budget1.mdb";
                    connec.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connec;
                    command.CommandType = CommandType.Text;

                    //Récupération du code du poste
                    command.CommandText = "select codePoste from Poste where libPoste ='" + cboPoste.SelectedItem.ToString() + "'";
                    code = (int)command.ExecuteScalar();

                    //Récupération de type de périodicité
                    command.CommandText = "select codePer from Periodicite where libPer ='" + cboPeriode.SelectedItem.ToString() + "'";
                    per = (int)command.ExecuteScalar();

                    //Création de la requète d'ajout
                    string ajout = "insert into PostePeriodique values (" + code + "," + txtMontant.Text + "," + per + "," + txtJour.Text + ")";
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

        }
    }
}
