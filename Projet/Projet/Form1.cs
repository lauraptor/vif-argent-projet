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
using System.Data.SqlClient;
using System.IO;

namespace Projet
{
    public partial class frmAppli : Form
    {
        OleDbConnection connec = new OleDbConnection();

        public frmAppli()
        {
            InitializeComponent();
        }
 
        private void frmAppli_Load(object sender, EventArgs e)
        {

            try
            {
                connec.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Documents\Cours\Projet_A21\vif-argent-projet-testLocal\vif-argent-projet-test\budget1.mdb";
                connec.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connec;
                command.CommandType = CommandType.Text;
                command.CommandText = "select libType from TypeTransaction";
                OleDbDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cboType.Items.Add(dr.GetString(0));

                    }

                    this.cboType.SelectedIndex = 0;
                    cboType.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                else
                {
                    MessageBox.Show("Pas de catégorie trouvées");
                }

                //requetes ligne personne
                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.Connection = connec;
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select pnPersonne from Personne";
                OleDbDataReader dr1 = cmd2.ExecuteReader();
                if(dr1.HasRows)
                 {
                    while(dr1.Read())
                    {
                        clbPersonne.Items.Add(dr1.GetString(0));
                       
                    }   
                }
            }

            catch(Exception error)
            {
                MessageBox.Show(error.GetType().ToString());
            }

            finally
            {
                if(connec.State == ConnectionState.Open)
                {
                    connec.Close();
                }        
            }
        }


        private void btnAjoutType_Click(object sender, EventArgs e)
        {
            //Affichage du formulaire de création d'un libellé
            Libelle_Type frm = new Libelle_Type();
            frm.Show();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //Vérification que le formulaire soit rempli avant la création d'une transaction
            if (txtDescription.Text == String.Empty || txtMontant.Text == String.Empty || (rdbPercu.Checked && !rdbRecette.Checked) || clbPersonne.CheckedItems.Count == 0)
            {
                MessageBox.Show("Veuillez remplir tout les champs");
            }
            else
            {
                int code;
                int type;
                try
                {

                    connec.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Documents\Cours\Projet_A21\vif-argent-projet-testLocal\vif-argent-projet-test\budget1.mdb";
                    connec.Open();

                    //Récupération du numéro de transaction
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connec;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "select max(codeTransaction) from [Transaction]";
                    code = (int)command.ExecuteScalar() + 1;

                    //Récupération du code type de la transaction
                    command.CommandText = "select codeType from TypeTransaction where libType= '" + cboType.SelectedItem.ToString() + "'";
                    type = (int)command.ExecuteScalar();

                    //Création de la requète d'ajout
                    string ajout = "insert into [Transaction] values (" + code + ", to_date('" + dtpDate.Value.ToShortDateString() + "', DD/MM/YYYY), '" + txtDescription.Text.ToString() + "','" + txtMontant.Text.ToString() + "'," + rdbRecette.Checked + "," + rdbPercu.Checked + "," + type + ")";
                    MessageBox.Show(ajout);
                    command.CommandText = ajout;
                    //command.ExecuteNonQuery();

                    //Liaison de la transaction aux bénéficiaires
                    for (int i = 0; i < clbPersonne.CheckedItems.Count ; i++)
                    {
                        command.CommandText = "select codePersonne from Personne where pnPersonne ='" + clbPersonne.CheckedItems[i] + "'";
                        ajout = "insert into Beneficiaires values (" + code + ", " + command.ExecuteScalar().ToString() + ")";
                        command.CommandText = ajout;
                        MessageBox.Show(ajout);
                        //command.ExecuteNonQuery();
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
        }


        private void txtMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // autorise à entrer une virgule ',' pour les décimales (et une seule)
            if (e.KeyChar == ','&& (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '\x27' && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Affichage1a1()
        {
            try
            {
                //recuperation des differents labels et checkbox pour l'affichage 1 à 1
                int jointure = 1;
                OleDbCommand cd1 = new OleDbCommand("SELECT [Transaction].* FROM [Transaction]", connec);
                connec.Open();
                OleDbDataReader dr4 = cd1.ExecuteReader();

                while(dr4.Read())
                {
                    lblCodeType.Text = dr4.GetInt32(0).ToString();
                    lblDescri.Text = dr4.GetString(1);
                    lblCout.Text = dr4.GetValue(2).ToString() + " €";
                    cboxRecette.Checked = dr4.GetBoolean(4);
                    cboxPercue.Checked = dr4.GetBoolean(5);
                    jointure = dr4.GetInt32(6);
                }
                connec.Close();

                // recuperation date des transactions dans la base Transaction
                OleDbCommand cmd3 = new OleDbCommand();
                cmd3.Connection = connec;
                cmd3.CommandType = CommandType.Text;
                cmd3.CommandText = "select dateTransaction from [Transaction]";
                OleDbDataReader dr5 = cmd3.ExecuteReader();
                if (dr5.HasRows)
                {
                    while (dr5.Read())
                    {
                        cboDateTransac.Items.Add(dr5.GetDateTime(0));
                    }
                connec.Close();
                this.cboDateTransac.SelectedIndex = 0;
                cboDateTransac.DropDownStyle = ComboBoxStyle.DropDownList;
                cboDateTransac.BackColor = System.Drawing.SystemColors.InactiveCaption;

                    //
                    OleDbCommand cmd4 = new OleDbCommand();
                    cmd4.Connection = connec;
                    cmd4.CommandType = CommandType.Text;
                    cmd4.CommandText = "SELECT[TypeTransaction].* FROM[TypeTransaction] where[codeType] = " + jointure; 
                    OleDbDataReader dr6 = cmd4.ExecuteReader();
                    while(dr6.Read())
                    {
                        lblType.Text = dr6.GetString(1);
                    }
                    connec.Close();
                }
            }

            catch (InvalidOperationException error)
            {
                MessageBox.Show("Erreur de requête SQL");
            }

            catch(OleDbException error)
            {
                MessageBox.Show("Erreur de chaine de connexion !");
            }
   
        }

        private void btnAjoutPersonne_Click(object sender, EventArgs e)
        {
            //Vérification que les champs sont remplis
            if (txtPrenom.Text == String.Empty || txtNom.Text == String.Empty)
            {
                if (txtPrenom.Text == String.Empty)
                {
                    error.SetError(txtPrenom, "Remplissez les champs");
                }
                if (txtNom.Text == String.Empty)
                {
                    error.SetError(txtNom, "Remplissez les champs");
                }
            }
            else
            {
                error.SetError(txtPrenom, String.Empty);
                error.SetError(txtNom, String.Empty);

                try
                {
                    //Ajout de la Personne
                    connec.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connec;
                    command.CommandText = "select max(codePersonne) from Personne";
                    int code = (int)command.ExecuteScalar() + 1;
                    string ajout = "insert into Personne values (" + code + ",'" + txtNom.Text + "','" + txtPrenom.Text + "','" + txtTel.Text + "')";
                    command.CommandText = ajout;
                    MessageBox.Show(ajout);
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
    }
}

