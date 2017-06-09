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
                    connec.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\..\budget1.mdb";
                    connec.Open();
                    //Récupération du codePoste le plus grand
                    String codePoste = "select max(codePoste) from Poste";
                    OleDbCommand cmd = new OleDbCommand(codePoste);
                    cmd.Connection = connec;
                    int code = (int)cmd.ExecuteScalar() + 1;

                    //Requète d'ajout de type de transaction
                    cmd.CommandText = "insert into Poste values (" + code + ",'" + txtPoste.Text + "')";
                    cmd.ExecuteNonQuery();

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
                    
                    //Réactive le form précédent et ferme celui-ci
                    Owner.Activate();
                    this.Close();
                    
                }
            }
            else
            {
                MessageBox.Show("Rentrez un libellé de poste");
            }
        }

        private void txtPoste_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '\x27' && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
