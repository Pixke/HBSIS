using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Edicao
{
    public partial class FormEditaMarcas : Form
    {
        private object querysInnerJoinDataSet;
        private object frmEditMarcas_Load;

        public FormEditaMarcas()
        {
            InitializeComponent();
        }
        public DataGridViewExample.QuerysInnerJoinDataSet.MarcasRow MarcasRow;
        private void FrmEditMarcas_Load(object sender, EventArgs e)
        {
           // this.marca Fill(this.querysInnerJoinDataSet.Marcas);

           textBox1.Text = MarcasRow.Nome;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MarcasRow.Nome = textBox1.Text;
            this.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
