using MVCProject.Adicionar;
using MVCProject.Editar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
        }

        private void FrmAutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaHBSISDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.CustomQuery(this.sistemaBibliotecaHBSISDataSet.Autores);

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddAutor formAdd = new frmAddAutor();
            formAdd.ShowDialog();

            this.autoresTableAdapter.Insert(
                formAdd.AutoresRow.Nome,
                formAdd.AutoresRow.Descricao

                );

            this.autoresTableAdapter.CustomQuery(this.sistemaBibliotecaHBSISDataSet.Autores);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var autorSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
            MVCProject.SistemaBibliotecaHBSISDataSet.AutoresRow;

            switch (e.ColumnIndex)
            {
                //case 1: { this.autoresTableAdapter.DeleteQuery(autorSelect.Id); } break;
                case 0:
                    {
                        frmEditAutor editUser = new frmEditAutor();
                        editUser.AutoresRow = autorSelect;
                        editUser.ShowDialog();

                        this.autoresTableAdapter.Update(autorSelect);


                    }
                    break;
            }


            this.autoresTableAdapter.CustomQuery(this.sistemaBibliotecaHBSISDataSet.Autores);
        }
    }
}
