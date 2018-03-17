namespace TCCMadeireira.Views
{
    partial class FrmCliente
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
            System.Windows.Forms.Label nOME_CLIENTELabel;
            System.Windows.Forms.Label cPF_CNPJ_CLIENTELabel;
            System.Windows.Forms.Label cEP_CLIENTELabel;
            System.Windows.Forms.Label rUA_CLIENTELabel;
            System.Windows.Forms.Label nUMERO_CLIENTELabel;
            System.Windows.Forms.Label bAIRRO_CLIENTELabel;
            System.Windows.Forms.Label cIDADE_CLIENTELabel;
            System.Windows.Forms.Label eSTADO_CLIENTELabel;
            System.Windows.Forms.Label tELEFONE_CLIENTELabel;
            System.Windows.Forms.Label cELULAR_CLIENTELabel;
            System.Windows.Forms.Label eMAIL_CLIENTELabel;
            System.Windows.Forms.Label oBS__FORNECEDORLabel;
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMadeireira = new TCCMadeireira.Bancos.DataSetMadeireira();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.txtIdentidade = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDataInfo = new System.Windows.Forms.Label();
            this.rbtnCnpj = new System.Windows.Forms.RadioButton();
            this.rbtnCpf = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cLIENTESDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.MaskedTextBox();
            this.rbtnCnpjFiltro = new System.Windows.Forms.RadioButton();
            this.rbtnCpfFiltro = new System.Windows.Forms.RadioButton();
            this.cLIENTESTableAdapter = new TCCMadeireira.Bancos.DataSetMadeireiraTableAdapters.CLIENTESTableAdapter();
            this.tableAdapterManager = new TCCMadeireira.Bancos.DataSetMadeireiraTableAdapters.TableAdapterManager();
            nOME_CLIENTELabel = new System.Windows.Forms.Label();
            cPF_CNPJ_CLIENTELabel = new System.Windows.Forms.Label();
            cEP_CLIENTELabel = new System.Windows.Forms.Label();
            rUA_CLIENTELabel = new System.Windows.Forms.Label();
            nUMERO_CLIENTELabel = new System.Windows.Forms.Label();
            bAIRRO_CLIENTELabel = new System.Windows.Forms.Label();
            cIDADE_CLIENTELabel = new System.Windows.Forms.Label();
            eSTADO_CLIENTELabel = new System.Windows.Forms.Label();
            tELEFONE_CLIENTELabel = new System.Windows.Forms.Label();
            cELULAR_CLIENTELabel = new System.Windows.Forms.Label();
            eMAIL_CLIENTELabel = new System.Windows.Forms.Label();
            oBS__FORNECEDORLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireira)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESDataGridView)).BeginInit();
            this.SuspendLayout();
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
            cPF_CNPJ_CLIENTELabel.Location = new System.Drawing.Point(387, 14);
            cPF_CNPJ_CLIENTELabel.Name = "cPF_CNPJ_CLIENTELabel";
            cPF_CNPJ_CLIENTELabel.Size = new System.Drawing.Size(76, 13);
            cPF_CNPJ_CLIENTELabel.TabIndex = 4;
            cPF_CNPJ_CLIENTELabel.Text = "IDENTIDADE:";
            // 
            // cEP_CLIENTELabel
            // 
            cEP_CLIENTELabel.AutoSize = true;
            cEP_CLIENTELabel.Location = new System.Drawing.Point(6, 72);
            cEP_CLIENTELabel.Name = "cEP_CLIENTELabel";
            cEP_CLIENTELabel.Size = new System.Drawing.Size(31, 13);
            cEP_CLIENTELabel.TabIndex = 6;
            cEP_CLIENTELabel.Text = "CEP:";
            // 
            // rUA_CLIENTELabel
            // 
            rUA_CLIENTELabel.AutoSize = true;
            rUA_CLIENTELabel.Location = new System.Drawing.Point(109, 72);
            rUA_CLIENTELabel.Name = "rUA_CLIENTELabel";
            rUA_CLIENTELabel.Size = new System.Drawing.Size(33, 13);
            rUA_CLIENTELabel.TabIndex = 8;
            rUA_CLIENTELabel.Text = "RUA:";
            // 
            // nUMERO_CLIENTELabel
            // 
            nUMERO_CLIENTELabel.AutoSize = true;
            nUMERO_CLIENTELabel.Location = new System.Drawing.Point(604, 72);
            nUMERO_CLIENTELabel.Name = "nUMERO_CLIENTELabel";
            nUMERO_CLIENTELabel.Size = new System.Drawing.Size(22, 13);
            nUMERO_CLIENTELabel.TabIndex = 10;
            nUMERO_CLIENTELabel.Text = "Nº:";
            // 
            // bAIRRO_CLIENTELabel
            // 
            bAIRRO_CLIENTELabel.AutoSize = true;
            bAIRRO_CLIENTELabel.Location = new System.Drawing.Point(6, 101);
            bAIRRO_CLIENTELabel.Name = "bAIRRO_CLIENTELabel";
            bAIRRO_CLIENTELabel.Size = new System.Drawing.Size(51, 13);
            bAIRRO_CLIENTELabel.TabIndex = 12;
            bAIRRO_CLIENTELabel.Text = "BAIRRO:";
            // 
            // cIDADE_CLIENTELabel
            // 
            cIDADE_CLIENTELabel.AutoSize = true;
            cIDADE_CLIENTELabel.Location = new System.Drawing.Point(362, 101);
            cIDADE_CLIENTELabel.Name = "cIDADE_CLIENTELabel";
            cIDADE_CLIENTELabel.Size = new System.Drawing.Size(50, 13);
            cIDADE_CLIENTELabel.TabIndex = 14;
            cIDADE_CLIENTELabel.Text = "CIDADE:";
            // 
            // eSTADO_CLIENTELabel
            // 
            eSTADO_CLIENTELabel.AutoSize = true;
            eSTADO_CLIENTELabel.Location = new System.Drawing.Point(602, 101);
            eSTADO_CLIENTELabel.Name = "eSTADO_CLIENTELabel";
            eSTADO_CLIENTELabel.Size = new System.Drawing.Size(24, 13);
            eSTADO_CLIENTELabel.TabIndex = 16;
            eSTADO_CLIENTELabel.Text = "UF:";
            // 
            // tELEFONE_CLIENTELabel
            // 
            tELEFONE_CLIENTELabel.AutoSize = true;
            tELEFONE_CLIENTELabel.Location = new System.Drawing.Point(373, 44);
            tELEFONE_CLIENTELabel.Name = "tELEFONE_CLIENTELabel";
            tELEFONE_CLIENTELabel.Size = new System.Drawing.Size(66, 13);
            tELEFONE_CLIENTELabel.TabIndex = 18;
            tELEFONE_CLIENTELabel.Text = "TELEFONE:";
            // 
            // cELULAR_CLIENTELabel
            // 
            cELULAR_CLIENTELabel.AutoSize = true;
            cELULAR_CLIENTELabel.Location = new System.Drawing.Point(536, 44);
            cELULAR_CLIENTELabel.Name = "cELULAR_CLIENTELabel";
            cELULAR_CLIENTELabel.Size = new System.Drawing.Size(59, 13);
            cELULAR_CLIENTELabel.TabIndex = 20;
            cELULAR_CLIENTELabel.Text = "CELULAR:";
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
            // oBS__FORNECEDORLabel
            // 
            oBS__FORNECEDORLabel.Location = new System.Drawing.Point(150, 464);
            oBS__FORNECEDORLabel.MaximumSize = new System.Drawing.Size(1000, 0);
            oBS__FORNECEDORLabel.Name = "oBS__FORNECEDORLabel";
            oBS__FORNECEDORLabel.Size = new System.Drawing.Size(103, 0);
            oBS__FORNECEDORLabel.TabIndex = 26;
            oBS__FORNECEDORLabel.Text = "DATA";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTESBindingSource, "NOME_CLIENTE", true));
            this.txtNome.Location = new System.Drawing.Point(54, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(327, 20);
            this.txtNome.TabIndex = 3;
            // 
            // cLIENTESBindingSource
            // 
            this.cLIENTESBindingSource.DataMember = "CLIENTES";
            this.cLIENTESBindingSource.DataSource = this.dataSetMadeireira;
            // 
            // dataSetMadeireira
            // 
            this.dataSetMadeireira.DataSetName = "DataSetMadeireira";
            this.dataSetMadeireira.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtRua
            // 
            this.txtRua.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTESBindingSource, "RUA_CLIENTE", true));
            this.txtRua.Location = new System.Drawing.Point(146, 69);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(452, 20);
            this.txtRua.TabIndex = 9;
            // 
            // txtNumero
            // 
            this.txtNumero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTESBindingSource, "NUMERO_CLIENTE", true));
            this.txtNumero.Location = new System.Drawing.Point(632, 69);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(52, 20);
            this.txtNumero.TabIndex = 11;
            // 
            // txtBairro
            // 
            this.txtBairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTESBindingSource, "BAIRRO_CLIENTE", true));
            this.txtBairro.Location = new System.Drawing.Point(63, 98);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(293, 20);
            this.txtBairro.TabIndex = 13;
            // 
            // txtCidade
            // 
            this.txtCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTESBindingSource, "CIDADE_CLIENTE", true));
            this.txtCidade.Location = new System.Drawing.Point(418, 98);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(178, 20);
            this.txtCidade.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTESBindingSource, "EMAIL_CLIENTE", true));
            this.txtEmail.Location = new System.Drawing.Point(57, 41);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(310, 20);
            this.txtEmail.TabIndex = 23;
            // 
            // txtObs
            // 
            this.txtObs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLIENTESBindingSource, "OBS__FORNECEDOR", true));
            this.txtObs.Location = new System.Drawing.Point(9, 124);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(675, 102);
            this.txtObs.TabIndex = 27;
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
            this.cmbUf.Location = new System.Drawing.Point(632, 98);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(52, 21);
            this.cmbUf.TabIndex = 28;
            // 
            // txtIdentidade
            // 
            this.txtIdentidade.Location = new System.Drawing.Point(468, 11);
            this.txtIdentidade.Mask = "999,999,999-99";
            this.txtIdentidade.Name = "txtIdentidade";
            this.txtIdentidade.Size = new System.Drawing.Size(107, 20);
            this.txtIdentidade.TabIndex = 29;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(43, 69);
            this.txtCep.Mask = "99999-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(60, 20);
            this.txtCep.TabIndex = 30;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(445, 41);
            this.txtTelefone.Mask = "(00)09999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(85, 20);
            this.txtTelefone.TabIndex = 31;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(601, 41);
            this.txtCelular.Mask = "(00)09999-9999";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(83, 20);
            this.txtCelular.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDataInfo);
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
            this.groupBox1.Size = new System.Drawing.Size(690, 235);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // lblDataInfo
            // 
            this.lblDataInfo.Location = new System.Drawing.Point(578, 197);
            this.lblDataInfo.MaximumSize = new System.Drawing.Size(10000, 1000);
            this.lblDataInfo.Name = "lblDataInfo";
            this.lblDataInfo.Size = new System.Drawing.Size(100, 20);
            this.lblDataInfo.TabIndex = 33;
            // 
            // rbtnCnpj
            // 
            this.rbtnCnpj.AutoSize = true;
            this.rbtnCnpj.Location = new System.Drawing.Point(632, 12);
            this.rbtnCnpj.Name = "rbtnCnpj";
            this.rbtnCnpj.Size = new System.Drawing.Size(52, 17);
            this.rbtnCnpj.TabIndex = 31;
            this.rbtnCnpj.Text = "CNPJ";
            this.rbtnCnpj.UseVisualStyleBackColor = true;
            this.rbtnCnpj.CheckedChanged += new System.EventHandler(this.RbtnIden_CheckedChanged);
            // 
            // rbtnCpf
            // 
            this.rbtnCpf.AutoSize = true;
            this.rbtnCpf.Checked = true;
            this.rbtnCpf.Location = new System.Drawing.Point(581, 12);
            this.rbtnCpf.Name = "rbtnCpf";
            this.rbtnCpf.Size = new System.Drawing.Size(45, 17);
            this.rbtnCpf.TabIndex = 30;
            this.rbtnCpf.TabStop = true;
            this.rbtnCpf.Text = "CPF";
            this.rbtnCpf.UseVisualStyleBackColor = true;
            this.rbtnCpf.CheckedChanged += new System.EventHandler(this.RbtnIden_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cLIENTESDataGridView);
            this.panel1.Location = new System.Drawing.Point(13, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 343);
            this.panel1.TabIndex = 34;
            // 
            // cLIENTESDataGridView
            // 
            this.cLIENTESDataGridView.AllowUserToAddRows = false;
            this.cLIENTESDataGridView.AllowUserToDeleteRows = false;
            this.cLIENTESDataGridView.AllowUserToOrderColumns = true;
            this.cLIENTESDataGridView.AutoGenerateColumns = false;
            this.cLIENTESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cLIENTESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
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
            this.dataGridViewTextBoxColumn14});
            this.cLIENTESDataGridView.DataSource = this.cLIENTESBindingSource;
            this.cLIENTESDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cLIENTESDataGridView.Location = new System.Drawing.Point(0, 0);
            this.cLIENTESDataGridView.Name = "cLIENTESDataGridView";
            this.cLIENTESDataGridView.ReadOnly = true;
            this.cLIENTESDataGridView.Size = new System.Drawing.Size(923, 343);
            this.cLIENTESDataGridView.TabIndex = 0;
            this.cLIENTESDataGridView.SelectionChanged += new System.EventHandler(this.CLIENTESDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_CLIENTE";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_CLIENTE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CEP_CLIENTE";
            this.dataGridViewTextBoxColumn4.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RUA_CLIENTE";
            this.dataGridViewTextBoxColumn5.HeaderText = "RUA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NUMERO_CLIENTE";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nº";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BAIRRO_CLIENTE";
            this.dataGridViewTextBoxColumn7.HeaderText = "BAIRRO";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CIDADE_CLIENTE";
            this.dataGridViewTextBoxColumn8.HeaderText = "CIDADE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ESTADO_CLIENTE";
            this.dataGridViewTextBoxColumn9.HeaderText = "ESTADO";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TELEFONE_CLIENTE";
            this.dataGridViewTextBoxColumn10.HeaderText = "TELEFONE";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CELULAR_CLIENTE";
            this.dataGridViewTextBoxColumn11.HeaderText = "CELULAR";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "EMAIL_CLIENTE";
            this.dataGridViewTextBoxColumn12.HeaderText = "E-MAIL";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "DATA_INFO_CLIENTE";
            this.dataGridViewTextBoxColumn13.HeaderText = "DATA INFOMAÇÃO";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "OBS__FORNECEDOR";
            this.dataGridViewTextBoxColumn14.HeaderText = "OBS";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(709, 15);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 35;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(708, 44);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 36;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(709, 73);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 37;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(709, 102);
            this.txtFiltro.Mask = "999,999,999-99";
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(107, 20);
            this.txtFiltro.TabIndex = 38;
            // 
            // rbtnCnpjFiltro
            // 
            this.rbtnCnpjFiltro.AutoSize = true;
            this.rbtnCnpjFiltro.Location = new System.Drawing.Point(760, 128);
            this.rbtnCnpjFiltro.Name = "rbtnCnpjFiltro";
            this.rbtnCnpjFiltro.Size = new System.Drawing.Size(52, 17);
            this.rbtnCnpjFiltro.TabIndex = 40;
            this.rbtnCnpjFiltro.Text = "CNPJ";
            this.rbtnCnpjFiltro.UseVisualStyleBackColor = true;
            this.rbtnCnpjFiltro.CheckedChanged += new System.EventHandler(this.RbtnCpfFiltro_CheckedChanged);
            // 
            // rbtnCpfFiltro
            // 
            this.rbtnCpfFiltro.AutoSize = true;
            this.rbtnCpfFiltro.Checked = true;
            this.rbtnCpfFiltro.Location = new System.Drawing.Point(709, 128);
            this.rbtnCpfFiltro.Name = "rbtnCpfFiltro";
            this.rbtnCpfFiltro.Size = new System.Drawing.Size(45, 17);
            this.rbtnCpfFiltro.TabIndex = 39;
            this.rbtnCpfFiltro.TabStop = true;
            this.rbtnCpfFiltro.Text = "CPF";
            this.rbtnCpfFiltro.UseVisualStyleBackColor = true;
            this.rbtnCpfFiltro.CheckedChanged += new System.EventHandler(this.RbtnCpfFiltro_CheckedChanged);
            // 
            // cLIENTESTableAdapter
            // 
            this.cLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTESTableAdapter = this.cLIENTESTableAdapter;
            this.tableAdapterManager.FORNECEDORESTableAdapter = null;
            this.tableAdapterManager.FORNECIMENTOSTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOSTableAdapter = null;
            this.tableAdapterManager.PRODUTOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TCCMadeireira.Bancos.DataSetMadeireiraTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDA_PRODUTOTableAdapter = null;
            this.tableAdapterManager.VENDASTableAdapter = null;
            this.tableAdapterManager.VENDEDORES_USERSTableAdapter = null;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 597);
            this.Controls.Add(this.rbtnCnpjFiltro);
            this.Controls.Add(this.rbtnCpfFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(oBS__FORNECEDORLabel);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireira)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bancos.DataSetMadeireira dataSetMadeireira;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource;
        private Bancos.DataSetMadeireiraTableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter;
        private Bancos.DataSetMadeireiraTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.MaskedTextBox txtIdentidade;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCnpj;
        private System.Windows.Forms.RadioButton rbtnCpf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView cLIENTESDataGridView;
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
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.MaskedTextBox txtFiltro;
        private System.Windows.Forms.RadioButton rbtnCnpjFiltro;
        private System.Windows.Forms.RadioButton rbtnCpfFiltro;
        private System.Windows.Forms.Label lblDataInfo;
    }
}