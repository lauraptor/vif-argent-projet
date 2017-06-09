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
using System.Globalization;

namespace Projet
{
    public partial class frmAppli : Form
    {
        OleDbConnection connec = new OleDbConnection();
        public static DataSet dsCbo = new DataSet();
        DataSet ds;
        BindingSource source = new BindingSource();
        BindingSource source1 = new BindingSource();
        DataTable dt = new DataTable();
        DataTable searchTable = new DataTable();

        public frmAppli()
        {
            InitializeComponent();
        }
 
        private void frmAppli_Load(object sender, EventArgs e)
        {
            
            try
            {
                if (connec.State == ConnectionState.Closed)
                {
                    connec.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\..\budget1.mdb";
                    connec.Open();
                }

                DataTable schemaTable = connec.GetOleDbSchemaTable(
                    OleDbSchemaGuid.Tables,
                    new object[] { null, null, null, "TABLE" });
                dsCbo.Clear();
                clbPersonne.Items.Clear();
                DataSetFill(schemaTable);

                //Remplissage de la combobox des types de transaction
                ComboBoxFill(cboType, "TypeTransaction", "libType", "codeType");

                //requetes ligne personne
                OleDbCommand cmd = new OleDbCommand("select pnPersonne from Personne",connec);
                OleDbDataReader dr1 = cmd.ExecuteReader();
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

        private void FrmAppli_RowChanged(object sender, DataRowChangeEventArgs e)
        {
            btnRecapRaz_Click(null, null);
        }

        private void RemplirTable(String nomTable)
        {
            string requete = "SELECT * FROM [" + nomTable + "]";
            OleDbDataAdapter da = new OleDbDataAdapter(requete, connec);
            da.Fill(ds, nomTable);
        }

        private void btnAjoutType_Click(object sender, EventArgs e)
        {
            //Affichage du formulaire de création d'un libellé
            Libelle_Type frm = new Libelle_Type();
            frm.Show(this);
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

                    connec.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\..\budget1.mdb";
                    connec.Open();

                    //Récupération du numéro de transaction
                    OleDbCommand command = new OleDbCommand("select max(codeTransaction) from [Transaction]",connec);
                    code = (int)command.ExecuteScalar() + 1;

                    //Récupération du code type de la transaction
                    type = (int)cboType.SelectedValue;


                    //Création de la requète d'ajout
                    string ajout = "insert into [Transaction] values ("+code+",format('"+dtpDate.Value.ToShortDateString()+"','DD/MM/YYYY'),'"+txtDescription.Text.ToString()+"','"+float.Parse(txtMontant.Text)+"',"+rdbRecette.Checked.ToString()+","+rdbPercu.Checked.ToString()+","+type+")";
                    command.CommandText = ajout;
                    command.ExecuteNonQuery();

                    //Liaison de la transaction aux bénéficiaires
                    int personne;
                    for (int i = 0; i < clbPersonne.CheckedItems.Count ; i++)
                    {
                        command.CommandText = "select codePersonne from Personne where pnPersonne ='" + clbPersonne.CheckedItems[i].ToString()+"'";
                        personne = (int)command.ExecuteScalar();
                        ajout = "insert into Beneficiaires values ("+code+ ","+personne+")";
                        command.CommandText = ajout;
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Success !");
                    //Nettoie le formulaire
                    txtDescription.Text = "";
                    txtMontant.Text = "";
                    cboxPercue.Checked = false;
                    cboxRecette.Checked = false;
                    clbPersonne.ClearSelected();
                    
                }

                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }

                finally
                {
                    if (connec.State == ConnectionState.Open)
                    {
                        connec.Close();
                    }
                    this.Activate();
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


        private void Source_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                if (source.Current != null)
                {
                    lboPersonne.Items.Clear();

                    if (ds.Tables["Beneficiaires"] == null)
                    {

                    }
                    else
                    {
                        foreach (DataRow dr in ds.Tables["Beneficiaires"].Select("codeTransaction = " + ((DataRowView)source.Current)["codeTransaction"]))
                        {
                            lboPersonne.Items.Add(ds.Tables["Personne"].Select("codePersonne = " + dr["codePersonne"])[0]["pnPersonne"]);
                        }

                        lblType1.Text = ds.Tables["TypeTransaction"].Select("codeType = " + ((DataRowView)source.Current)["type"])[0]["libType"].ToString();
                    }
                }
            }
            catch(System.NullReferenceException error)
            {

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
                    command.ExecuteNonQuery();
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
                    this.Activate();
                }
            }
        }

