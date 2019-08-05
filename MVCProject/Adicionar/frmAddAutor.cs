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
    public partial class frmAddAutor : Form
    {
        public frmAddAutor()
        {
            InitializeComponent();
        }

        public Autor AutoresRow;

        private void FrmAddAutor_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AutoresRow = new Autor();

            AutoresRow.Nome = textBox1.Text;
            AutoresRow.Descricao = textBox2.Text;



            this.Close();
        }
    }
}
