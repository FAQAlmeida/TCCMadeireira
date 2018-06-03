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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fORNECEDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMadeireiraV2 = new TCCMadeireira.Bancos.DataSetMadeireiraV2();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.iDPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTIDADEPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDFORNECEDORPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFiltro = new System.Windows.Forms.MaskedTextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pRODUTOSTableAdapter = new TCCMadeireira.Bancos.DataSetMadeireiraV2TableAdapters.PRODUTOSTableAdapter();
            this.fORNECEDORESTableAdapter = new TCCMadeireira.Bancos.DataSetMadeireiraV2TableAdapters.FORNECEDORESTableAdapter();
            this.btnCancelar = new System.Windows.Forms.Button();
            lblNome = new System.Windows.Forms.Label();
            lblQuantidade = new System.Windows.Forms.Label();
            vALOR_PRODUTOLabel = new System.Windows.Forms.Label();
            iD_FORNECEDOR_PRODUTOLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireiraV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).BeginInit();
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
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.fORNECEDORESBindingSource, "NOME_FORNECEDOR", true));
            this.comboBox1.DataSource = this.fORNECEDORESBindingSource;
            this.comboBox1.DisplayMember = "NOME_FORNECEDOR";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(270, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 21);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.ValueMember = "ID_FORNECEDOR";
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // fORNECEDORESBindingSource
            // 
            this.fORNECEDORESBindingSource.DataMember = "FORNECEDORES";
            this.fORNECEDORESBindingSource.DataSource = this.dataSetMadeireiraV2;
            // 
            // dataSetMadeireiraV2
            // 
            this.dataSetMadeireiraV2.DataSetName = "DataSetMadeireiraV2";
            this.dataSetMadeireiraV2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.txtNome.Location = new System.Drawing.Point(76, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(225, 20);
            this.txtNome.TabIndex = 16;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(60, 53);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(113, 20);
            this.txtValor.TabIndex = 20;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(9, 79);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(513, 82);
            this.txtObs.TabIndex = 24;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPRODUTODataGridViewTextBoxColumn,
            this.nOMEPRODUTODataGridViewTextBoxColumn,
            this.qUANTIDADEPRODUTODataGridViewTextBoxColumn,
            this.vALORPRODUTODataGridViewTextBoxColumn,
            this.iDFORNECEDORPRODUTODataGridViewTextBoxColumn,
            this.oBSPRODUTODataGridViewTextBoxColumn});
            this.dgvProdutos.DataSource = this.pRODUTOSBindingSource;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(0, 0);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(757, 215);
            this.dgvProdutos.TabIndex = 1;
            // 
            // iDPRODUTODataGridViewTextBoxColumn
            // 
            this.iDPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUTO";
            this.iDPRODUTODataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDPRODUTODataGridViewTextBoxColumn.Name = "iDPRODUTODataGridViewTextBoxColumn";
            this.iDPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMEPRODUTODataGridViewTextBoxColumn
            // 
            this.nOMEPRODUTODataGridViewTextBoxColumn.DataPropertyName = "NOME_PRODUTO";
            this.nOMEPRODUTODataGridViewTextBoxColumn.HeaderText = "PRODUTO";
            this.nOMEPRODUTODataGridViewTextBoxColumn.Name = "nOMEPRODUTODataGridViewTextBoxColumn";
            this.nOMEPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qUANTIDADEPRODUTODataGridViewTextBoxColumn
            // 
            this.qUANTIDADEPRODUTODataGridViewTextBoxColumn.DataPropertyName = "QUANTIDADE_PRODUTO";
            this.qUANTIDADEPRODUTODataGridViewTextBoxColumn.HeaderText = "QUANTIDADE";
            this.qUANTIDADEPRODUTODataGridViewTextBoxColumn.Name = "qUANTIDADEPRODUTODataGridViewTextBoxColumn";
            this.qUANTIDADEPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vALORPRODUTODataGridViewTextBoxColumn
            // 
            this.vALORPRODUTODataGridViewTextBoxColumn.DataPropertyName = "VALOR_PRODUTO";
            this.vALORPRODUTODataGridViewTextBoxColumn.HeaderText = "VALOR";
            this.vALORPRODUTODataGridViewTextBoxColumn.Name = "vALORPRODUTODataGridViewTextBoxColumn";
            this.vALORPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDFORNECEDORPRODUTODataGridViewTextBoxColumn
            // 
            this.iDFORNECEDORPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ID_FORNECEDOR_PRODUTO";
            this.iDFORNECEDORPRODUTODataGridViewTextBoxColumn.HeaderText = "ID_FORNECEDOR";
            this.iDFORNECEDORPRODUTODataGridViewTextBoxColumn.Name = "iDFORNECEDORPRODUTODataGridViewTextBoxColumn";
            this.iDFORNECEDORPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oBSPRODUTODataGridViewTextBoxColumn
            // 
            this.oBSPRODUTODataGridViewTextBoxColumn.DataPropertyName = "OBS_PRODUTO";
            this.oBSPRODUTODataGridViewTextBoxColumn.HeaderText = "OBS";
            this.oBSPRODUTODataGridViewTextBoxColumn.Name = "oBSPRODUTODataGridViewTextBoxColumn";
            this.oBSPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODUTOSBindingSource
            // 
            this.pRODUTOSBindingSource.DataMember = "PRODUTOS";
            this.pRODUTOSBindingSource.DataSource = this.dataSetMadeireiraV2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProdutos);
            this.panel1.Location = new System.Drawing.Point(12, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 215);
            this.panel1.TabIndex = 2;
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
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(554, 50);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(554, 21);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 42;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // pRODUTOSTableAdapter
            // 
            this.pRODUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // fORNECEDORESTableAdapter
            // 
            this.fORNECEDORESTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(554, 134);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 426);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProduto";
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireiraV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtFiltro;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.ComboBox comboBox1;
        private Bancos.DataSetMadeireiraV2 dataSetMadeireiraV2;
        private System.Windows.Forms.BindingSource pRODUTOSBindingSource;
        private Bancos.DataSetMadeireiraV2TableAdapters.PRODUTOSTableAdapter pRODUTOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTIDADEPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vALORPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFORNECEDORPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fORNECEDORESBindingSource;
        private Bancos.DataSetMadeireiraV2TableAdapters.FORNECEDORESTableAdapter fORNECEDORESTableAdapter;
        private System.Windows.Forms.Button btnCancelar;
    }
}