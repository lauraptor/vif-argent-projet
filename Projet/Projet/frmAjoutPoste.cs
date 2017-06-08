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
    public partial class frmAjoutPoste : Form
    {

        public frmAjoutPoste()
        {
            InitializeComponent();
        }

        OleDbConnection connec = new OleDbConnection();

        private void frmAjoutPoste_Load(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtPoste.Text != String.Empty)
            {
                String type = txtPoste.Text;
                try
                {
                    connec.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=X:\Projet_D21\vif-argent-projet-master\vif-argent-projet-master\budget1.mdb";
                    connec.Open();
                    //Récupération du codePoste le plus grand
                    String codePoste = "select max(codePoste) from Poste";
                    OleDbCommand cmd = new OleDbCommand(codePoste);
                    cmd.Connection = connec;
                    int code = (int)cmd.ExecuteScalar() + 1;

                    //Requète d'ajout de type de transaction
                    cmd.CommandText = "insert into Poste values (" + code + "," + txtPoste.Text + ")";
                    MessageBox.Show(cmd.CommandText);
                    //cmd.ExecuteNonQuery();

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
            else
            {
                MessageBox.Show("Rentrez un libellé de poste");
            }
        }
    }
}
