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
    public partial class frmAddVendas : Form
    {
        public frmAddVendas()
        {
            InitializeComponent();
        }

        public Vendas VendasRow;

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            decimal.TryParse(textBox1.Text, out decimal valor);

            VendasRow = new Vendas()
            {
                Carro = (int)comboBox1.SelectedValue,
                Quantidade = (int)numericUpDown1.Value,
                Valor = valor
            };

            this.Close();

        }

        private void FrmAddVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet.Carros);

        }
    }
}
