using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCCMadeireira.Views.Relatorios
{
    public partial class FrmRelatorioVendas : Form
    {
        public FrmRelatorioVendas()
        {
            InitializeComponent();
        }

        private void FrmRelatorioVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMadeireiraV2.RELATORIO_VENDA' table. You can move, or remove it, as needed.
            this.relatorioVendaTableAdapter.Fill(this.dataSetMadeireiraV2.RELATORIO_VENDA);

            this.reportViewer1.RefreshReport();
        }
    }
}
