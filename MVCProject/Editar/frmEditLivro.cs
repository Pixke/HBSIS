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

namespace MVCProject.Editar
{
    public partial class frmEditLivro : Form
    {
        public frmEditLivro()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaHBSISDataSet.LivrosRow livroRom;

        private void FrmEditLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaHBSISDataSet.Editora' table. You can move, or remove it, as needed.
            this.editoraTableAdapter.Fill(this.sistemaBibliotecaHBSISDataSet.Editora);
            // TODO: This line of code loads data into the 'sistemaBibliotecaHBSISDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaHBSISDataSet.Generos);
            // livroRom = new Livro();


            textBox1.Text = livroRom.Registro.ToString();
            textBox3.Text = livroRom.Titulo;
            textBox4.Text = livroRom.ISBN;
            comboBox1.SelectedValue = livroRom.Genero;
            comboBox2.SelectedValue = livroRom.Editora;
            textBox2.Text = livroRom.Sinopse;
            textBox5.Text = livroRom.Observacoes;   

           

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           //livroRom = new Livro();

            livroRom.Registro = int.Parse(textBox1.Text);
            livroRom.Titulo = textBox3.Text;
            livroRom.ISBN = textBox4.Text;
            livroRom.Genero = (int)comboBox1.SelectedValue;
            livroRom.Editora = (int)comboBox2.SelectedValue;
            livroRom.Sinopse = textBox2.Text;
            livroRom.Observacoes = textBox5.Text;
            

            this.Close();
        }
    }
}
