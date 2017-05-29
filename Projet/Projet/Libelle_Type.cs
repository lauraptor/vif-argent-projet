using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class Libelle_Type : Form
    {
        public Libelle_Type()
        {
            InitializeComponent();
        }

        private void Libelle_Type_Load(object sender, EventArgs e)
        {

        }

        private void btnAjoutType_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
