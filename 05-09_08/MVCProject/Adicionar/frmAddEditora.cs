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
using static MVCProject.SistemaBibliotecaHBSISDataSet;

namespace MVCProject.Adicionar
{
    public partial class frmAddEditora : Form
    {
        public frmAddEditora()
        {
            InitializeComponent();
        }

        public Editora EditoraRow { get; private set; }

        private void Button1_Click(object sender, EventArgs e)
        {
            EditoraRow = new Editora();

            EditoraRow.Nome = textBox1.Text;
            EditoraRow.Descricao = textBox2.Text;



            this.Close();
        }
    }
}
