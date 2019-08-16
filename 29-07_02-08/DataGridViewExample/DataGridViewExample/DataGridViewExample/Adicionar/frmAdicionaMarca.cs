using DataGridViewExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Adicionar
{
    public partial class frmAdicionaMarca : Form
    {
        public frmAdicionaMarca()
        {
            InitializeComponent();
        }

        public Marca MarcasRow;


        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MarcasRow = new Marca();

            MarcasRow.Nome = textBox1.Text;

            this.Close();
        }

        private void FrmAdicionaMarca_Load(object sender, EventArgs e)
        {

        }
    }
}
