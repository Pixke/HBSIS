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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var carSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridView.QuerysInnerJoinDataSet.CarrosRow;

            switch (e.ColumnIndex)
            {
                case 0: {
                        this.carrosTableAdapter.DeleteQuery(carSelect.Id);
                        this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet.Carros);
                    } break;
            }

            this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet.Carros);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Carros);
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 tela = new Form2();
            tela.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 tela = new Form3();
            tela.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form4 tela = new Form4();
            tela.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Lixeira lixo = new Lixeira();
            lixo.ShowDialog();
            this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet.Carros);
        }


    }
}
