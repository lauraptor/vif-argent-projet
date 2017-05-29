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
                connec.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\\pie\tunterfinger\A21\Projet\Git\budget1.mdb";
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
            if (txtDescription.Text == String.Empty || txtMontant.Text == String.Empty || (rdbPercu.Checked && rdbRecette.Checked) || (!rdbRecette.Checked && !rdbPercu.Checked))
            {
                MessageBox.Show("Veuillez remplir tout les champs");
            }
            else
            {

            }
        }
    }
}

