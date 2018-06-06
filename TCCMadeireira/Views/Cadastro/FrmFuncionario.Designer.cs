namespace TCCMadeireira.Views
{
    /// <summary>
    /// Classe de design do FrmFuncionario
    /// <para>Responsável pelo visual do Form</para>
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class FrmFuncionario
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
            System.Windows.Forms.Label cIDADE_CLIENTELabel;
            System.Windows.Forms.Label bAIRRO_CLIENTELabel;
            System.Windows.Forms.Label eSTADO_CLIENTELabel;
            System.Windows.Forms.Label rUA_CLIENTELabel;
            System.Windows.Forms.Label nUMERO_CLIENTELabel;
            System.Windows.Forms.Label cEP_CLIENTELabel;
            System.Windows.Forms.Label nOME_CLIENTELabel;
            System.Windows.Forms.Label cPF_CNPJ_CLIENTELabel;
            System.Windows.Forms.Label eMAIL_CLIENTELabel;
            System.Windows.Forms.Label tELEFONE_CLIENTELabel;
            System.Windows.Forms.Label cELULAR_CLIENTELabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionario));
            this.lblDataInfo = new System.Windows.Forms.Label();
            this.rbtnCnpjFiltro = new System.Windows.Forms.RadioButton();
            this.rbtnCpfFiltro = new System.Windows.Forms.RadioButton();
            this.txtFiltro = new System.Windows.Forms.MaskedTextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.rbtnCnpj = new System.Windows.Forms.RadioButton();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.rbtnCpf = new System.Windows.Forms.RadioButton();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdentidade = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlDgv = new System.Windows.Forms.Panel();
            this.fUNCIONARIOSDataGridView = new System.Windows.Forms.DataGridView();
            this.iDFUNCIONARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEFUNCIONARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDENTIDADEFUNCIONARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARGOFUNCIONARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPFUNCIONARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUAFUNCIONARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEROFUNCIONARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAIRROFUNCIONARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDADEFUNCIONARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADOFUNCIONARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONEFUNCIONARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cELULARFUNCIONARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILFUNCIONARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSFUNCIONARIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fUNCIONARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMadeireiraV2 = new TCCMadeireira.Bancos.DataSetMadeireiraV2();
            this.fUNCIONARIOSTableAdapter = new TCCMadeireira.Bancos.DataSetMadeireiraV2TableAdapters.FUNCIONARIOSTableAdapter();
            this.btnCancelar = new System.Windows.Forms.Button();
            cIDADE_CLIENTELabel = new System.Windows.Forms.Label();
            bAIRRO_CLIENTELabel = new System.Windows.Forms.Label();
            eSTADO_CLIENTELabel = new System.Windows.Forms.Label();
            rUA_CLIENTELabel = new System.Windows.Forms.Label();
            nUMERO_CLIENTELabel = new System.Windows.Forms.Label();
            cEP_CLIENTELabel = new System.Windows.Forms.Label();
            nOME_CLIENTELabel = new System.Windows.Forms.Label();
            cPF_CNPJ_CLIENTELabel = new System.Windows.Forms.Label();
            eMAIL_CLIENTELabel = new System.Windows.Forms.Label();
            tELEFONE_CLIENTELabel = new System.Windows.Forms.Label();
            cELULAR_CLIENTELabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.pnlDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireiraV2)).BeginInit();
            this.SuspendLayout();
            // 
            // cIDADE_CLIENTELabel
            // 
            cIDADE_CLIENTELabel.AutoSize = true;
            cIDADE_CLIENTELabel.Location = new System.Drawing.Point(362, 133);
            cIDADE_CLIENTELabel.Name = "cIDADE_CLIENTELabel";
            cIDADE_CLIENTELabel.Size = new System.Drawing.Size(50, 13);
            cIDADE_CLIENTELabel.TabIndex = 14;
            cIDADE_CLIENTELabel.Text = "CIDADE:";
            // 
            // bAIRRO_CLIENTELabel
            // 
            bAIRRO_CLIENTELabel.AutoSize = true;
            bAIRRO_CLIENTELabel.Location = new System.Drawing.Point(6, 133);
            bAIRRO_CLIENTELabel.Name = "bAIRRO_CLIENTELabel";
            bAIRRO_CLIENTELabel.Size = new System.Drawing.Size(51, 13);
            bAIRRO_CLIENTELabel.TabIndex = 12;
            bAIRRO_CLIENTELabel.Text = "BAIRRO:";
            // 
            // eSTADO_CLIENTELabel
            // 
            eSTADO_CLIENTELabel.AutoSize = true;
            eSTADO_CLIENTELabel.Location = new System.Drawing.Point(602, 133);
            eSTADO_CLIENTELabel.Name = "eSTADO_CLIENTELabel";
            eSTADO_CLIENTELabel.Size = new System.Drawing.Size(24, 13);
            eSTADO_CLIENTELabel.TabIndex = 16;
            eSTADO_CLIENTELabel.Text = "UF:";
            // 
            // rUA_CLIENTELabel
            // 
            rUA_CLIENTELabel.AutoSize = true;
            rUA_CLIENTELabel.Location = new System.Drawing.Point(6, 104);
            rUA_CLIENTELabel.Name = "rUA_CLIENTELabel";
            rUA_CLIENTELabel.Size = new System.Drawing.Size(33, 13);
            rUA_CLIENTELabel.TabIndex = 8;
            rUA_CLIENTELabel.Text = "RUA:";
            // 
            // nUMERO_CLIENTELabel
            // 
            nUMERO_CLIENTELabel.AutoSize = true;
            nUMERO_CLIENTELabel.Location = new System.Drawing.Point(604, 104);
            nUMERO_CLIENTELabel.Name = "nUMERO_CLIENTELabel";
            nUMERO_CLIENTELabel.Size = new System.Drawing.Size(22, 13);
            nUMERO_CLIENTELabel.TabIndex = 10;
            nUMERO_CLIENTELabel.Text = "Nº:";
            // 
            // cEP_CLIENTELabel
            // 
            cEP_CLIENTELabel.AutoSize = true;
            cEP_CLIENTELabel.Location = new System.Drawing.Point(587, 73);
            cEP_CLIENTELabel.Name = "cEP_CLIENTELabel";
            cEP_CLIENTELabel.Size = new System.Drawing.Size(31, 13);
            cEP_CLIENTELabel.TabIndex = 6;
            cEP_CLIENTELabel.Text = "CEP:";
            // 
            // nOME_CLIENTELabel
            // 
            nOME_CLIENTELabel.AutoSize = true;
            nOME_CLIENTELabel.Location = new System.Drawing.Point(6, 16);
            nOME_CLIENTELabel.Name = "nOME_CLIENTELabel";
            nOME_CLIENTELabel.Size = new System.Drawing.Size(42, 13);
            nOME_CLIENTELabel.TabIndex = 2;
            nOME_CLIENTELabel.Text = "NOME:";
            // 
            // cPF_CNPJ_CLIENTELabel
            // 
            cPF_CNPJ_CLIENTELabel.AutoSize = true;
            cPF_CNPJ_CLIENTELabel.Location = new System.Drawing.Point(387, 16);
            cPF_CNPJ_CLIENTELabel.Name = "cPF_CNPJ_CLIENTELabel";
            cPF_CNPJ_CLIENTELabel.Size = new System.Drawing.Size(76, 13);
            cPF_CNPJ_CLIENTELabel.TabIndex = 4;
            cPF_CNPJ_CLIENTELabel.Text = "IDENTIDADE:";
            // 
            // eMAIL_CLIENTELabel
            // 
            eMAIL_CLIENTELabel.AutoSize = true;
            eMAIL_CLIENTELabel.Location = new System.Drawing.Point(6, 44);
            eMAIL_CLIENTELabel.Name = "eMAIL_CLIENTELabel";
            eMAIL_CLIENTELabel.Size = new System.Drawing.Size(45, 13);
            eMAIL_CLIENTELabel.TabIndex = 22;
            eMAIL_CLIENTELabel.Text = "E-MAIL:";
            // 
            // tELEFONE_CLIENTELabel
            // 
            tELEFONE_CLIENTELabel.AutoSize = true;
            tELEFONE_CLIENTELabel.Location = new System.Drawing.Point(527, 44);
            tELEFONE_CLIENTELabel.Name = "tELEFONE_CLIENTELabel";
            tELEFONE_CLIENTELabel.Size = new System.Drawing.Size(66, 13);
            tELEFONE_CLIENTELabel.TabIndex = 18;
            tELEFONE_CLIENTELabel.Text = "TELEFONE:";
            // 
            // cELULAR_CLIENTELabel
            // 
            cELULAR_CLIENTELabel.AutoSize = true;
            cELULAR_CLIENTELabel.Location = new System.Drawing.Point(433, 73);
            cELULAR_CLIENTELabel.Name = "cELULAR_CLIENTELabel";
            cELULAR_CLIENTELabel.Size = new System.Drawing.Size(59, 13);
            cELULAR_CLIENTELabel.TabIndex = 20;
            cELULAR_CLIENTELabel.Text = "CELULAR:";
            // 
            // lblDataInfo
            // 
            this.lblDataInfo.Location = new System.Drawing.Point(702, 250);
            this.lblDataInfo.MaximumSize = new System.Drawing.Size(10000, 1000);
            this.lblDataInfo.Name = "lblDataInfo";
            this.lblDataInfo.Size = new System.Drawing.Size(100, 20);
            this.lblDataInfo.TabIndex = 41;
            this.lblDataInfo.Text = "DATA_INFO";
            this.lblDataInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtnCnpjFiltro
            // 
            this.rbtnCnpjFiltro.AutoSize = true;
            this.rbtnCnpjFiltro.Location = new System.Drawing.Point(762, 138);
            this.rbtnCnpjFiltro.Name = "rbtnCnpjFiltro";
            this.rbtnCnpjFiltro.Size = new System.Drawing.Size(52, 17);
            this.rbtnCnpjFiltro.TabIndex = 48;
            this.rbtnCnpjFiltro.Text = "CNPJ";
            this.rbtnCnpjFiltro.UseVisualStyleBackColor = true;
            this.rbtnCnpjFiltro.Click += new System.EventHandler(this.RbtnCpfFiltro_CheckedChanged);
            // 
            // rbtnCpfFiltro
            // 
            this.rbtnCpfFiltro.AutoSize = true;
            this.rbtnCpfFiltro.Checked = true;
            this.rbtnCpfFiltro.Location = new System.Drawing.Point(711, 138);
            this.rbtnCpfFiltro.Name = "rbtnCpfFiltro";
            this.rbtnCpfFiltro.Size = new System.Drawing.Size(45, 17);
            this.rbtnCpfFiltro.TabIndex = 47;
            this.rbtnCpfFiltro.TabStop = true;
            this.rbtnCpfFiltro.Text = "CPF";
            this.rbtnCpfFiltro.UseVisualStyleBackColor = true;
            this.rbtnCpfFiltro.CheckedChanged += new System.EventHandler(this.RbtnCpfFiltro_CheckedChanged);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(711, 110);
            this.txtFiltro.Mask = "999,999,999-99";
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(107, 20);
            this.txtFiltro.TabIndex = 46;
            this.txtFiltro.TabStop = false;
            this.txtFiltro.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(711, 81);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(83, 23);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(711, 52);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(83, 23);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(711, 23);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(83, 23);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCargo);
            this.groupBox1.Controls.Add(this.rbtnCnpj);
            this.groupBox1.Controls.Add(cIDADE_CLIENTELabel);
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.cmbUf);
            this.groupBox1.Controls.Add(this.txtCep);
            this.groupBox1.Controls.Add(bAIRRO_CLIENTELabel);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(eSTADO_CLIENTELabel);
            this.groupBox1.Controls.Add(rUA_CLIENTELabel);
            this.groupBox1.Controls.Add(this.txtRua);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(nUMERO_CLIENTELabel);
            this.groupBox1.Controls.Add(this.rbtnCpf);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(cEP_CLIENTELabel);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(nOME_CLIENTELabel);
            this.groupBox1.Controls.Add(cPF_CNPJ_CLIENTELabel);
            this.groupBox1.Controls.Add(this.txtIdentidade);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(eMAIL_CLIENTELabel);
            this.groupBox1.Controls.Add(tELEFONE_CLIENTELabel);
            this.groupBox1.Controls.Add(cELULAR_CLIENTELabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 265);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "CARGO";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(57, 70);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(370, 20);
            this.txtCargo.TabIndex = 5;
            // 
            // rbtnCnpj
            // 
            this.rbtnCnpj.AutoSize = true;
            this.rbtnCnpj.Location = new System.Drawing.Point(632, 14);
            this.rbtnCnpj.Name = "rbtnCnpj";
            this.rbtnCnpj.Size = new System.Drawing.Size(52, 17);
            this.rbtnCnpj.TabIndex = 31;
            this.rbtnCnpj.Text = "CNPJ";
            this.rbtnCnpj.UseVisualStyleBackColor = true;
            this.rbtnCnpj.Click += new System.EventHandler(this.RbtnIden_CheckedChanged);
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(9, 156);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(675, 102);
            this.txtObs.TabIndex = 13;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(418, 130);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(178, 20);
            this.txtCidade.TabIndex = 11;
            // 
            // cmbUf
            // 
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.Items.AddRange(new object[] {
            "",
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.cmbUf.Location = new System.Drawing.Point(632, 130);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(52, 21);
            this.cmbUf.TabIndex = 12;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(624, 70);
            this.txtCep.Mask = "99999-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(60, 20);
            this.txtCep.TabIndex = 7;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(63, 130);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(293, 20);
            this.txtBairro.TabIndex = 10;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(45, 101);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(553, 20);
            this.txtRua.TabIndex = 8;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(498, 70);
            this.txtCelular.Mask = "(00)09999-9999";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(83, 20);
            this.txtCelular.TabIndex = 6;
            // 
            // rbtnCpf
            // 
            this.rbtnCpf.AutoSize = true;
            this.rbtnCpf.Checked = true;
            this.rbtnCpf.Location = new System.Drawing.Point(581, 14);
            this.rbtnCpf.Name = "rbtnCpf";
            this.rbtnCpf.Size = new System.Drawing.Size(45, 17);
            this.rbtnCpf.TabIndex = 30;
            this.rbtnCpf.TabStop = true;
            this.rbtnCpf.Text = "CPF";
            this.rbtnCpf.UseVisualStyleBackColor = true;
            this.rbtnCpf.Click += new System.EventHandler(this.RbtnIden_CheckedChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(632, 101);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(52, 20);
            this.txtNumero.TabIndex = 9;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(599, 41);
            this.txtTelefone.Mask = "(00)09999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(85, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(54, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(327, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtIdentidade
            // 
            this.txtIdentidade.Location = new System.Drawing.Point(468, 13);
            this.txtIdentidade.Mask = "999,999,999-99";
            this.txtIdentidade.Name = "txtIdentidade";
            this.txtIdentidade.Size = new System.Drawing.Size(83, 20);
            this.txtIdentidade.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(57, 41);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(464, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.fUNCIONARIOSDataGridView);
            this.pnlDgv.Location = new System.Drawing.Point(12, 284);
            this.pnlDgv.Name = "pnlDgv";
            this.pnlDgv.Size = new System.Drawing.Size(854, 287);
            this.pnlDgv.TabIndex = 49;
            // 
            // fUNCIONARIOSDataGridView
            // 
            this.fUNCIONARIOSDataGridView.AllowUserToAddRows = false;
            this.fUNCIONARIOSDataGridView.AllowUserToDeleteRows = false;
            this.fUNCIONARIOSDataGridView.AllowUserToOrderColumns = true;
            this.fUNCIONARIOSDataGridView.AutoGenerateColumns = false;
            this.fUNCIONARIOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fUNCIONARIOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDFUNCIONARIODataGridViewTextBoxColumn,
            this.nOMEFUNCIONARIODataGridViewTextBoxColumn,
            this.iDENTIDADEFUNCIONARIODataGridViewTextBoxColumn,
            this.cARGOFUNCIONARIODataGridViewTextBoxColumn,
            this.cEPFUNCIONARIODataGridViewTextBoxColumn,
            this.rUAFUNCIONARIODataGridViewTextBoxColumn,
            this.nUMEROFUNCIONARIODataGridViewTextBoxColumn,
            this.bAIRROFUNCIONARIODataGridViewTextBoxColumn,
            this.cIDADEFUNCIONARIODataGridViewTextBoxColumn,
            this.eSTADOFUNCIONARIODataGridViewTextBoxColumn,
            this.tELEFONEFUNCIONARIODataGridViewTextBoxColumn,
            this.cELULARFUNCIONARIODataGridViewTextBoxColumn,
            this.eMAILFUNCIONARIODataGridViewTextBoxColumn,
            this.oBSFUNCIONARIODataGridViewTextBoxColumn});
            this.fUNCIONARIOSDataGridView.DataSource = this.fUNCIONARIOSBindingSource;
            this.fUNCIONARIOSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fUNCIONARIOSDataGridView.Location = new System.Drawing.Point(0, 0);
            this.fUNCIONARIOSDataGridView.MultiSelect = false;
            this.fUNCIONARIOSDataGridView.Name = "fUNCIONARIOSDataGridView";
            this.fUNCIONARIOSDataGridView.ReadOnly = true;
            this.fUNCIONARIOSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fUNCIONARIOSDataGridView.Size = new System.Drawing.Size(854, 287);
            this.fUNCIONARIOSDataGridView.TabIndex = 0;
            this.fUNCIONARIOSDataGridView.TabStop = false;
            this.fUNCIONARIOSDataGridView.SelectionChanged += new System.EventHandler(this.FUNCIONARIOSDataGridView_SelectionChanged);
            // 
            // iDFUNCIONARIODataGridViewTextBoxColumn
            // 
            this.iDFUNCIONARIODataGridViewTextBoxColumn.DataPropertyName = "ID_FUNCIONARIO";
            this.iDFUNCIONARIODataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDFUNCIONARIODataGridViewTextBoxColumn.Name = "iDFUNCIONARIODataGridViewTextBoxColumn";
            this.iDFUNCIONARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMEFUNCIONARIODataGridViewTextBoxColumn
            // 
            this.nOMEFUNCIONARIODataGridViewTextBoxColumn.DataPropertyName = "NOME_FUNCIONARIO";
            this.nOMEFUNCIONARIODataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEFUNCIONARIODataGridViewTextBoxColumn.Name = "nOMEFUNCIONARIODataGridViewTextBoxColumn";
            this.nOMEFUNCIONARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDENTIDADEFUNCIONARIODataGridViewTextBoxColumn
            // 
            this.iDENTIDADEFUNCIONARIODataGridViewTextBoxColumn.DataPropertyName = "IDENTIDADE_FUNCIONARIO";
            this.iDENTIDADEFUNCIONARIODataGridViewTextBoxColumn.HeaderText = "IDENTIDADE";
            this.iDENTIDADEFUNCIONARIODataGridViewTextBoxColumn.Name = "iDENTIDADEFUNCIONARIODataGridViewTextBoxColumn";
            this.iDENTIDADEFUNCIONARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cARGOFUNCIONARIODataGridViewTextBoxColumn
            // 
            this.cARGOFUNCIONARIODataGridViewTextBoxColumn.DataPropertyName = "CARGO_FUNCIONARIO";
            this.cARGOFUNCIONARIODataGridViewTextBoxColumn.HeaderText = "CARGO";
            this.cARGOFUNCIONARIODataGridViewTextBoxColumn.Name = "cARGOFUNCIONARIODataGridViewTextBoxColumn";
            this.cARGOFUNCIONARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEPFUNCIONARIODataGridViewTextBoxColumn
            // 
            this.cEPFUNCIONARIODataGridViewTextBoxColumn.DataPropertyName = "CEP_FUNCIONARIO";
            this.cEPFUNCIONARIODataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPFUNCIONARIODataGridViewTextBoxColumn.Name = "cEPFUNCIONARIODataGridViewTextBoxColumn";
            this.cEPFUNCIONARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rUAFUNCIONARIODataGridViewTextBoxColumn
            // 
            this.rUAFUNCIONARIODataGridViewTextBoxColumn.DataPropertyName = "RUA_FUNCIONARIO";
            this.rUAFUNCIONARIODataGridViewTextBoxColumn.HeaderText = "RUA";
            this.rUAFUNCIONARIODataGridViewTextBoxColumn.Name = "rUAFUNCIONARIODataGridViewTextBoxColumn";
            this.rUAFUNCIONARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nUMEROFUNCIONARIODataGridViewTextBoxColumn
            // 
            this.nUMEROFUNCIONARIODataGridViewTextBoxColumn.DataPropertyName = "NUMERO_FUNCIONARIO";
            this.nUMEROFUNCIONARIODataGridViewTextBoxColumn.HeaderText = "NUMERO";
            this.nUMEROFUNCIONARIODataGridViewTextBoxColumn.Name = "nUMEROFUNCIONARIODataGridViewTextBoxColumn";
            this.nUMEROFUNCIONARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bAIRROFUNCIONARIODataGridViewTextBoxColumn
            // 
            this.bAIRROFUNCIONARIODataGridViewTextBoxColumn.DataPropertyName = "BAIRRO_FUNCIONARIO";
            this.bAIRROFUNCIONARIODataGridViewTextBoxColumn.HeaderText = "BAIRRO";
            this.bAIRROFUNCIONARIODataGridViewTextBoxColumn.Name = "bAIRROFUNCIONARIODataGridViewTextBoxColumn";
            this.bAIRROFUNCIONARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cIDADEFUNCIONARIODataGridViewTextBoxColumn
            // 
            this.cIDADEFUNCIONARIODataGridViewTextBoxColumn.DataPropertyName = "CIDADE_FUNCIONARIO";
            this.cIDADEFUNCIONARIODataGridViewTextBoxColumn.HeaderText = "CIDADE";
            this.cIDADEFUNCIONARIODataGridViewTextBoxColumn.Name = "cIDADEFUNCIONARIODataGridViewTextBoxColumn";
            this.cIDADEFUNCIONARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eSTADOFUNCIONARIODataGridViewTextBoxColumn
            // 
            this.eSTADOFUNCIONARIODataGridViewTextBoxColumn.DataPropertyName = "ESTADO_FUNCIONARIO";
            this.eSTADOFUNCIONARIODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADOFUNCIONARIODataGridViewTextBoxColumn.Name = "eSTADOFUNCIONARIODataGridViewTextBoxColumn";
            this.eSTADOFUNCIONARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tELEFONEFUNCIONARIODataGridViewTextBoxColumn
            // 
            this.tELEFONEFUNCIONARIODataGridViewTextBoxColumn.DataPropertyName = "TELEFONE_FUNCIONARIO";
            this.tELEFONEFUNCIONARIODataGridViewTextBoxColumn.HeaderText = "TELEFONE";
            this.tELEFONEFUNCIONARIODataGridViewTextBoxColumn.Name = "tELEFONEFUNCIONARIODataGridViewTextBoxColumn";
            this.tELEFONEFUNCIONARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cELULARFUNCIONARIODataGridViewTextBoxColumn
            // 
            this.cELULARFUNCIONARIODataGridViewTextBoxColumn.DataPropertyName = "CELULAR_FUNCIONARIO";
            this.cELULARFUNCIONARIODataGridViewTextBoxColumn.HeaderText = "CELULAR";
            this.cELULARFUNCIONARIODataGridViewTextBoxColumn.Name = "cELULARFUNCIONARIODataGridViewTextBoxColumn";
            this.cELULARFUNCIONARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMAILFUNCIONARIODataGridViewTextBoxColumn
            // 
            this.eMAILFUNCIONARIODataGridViewTextBoxColumn.DataPropertyName = "EMAIL_FUNCIONARIO";
            this.eMAILFUNCIONARIODataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILFUNCIONARIODataGridViewTextBoxColumn.Name = "eMAILFUNCIONARIODataGridViewTextBoxColumn";
            this.eMAILFUNCIONARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oBSFUNCIONARIODataGridViewTextBoxColumn
            // 
            this.oBSFUNCIONARIODataGridViewTextBoxColumn.DataPropertyName = "OBS_FUNCIONARIO";
            this.oBSFUNCIONARIODataGridViewTextBoxColumn.HeaderText = "OBS";
            this.oBSFUNCIONARIODataGridViewTextBoxColumn.Name = "oBSFUNCIONARIODataGridViewTextBoxColumn";
            this.oBSFUNCIONARIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fUNCIONARIOSBindingSource
            // 
            this.fUNCIONARIOSBindingSource.DataMember = "FUNCIONARIOS";
            this.fUNCIONARIOSBindingSource.DataSource = this.dataSetMadeireiraV2;
            // 
            // dataSetMadeireiraV2
            // 
            this.dataSetMadeireiraV2.DataSetName = "DataSetMadeireiraV2";
            this.dataSetMadeireiraV2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fUNCIONARIOSTableAdapter
            // 
            this.fUNCIONARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(711, 161);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 582);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlDgv);
            this.Controls.Add(this.lblDataInfo);
            this.Controls.Add(this.rbtnCnpjFiltro);
            this.Controls.Add(this.rbtnCpfFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFuncionario";
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.FrmFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireiraV2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDataInfo;
        private System.Windows.Forms.RadioButton rbtnCnpjFiltro;
        private System.Windows.Forms.RadioButton rbtnCpfFiltro;
        private System.Windows.Forms.MaskedTextBox txtFiltro;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.RadioButton rbtnCnpj;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.RadioButton rbtnCpf;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtIdentidade;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlDgv;
        private System.Windows.Forms.DataGridView fUNCIONARIOSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Bancos.DataSetMadeireiraV2 dataSetMadeireiraV2;
        private System.Windows.Forms.BindingSource fUNCIONARIOSBindingSource;
        private Bancos.DataSetMadeireiraV2TableAdapters.FUNCIONARIOSTableAdapter fUNCIONARIOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDFUNCIONARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEFUNCIONARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDENTIDADEFUNCIONARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARGOFUNCIONARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPFUNCIONARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUAFUNCIONARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROFUNCIONARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAIRROFUNCIONARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDADEFUNCIONARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADOFUNCIONARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONEFUNCIONARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cELULARFUNCIONARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILFUNCIONARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSFUNCIONARIODataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCancelar;
    }
}