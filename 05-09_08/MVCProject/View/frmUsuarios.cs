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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaHBSISDataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.CustomQuery(this.sistemaBibliotecaHBSISDataSet.Usuario);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var userSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
            MVCProject.SistemaBibliotecaHBSISDataSet.UsuarioRow;
            
            switch (e.ColumnIndex)
            {
                case 1: { this.usuarioTableAdapter.DeleteQuery(userSelect.Id); } break;
                case 0:
                    {
                        frmEditUsuario editUser = new frmEditUsuario();
                        editUser.UsuarioRom = userSelect;
                        editUser.ShowDialog();
            
                        this.usuarioTableAdapter.Update(userSelect);
            
            
                    }
                    break;
            }
            
            
            this.usuarioTableAdapter.CustomQuery(this.sistemaBibliotecaHBSISDataSet.Usuario);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddUsuario formAdd = new frmAddUsuario();
            formAdd.ShowDialog();

            this.usuarioTableAdapter.Insert(
                formAdd.usuarioRom.Nome,
                formAdd.usuarioRom.Login,
                formAdd.usuarioRom.Senha,
                formAdd.usuarioRom.Email,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );

            this.usuarioTableAdapter.CustomQuery(this.sistemaBibliotecaHBSISDataSet.Usuario);
        }
    }
}
