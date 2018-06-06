using System;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            this.groupComp = new System.Windows.Forms.GroupBox();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.cmbFornecedores = new System.Windows.Forms.ComboBox();
            this.fORNECEDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMadeireiraV2 = new TCCMadeireira.Bancos.DataSetMadeireiraV2();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.iDPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTIDADEPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vALORPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDFORNECEDORPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pvlDgv = new System.Windows.Forms.Panel();
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
            this.groupComp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireiraV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).BeginInit();
            this.pvlDgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new System.Drawing.Point(7, 22);
            lblNome.Name = "lblNome";
            lblNome.Size = new System.Drawing.Size(64, 13);
            lblNome.TabIndex = 15;
            lblNome.Text = "PRODUTO:";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new System.Drawing.Point(308, 22);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new System.Drawing.Size(81, 13);
            lblQuantidade.TabIndex = 17;
            lblQuantidade.Text = "QUANTIDADE:";
            // 
            // vALOR_PRODUTOLabel
            // 
            vALOR_PRODUTOLabel.AutoSize = true;
            vALOR_PRODUTOLabel.Location = new System.Drawing.Point(7, 48);
            vALOR_PRODUTOLabel.Name = "vALOR_PRODUTOLabel";
            vALOR_PRODUTOLabel.Size = new System.Drawing.Size(46, 13);
            vALOR_PRODUTOLabel.TabIndex = 19;
            vALOR_PRODUTOLabel.Text = "VALOR:";
            // 
            // iD_FORNECEDOR_PRODUTOLabel
            // 
            iD_FORNECEDOR_PRODUTOLabel.AutoSize = true;
            iD_FORNECEDOR_PRODUTOLabel.Location = new System.Drawing.Point(180, 48);
            iD_FORNECEDOR_PRODUTOLabel.Name = "iD_FORNECEDOR_PRODUTOLabel";
            iD_FORNECEDOR_PRODUTOLabel.Size = new System.Drawing.Size(85, 13);
            iD_FORNECEDOR_PRODUTOLabel.TabIndex = 21;
            iD_FORNECEDOR_PRODUTOLabel.Text = "FORNECEDOR:";
            // 
            // groupComp
            // 
            this.groupComp.Controls.Add(this.numValor);
            this.groupComp.Controls.Add(this.cmbFornecedores);
            this.groupComp.Controls.Add(this.numQuantidade);
            this.groupComp.Controls.Add(lblNome);
            this.groupComp.Controls.Add(this.txtNome);
            this.groupComp.Controls.Add(lblQuantidade);
            this.groupComp.Controls.Add(vALOR_PRODUTOLabel);
            this.groupComp.Controls.Add(iD_FORNECEDOR_PRODUTOLabel);
            this.groupComp.Controls.Add(this.txtObs);
            this.groupComp.Location = new System.Drawing.Point(12, 12);
            this.groupComp.Name = "groupComp";
            this.groupComp.Size = new System.Drawing.Size(536, 163);
            this.groupComp.TabIndex = 0;
            this.groupComp.TabStop = false;
            this.groupComp.Text = "Produto";
            // 
            // numValor
            // 
            this.numValor.DecimalPlaces = 2;
            this.numValor.Location = new System.Drawing.Point(59, 46);
            this.numValor.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(115, 20);
            this.numValor.TabIndex = 3;
            this.numValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbFornecedores
            // 
            this.cmbFornecedores.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.fORNECEDORESBindingSource, "NOME_FORNECEDOR", true));
            this.cmbFornecedores.DataSource = this.fORNECEDORESBindingSource;
            this.cmbFornecedores.DisplayMember = "NOME_FORNECEDOR";
            this.cmbFornecedores.FormattingEnabled = true;
            this.cmbFornecedores.Location = new System.Drawing.Point(271, 45);
            this.cmbFornecedores.Name = "cmbFornecedores";
            this.cmbFornecedores.Size = new System.Drawing.Size(252, 21);
            this.cmbFornecedores.TabIndex = 4;
            this.cmbFornecedores.ValueMember = "ID_FORNECEDOR";
            this.cmbFornecedores.Leave += new System.EventHandler(this.comboBox1_Leave);
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
            this.numQuantidade.DecimalPlaces = 4;
            this.numQuantidade.Location = new System.Drawing.Point(395, 19);
            this.numQuantidade.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(128, 20);
            this.numQuantidade.TabIndex = 2;
            this.numQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(225, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(10, 71);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(513, 82);
            this.txtObs.TabIndex = 5;
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
            this.dgvProdutos.Size = new System.Drawing.Size(757, 234);
            this.dgvProdutos.TabIndex = 1;
            this.dgvProdutos.TabStop = false;
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
            // pvlDgv
            // 
            this.pvlDgv.Controls.Add(this.dgvProdutos);
            this.pvlDgv.Location = new System.Drawing.Point(12, 181);
            this.pvlDgv.Name = "pvlDgv";
            this.pvlDgv.Size = new System.Drawing.Size(757, 234);
            this.pvlDgv.TabIndex = 2;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(554, 108);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(107, 20);
            this.txtFiltro.TabIndex = 9;
            this.txtFiltro.TabStop = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(554, 79);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(554, 50);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(554, 21);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 6;
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
            this.btnCancelar.TabIndex = 10;
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
            this.Controls.Add(this.pvlDgv);
            this.Controls.Add(this.groupComp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProduto";
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.groupComp.ResumeLayout(false);
            this.groupComp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireiraV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).EndInit();
            this.pvlDgv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupComp;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Panel pvlDgv;
        private System.Windows.Forms.MaskedTextBox txtFiltro;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.ComboBox cmbFornecedores;
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
        private System.Windows.Forms.NumericUpDown numValor;
    }
}