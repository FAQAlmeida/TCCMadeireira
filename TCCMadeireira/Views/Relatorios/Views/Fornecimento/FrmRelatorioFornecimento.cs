using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCCMadeireira.Views.Relatorios.Views.Fornecimento
{
    public partial class FrmRelatorioFornecimento : MaterialForm
    {
        public FrmRelatorioFornecimento()
        {
            InitializeComponent();
        }

        private void FrmRelatorioFornecimento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetReport.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.Fill(this.dataSetReport.DataTable2);
            this.reportViewer.RefreshReport();
            PageSizeConfig();
        }
        private void PageSizeConfig()
        {
            PageSettings pageSettings = new PageSettings
            {
                Margins = new Margins(0, 0, 0, 0),
                Landscape = true
            };
            this.reportViewer.SetPageSettings(pageSettings);
        }
    }
}
