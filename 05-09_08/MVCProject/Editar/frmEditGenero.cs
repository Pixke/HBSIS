using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.Editar
{
    public partial class frmEditGenero : Form
    {
        public frmEditGenero()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaHBSISDataSet.GenerosRow generosRow;

        private void FrmEditGenero_Load(object sender, EventArgs e)
        {
            textBox1.Text = generosRow.Titulo;
            textBox2.Text = generosRow.Tipo;
            textBox3.Text = generosRow.Descricao;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            generosRow.Titulo = textBox1.Text;
            generosRow.Tipo = textBox2.Text;
            generosRow.Descricao = textBox3.Text;
        

            this.Close();
        }
    }
}
    

