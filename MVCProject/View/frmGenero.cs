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

namespace MVCProject.View
{
    public partial class frmGenero : Form
    {
        public frmGenero()
        {
            InitializeComponent();
        }

        public Genero generosRow { get; private set; }

        private void FrmGenero_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaHBSISDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.CustomQuery(this.sistemaBibliotecaHBSISDataSet.Generos);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddGenero formAdd = new frmAddGenero();
            formAdd.ShowDialog();

            this.generosTableAdapter.Insert(
                formAdd.generosRow.Titulo,
                formAdd.generosRow.Tipo,
                formAdd.generosRow.Descricao
                );

            this.generosTableAdapter.CustomQuery(this.sistemaBibliotecaHBSISDataSet.Generos);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var generoSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
            MVCProject.SistemaBibliotecaHBSISDataSet.GenerosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmEditGenero editUser = new frmEditGenero();
                        editUser.generosRow = generoSelect;
                        editUser.ShowDialog();

                        this.generosTableAdapter.Update(generoSelect);


                    }
                    break;
            }


            this.generosTableAdapter.CustomQuery(this.sistemaBibliotecaHBSISDataSet.Generos);
        }
    }
}
