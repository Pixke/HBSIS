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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet.Usuarios);
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet2.Usuarios' table. You can move, or remove it, as needed.


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var userSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridView.QuerysInnerJoinDataSet.MarcasRow;

            this.usuariosTableAdapter.DeleteQuery(userSelect.Id);
            this.usuariosTableAdapter.CustomQuery(querysInnerJoinDataSet.Usuarios);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }
    }
}
