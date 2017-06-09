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
    public partial class Libelle_Type : Form
    {
        public Libelle_Type()
        {
            InitializeComponent();
        }

        OleDbConnection connec = new OleDbConnection();

        private void Libelle_Type_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAjoutType_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                String type = textBox1.Text;
                try
                {
                    connec.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\..\budget1.mdb";
                    connec.Open();
                    //Récupération du codeType le plus grand
                    String codeType = "select max(codeType) from TypeTransaction";
                    OleDbCommand cmd = new OleDbCommand(codeType);
                    cmd.Connection = connec;
                    int code = (int)cmd.ExecuteScalar() + 1;

                    //Requète d'ajout de type de transaction
                    cmd.CommandText = "insert into TypeTransaction values (" + code + "," + textBox1.Text + ")";
                    MessageBox.Show(cmd.CommandText);
                    //cmd.ExecuteNonQuery();

                    //Ajout à la combobox des libéllés
                    

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
                    //Réactive le form précédent et ferme celui-ci
                    Owner.Activate();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Rentrez un libellé de type");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '\x27' && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
