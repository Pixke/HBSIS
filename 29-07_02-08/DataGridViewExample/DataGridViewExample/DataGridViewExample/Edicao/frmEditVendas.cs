using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Edicao
{
    public partial class frmEditVendas : Form
    {
        internal QuerysInnerJoinDataSet.VendasRow VendasRow;

        public frmEditVendas()
        {
            InitializeComponent();
        }

        private void FrmEditVendas_Load(object sender, EventArgs e)
        {

        }
    }
}
