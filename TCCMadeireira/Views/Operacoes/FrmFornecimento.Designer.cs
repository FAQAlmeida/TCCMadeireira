namespace TCCMadeireira.Views
{
    partial class FrmFornecimento
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
            System.Windows.Forms.Label cPF_CNPJ_CLIENTELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFornecimento));
            this.pnlVenda = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.grbProdutos = new System.Windows.Forms.GroupBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbFornecedor = new System.Windows.Forms.GroupBox();
            this.rbtnCnpj = new System.Windows.Forms.RadioButton();
            this.rbtnCpf = new System.Windows.Forms.RadioButton();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentidade = new System.Windows.Forms.MaskedTextBox();
            cPF_CNPJ_CLIENTELabel = new System.Windows.Forms.Label();
            this.pnlVenda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbFornecedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // cPF_CNPJ_CLIENTELabel
            // 
            cPF_CNPJ_CLIENTELabel.AutoSize = true;
            cPF_CNPJ_CLIENTELabel.Location = new System.Drawing.Point(6, 16);
            cPF_CNPJ_CLIENTELabel.Name = "cPF_CNPJ_CLIENTELabel";
            cPF_CNPJ_CLIENTELabel.Size = new System.Drawing.Size(76, 13);
            cPF_CNPJ_CLIENTELabel.TabIndex = 30;
            cPF_CNPJ_CLIENTELabel.Text = "IDENTIDADE:";
            // 
            // pnlVenda
            // 
            this.pnlVenda.Controls.Add(this.btnCancelar);
            this.pnlVenda.Controls.Add(this.btnFinalizar);
            this.pnlVenda.Location = new System.Drawing.Point(555, 269);
            this.pnlVenda.Name = "pnlVenda";
            this.pnlVenda.Size = new System.Drawing.Size(167, 77);
            this.pnlVenda.TabIndex = 51;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(6, 42);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(6, 13);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 0;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblValorTotal);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Location = new System.Drawing.Point(555, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 144);
            this.panel1.TabIndex = 50;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(3, 100);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(84, 13);
            this.lblValorTotal.TabIndex = 2;
            this.lblValorTotal.Text = "Valor Total:  R$ ";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(3, 45);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(3, 16);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // grbProdutos
            // 
            this.grbProdutos.Controls.Add(this.dgvProdutos);
            this.grbProdutos.Location = new System.Drawing.Point(12, 119);
            this.grbProdutos.Name = "grbProdutos";
            this.grbProdutos.Size = new System.Drawing.Size(537, 270);
            this.grbProdutos.TabIndex = 49;
            this.grbProdutos.TabStop = false;
            this.grbProdutos.Text = "Produtos";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.NomeProduto,
            this.QuantidadeProduto,
            this.ValorProduto});
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 16);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(531, 251);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ValorSet);
            this.dgvProdutos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.ValorSet);
            // 
            // IdProduto
            // 
            this.IdProduto.HeaderText = "ID";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "NOME";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            // 
            // QuantidadeProduto
            // 
            this.QuantidadeProduto.HeaderText = "QUANTIDADE";
            this.QuantidadeProduto.Name = "QuantidadeProduto";
            this.QuantidadeProduto.ReadOnly = true;
            // 
            // ValorProduto
            // 
            this.ValorProduto.HeaderText = "VALOR";
            this.ValorProduto.Name = "ValorProduto";
            this.ValorProduto.ReadOnly = true;
            // 
            // grbFornecedor
            // 
            this.grbFornecedor.Controls.Add(this.rbtnCnpj);
            this.grbFornecedor.Controls.Add(this.rbtnCpf);
            this.grbFornecedor.Controls.Add(this.lblEndereco);
            this.grbFornecedor.Controls.Add(this.lblNome);
            this.grbFornecedor.Controls.Add(this.label2);
            this.grbFornecedor.Controls.Add(this.label1);
            this.grbFornecedor.Controls.Add(cPF_CNPJ_CLIENTELabel);
            this.grbFornecedor.Controls.Add(this.txtIdentidade);
            this.grbFornecedor.Location = new System.Drawing.Point(12, 12);
            this.grbFornecedor.Name = "grbFornecedor";
            this.grbFornecedor.Size = new System.Drawing.Size(710, 101);
            this.grbFornecedor.TabIndex = 48;
            this.grbFornecedor.TabStop = false;
            this.grbFornecedor.Text = "Fornecedor";
            // 
            // rbtnCnpj
            // 
            this.rbtnCnpj.AutoSize = true;
            this.rbtnCnpj.Checked = true;
            this.rbtnCnpj.Location = new System.Drawing.Point(263, 14);
            this.rbtnCnpj.Name = "rbtnCnpj";
            this.rbtnCnpj.Size = new System.Drawing.Size(52, 17);
            this.rbtnCnpj.TabIndex = 37;
            this.rbtnCnpj.TabStop = true;
            this.rbtnCnpj.Text = "CNPJ";
            this.rbtnCnpj.UseVisualStyleBackColor = true;
            this.rbtnCnpj.CheckedChanged += new System.EventHandler(this.RbtnIden_CheckedChanged);
            // 
            // rbtnCpf
            // 
            this.rbtnCpf.AutoSize = true;
            this.rbtnCpf.Location = new System.Drawing.Point(212, 14);
            this.rbtnCpf.Name = "rbtnCpf";
            this.rbtnCpf.Size = new System.Drawing.Size(45, 17);
            this.rbtnCpf.TabIndex = 36;
            this.rbtnCpf.Text = "CPF";
            this.rbtnCpf.UseVisualStyleBackColor = true;
            this.rbtnCpf.CheckedChanged += new System.EventHandler(this.RbtnIden_CheckedChanged);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(87, 60);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(0, 13);
            this.lblEndereco.TabIndex = 35;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(84, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 13);
            this.lblNome.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "ENDEREÇO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "NOME:";
            // 
            // txtIdentidade
            // 
            this.txtIdentidade.Location = new System.Drawing.Point(87, 13);
            this.txtIdentidade.Mask = "00,000,000/0000-00";
            this.txtIdentidade.Name = "txtIdentidade";
            this.txtIdentidade.Size = new System.Drawing.Size(106, 20);
            this.txtIdentidade.TabIndex = 31;
            this.txtIdentidade.Leave += new System.EventHandler(this.TxtIdentidade_Leave);
            // 
            // FrmFornecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 401);
            this.Controls.Add(this.pnlVenda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbProdutos);
            this.Controls.Add(this.grbFornecedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFornecimento";
            this.Text = "Fornecimento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFornecimento_FormClosing);
            this.Load += new System.EventHandler(this.FrmFornecimento_Load);
            this.pnlVenda.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbFornecedor.ResumeLayout(false);
            this.grbFornecedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVenda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox grbProdutos;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorProduto;
        private System.Windows.Forms.GroupBox grbFornecedor;
        private System.Windows.Forms.RadioButton rbtnCnpj;
        private System.Windows.Forms.RadioButton rbtnCpf;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtIdentidade;
    }
}