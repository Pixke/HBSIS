using DataGridViewExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Adicionar
{
    public partial class frmAdicionar : Form
    {
        public frmAdicionar()
        {
            InitializeComponent();
        }
        public Carro carrosRow;

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            carrosRow = new Carro();

            carrosRow.Modelo = textBox1.Text;
            carrosRow.Ano = dateTimePicker1.Value;
            carrosRow.Marca = (int)comboBox1.SelectedValue;

            this.Close();
        }

        private void FrmAdicionar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet1.Marcas);

        }
    }
}
