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
    public partial class frmAddLocacao : Form
    {
        public frmAddLocacao()
        {
            InitializeComponent();
        }

        public Locacao locacaoRom;

        private void FrmAddLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaHBSISDataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.sistemaBibliotecaHBSISDataSet.Usuario);
            // TODO: This line of code loads data into the 'sistemaBibliotecaHBSISDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaHBSISDataSet.Livros);
            // TODO: This line of code loads data into the 'sistemaBibliotecaHBSISDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.sistemaBibliotecaHBSISDataSet.Livros);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            locacaoRom = new Locacao();

            locacaoRom.Livro = (int)comboBox1.SelectedValue;
            locacaoRom.Usuario = (int)comboBox2.SelectedValue;
            locacaoRom.Tipo = comboBox3.SelectedIndex;
            locacaoRom.Devolucao = dateTimePicker1.Value;


            this.Close();
        }
    }
}