        private void RemplirDGV()
        {
            try
            {
                connec.Open();
                OleDbCommand command1 = new OleDbCommand("SELECT * FROM [Transaction]", connec);
                OleDbDataAdapter da = new OleDbDataAdapter(command1);
                dt.Clear();
                da.Fill(dt);
                dt.AcceptChanges();


                connec.Close();
            }
            catch
            {

            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            DialogResult suppression = MessageBox.Show("Êtes vous sûr de vouloir supprimer  cette transaction ?", "supression", MessageBoxButtons.YesNo);
            if (suppression == DialogResult.Yes)
            {
                int codeTransaction = int.Parse(txtCode.Text);
                connec.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connec;
                command.CommandType = CommandType.Text;
                command.CommandText = "select max(codeTransaction) from [Transaction]";
                int lastCodeTransac = (int)command.ExecuteScalar();
                connec.Close();
                if (codeTransaction <= lastCodeTransac)
                {
                    try
                    {
                        connec.Open();
                        string requete = "DELETE from [Beneficiaires] where [Beneficiaires].[codeTransaction] = " + codeTransaction;
                        OleDbCommand command1 = new OleDbCommand(requete, connec);
                        command1.ExecuteNonQuery();
                        requete = "DELETE from [Transaction] where [Transaction].[codeTransaction] =" + codeTransaction;
                        OleDbCommand command2 = new OleDbCommand(requete, connec);
                        command2.ExecuteNonQuery();
                        //Mise à jour de la bdd
                        connec.Close();


                        ds.Tables["Transaction"].Select("codeTransaction = " + codeTransaction)[0].Delete();
                        ds.Tables["Transaction"].AcceptChanges();

                        MessageBox.Show("Suppression de la transaction réussie");
                        RemplirDGV();
                    }

                    catch (InvalidOperationException error)
                    {
                        MessageBox.Show("Erreur de chaine de connexion ! Suppr\n"+error.Message);
                    }
                    catch (OleDbException error)
                    {
                        MessageBox.Show("Erreur de requete SQL ! Suppr\n"+error.Message);   
                    }

                }
            }
        }

        private void tabSupTransac_Enter(object sender, EventArgs e)
        {
            RemplirDGV();
        }

        //Remplit la ComboBox donnee en parametre avec la table nomTable par la colonne ColonneAffichee, et la colonne cachee colonneCachee
        private void ComboBoxFill(ComboBox cb, string nomTable, string ColonneAffichee, string colonneCachee)
        {
            cb.DataSource = dsCbo.Tables[nomTable];
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
                requete = "select * from [" + nomTable + "]";
                //MessageBox.Show(requete);
                OleDbCommand cd = new OleDbCommand(requete, connec);

                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cd;

                da.Fill(dsCbo, nomTable);
            }
            
        }

        private void btnBudgetPre_Click(object sender, EventArgs e)
        {
            //Affichage du formulaire du budget prévisionnel
            frmPrevisionnel pre = new frmPrevisionnel();
            pre.Show(this);
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            source.MoveFirst();
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            source.MovePrevious();

        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            source.MoveNext();
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            source.MoveLast();
        }

        #region Recap

