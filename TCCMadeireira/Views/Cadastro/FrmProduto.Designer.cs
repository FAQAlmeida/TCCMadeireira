namespace TCCMadeireira.Views
{
    /// <summary>
    /// Form responsavel pelo CRUD de Produtos
    /// </summary>
    partial class FrmProduto
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
            System.Windows.Forms.Label lblNome;
            System.Windows.Forms.Label lblQuantidade;
            System.Windows.Forms.Label vALOR_PRODUTOLabel;
            System.Windows.Forms.Label iD_FORNECEDOR_PRODUTOLabel;
            this.dataSetMadeireiraV2 = new TCCMadeireira.Bancos.DataSetMadeireiraV2();
            this.ProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProdutosTableAdapter = new TCCMadeireira.Bancos.DataSetMadeireiraV2TableAdapters.PRODUTOSTableAdapter();
            this.tableAdapterManager = new TCCMadeireira.Bancos.DataSetMadeireiraV2TableAdapters.TableAdapterManager();
            this.FornecedoresTableAdapter = new TCCMadeireira.Bancos.DataSetMadeireiraV2TableAdapters.FORNECEDORESTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.oBS_PRODUTOTextBox = new System.Windows.Forms.TextBox();
            this.pRODUTOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDataInfo = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.MaskedTextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            lblNome = new System.Windows.Forms.Label();
            lblQuantidade = new System.Windows.Forms.Label();
            vALOR_PRODUTOLabel = new System.Windows.Forms.Label();
            iD_FORNECEDOR_PRODUTOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireiraV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new System.Drawing.Point(6, 30);
            lblNome.Name = "lblNome";
            lblNome.Size = new System.Drawing.Size(64, 13);
            lblNome.TabIndex = 15;
            lblNome.Text = "PRODUTO:";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new System.Drawing.Point(307, 30);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new System.Drawing.Size(81, 13);
            lblQuantidade.TabIndex = 17;
            lblQuantidade.Text = "QUANTIDADE:";
            // 
            // vALOR_PRODUTOLabel
            // 
            vALOR_PRODUTOLabel.AutoSize = true;
            vALOR_PRODUTOLabel.Location = new System.Drawing.Point(6, 56);
            vALOR_PRODUTOLabel.Name = "vALOR_PRODUTOLabel";
            vALOR_PRODUTOLabel.Size = new System.Drawing.Size(46, 13);
            vALOR_PRODUTOLabel.TabIndex = 19;
            vALOR_PRODUTOLabel.Text = "VALOR:";
            // 
            // iD_FORNECEDOR_PRODUTOLabel
            // 
            iD_FORNECEDOR_PRODUTOLabel.AutoSize = true;
            iD_FORNECEDOR_PRODUTOLabel.Location = new System.Drawing.Point(179, 56);
            iD_FORNECEDOR_PRODUTOLabel.Name = "iD_FORNECEDOR_PRODUTOLabel";
            iD_FORNECEDOR_PRODUTOLabel.Size = new System.Drawing.Size(85, 13);
            iD_FORNECEDOR_PRODUTOLabel.TabIndex = 21;
            iD_FORNECEDOR_PRODUTOLabel.Text = "FORNECEDOR:";
            // 
            // dataSetMadeireiraV2
            // 
            this.dataSetMadeireiraV2.DataSetName = "DataSetMadeireiraV2";
            this.dataSetMadeireiraV2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProdutosBindingSource
            // 
            this.ProdutosBindingSource.DataMember = "PRODUTOS";
            this.ProdutosBindingSource.DataSource = this.dataSetMadeireiraV2;
            // 
            // ProdutosTableAdapter
            // 
            this.ProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTESTableAdapter = null;
            this.tableAdapterManager.FORNECEDORESTableAdapter = this.FornecedoresTableAdapter;
            this.tableAdapterManager.FORNECIMENTO_PRODUTOTableAdapter = null;
            this.tableAdapterManager.FORNECIMENTOSTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOSTableAdapter = null;
            this.tableAdapterManager.PRODUTOSTableAdapter = this.ProdutosTableAdapter;
            this.tableAdapterManager.UpdateOrder = TCCMadeireira.Bancos.DataSetMadeireiraV2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            this.tableAdapterManager.VENDA_PRODUTOTableAdapter = null;
            this.tableAdapterManager.VENDASTableAdapter = null;
            // 
            // FornecedoresTableAdapter
            // 
            this.FornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.numQuantidade);
            this.groupBox1.Controls.Add(lblNome);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(lblQuantidade);
            this.groupBox1.Controls.Add(vALOR_PRODUTOLabel);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(iD_FORNECEDOR_PRODUTOLabel);
            this.groupBox1.Controls.Add(this.oBS_PRODUTOTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.FornecedoresBindingSource, "NOME_FORNECEDOR", true));
            this.comboBox1.DataSource = this.FornecedoresBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(270, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // FornecedoresBindingSource
            // 
            this.FornecedoresBindingSource.DataMember = "FORNECEDORES";
            this.FornecedoresBindingSource.DataSource = this.dataSetMadeireiraV2;
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(394, 27);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(128, 20);
            this.numQuantidade.TabIndex = 25;
            this.numQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProdutosBindingSource, "NOME_PRODUTO", true));
            this.txtNome.Location = new System.Drawing.Point(76, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(225, 20);
            this.txtNome.TabIndex = 16;
            // 
            // txtValor
            // 
            this.txtValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProdutosBindingSource, "VALOR_PRODUTO", true));
            this.txtValor.Location = new System.Drawing.Point(60, 53);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(113, 20);
            this.txtValor.TabIndex = 20;
            // 
            // oBS_PRODUTOTextBox
            // 
            this.oBS_PRODUTOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProdutosBindingSource, "OBS_PRODUTO", true));
            this.oBS_PRODUTOTextBox.Location = new System.Drawing.Point(9, 79);
            this.oBS_PRODUTOTextBox.Multiline = true;
            this.oBS_PRODUTOTextBox.Name = "oBS_PRODUTOTextBox";
            this.oBS_PRODUTOTextBox.Size = new System.Drawing.Size(513, 82);
            this.oBS_PRODUTOTextBox.TabIndex = 24;
            // 
            // pRODUTOSDataGridView
            // 
            this.pRODUTOSDataGridView.AllowUserToAddRows = false;
            this.pRODUTOSDataGridView.AllowUserToDeleteRows = false;
            this.pRODUTOSDataGridView.AllowUserToOrderColumns = true;
            this.pRODUTOSDataGridView.AutoGenerateColumns = false;
            this.pRODUTOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pRODUTOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pRODUTOSDataGridView.DataSource = this.ProdutosBindingSource;
            this.pRODUTOSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pRODUTOSDataGridView.Location = new System.Drawing.Point(0, 0);
            this.pRODUTOSDataGridView.Name = "pRODUTOSDataGridView";
            this.pRODUTOSDataGridView.ReadOnly = true;
            this.pRODUTOSDataGridView.Size = new System.Drawing.Size(757, 215);
            this.pRODUTOSDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_PRODUTO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_PRODUTO";
            this.dataGridViewTextBoxColumn2.HeaderText = "PRODUTO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "QUANTIDADE_PRODUTO";
            this.dataGridViewTextBoxColumn3.HeaderText = "QUANTIDADE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_FORNECEDOR_PRODUTO";
            this.dataGridViewTextBoxColumn5.HeaderText = "FORNECEDOR";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OBS_PRODUTO";
            this.dataGridViewTextBoxColumn6.HeaderText = "OBS";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pRODUTOSDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 215);
            this.panel1.TabIndex = 2;
            // 
            // lblDataInfo
            // 
            this.lblDataInfo.Location = new System.Drawing.Point(561, 173);
            this.lblDataInfo.MaximumSize = new System.Drawing.Size(10000, 1000);
            this.lblDataInfo.Name = "lblDataInfo";
            this.lblDataInfo.Size = new System.Drawing.Size(100, 20);
            this.lblDataInfo.TabIndex = 41;
            this.lblDataInfo.Text = "DATA_INFO";
            this.lblDataInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(554, 108);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(107, 20);
            this.txtFiltro.TabIndex = 45;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(554, 79);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 44;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(554, 50);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(554, 21);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 42;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 426);
            this.Controls.Add(this.lblDataInfo);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProduto";
            this.Text = "FrmProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireiraV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bancos.DataSetMadeireiraV2 dataSetMadeireiraV2;
        private System.Windows.Forms.BindingSource ProdutosBindingSource;
        private Bancos.DataSetMadeireiraV2TableAdapters.PRODUTOSTableAdapter ProdutosTableAdapter;
        private Bancos.DataSetMadeireiraV2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox oBS_PRODUTOTextBox;
        private System.Windows.Forms.DataGridView pRODUTOSDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDataInfo;
        private System.Windows.Forms.MaskedTextBox txtFiltro;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private Bancos.DataSetMadeireiraV2TableAdapters.FORNECEDORESTableAdapter FornecedoresTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource FornecedoresBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}