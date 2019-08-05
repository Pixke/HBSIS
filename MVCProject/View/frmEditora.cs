using MVCProject.Adicionar;
using MVCProject.Editar;
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
using static MVCProject.SistemaBibliotecaHBSISDataSet;

namespace MVCProject.View
{
    public partial class frmEditora : Form
    {
        public Editora EditoraRow { get; private set; }

        public frmEditora()
        {
            InitializeComponent();
        }

        private void FrmEditora_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaHBSISDataSet.Editora' table. You can move, or remove it, as needed.
            this.editoraTableAdapter.CustomQuery(this.sistemaBibliotecaHBSISDataSet.Editora);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddEditora formAdd = new frmAddEditora();
            formAdd.ShowDialog();

            this.editoraTableAdapter.Insert(
                formAdd.EditoraRow.Nome,
                formAdd.EditoraRow.Descricao

                );

            this.editoraTableAdapter.CustomQuery(this.sistemaBibliotecaHBSISDataSet.Editora);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var editoraSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
            MVCProject.SistemaBibliotecaHBSISDataSet.EditoraRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmEditEditora editUser = new frmEditEditora();
                        editUser.EditoraRow = editoraSelect;
                        editUser.ShowDialog();

                        this.editoraTableAdapter.Update(editoraSelect);


                    }
                    break;
            }


            this.editoraTableAdapter.CustomQuery(this.sistemaBibliotecaHBSISDataSet.Editora);
        }
    }
}
