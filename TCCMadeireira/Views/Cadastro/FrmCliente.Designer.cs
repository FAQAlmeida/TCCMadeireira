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
            this.groupComp = new System.Windows.Forms.GroupBox();
            this.rbtnCnpj = new System.Windows.Forms.RadioButton();
            this.rbtnCpf = new System.Windows.Forms.RadioButton();
            this.lblDataInfo = new System.Windows.Forms.Label();
            this.pnlDgv = new System.Windows.Forms.Panel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.iDCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMECLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDENTIDADECLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUACLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMEROCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAIRROCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDADECLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADOCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONECLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cELULARCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAINFOCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oBSCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMadeireiraV2 = new TCCMadeireira.Bancos.DataSetMadeireiraV2();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.MaskedTextBox();
            this.rbtnCnpjFiltro = new System.Windows.Forms.RadioButton();
            this.rbtnCpfFiltro = new System.Windows.Forms.RadioButton();
            this.cLIENTESTableAdapter = new TCCMadeireira.Bancos.DataSetMadeireiraV2TableAdapters.CLIENTESTableAdapter();
            this.tableAdapterManager = new TCCMadeireira.Bancos.DataSetMadeireiraV2TableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlComp = new System.Windows.Forms.Panel();
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
            this.groupComp.SuspendLayout();
            this.pnlDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireiraV2)).BeginInit();
            this.pnlComp.SuspendLayout();
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
            this.txtNome.Location = new System.Drawing.Point(54, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(327, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(146, 69);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(452, 20);
            this.txtRua.TabIndex = 7;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(632, 69);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(52, 20);
            this.txtNumero.TabIndex = 8;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(63, 98);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(293, 20);
            this.txtBairro.TabIndex = 9;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(418, 98);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(178, 20);
            this.txtCidade.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(57, 41);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(310, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(9, 124);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(675, 102);
            this.txtObs.TabIndex = 12;
            // 
            // cmbUf
            // 
            this.cmbUf.FormattingEnabled = true;
            this.cmbUf.ItemHeight = 13;
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
            this.txtIdentidade.Size = new System.Drawing.Size(85, 20);
            this.txtIdentidade.TabIndex = 2;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(43, 69);
            this.txtCep.Mask = "99999-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(60, 20);
            this.txtCep.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(445, 41);
            this.txtTelefone.Mask = "(00)09999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(85, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(601, 41);
            this.txtCelular.Mask = "(00)09999-9999";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(83, 20);
            this.txtCelular.TabIndex = 5;
            // 
            // groupComp
            // 
            this.groupComp.Controls.Add(this.rbtnCnpj);
            this.groupComp.Controls.Add(cIDADE_CLIENTELabel);
            this.groupComp.Controls.Add(this.txtObs);
            this.groupComp.Controls.Add(this.txtCidade);
            this.groupComp.Controls.Add(this.cmbUf);
            this.groupComp.Controls.Add(this.txtCep);
            this.groupComp.Controls.Add(bAIRRO_CLIENTELabel);
            this.groupComp.Controls.Add(this.txtBairro);
            this.groupComp.Controls.Add(eSTADO_CLIENTELabel);
            this.groupComp.Controls.Add(rUA_CLIENTELabel);
            this.groupComp.Controls.Add(this.txtRua);
            this.groupComp.Controls.Add(this.txtCelular);
            this.groupComp.Controls.Add(nUMERO_CLIENTELabel);
            this.groupComp.Controls.Add(this.rbtnCpf);
            this.groupComp.Controls.Add(this.txtNumero);
            this.groupComp.Controls.Add(cEP_CLIENTELabel);
            this.groupComp.Controls.Add(this.txtTelefone);
            this.groupComp.Controls.Add(this.txtNome);
            this.groupComp.Controls.Add(nOME_CLIENTELabel);
            this.groupComp.Controls.Add(cPF_CNPJ_CLIENTELabel);
            this.groupComp.Controls.Add(this.txtIdentidade);
            this.groupComp.Controls.Add(this.txtEmail);
            this.groupComp.Controls.Add(eMAIL_CLIENTELabel);
            this.groupComp.Controls.Add(tELEFONE_CLIENTELabel);
            this.groupComp.Controls.Add(cELULAR_CLIENTELabel);
            this.groupComp.Location = new System.Drawing.Point(12, 12);
            this.groupComp.Name = "groupComp";
            this.groupComp.Size = new System.Drawing.Size(690, 235);
            this.groupComp.TabIndex = 33;
            this.groupComp.TabStop = false;
            this.groupComp.Text = "Cliente";
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
            // lblDataInfo
            // 
            this.lblDataInfo.AutoSize = true;
            this.lblDataInfo.Location = new System.Drawing.Point(5, 212);
            this.lblDataInfo.MaximumSize = new System.Drawing.Size(10000, 1000);
            this.lblDataInfo.Name = "lblDataInfo";
            this.lblDataInfo.Size = new System.Drawing.Size(67, 13);
            this.lblDataInfo.TabIndex = 33;
            this.lblDataInfo.Text = "DATA_INFO";
            this.lblDataInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDgv
            // 
            this.pnlDgv.Controls.Add(this.dgvClientes);
            this.pnlDgv.Location = new System.Drawing.Point(13, 254);
            this.pnlDgv.Name = "pnlDgv";
            this.pnlDgv.Size = new System.Drawing.Size(923, 343);
            this.pnlDgv.TabIndex = 34;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCLIENTEDataGridViewTextBoxColumn,
            this.nOMECLIENTEDataGridViewTextBoxColumn,
            this.iDENTIDADECLIENTEDataGridViewTextBoxColumn,
            this.cEPCLIENTEDataGridViewTextBoxColumn,
            this.rUACLIENTEDataGridViewTextBoxColumn,
            this.nUMEROCLIENTEDataGridViewTextBoxColumn,
            this.bAIRROCLIENTEDataGridViewTextBoxColumn,
            this.cIDADECLIENTEDataGridViewTextBoxColumn,
            this.eSTADOCLIENTEDataGridViewTextBoxColumn,
            this.tELEFONECLIENTEDataGridViewTextBoxColumn,
            this.cELULARCLIENTEDataGridViewTextBoxColumn,
            this.eMAILCLIENTEDataGridViewTextBoxColumn,
            this.dATAINFOCLIENTEDataGridViewTextBoxColumn,
            this.oBSCLIENTEDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.cLIENTESBindingSource;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(923, 343);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.TabStop = false;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.ClientesDataGridView_SelectionChanged);
            // 
            // iDCLIENTEDataGridViewTextBoxColumn
            // 
            this.iDCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "ID_CLIENTE";
            this.iDCLIENTEDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDCLIENTEDataGridViewTextBoxColumn.Name = "iDCLIENTEDataGridViewTextBoxColumn";
            this.iDCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMECLIENTEDataGridViewTextBoxColumn
            // 
            this.nOMECLIENTEDataGridViewTextBoxColumn.DataPropertyName = "NOME_CLIENTE";
            this.nOMECLIENTEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMECLIENTEDataGridViewTextBoxColumn.Name = "nOMECLIENTEDataGridViewTextBoxColumn";
            this.nOMECLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDENTIDADECLIENTEDataGridViewTextBoxColumn
            // 
            this.iDENTIDADECLIENTEDataGridViewTextBoxColumn.DataPropertyName = "IDENTIDADE_CLIENTE";
            this.iDENTIDADECLIENTEDataGridViewTextBoxColumn.HeaderText = "IDENTIDADE";
            this.iDENTIDADECLIENTEDataGridViewTextBoxColumn.Name = "iDENTIDADECLIENTEDataGridViewTextBoxColumn";
            this.iDENTIDADECLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEPCLIENTEDataGridViewTextBoxColumn
            // 
            this.cEPCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CEP_CLIENTE";
            this.cEPCLIENTEDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPCLIENTEDataGridViewTextBoxColumn.Name = "cEPCLIENTEDataGridViewTextBoxColumn";
            this.cEPCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rUACLIENTEDataGridViewTextBoxColumn
            // 
            this.rUACLIENTEDataGridViewTextBoxColumn.DataPropertyName = "RUA_CLIENTE";
            this.rUACLIENTEDataGridViewTextBoxColumn.HeaderText = "RUA";
            this.rUACLIENTEDataGridViewTextBoxColumn.Name = "rUACLIENTEDataGridViewTextBoxColumn";
            this.rUACLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nUMEROCLIENTEDataGridViewTextBoxColumn
            // 
            this.nUMEROCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "NUMERO_CLIENTE";
            this.nUMEROCLIENTEDataGridViewTextBoxColumn.HeaderText = "NUMERO";
            this.nUMEROCLIENTEDataGridViewTextBoxColumn.Name = "nUMEROCLIENTEDataGridViewTextBoxColumn";
            this.nUMEROCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bAIRROCLIENTEDataGridViewTextBoxColumn
            // 
            this.bAIRROCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "BAIRRO_CLIENTE";
            this.bAIRROCLIENTEDataGridViewTextBoxColumn.HeaderText = "BAIRRO";
            this.bAIRROCLIENTEDataGridViewTextBoxColumn.Name = "bAIRROCLIENTEDataGridViewTextBoxColumn";
            this.bAIRROCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cIDADECLIENTEDataGridViewTextBoxColumn
            // 
            this.cIDADECLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CIDADE_CLIENTE";
            this.cIDADECLIENTEDataGridViewTextBoxColumn.HeaderText = "CIDADE";
            this.cIDADECLIENTEDataGridViewTextBoxColumn.Name = "cIDADECLIENTEDataGridViewTextBoxColumn";
            this.cIDADECLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eSTADOCLIENTEDataGridViewTextBoxColumn
            // 
            this.eSTADOCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "ESTADO_CLIENTE";
            this.eSTADOCLIENTEDataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADOCLIENTEDataGridViewTextBoxColumn.Name = "eSTADOCLIENTEDataGridViewTextBoxColumn";
            this.eSTADOCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tELEFONECLIENTEDataGridViewTextBoxColumn
            // 
            this.tELEFONECLIENTEDataGridViewTextBoxColumn.DataPropertyName = "TELEFONE_CLIENTE";
            this.tELEFONECLIENTEDataGridViewTextBoxColumn.HeaderText = "TELEFONE";
            this.tELEFONECLIENTEDataGridViewTextBoxColumn.Name = "tELEFONECLIENTEDataGridViewTextBoxColumn";
            this.tELEFONECLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cELULARCLIENTEDataGridViewTextBoxColumn
            // 
            this.cELULARCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CELULAR_CLIENTE";
            this.cELULARCLIENTEDataGridViewTextBoxColumn.HeaderText = "CELULAR";
            this.cELULARCLIENTEDataGridViewTextBoxColumn.Name = "cELULARCLIENTEDataGridViewTextBoxColumn";
            this.cELULARCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMAILCLIENTEDataGridViewTextBoxColumn
            // 
            this.eMAILCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "EMAIL_CLIENTE";
            this.eMAILCLIENTEDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILCLIENTEDataGridViewTextBoxColumn.Name = "eMAILCLIENTEDataGridViewTextBoxColumn";
            this.eMAILCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATAINFOCLIENTEDataGridViewTextBoxColumn
            // 
            this.dATAINFOCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "DATA_INFO_CLIENTE";
            this.dATAINFOCLIENTEDataGridViewTextBoxColumn.HeaderText = "DATA INFO";
            this.dATAINFOCLIENTEDataGridViewTextBoxColumn.Name = "dATAINFOCLIENTEDataGridViewTextBoxColumn";
            this.dATAINFOCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oBSCLIENTEDataGridViewTextBoxColumn
            // 
            this.oBSCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "OBS_CLIENTE";
            this.oBSCLIENTEDataGridViewTextBoxColumn.HeaderText = "OBS";
            this.oBSCLIENTEDataGridViewTextBoxColumn.Name = "oBSCLIENTEDataGridViewTextBoxColumn";
            this.oBSCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLIENTESBindingSource
            // 
            this.cLIENTESBindingSource.DataMember = "CLIENTES";
            this.cLIENTESBindingSource.DataSource = this.dataSetMadeireiraV2;
            // 
            // dataSetMadeireiraV2
            // 
            this.dataSetMadeireiraV2.DataSetName = "DataSetMadeireiraV2";
            this.dataSetMadeireiraV2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(3, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(3, 32);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(3, 61);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 15;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(3, 90);
            this.txtFiltro.Mask = "999,999,999-99";
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(85, 20);
            this.txtFiltro.TabIndex = 38;
            this.txtFiltro.TabStop = false;
            this.txtFiltro.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            // 
            // rbtnCnpjFiltro
            // 
            this.rbtnCnpjFiltro.AutoSize = true;
            this.rbtnCnpjFiltro.Location = new System.Drawing.Point(54, 116);
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
            this.rbtnCpfFiltro.Location = new System.Drawing.Point(3, 116);
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
            this.tableAdapterManager.FORNECIMENTO_PRODUTOTableAdapter = null;
            this.tableAdapterManager.FORNECIMENTOSTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOSTableAdapter = null;
            this.tableAdapterManager.PRODUTOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TCCMadeireira.Bancos.DataSetMadeireiraV2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            this.tableAdapterManager.VENDA_PRODUTOTableAdapter = null;
            this.tableAdapterManager.VENDASTableAdapter = null;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_CLIENTE";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_CLIENTE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOME";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.DataPropertyName = "ID_CLIENTE";
            this.ID_CLIENTE.HeaderText = "ID";
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.ReadOnly = true;
            // 
            // NOME_CLIENTE
            // 
            this.NOME_CLIENTE.DataPropertyName = "NOME_CLIENTE";
            this.NOME_CLIENTE.HeaderText = "NOME";
            this.NOME_CLIENTE.Name = "NOME_CLIENTE";
            this.NOME_CLIENTE.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(3, 140);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // pnlComp
            // 
            this.pnlComp.Controls.Add(this.btnCancelar);
            this.pnlComp.Controls.Add(this.btnAlterar);
            this.pnlComp.Controls.Add(this.lblDataInfo);
            this.pnlComp.Controls.Add(this.btnCadastrar);
            this.pnlComp.Controls.Add(this.rbtnCnpjFiltro);
            this.pnlComp.Controls.Add(this.btnExcluir);
            this.pnlComp.Controls.Add(this.rbtnCpfFiltro);
            this.pnlComp.Controls.Add(this.txtFiltro);
            this.pnlComp.Location = new System.Drawing.Point(703, 13);
            this.pnlComp.Name = "pnlComp";
            this.pnlComp.Size = new System.Drawing.Size(233, 235);
            this.pnlComp.TabIndex = 42;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 610);
            this.Controls.Add(this.pnlDgv);
            this.Controls.Add(this.groupComp);
            this.Controls.Add(oBS__FORNECEDORLabel);
            this.Controls.Add(this.pnlComp);
            this.Name = "FrmCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.groupComp.ResumeLayout(false);
            this.groupComp.PerformLayout();
            this.pnlDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireiraV2)).EndInit();
            this.pnlComp.ResumeLayout(false);
            this.pnlComp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bancos.DataSetMadeireiraV2TableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter;
        private Bancos.DataSetMadeireiraV2TableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.GroupBox groupComp;
        private System.Windows.Forms.RadioButton rbtnCnpj;
        private System.Windows.Forms.RadioButton rbtnCpf;
        private System.Windows.Forms.Panel pnlDgv;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.MaskedTextBox txtFiltro;
        private System.Windows.Forms.RadioButton rbtnCnpjFiltro;
        private System.Windows.Forms.RadioButton rbtnCpfFiltro;
        private System.Windows.Forms.Label lblDataInfo;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_CLIENTE;
        private Bancos.DataSetMadeireiraV2 dataSetMadeireiraV2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMECLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDENTIDADECLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUACLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMEROCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAIRROCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDADECLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADOCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONECLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cELULARCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAINFOCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oBSCLIENTEDataGridViewTextBoxColumn;
    }
}