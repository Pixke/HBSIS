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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        public Aluno novoAluno = new Aluno();

        private void Label2_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            novoAluno.Nome_Aluno = txNome.Text;
            novoAluno.Idade = (int)nIdade.Value;
            this.Close();
        }
    }
}