        private void btnRecapRecherche_Click(object sender, EventArgs e)
        {
            double montant = -1;
            DateTime dateInf;
            DateTime dateSup;

            String filter = "";

            if (!string.IsNullOrWhiteSpace(txtRecapLib.Text))
                filter += "description LIKE '*" + txtRecapLib.Text + "*' AND ";

            if (txtRecapMontant.Text.Length != 0 && double.TryParse(txtRecapMontant.Text.Substring(0, txtRecapMontant.Text.Length - 2), out montant))
            {
                filter += "montant ";
                if (rdbRecapInf.Checked)
                    filter += "<";
                else if (rdbRecapEgal.Checked)
                    filter += "=";
                else
                    filter += ">=";

                filter += " " + montant.ToString(CultureInfo.InvariantCulture) + " AND ";
            }

            filter += "dateTransaction >= #" + dtpRecapInf.Value.ToString("MM/dd/yyyy") + "# AND ";
            filter += "dateTransaction <= #" + dtpRecapSup.Value.ToString("MM/dd/yyyy") + "# AND ";

            filter += "percuON = ";
            if (cbRecapPercu.Checked)
                filter += "True";
            else
                filter += "False";
            filter += " AND ";

            if (rdbRecapEntrant.Checked)
                filter += "recetteON = True AND ";
            if (rdbRecapSortant.Checked)
                filter += "recetteON = False AND ";

            if (filter.Length > 5)
                filter = filter.Substring(0, filter.Length - 5);

            searchTable.Rows.Clear();
            foreach (DataRow dr in ds.Tables["Transaction"].Select(filter))
                searchTable.Rows.Add(dr.ItemArray);
        }

        private void btnRecapRaz_Click(object sender, EventArgs e)
        {
            dtpRecapInf.Value = DateTime.Parse(ds.Tables["Transaction"].Select("dateTransaction = MIN(dateTransaction)")[0]["dateTransaction"].ToString());
            dtpRecapSup.Value = DateTime.Parse(ds.Tables["Transaction"].Select("dateTransaction = MAX(dateTransaction)")[0]["dateTransaction"].ToString());

            txtRecapLib.Text = "";
            txtRecapMontant.Text = "";
            rdbRecapEgal.Checked = true;
            rdbRecapEntrant.Checked = false;
            rdbRecapInf.Checked = false;
            rdbRecapSortant.Checked = false;
            rdbRecapSup.Checked = false;
            cbRecapPercu.Checked = false;

            searchTable.Rows.Clear();
            foreach (DataRow dr in ds.Tables["Transaction"].Select())
                searchTable.Rows.Add(dr.ItemArray);
        }

        #endregion

        private void tab1a12_Enter(object sender, EventArgs e)
        {
            ds = new DataSet();

            RemplirTable("Transaction");
            source.DataSource = ds.Tables["Transaction"];
            RemplirTable("TypeTransaction");
            RemplirTable("Beneficiaires");
            RemplirTable("Personne");

            cboDateTransac.DataBindings.Clear();
            cboDateTransac.DataBindings.Add(new Binding("Text", source, "DateTransaction"));
            lblCodeType.DataBindings.Clear();
            lblCodeType.DataBindings.Add(new Binding("Text", source, "codeTransaction"));
            lblDescri.DataBindings.Clear();
            lblDescri.DataBindings.Add(new Binding("Text", source, "description"));
            lblCout.DataBindings.Clear();
            lblCout.DataBindings.Add(new Binding("Text", source, "montant"));
            cboxPercue.DataBindings.Clear();
            cboxPercue.DataBindings.Add(new Binding("Checked", source, "recetteON"));
            cboxRecette.DataBindings.Clear();
            cboxRecette.DataBindings.Add(new Binding("Checked", source, "percuON"));

            source.CurrentItemChanged += Source_CurrentItemChanged;
            Source_CurrentItemChanged(null, null);

            dtgSupprimer.DataSource = dt;
            dtgModif.DataSource = dt;

            
            DataColumnCollection cols = searchTable.Columns;
            cols.Clear();
            cols.Add("Identifiant", typeof(int));
            cols.Add("Date", typeof(DateTime));
            cols.Add("Libellé", typeof(string));
            cols.Add("Montant", typeof(double));
            cols.Add("Recette", typeof(bool));
            cols.Add("Perçu", typeof(bool));
            cols.Add("Type", typeof(int));

            dgvRecap.DataSource = searchTable;

            btnRecapRaz_Click(null, null);

            ds.Tables["Transaction"].RowChanged += FrmAppli_RowChanged;
        }
    }
}

