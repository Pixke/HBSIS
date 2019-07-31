using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Marcas);
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet2.Marcas' table. You can move, or remove it, as needed.

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 tela = new Form3();
            tela.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marcasSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridView.QuerysInnerJoinDataSet.MarcasRow;
                       
            this.marcasTableAdapter.DeleteQuery(marcasSelect.Id);
            this.marcasTableAdapter.CustomQuery(querysInnerJoinDataSet.Marcas);
        }
    }
}
