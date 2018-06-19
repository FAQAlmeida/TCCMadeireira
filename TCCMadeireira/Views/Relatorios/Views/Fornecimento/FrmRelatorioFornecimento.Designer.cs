namespace TCCMadeireira.Views.Relatorios.Views.Fornecimento
{
    partial class FrmRelatorioFornecimento
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
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlReportViewer = new System.Windows.Forms.Panel();
            this.dataSetReport = new TCCMadeireira.Bancos.DataSetReport();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2TableAdapter = new TCCMadeireira.Bancos.DataSetReportTableAdapters.DataTable2TableAdapter();
            this.pnlReportViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable2BindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "TCCMadeireira.Views.Relatorios.Reports.Fornecimento.ReportFornecimento.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1250, 452);
            this.reportViewer.TabIndex = 0;
            // 
            // pnlReportViewer
            // 
            this.pnlReportViewer.Controls.Add(this.reportViewer);
            this.pnlReportViewer.Location = new System.Drawing.Point(0, 64);
            this.pnlReportViewer.Name = "pnlReportViewer";
            this.pnlReportViewer.Size = new System.Drawing.Size(1250, 452);
            this.pnlReportViewer.TabIndex = 2;
            // 
            // dataSetReport
            // 
            this.dataSetReport.DataSetName = "DataSetReport";
            this.dataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.dataSetReport;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorioFornecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 515);
            this.Controls.Add(this.pnlReportViewer);
            this.Name = "FrmRelatorioFornecimento";
            this.Text = "Relatório de Fornecimento";
            this.Load += new System.EventHandler(this.FrmRelatorioFornecimento_Load);
            this.pnlReportViewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.Panel pnlReportViewer;
        private Bancos.DataSetReport dataSetReport;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private Bancos.DataSetReportTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
    }
}