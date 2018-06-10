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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFinalizar = new MaterialSkin.Controls.MaterialRaisedButton();
            cPF_CNPJ_CLIENTELabel = new System.Windows.Forms.Label();
            this.pnlVenda.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.pnlVenda.BackColor = System.Drawing.Color.White;
            this.pnlVenda.Controls.Add(this.btnCancelar);
            this.pnlVenda.Controls.Add(this.btnFinalizar);
            this.pnlVenda.Location = new System.Drawing.Point(555, 326);
            this.pnlVenda.Name = "pnlVenda";
            this.pnlVenda.Size = new System.Drawing.Size(195, 119);
            this.pnlVenda.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.lblValorTotal);
            this.panel1.Location = new System.Drawing.Point(555, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 144);
            this.panel1.TabIndex = 50;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(3, 104);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(84, 13);
            this.lblValorTotal.TabIndex = 2;
            this.lblValorTotal.Text = "Valor Total:  R$ ";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(549, 40);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Visible = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(549, 11);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Visible = false;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // grbProdutos
            // 
            this.grbProdutos.BackColor = System.Drawing.Color.White;
            this.grbProdutos.Controls.Add(this.dgvProdutos);
            this.grbProdutos.Location = new System.Drawing.Point(12, 176);
            this.grbProdutos.Name = "grbProdutos";
            this.grbProdutos.Size = new System.Drawing.Size(537, 272);
            this.grbProdutos.TabIndex = 49;
            this.grbProdutos.TabStop = false;
            this.grbProdutos.Text = "Produtos";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.NomeProduto,
            this.QuantidadeProduto,
            this.ValorProduto});
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 16);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(531, 253);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ValorSet);
            this.dgvProdutos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.ValorSet);
            // 
            // IdProduto
            // 
            this.IdProduto.HeaderText = "ID";
            this.IdProduto.Name = "IdProduto";
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "NOME";
            this.NomeProduto.Name = "NomeProduto";
            // 
            // QuantidadeProduto
            // 
            this.QuantidadeProduto.HeaderText = "QUANTIDADE";
            this.QuantidadeProduto.Name = "QuantidadeProduto";
            // 
            // ValorProduto
            // 
            this.ValorProduto.HeaderText = "VALOR";
            this.ValorProduto.Name = "ValorProduto";
            // 
            // grbFornecedor
            // 
            this.grbFornecedor.BackColor = System.Drawing.Color.White;
            this.grbFornecedor.Controls.Add(this.rbtnCnpj);
            this.grbFornecedor.Controls.Add(this.btnRemover);
            this.grbFornecedor.Controls.Add(this.rbtnCpf);
            this.grbFornecedor.Controls.Add(this.btnAdicionar);
            this.grbFornecedor.Controls.Add(this.lblEndereco);
            this.grbFornecedor.Controls.Add(this.lblNome);
            this.grbFornecedor.Controls.Add(this.label2);
            this.grbFornecedor.Controls.Add(this.label1);
            this.grbFornecedor.Controls.Add(cPF_CNPJ_CLIENTELabel);
            this.grbFornecedor.Controls.Add(this.txtIdentidade);
            this.grbFornecedor.Location = new System.Drawing.Point(12, 69);
            this.grbFornecedor.Name = "grbFornecedor";
            this.grbFornecedor.Size = new System.Drawing.Size(738, 101);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DESCONTO:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "%",
            "R$"});
            this.comboBox1.Location = new System.Drawing.Point(126, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(36, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(6, 71);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(114, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(98, 80);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = true;
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.AutoSize = true;
            this.btnFinalizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinalizar.Depth = 0;
            this.btnFinalizar.Icon = null;
            this.btnFinalizar.Location = new System.Drawing.Point(3, 80);
            this.btnFinalizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Primary = true;
            this.btnFinalizar.Size = new System.Drawing.Size(89, 36);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "FINALIZAR";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // FrmFornecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 460);
            this.Controls.Add(this.pnlVenda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grbProdutos);
            this.Controls.Add(this.grbFornecedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFornecimento";
            this.Text = "Fornecimento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFornecimento_FormClosing);
            this.Load += new System.EventHandler(this.FrmFornecimento_Load);
            this.pnlVenda.ResumeLayout(false);
            this.pnlVenda.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbFornecedor.ResumeLayout(false);
            this.grbFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlVenda;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelar;
        private MaterialSkin.Controls.MaterialRaisedButton btnFinalizar;
    }
}