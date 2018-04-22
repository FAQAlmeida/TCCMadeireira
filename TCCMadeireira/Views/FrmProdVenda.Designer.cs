namespace TCCMadeireira.Views
{
    partial class FrmProdVenda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dvgProduto = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMadeireiraV2 = new TCCMadeireira.Bancos.DataSetMadeireiraV2();
            this.produtosTableAdapter = new TCCMadeireira.Bancos.DataSetMadeireiraV2TableAdapters.PRODUTOSTableAdapter();
            this.tableAdapterManager = new TCCMadeireira.Bancos.DataSetMadeireiraV2TableAdapters.TableAdapterManager();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireiraV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dvgProduto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 280);
            this.panel1.TabIndex = 0;
            // 
            // dvgProduto
            // 
            this.dvgProduto.AllowUserToAddRows = false;
            this.dvgProduto.AllowUserToDeleteRows = false;
            this.dvgProduto.AutoGenerateColumns = false;
            this.dvgProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dvgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dvgProduto.DataSource = this.produtosBindingSource;
            this.dvgProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgProduto.Location = new System.Drawing.Point(0, 0);
            this.dvgProduto.MultiSelect = false;
            this.dvgProduto.Name = "dvgProduto";
            this.dvgProduto.ReadOnly = true;
            this.dvgProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgProduto.Size = new System.Drawing.Size(652, 280);
            this.dvgProduto.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_PRODUTO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_PRODUTO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 103;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_PRODUTO";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME_PRODUTO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 124;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "QUANTIDADE_PRODUTO";
            this.dataGridViewTextBoxColumn3.HeaderText = "QUANTIDADE_PRODUTO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 163;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VALOR_PRODUTO";
            this.dataGridViewTextBoxColumn4.HeaderText = "VALOR_PRODUTO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 128;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ID_FORNECEDOR_PRODUTO";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID_FORNECEDOR_PRODUTO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 184;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OBS_PRODUTO";
            this.dataGridViewTextBoxColumn6.HeaderText = "OBS_PRODUTO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 114;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "PRODUTOS";
            this.produtosBindingSource.DataSource = this.dataSetMadeireiraV2;
            // 
            // dataSetMadeireiraV2
            // 
            this.dataSetMadeireiraV2.DataSetName = "DataSetMadeireiraV2";
            this.dataSetMadeireiraV2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTESTableAdapter = null;
            this.tableAdapterManager.FORNECEDORESTableAdapter = null;
            this.tableAdapterManager.FORNECIMENTO_PRODUTOTableAdapter = null;
            this.tableAdapterManager.FORNECIMENTOSTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOSTableAdapter = null;
            this.tableAdapterManager.PRODUTOSTableAdapter = this.produtosTableAdapter;
            this.tableAdapterManager.UpdateOrder = TCCMadeireira.Bancos.DataSetMadeireiraV2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            this.tableAdapterManager.VENDA_PRODUTOTableAdapter = null;
            this.tableAdapterManager.VENDASTableAdapter = null;
            // 
            // numValor
            // 
            this.numValor.DecimalPlaces = 2;
            this.numValor.Location = new System.Drawing.Point(122, 33);
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(120, 20);
            this.numValor.TabIndex = 2;
            this.numValor.ThousandsSeparator = true;
            this.numValor.Leave += new System.EventHandler(this.NumValor_Leave);
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(122, 7);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(120, 20);
            this.numQuantidade.TabIndex = 1;
            this.numQuantidade.Leave += new System.EventHandler(this.NumQuantidade_Leave);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(12, 9);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(81, 13);
            this.lblQuantidade.TabIndex = 3;
            this.lblQuantidade.Text = "QUANTIDADE:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 35);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(104, 13);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "VALOR UNITÁRIO: ";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Código",
            "Produto"});
            this.cmbFiltro.Location = new System.Drawing.Point(336, 43);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(94, 21);
            this.cmbFiltro.TabIndex = 3;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(436, 43);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(204, 20);
            this.txtFiltro.TabIndex = 4;
            this.txtFiltro.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(484, 4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 5;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(565, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmProdVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 350);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.numQuantidade);
            this.Controls.Add(this.numValor);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProdVenda";
            this.Text = "FrmProdVenda";
            this.Load += new System.EventHandler(this.FrmProdVenda_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireiraV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bancos.DataSetMadeireiraV2 dataSetMadeireiraV2;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private Bancos.DataSetMadeireiraV2TableAdapters.PRODUTOSTableAdapter produtosTableAdapter;
        private Bancos.DataSetMadeireiraV2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        public System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        public System.Windows.Forms.DataGridView dvgProduto;
        public System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnCancelar;
    }
}