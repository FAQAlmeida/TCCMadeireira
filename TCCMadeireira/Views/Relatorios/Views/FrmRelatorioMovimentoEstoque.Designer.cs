namespace TCCMadeireira.Views.Relatorios.Views
{
    partial class FrmFiltrarVendasData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pnlReportViewer = new System.Windows.Forms.Panel();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetReport = new TCCMadeireira.Bancos.DataSetReport();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new TCCMadeireira.Bancos.DataSetReportTableAdapters.DataTable1TableAdapter();
            this.pnlReportViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlReportViewer
            // 
            this.pnlReportViewer.Controls.Add(this.reportViewer);
            this.pnlReportViewer.Location = new System.Drawing.Point(0, 64);
            this.pnlReportViewer.Name = "pnlReportViewer";
            this.pnlReportViewer.Size = new System.Drawing.Size(1250, 452);
            this.pnlReportViewer.TabIndex = 2;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetVendas";
            reportDataSource1.Value = this.dataTable1BindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "TCCMadeireira.Views.Relatorios.Reports.VendasDataReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1250, 452);
            this.reportViewer.TabIndex = 0;
            // 
            // dataSetReport
            // 
            this.dataSetReport.DataSetName = "DataSetReport";
            this.dataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSetReport;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // FrmFiltrarVendasData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 515);
            this.Controls.Add(this.pnlReportViewer);
            this.Name = "FrmFiltrarVendasData";
            this.Text = "FrmFiltrarVendasData";
            this.Load += new System.EventHandler(this.FrmFiltrarVendasData_Load);
            this.pnlReportViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlReportViewer;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Bancos.DataSetReport dataSetReport;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Bancos.DataSetReportTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    }
}