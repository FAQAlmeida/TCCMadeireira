﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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
            // TODO: This line of code loads data into the 'dataSetReport.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSetReport.DataTable1);
            this.reportViewer.RefreshReport();
            PageSizeConfig();
        }
        private void PageSizeConfig()
        {
            PageSettings pageSettings = new PageSettings();
            pageSettings.Margins = new Margins(0, 0, 0, 0);
            this.reportViewer.SetPageSettings(pageSettings);
        }
    }
}
