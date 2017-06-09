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
            connec.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\..\budget1.mdb";
            try
            {
                connec.Open();

                DataTable schemaTable = connec.GetOleDbSchemaTable(
                    OleDbSchemaGuid.Tables,
                    new object[] { null, null, null, "TABLE" });
                ds.Clear();
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
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            connec.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\..\budget1.mdb";
            Button s = (Button)sender;
            string requete = "";
            //On détermine la requete en fonction du bouton cliquer
            if (s == btnValider)
            {
                if (txtJour.Text == String.Empty || txtMontant.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez remplir toutes les informations");
                }
                else
                {
                    connec.Open();
                    OleDbCommand command = new OleDbCommand("select codePoste from PostePeriodique where codePoste=" + cboPoste.SelectedValue, connec);
                    //Test si le poste fixe n'existe pas déja
                    if (command.ExecuteScalar() == cboPoste.SelectedValue)
                    {
                        //Création de la requète
                        requete = "insert into PostePeriodique values (" + cboPoste.SelectedValue + ",'" + float.Parse(txtMontant.Text) + "'," + cboPeriode.SelectedValue + "," + txtJour.Text + ")";
                        command.CommandText = requete;
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Ce poste existe déjà");
                    }
                    connec.Close();
 
                }
            }
            else if (s == btnValiderRev)
            {
                if (txtJourDuMois.Text == String.Empty || txtMontantRev.Text == String.Empty)
                {
                    MessageBox.Show("Veuillez remplir toutes les informations");
                }
                else if (int.Parse(txtJourDuMois.Text) > 31)
                {
                    MessageBox.Show("Veuillez rentrez un jour entre 1 et 31");
                }
                else
                {
                    connec.Open();
                    OleDbCommand command = new OleDbCommand("select codePoste from PosteRevenu where codePoste=" + cboPosteRev.SelectedValue, connec);
                    //Test si le poste revenu n'existe pas déja
                    if (command.ExecuteScalar() == cboPosteRev.SelectedValue)
                    {
                        //Création de la requète
                        requete = "insert into PosteRevenu values (" + cboPosteRev.SelectedValue + ",'" + float.Parse(txtMontantRev.Text) + "'," + cboBenef.SelectedValue + "," + txtJourDuMois.Text + ")";
                        command.CommandText = requete;
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Ce poste existe déjà");
                    }
                    connec.Close();   
                }
            }
            

            if (requete != String.Empty)
            {
                try
                {
                    connec.Open();
                    OleDbCommand command = new OleDbCommand("select codePoste from PostePeriodique where codePoste="+cboPoste.SelectedValue, connec);
                    //Test si le poste fixe n'existe pas déja
                    if (command.ExecuteScalar() == cboPoste.SelectedValue)
                    {
                        command.CommandText = requete;
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Ce poste existe déjà");
                    }
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
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            frmAjoutPoste poste = new frmAjoutPoste();
            poste.Show(this);
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
                requete = "select * from [" + nomTable + "]";
                OleDbCommand cd = new OleDbCommand(requete, connec);

                OleDbDataAdapter da = new OleDbDataAdapter();
                da.SelectCommand = cd;

                da.Fill(ds, nomTable);
            }
        }

        private void txtPrelevement_TextChanged(object sender, EventArgs e)
        {
            grpEcheance.Controls.Clear();
            int top = 15;
            int left = 15;
            int nb = 0;
            if (txtPrelevement.Text != String.Empty)
            {
                nb = int.Parse(txtPrelevement.Text);
            }
            for (int i = 0; i < nb; i++)
            {
                if (i % 7 == 0 && i != 0)
                {
                    left += 300;
                    top = 15;
                }
                //DateTimePicker
                DateTimePicker dt = new DateTimePicker();
                dt.Size = new System.Drawing.Size(80, 25);
                dt.Value = DateTime.Today;
                //Ajoute 1 mois à chaque nouveau datetimepicker
                dt.Value = dt.Value.AddMonths(i);
                dt.Format = DateTimePickerFormat.Short;
                dt.Top = top;
                dt.Left = left;
                if ( i== 0)
                {
                    dt.ValueChanged += new System.EventHandler(this.dt_ValueChanged);
                }
                grpEcheance.Controls.Add(dt);

                //label
                Label lbl = new Label();
                lbl.Size = new System.Drawing.Size(50, 25);
                lbl.Text = "Montant";
                lbl.Top = top + 3;
                lbl.Left = left + 85;
                grpEcheance.Controls.Add(lbl);

                //textBox
                TextBox txt = new TextBox();
                txt.Size = new System.Drawing.Size(100, 25);
                txt.Top = top;
                txt.Left = left + 150;
                if (i == 0)
                {
                    txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
                }
                grpEcheance.Controls.Add(txt);

                top += 30;
            }
        }

        //Permet de copier le texte du premier textebox dans tous les autres
        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            foreach (Control c in grpEcheance.Controls)
            {
                if (c is TextBox )
                {
                    c.Text = t.Text;
                }
            }
        }

        //Permet de copier la date du premier datetimePicker en ajoutant 1 mois a chaque fois
        private void dt_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dt = (DateTimePicker)sender;
            int i = 0;
            foreach (Control c in grpEcheance.Controls)
            {
                if (c is DateTimePicker)
                {
                    var date = c as DateTimePicker;
                    date.Value = dt.Value.AddMonths(i);
                    i++;
                }
            }
        }

        private void txtPrelevement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnPonctuel_Click(object sender, EventArgs e)
        {
            if (txtIntitule.Text == "")
            {
                MessageBox.Show("Entrer un intitulé!");
            }
            else if (txtPrelevement.Text == "" || int.Parse(txtPrelevement.Text) <= 0)
            {
                MessageBox.Show("Entrer un nombre de prélèvement supérieur à 0!");
            }
            else
            {
                try
                {
                    connec.Open();
                    
                    //Récupération du code du poste à créer
                    OleDbCommand command = new OleDbCommand("select max(codePoste) from Poste", connec);
                    int code = (int)command.ExecuteScalar() + 1;

                    //ajout du poste dans la table Poste
                    string requete = "insert into Poste values ("+code+",'"+ txtIntitule.Text + "')";
                    command.CommandText = requete;
                    command.ExecuteNonQuery();

                    //ajout dans la table PostePonctuel
                    requete = "insert into PostePonctuel values ("+code+",'"+ txtCom.Text + "')";
                    command.CommandText = requete;
                    command.ExecuteNonQuery();

                    DateTime datePrelevt = DateTime.Today;
                    float montantEcheance = 0;
                    foreach (Control c in grpEcheance.Controls)
                    {
                        if (c is DateTimePicker)
                        {
                            var dateTimePicker = c as DateTimePicker;
                            datePrelevt = dateTimePicker.Value;
                        }
                        if (c is TextBox)
                        {
                            if (c.Text == "")
                            {
                                MessageBox.Show("Chaque échéance doit avoir un montant !");
                                break;
                            }
                            else
                            {
                                montantEcheance = float.Parse(c.Text);

                                //ajout dans la table Echeances

                                requete = "insert into Echeances values ("+code+",format('"+ datePrelevt.ToShortDateString()+"', 'DD/MM/YYYY'),'"+montantEcheance+"')";
                                command.CommandText = requete;
                                command.ExecuteNonQuery();
                            }
                        } 
                        
                    }
                    MessageBox.Show("Success !");
                    txtIntitule.Text = "";
                    txtCom.Text = "";
                    txtPrelevement.Text = "";
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
                }
            }
        }

        private void txtIntitule_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
           
        }

        private void frmPrevisionnel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Activate();
        }

        private void txtCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
