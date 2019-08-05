using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.Adicionar
{
    public partial class frmAddGenero : Form
    {
        public frmAddGenero()
        {
            InitializeComponent();
        }

        public Genero generosRow;
        private void FrmAddGenero_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaHBSISDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.CustomQuery(this.sistemaBibliotecaHBSISDataSet.Generos);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            generosRow = new Genero()
            {
                Titulo = textBox1.Text,
                Tipo = textBox2.Text,
                Descricao = textBox3.Text,
            };


            this.Close();
        }
    }
}
