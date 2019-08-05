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
    public partial class frmEditAutor : Form
    {
        public frmEditAutor()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaHBSISDataSet.AutoresRow AutoresRow;



        private void FrmAddAutor_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = AutoresRow.Nome;
            textBox2.Text = AutoresRow.Descricao;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AutoresRow.Nome = textBox1.Text;
            AutoresRow.Descricao = textBox2.Text;
            this.Close();
        }
    }
}
