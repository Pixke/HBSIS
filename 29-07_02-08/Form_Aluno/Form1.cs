using Form_Aluno.Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Aluno
{
    public partial class Form1 : Form
    {
        public object Nome_Aluno { get; private set; }

        List<Aluno> listaAlunos = new List<Aluno>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.ShowDialog();

            listaAlunos.Add(cad.novoAluno);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaAlunos;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
