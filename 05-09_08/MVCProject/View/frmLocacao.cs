using MVCProject.Adicionar;
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
    public partial class frmLocacao : Form
    {
        public frmLocacao()
        {
            InitializeComponent();
        }

        private void FrmLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaHBSISDataSet.Locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.CustomQuery(this.sistemaBibliotecaHBSISDataSet.Locacao);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddLocacao formAdd = new frmAddLocacao();
            formAdd.ShowDialog();
            this.locacaoTableAdapter.Insert(formAdd.locacaoRom.Livro,
                                            formAdd.locacaoRom.Usuario,
                                            formAdd.locacaoRom.Tipo,
                                            formAdd.locacaoRom.Devolucao,
                                            true,
                                            1,
                                            1,
                                            DateTime.Now,
                                            DateTime.Now
                                            );
            this.locacaoTableAdapter.CustomQuery(this.sistemaBibliotecaHBSISDataSet.Locacao);
        }
    }
}
