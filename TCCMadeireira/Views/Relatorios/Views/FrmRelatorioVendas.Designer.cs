namespace TCCMadeireira.Views.Relatorios
{
    partial class FrmRelatorioVendas
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
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReport = new TCCMadeireira.Bancos.DataSetReport();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTable1TableAdapter = new TCCMadeireira.Bancos.DataSetReportTableAdapters.DataTable1TableAdapter();
            this.dataSetMadeireiraV21 = new TCCMadeireira.Bancos.DataSetMadeireiraV2();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireiraV21)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSetReport;
            // 
            // dataSetReport
            // 
            this.dataSetReport.DataSetName = "DataSetReport";
            this.dataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetVendasReport";
            reportDataSource1.Value = this.dataTable1BindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "TCCMadeireira.Views.Relatorios.Reports.VendasReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(984, 461);
            this.reportViewer.TabIndex = 0;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataSetMadeireiraV21
            // 
            this.dataSetMadeireiraV21.DataSetName = "DataSetMadeireiraV2";
            this.dataSetMadeireiraV21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmRelatorioVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.reportViewer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRelatorioVendas";
            this.Text = "Relatório de Vendas";
            this.Load += new System.EventHandler(this.FrmRelatorioVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireiraV21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bancos.DataSetMadeireiraV2TableAdapters.RELATORIO_VENDATableAdapter relatorioVendaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private Bancos.DataSetReport dataSetReport;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Bancos.DataSetReportTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private Bancos.DataSetMadeireiraV2 dataSetMadeireiraV21;
    }
}