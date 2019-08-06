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

namespace MVCProject.Editar
{
    public partial class frmEditUsuario : Form
    {
        public frmEditUsuario()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaHBSISDataSet.UsuarioRow UsuarioRom;

        private void FrmEditUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaHBSISDataSet.Usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.CustomQuery(this.sistemaBibliotecaHBSISDataSet.Usuario);

            textBox2.Text = UsuarioRom.Login;
            textBox3.Text = UsuarioRom.Senha;
            textBox4.Text = UsuarioRom._E_mail;

        }
    }
}
