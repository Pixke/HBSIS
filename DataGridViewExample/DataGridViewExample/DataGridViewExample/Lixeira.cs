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
    public partial class Lixeira : Form
    {
        public Lixeira()
        {
            InitializeComponent();
        }

        private void Lixeira_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.InativeCustomQuery(this.querysInnerJoinDataSet.Vendas);
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.InativeCustomQuery(this.querysInnerJoinDataSet.Marcas);
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.InativeCustomQuery(this.querysInnerJoinDataSet.Carros);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carrSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
            DataGridViewExample.QuerysInnerJoinDataSet.CarrosRow;

            switch (e.ColumnIndex)
            {
                case 1: { this.carrosTableAdapter.RestoreQuery(carrSelect.Id); } break;
            }

            this.carrosTableAdapter.InativeCustomQuery(this.querysInnerJoinDataSet.Carros);

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marcasSelect = ((System.Data.DataRowView)
            this.dataGridView2.Rows[e.RowIndex].DataBoundItem).Row as
            DataGridViewExample.QuerysInnerJoinDataSet.MarcasRow;

            switch (e.ColumnIndex)
            {
                case 0: { this.marcasTableAdapter.RestoreQuery(marcasSelect.Id); } break;
            }


            this.marcasTableAdapter.InativeCustomQuery(this.querysInnerJoinDataSet.Marcas);
        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.vendasTableAdapter.InativeCustomQuery(this.querysInnerJoinDataSet.Vendas);
        }
    }
}
