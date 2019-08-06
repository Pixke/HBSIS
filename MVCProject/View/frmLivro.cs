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
    public partial class frmLivro : Form
    {
        public frmLivro()
        {
            InitializeComponent();
        }

        private void FrmLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaHBSISDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.FillBy(this.sistemaBibliotecaHBSISDataSet.Livros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddLivro formAdd = new frmAddLivro();
            formAdd.ShowDialog();

            this.livrosTableAdapter.Insert(
                formAdd.livroRom.Registro,
                formAdd.livroRom.Titulo,
                formAdd.livroRom.Isbn,
                formAdd.livroRom.Genero,
                formAdd.livroRom.Editora,
                formAdd.livroRom.Sinopse,
                formAdd.livroRom.Observacoes,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );

            this.livrosTableAdapter.FillBy(this.sistemaBibliotecaHBSISDataSet.Livros);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livroSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
            MVCProject.SistemaBibliotecaHBSISDataSet.LivrosRow;

            switch (e.ColumnIndex)
            {
                //case 1: { this.livrosTableAdapter.DeleteQuery(livroSelect.Id); } break;
                case 0:
                    {
                        frmEditLivro editLivro = new frmEditLivro();
                        editLivro.livroRom = livroSelect;
                        editLivro.ShowDialog();

                        this.livrosTableAdapter.Update(livroSelect);


                    }
                    break;
            }


            this.livrosTableAdapter.FillBy(this.sistemaBibliotecaHBSISDataSet.Livros);
        }
    }
}
