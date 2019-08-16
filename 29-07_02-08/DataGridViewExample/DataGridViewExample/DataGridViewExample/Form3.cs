using DataGridViewExample.Adicionar;
using DataGridViewExample.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendasSelect = ((System.Data.DataRowView)
    this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
    DataGridViewExample.QuerysInnerJoinDataSet.VendasRow;

            switch (e.ColumnIndex)
            {
                case 0: { this.vendasTableAdapter.DeleteQuery(vendasSelect.Id); } break;
                case 1:
                    {
                        frmEditVendas editVendas = new frmEditVendas();
                        editVendas.VendasRow = vendasSelect;
                        editVendas.ShowDialog();

                        this.vendasTableAdapter.Update(vendasSelect);
                    }
                    break;
            }
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Vendas);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddVendas frmVendas = new frmAddVendas();
            frmVendas.ShowDialog();

            if (frmVendas.VendasRow?.Carro > 0
                && frmVendas.VendasRow?.Valor > 0)
                this.vendasTableAdapter.Insert(
                    frmVendas.VendasRow.Carro,
                    frmVendas.VendasRow.Quantidade,
                    frmVendas.VendasRow.Valor,
                    frmVendas.VendasRow.Ativo,
                    1,
                    1,
                    frmVendas.VendasRow.DatInc,
                    frmVendas.VendasRow.DatAlt
                    );
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Vendas);
        }



    }
}
