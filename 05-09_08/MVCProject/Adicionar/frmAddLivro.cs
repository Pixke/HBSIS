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
    public partial class frmAddLivro : Form
    {
        public frmAddLivro()
        {
            InitializeComponent();
        }

        public Livro livroRom;

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAddLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaHBSISDataSet.Editora' table. You can move, or remove it, as needed.
            this.editoraTableAdapter.Fill(this.sistemaBibliotecaHBSISDataSet.Editora);
            this.generosTableAdapter.Fill(this.sistemaBibliotecaHBSISDataSet.Generos);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            livroRom = new Livro();

            livroRom.Registro = int.Parse(textBox1.Text);
            livroRom.Titulo = textBox3.Text;
            livroRom.Isbn = textBox4.Text;
            livroRom.Genero = (int)comboBox1.SelectedValue;
            livroRom.Editora = (int)comboBox2.SelectedValue;
            livroRom.Sinopse = textBox2.Text;
            livroRom.Observacoes = textBox5.Text;


            this.Close();
        }
    }
}
