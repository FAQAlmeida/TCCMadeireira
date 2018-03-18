namespace TCCMadeireira.Views
{
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fUNCIONARIOSDataGridView = new System.Windows.Forms.DataGridView();
            this.fUNCIONARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMadeireira = new TCCMadeireira.Bancos.DataSetMadeireira();
            this.fORNECEDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fORNECEDORESTableAdapter = new TCCMadeireira.Bancos.DataSetMadeireiraTableAdapters.FORNECEDORESTableAdapter();
            this.tableAdapterManager = new TCCMadeireira.Bancos.DataSetMadeireiraTableAdapters.TableAdapterManager();
            this.fUNCIONARIOSTableAdapter = new TCCMadeireira.Bancos.DataSetMadeireiraTableAdapters.FUNCIONARIOSTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBS_FUNCIONARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORESBindingSource)).BeginInit();
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
            this.lblDataInfo.Location = new System.Drawing.Point(708, 174);
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
            this.txtFiltro.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(711, 81);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 45;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(711, 52);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 44;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(711, 23);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 43;
            this.btnCadastrar.Text = "Cadastrar";
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
            this.txtCargo.TabIndex = 49;
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
            this.txtObs.TabIndex = 27;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(418, 130);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(178, 20);
            this.txtCidade.TabIndex = 15;
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
            this.cmbUf.TabIndex = 28;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(624, 70);
            this.txtCep.Mask = "99999-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(60, 20);
            this.txtCep.TabIndex = 30;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(63, 130);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(293, 20);
            this.txtBairro.TabIndex = 13;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(45, 101);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(553, 20);
            this.txtRua.TabIndex = 9;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(498, 70);
            this.txtCelular.Mask = "(00)09999-9999";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(83, 20);
            this.txtCelular.TabIndex = 32;
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
            this.txtNumero.TabIndex = 11;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(599, 41);
            this.txtTelefone.Mask = "(00)09999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(85, 20);
            this.txtTelefone.TabIndex = 31;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(54, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(327, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtIdentidade
            // 
            this.txtIdentidade.Location = new System.Drawing.Point(468, 13);
            this.txtIdentidade.Mask = "999,999,999-99";
            this.txtIdentidade.Name = "txtIdentidade";
            this.txtIdentidade.Size = new System.Drawing.Size(107, 20);
            this.txtIdentidade.TabIndex = 29;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(57, 41);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(464, 20);
            this.txtEmail.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fUNCIONARIOSDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 355);
            this.panel1.TabIndex = 49;
            // 
            // fUNCIONARIOSDataGridView
            // 
            this.fUNCIONARIOSDataGridView.AllowUserToAddRows = false;
            this.fUNCIONARIOSDataGridView.AllowUserToDeleteRows = false;
            this.fUNCIONARIOSDataGridView.AllowUserToOrderColumns = true;
            this.fUNCIONARIOSDataGridView.AutoGenerateColumns = false;
            this.fUNCIONARIOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fUNCIONARIOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.OBS_FUNCIONARIO});
            this.fUNCIONARIOSDataGridView.DataSource = this.fUNCIONARIOSBindingSource;
            this.fUNCIONARIOSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fUNCIONARIOSDataGridView.Location = new System.Drawing.Point(0, 0);
            this.fUNCIONARIOSDataGridView.Name = "fUNCIONARIOSDataGridView";
            this.fUNCIONARIOSDataGridView.ReadOnly = true;
            this.fUNCIONARIOSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fUNCIONARIOSDataGridView.Size = new System.Drawing.Size(854, 355);
            this.fUNCIONARIOSDataGridView.TabIndex = 0;
            this.fUNCIONARIOSDataGridView.SelectionChanged += new System.EventHandler(this.FUNCIONARIOSDataGridView_SelectionChanged);
            // 
            // fUNCIONARIOSBindingSource
            // 
            this.fUNCIONARIOSBindingSource.DataMember = "FUNCIONARIOS";
            this.fUNCIONARIOSBindingSource.DataSource = this.dataSetMadeireira;
            // 
            // dataSetMadeireira
            // 
            this.dataSetMadeireira.DataSetName = "DataSetMadeireira";
            this.dataSetMadeireira.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fORNECEDORESBindingSource
            // 
            this.fORNECEDORESBindingSource.DataMember = "FORNECEDORES";
            this.fORNECEDORESBindingSource.DataSource = this.dataSetMadeireira;
            // 
            // fORNECEDORESTableAdapter
            // 
            this.fORNECEDORESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTESTableAdapter = null;
            this.tableAdapterManager.FORNECEDORESTableAdapter = this.fORNECEDORESTableAdapter;
            this.tableAdapterManager.FORNECIMENTOSTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOSTableAdapter = this.fUNCIONARIOSTableAdapter;
            this.tableAdapterManager.PRODUTOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TCCMadeireira.Bancos.DataSetMadeireiraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDA_PRODUTOTableAdapter = null;
            this.tableAdapterManager.VENDASTableAdapter = null;
            this.tableAdapterManager.VENDEDORES_USERSTableAdapter = null;
            // 
            // fUNCIONARIOSTableAdapter
            // 
            this.fUNCIONARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_FUNCIONARIO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_FUNCIONARIO";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CPF/CNPJ_FUNCIONARIO";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDENTIDADE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CARGO_FUNCIONARIO";
            this.dataGridViewTextBoxColumn4.HeaderText = "CARGO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CEP_FUNCIONARIO";
            this.dataGridViewTextBoxColumn5.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RUA_FUNCIONARIO";
            this.dataGridViewTextBoxColumn6.HeaderText = "RUA";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NUMERO_FUNCIONARIO";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nº";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "BAIRRO_FUNCIONARIO";
            this.dataGridViewTextBoxColumn8.HeaderText = "BAIRRO";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CIDADE_FUNCIONARIO";
            this.dataGridViewTextBoxColumn9.HeaderText = "CIDADE";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ESTADO_FUNCIONARIO";
            this.dataGridViewTextBoxColumn10.HeaderText = "UF";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "TELEFONE_FUNCIONARIO";
            this.dataGridViewTextBoxColumn11.HeaderText = "TELEFONE";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CELULAR_FUNCIONARIO";
            this.dataGridViewTextBoxColumn12.HeaderText = "CELULAR";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "EMAIL_FUNCIONARIO";
            this.dataGridViewTextBoxColumn13.HeaderText = "E-MAIL";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "DATA_INFO_FUNCIONARIO";
            this.dataGridViewTextBoxColumn14.HeaderText = "DATA DA INFORMAÇÃO";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // OBS_FUNCIONARIO
            // 
            this.OBS_FUNCIONARIO.DataPropertyName = "OBS_FUNCIONARIO";
            this.OBS_FUNCIONARIO.HeaderText = "OBS";
            this.OBS_FUNCIONARIO.Name = "OBS_FUNCIONARIO";
            this.OBS_FUNCIONARIO.ReadOnly = true;
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 651);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDataInfo);
            this.Controls.Add(this.rbtnCnpjFiltro);
            this.Controls.Add(this.rbtnCpfFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFuncionario";
            this.Text = "FrmFuncionario";
            this.Load += new System.EventHandler(this.FrmFuncionario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fUNCIONARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bancos.DataSetMadeireira dataSetMadeireira;
        private System.Windows.Forms.BindingSource fORNECEDORESBindingSource;
        private Bancos.DataSetMadeireiraTableAdapters.FORNECEDORESTableAdapter fORNECEDORESTableAdapter;
        private Bancos.DataSetMadeireiraTableAdapters.TableAdapterManager tableAdapterManager;
        private Bancos.DataSetMadeireiraTableAdapters.FUNCIONARIOSTableAdapter fUNCIONARIOSTableAdapter;
        private System.Windows.Forms.BindingSource fUNCIONARIOSBindingSource;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView fUNCIONARIOSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBS_FUNCIONARIO;
    }
}