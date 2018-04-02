namespace TCCMadeireira.Views
{
    partial class FrmFornecedor
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
            System.Windows.Forms.Label nOME_FORNECEDORLabel;
            System.Windows.Forms.Label iDENTIDADE_FORNECEDORLabel;
            System.Windows.Forms.Label cEP_FORNECEDORLabel;
            System.Windows.Forms.Label rUA_FORNECEDORLabel;
            System.Windows.Forms.Label nUMERO_FORNECEDORLabel;
            System.Windows.Forms.Label bAIRRO_FORNECEDORLabel;
            System.Windows.Forms.Label cIDADE_FORNECEDORLabel;
            System.Windows.Forms.Label eSTADO_FORNECEDORLabel;
            System.Windows.Forms.Label tELEFONE_FORNECEDORLabel;
            System.Windows.Forms.Label cELULAR_FORNECEDORLabel;
            System.Windows.Forms.Label eMAIL_FORNECEDORLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCnpj = new System.Windows.Forms.RadioButton();
            this.rbtnCpf = new System.Windows.Forms.RadioButton();
            this.cmbUf = new System.Windows.Forms.ComboBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtIdentidade = new System.Windows.Forms.MaskedTextBox();
            this.nOME_FORNECEDORTextBox = new System.Windows.Forms.TextBox();
            this.fORNECEDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetMadeireiraV2 = new TCCMadeireira.Bancos.DataSetMadeireiraV2();
            this.rUA_FORNECEDORTextBox = new System.Windows.Forms.TextBox();
            this.nUMERO_FORNECEDORTextBox = new System.Windows.Forms.TextBox();
            this.bAIRRO_FORNECEDORTextBox = new System.Windows.Forms.TextBox();
            this.cIDADE_FORNECEDORTextBox = new System.Windows.Forms.TextBox();
            this.eMAIL_FORNECEDORTextBox = new System.Windows.Forms.TextBox();
            this.oBS_FORNECEDORTextBox = new System.Windows.Forms.TextBox();
            this.fORNECEDORESTableAdapter = new TCCMadeireira.Bancos.DataSetMadeireiraV2TableAdapters.FORNECEDORESTableAdapter();
            this.tableAdapterManager = new TCCMadeireira.Bancos.DataSetMadeireiraV2TableAdapters.TableAdapterManager();
            this.lblDataInfo = new System.Windows.Forms.Label();
            this.rbtnCnpjFiltro = new System.Windows.Forms.RadioButton();
            this.rbtnCpfFiltro = new System.Windows.Forms.RadioButton();
            this.txtFiltro = new System.Windows.Forms.MaskedTextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fORNECEDORESDataGridView = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nOME_FORNECEDORLabel = new System.Windows.Forms.Label();
            iDENTIDADE_FORNECEDORLabel = new System.Windows.Forms.Label();
            cEP_FORNECEDORLabel = new System.Windows.Forms.Label();
            rUA_FORNECEDORLabel = new System.Windows.Forms.Label();
            nUMERO_FORNECEDORLabel = new System.Windows.Forms.Label();
            bAIRRO_FORNECEDORLabel = new System.Windows.Forms.Label();
            cIDADE_FORNECEDORLabel = new System.Windows.Forms.Label();
            eSTADO_FORNECEDORLabel = new System.Windows.Forms.Label();
            tELEFONE_FORNECEDORLabel = new System.Windows.Forms.Label();
            cELULAR_FORNECEDORLabel = new System.Windows.Forms.Label();
            eMAIL_FORNECEDORLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireiraV2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORESDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nOME_FORNECEDORLabel
            // 
            nOME_FORNECEDORLabel.AutoSize = true;
            nOME_FORNECEDORLabel.Location = new System.Drawing.Point(6, 26);
            nOME_FORNECEDORLabel.Name = "nOME_FORNECEDORLabel";
            nOME_FORNECEDORLabel.Size = new System.Drawing.Size(85, 13);
            nOME_FORNECEDORLabel.TabIndex = 2;
            nOME_FORNECEDORLabel.Text = "FORNECEDOR:";
            // 
            // iDENTIDADE_FORNECEDORLabel
            // 
            iDENTIDADE_FORNECEDORLabel.AutoSize = true;
            iDENTIDADE_FORNECEDORLabel.Location = new System.Drawing.Point(504, 26);
            iDENTIDADE_FORNECEDORLabel.Name = "iDENTIDADE_FORNECEDORLabel";
            iDENTIDADE_FORNECEDORLabel.Size = new System.Drawing.Size(76, 13);
            iDENTIDADE_FORNECEDORLabel.TabIndex = 4;
            iDENTIDADE_FORNECEDORLabel.Text = "IDENTIDADE:";
            // 
            // cEP_FORNECEDORLabel
            // 
            cEP_FORNECEDORLabel.AutoSize = true;
            cEP_FORNECEDORLabel.Location = new System.Drawing.Point(6, 78);
            cEP_FORNECEDORLabel.Name = "cEP_FORNECEDORLabel";
            cEP_FORNECEDORLabel.Size = new System.Drawing.Size(31, 13);
            cEP_FORNECEDORLabel.TabIndex = 6;
            cEP_FORNECEDORLabel.Text = "CEP:";
            // 
            // rUA_FORNECEDORLabel
            // 
            rUA_FORNECEDORLabel.AutoSize = true;
            rUA_FORNECEDORLabel.Location = new System.Drawing.Point(109, 78);
            rUA_FORNECEDORLabel.Name = "rUA_FORNECEDORLabel";
            rUA_FORNECEDORLabel.Size = new System.Drawing.Size(33, 13);
            rUA_FORNECEDORLabel.TabIndex = 8;
            rUA_FORNECEDORLabel.Text = "RUA:";
            // 
            // nUMERO_FORNECEDORLabel
            // 
            nUMERO_FORNECEDORLabel.AutoSize = true;
            nUMERO_FORNECEDORLabel.Location = new System.Drawing.Point(726, 78);
            nUMERO_FORNECEDORLabel.Name = "nUMERO_FORNECEDORLabel";
            nUMERO_FORNECEDORLabel.Size = new System.Drawing.Size(22, 13);
            nUMERO_FORNECEDORLabel.TabIndex = 10;
            nUMERO_FORNECEDORLabel.Text = "Nº:";
            // 
            // bAIRRO_FORNECEDORLabel
            // 
            bAIRRO_FORNECEDORLabel.AutoSize = true;
            bAIRRO_FORNECEDORLabel.Location = new System.Drawing.Point(6, 105);
            bAIRRO_FORNECEDORLabel.Name = "bAIRRO_FORNECEDORLabel";
            bAIRRO_FORNECEDORLabel.Size = new System.Drawing.Size(51, 13);
            bAIRRO_FORNECEDORLabel.TabIndex = 12;
            bAIRRO_FORNECEDORLabel.Text = "BAIRRO:";
            // 
            // cIDADE_FORNECEDORLabel
            // 
            cIDADE_FORNECEDORLabel.AutoSize = true;
            cIDADE_FORNECEDORLabel.Location = new System.Drawing.Point(379, 106);
            cIDADE_FORNECEDORLabel.Name = "cIDADE_FORNECEDORLabel";
            cIDADE_FORNECEDORLabel.Size = new System.Drawing.Size(50, 13);
            cIDADE_FORNECEDORLabel.TabIndex = 14;
            cIDADE_FORNECEDORLabel.Text = "CIDADE:";
            // 
            // eSTADO_FORNECEDORLabel
            // 
            eSTADO_FORNECEDORLabel.AutoSize = true;
            eSTADO_FORNECEDORLabel.Location = new System.Drawing.Point(720, 105);
            eSTADO_FORNECEDORLabel.Name = "eSTADO_FORNECEDORLabel";
            eSTADO_FORNECEDORLabel.Size = new System.Drawing.Size(24, 13);
            eSTADO_FORNECEDORLabel.TabIndex = 16;
            eSTADO_FORNECEDORLabel.Text = "UF:";
            // 
            // tELEFONE_FORNECEDORLabel
            // 
            tELEFONE_FORNECEDORLabel.AutoSize = true;
            tELEFONE_FORNECEDORLabel.Location = new System.Drawing.Point(491, 50);
            tELEFONE_FORNECEDORLabel.Name = "tELEFONE_FORNECEDORLabel";
            tELEFONE_FORNECEDORLabel.Size = new System.Drawing.Size(66, 13);
            tELEFONE_FORNECEDORLabel.TabIndex = 18;
            tELEFONE_FORNECEDORLabel.Text = "TELEFONE:";
            // 
            // cELULAR_FORNECEDORLabel
            // 
            cELULAR_FORNECEDORLabel.AutoSize = true;
            cELULAR_FORNECEDORLabel.Location = new System.Drawing.Point(654, 50);
            cELULAR_FORNECEDORLabel.Name = "cELULAR_FORNECEDORLabel";
            cELULAR_FORNECEDORLabel.Size = new System.Drawing.Size(59, 13);
            cELULAR_FORNECEDORLabel.TabIndex = 20;
            cELULAR_FORNECEDORLabel.Text = "CELULAR:";
            // 
            // eMAIL_FORNECEDORLabel
            // 
            eMAIL_FORNECEDORLabel.AutoSize = true;
            eMAIL_FORNECEDORLabel.Location = new System.Drawing.Point(6, 49);
            eMAIL_FORNECEDORLabel.Name = "eMAIL_FORNECEDORLabel";
            eMAIL_FORNECEDORLabel.Size = new System.Drawing.Size(45, 13);
            eMAIL_FORNECEDORLabel.TabIndex = 22;
            eMAIL_FORNECEDORLabel.Text = "E-MAIL:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCnpj);
            this.groupBox1.Controls.Add(this.rbtnCpf);
            this.groupBox1.Controls.Add(this.cmbUf);
            this.groupBox1.Controls.Add(this.txtCep);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.txtIdentidade);
            this.groupBox1.Controls.Add(nOME_FORNECEDORLabel);
            this.groupBox1.Controls.Add(this.nOME_FORNECEDORTextBox);
            this.groupBox1.Controls.Add(iDENTIDADE_FORNECEDORLabel);
            this.groupBox1.Controls.Add(cEP_FORNECEDORLabel);
            this.groupBox1.Controls.Add(rUA_FORNECEDORLabel);
            this.groupBox1.Controls.Add(this.rUA_FORNECEDORTextBox);
            this.groupBox1.Controls.Add(nUMERO_FORNECEDORLabel);
            this.groupBox1.Controls.Add(this.nUMERO_FORNECEDORTextBox);
            this.groupBox1.Controls.Add(bAIRRO_FORNECEDORLabel);
            this.groupBox1.Controls.Add(this.bAIRRO_FORNECEDORTextBox);
            this.groupBox1.Controls.Add(cIDADE_FORNECEDORLabel);
            this.groupBox1.Controls.Add(this.cIDADE_FORNECEDORTextBox);
            this.groupBox1.Controls.Add(eSTADO_FORNECEDORLabel);
            this.groupBox1.Controls.Add(tELEFONE_FORNECEDORLabel);
            this.groupBox1.Controls.Add(cELULAR_FORNECEDORLabel);
            this.groupBox1.Controls.Add(eMAIL_FORNECEDORLabel);
            this.groupBox1.Controls.Add(this.eMAIL_FORNECEDORTextBox);
            this.groupBox1.Controls.Add(this.oBS_FORNECEDORTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fornecedor";
            // 
            // rbtnCnpj
            // 
            this.rbtnCnpj.AutoSize = true;
            this.rbtnCnpj.Location = new System.Drawing.Point(750, 24);
            this.rbtnCnpj.Name = "rbtnCnpj";
            this.rbtnCnpj.Size = new System.Drawing.Size(52, 17);
            this.rbtnCnpj.TabIndex = 39;
            this.rbtnCnpj.Text = "CNPJ";
            this.rbtnCnpj.UseVisualStyleBackColor = true;
            // 
            // rbtnCpf
            // 
            this.rbtnCpf.AutoSize = true;
            this.rbtnCpf.Checked = true;
            this.rbtnCpf.Location = new System.Drawing.Point(699, 24);
            this.rbtnCpf.Name = "rbtnCpf";
            this.rbtnCpf.Size = new System.Drawing.Size(45, 17);
            this.rbtnCpf.TabIndex = 38;
            this.rbtnCpf.TabStop = true;
            this.rbtnCpf.Text = "CPF";
            this.rbtnCpf.UseVisualStyleBackColor = true;
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
            this.cmbUf.Location = new System.Drawing.Point(750, 102);
            this.cmbUf.Name = "cmbUf";
            this.cmbUf.Size = new System.Drawing.Size(52, 21);
            this.cmbUf.TabIndex = 33;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(43, 75);
            this.txtCep.Mask = "99999-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(60, 20);
            this.txtCep.TabIndex = 35;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(719, 47);
            this.txtCelular.Mask = "(00)09999-9999";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(83, 20);
            this.txtCelular.TabIndex = 37;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(563, 47);
            this.txtTelefone.Mask = "(00)09999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(85, 20);
            this.txtTelefone.TabIndex = 36;
            // 
            // txtIdentidade
            // 
            this.txtIdentidade.Location = new System.Drawing.Point(586, 23);
            this.txtIdentidade.Mask = "999,999,999-99";
            this.txtIdentidade.Name = "txtIdentidade";
            this.txtIdentidade.Size = new System.Drawing.Size(107, 20);
            this.txtIdentidade.TabIndex = 34;
            // 
            // nOME_FORNECEDORTextBox
            // 
            this.nOME_FORNECEDORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORNECEDORESBindingSource, "NOME_FORNECEDOR", true));
            this.nOME_FORNECEDORTextBox.Location = new System.Drawing.Point(97, 23);
            this.nOME_FORNECEDORTextBox.Name = "nOME_FORNECEDORTextBox";
            this.nOME_FORNECEDORTextBox.Size = new System.Drawing.Size(402, 20);
            this.nOME_FORNECEDORTextBox.TabIndex = 3;
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
            // rUA_FORNECEDORTextBox
            // 
            this.rUA_FORNECEDORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORNECEDORESBindingSource, "RUA_FORNECEDOR", true));
            this.rUA_FORNECEDORTextBox.Location = new System.Drawing.Point(146, 75);
            this.rUA_FORNECEDORTextBox.Name = "rUA_FORNECEDORTextBox";
            this.rUA_FORNECEDORTextBox.Size = new System.Drawing.Size(574, 20);
            this.rUA_FORNECEDORTextBox.TabIndex = 9;
            // 
            // nUMERO_FORNECEDORTextBox
            // 
            this.nUMERO_FORNECEDORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORNECEDORESBindingSource, "NUMERO_FORNECEDOR", true));
            this.nUMERO_FORNECEDORTextBox.Location = new System.Drawing.Point(754, 75);
            this.nUMERO_FORNECEDORTextBox.Name = "nUMERO_FORNECEDORTextBox";
            this.nUMERO_FORNECEDORTextBox.Size = new System.Drawing.Size(48, 20);
            this.nUMERO_FORNECEDORTextBox.TabIndex = 11;
            // 
            // bAIRRO_FORNECEDORTextBox
            // 
            this.bAIRRO_FORNECEDORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORNECEDORESBindingSource, "BAIRRO_FORNECEDOR", true));
            this.bAIRRO_FORNECEDORTextBox.Location = new System.Drawing.Point(63, 102);
            this.bAIRRO_FORNECEDORTextBox.Name = "bAIRRO_FORNECEDORTextBox";
            this.bAIRRO_FORNECEDORTextBox.Size = new System.Drawing.Size(310, 20);
            this.bAIRRO_FORNECEDORTextBox.TabIndex = 13;
            // 
            // cIDADE_FORNECEDORTextBox
            // 
            this.cIDADE_FORNECEDORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORNECEDORESBindingSource, "CIDADE_FORNECEDOR", true));
            this.cIDADE_FORNECEDORTextBox.Location = new System.Drawing.Point(435, 103);
            this.cIDADE_FORNECEDORTextBox.Name = "cIDADE_FORNECEDORTextBox";
            this.cIDADE_FORNECEDORTextBox.Size = new System.Drawing.Size(278, 20);
            this.cIDADE_FORNECEDORTextBox.TabIndex = 15;
            // 
            // eMAIL_FORNECEDORTextBox
            // 
            this.eMAIL_FORNECEDORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORNECEDORESBindingSource, "EMAIL_FORNECEDOR", true));
            this.eMAIL_FORNECEDORTextBox.Location = new System.Drawing.Point(57, 46);
            this.eMAIL_FORNECEDORTextBox.Name = "eMAIL_FORNECEDORTextBox";
            this.eMAIL_FORNECEDORTextBox.Size = new System.Drawing.Size(428, 20);
            this.eMAIL_FORNECEDORTextBox.TabIndex = 23;
            // 
            // oBS_FORNECEDORTextBox
            // 
            this.oBS_FORNECEDORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fORNECEDORESBindingSource, "OBS_FORNECEDOR", true));
            this.oBS_FORNECEDORTextBox.Location = new System.Drawing.Point(9, 129);
            this.oBS_FORNECEDORTextBox.Multiline = true;
            this.oBS_FORNECEDORTextBox.Name = "oBS_FORNECEDORTextBox";
            this.oBS_FORNECEDORTextBox.Size = new System.Drawing.Size(793, 105);
            this.oBS_FORNECEDORTextBox.TabIndex = 27;
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
            this.tableAdapterManager.FORNECIMENTO_PRODUTOTableAdapter = null;
            this.tableAdapterManager.FORNECIMENTOSTableAdapter = null;
            this.tableAdapterManager.FUNCIONARIOSTableAdapter = null;
            this.tableAdapterManager.PRODUTOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TCCMadeireira.Bancos.DataSetMadeireiraV2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERSTableAdapter = null;
            this.tableAdapterManager.VENDA_PRODUTOTableAdapter = null;
            this.tableAdapterManager.VENDASTableAdapter = null;
            // 
            // lblDataInfo
            // 
            this.lblDataInfo.Location = new System.Drawing.Point(823, 160);
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
            this.rbtnCnpjFiltro.Location = new System.Drawing.Point(877, 136);
            this.rbtnCnpjFiltro.Name = "rbtnCnpjFiltro";
            this.rbtnCnpjFiltro.Size = new System.Drawing.Size(52, 17);
            this.rbtnCnpjFiltro.TabIndex = 47;
            this.rbtnCnpjFiltro.Text = "CNPJ";
            this.rbtnCnpjFiltro.UseVisualStyleBackColor = true;
            // 
            // rbtnCpfFiltro
            // 
            this.rbtnCpfFiltro.AutoSize = true;
            this.rbtnCpfFiltro.Checked = true;
            this.rbtnCpfFiltro.Location = new System.Drawing.Point(826, 136);
            this.rbtnCpfFiltro.Name = "rbtnCpfFiltro";
            this.rbtnCpfFiltro.Size = new System.Drawing.Size(45, 17);
            this.rbtnCpfFiltro.TabIndex = 46;
            this.rbtnCpfFiltro.TabStop = true;
            this.rbtnCpfFiltro.Text = "CPF";
            this.rbtnCpfFiltro.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(826, 110);
            this.txtFiltro.Mask = "999,999,999-99";
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(107, 20);
            this.txtFiltro.TabIndex = 45;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(826, 81);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 44;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(826, 51);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(826, 23);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 42;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fORNECEDORESDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 258);
            this.panel1.TabIndex = 48;
            // 
            // fORNECEDORESDataGridView
            // 
            this.fORNECEDORESDataGridView.AllowUserToAddRows = false;
            this.fORNECEDORESDataGridView.AllowUserToDeleteRows = false;
            this.fORNECEDORESDataGridView.AllowUserToOrderColumns = true;
            this.fORNECEDORESDataGridView.AutoGenerateColumns = false;
            this.fORNECEDORESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fORNECEDORESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn14});
            this.fORNECEDORESDataGridView.DataSource = this.fORNECEDORESBindingSource;
            this.fORNECEDORESDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fORNECEDORESDataGridView.Location = new System.Drawing.Point(0, 0);
            this.fORNECEDORESDataGridView.Name = "fORNECEDORESDataGridView";
            this.fORNECEDORESDataGridView.ReadOnly = true;
            this.fORNECEDORESDataGridView.Size = new System.Drawing.Size(954, 258);
            this.fORNECEDORESDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_FORNECEDOR";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_FORNECEDOR";
            this.dataGridViewTextBoxColumn2.HeaderText = "FORNECEDOR";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDENTIDADE_FORNECEDOR";
            this.dataGridViewTextBoxColumn3.HeaderText = "IDENTIDADE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CEP_FORNECEDOR";
            this.dataGridViewTextBoxColumn4.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RUA_FORNECEDOR";
            this.dataGridViewTextBoxColumn5.HeaderText = "RUA";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NUMERO_FORNECEDOR";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nº";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BAIRRO_FORNECEDOR";
            this.dataGridViewTextBoxColumn7.HeaderText = "BAIRRO";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CIDADE_FORNECEDOR";
            this.dataGridViewTextBoxColumn8.HeaderText = "CIDADE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ESTADO_FORNECEDOR";
            this.dataGridViewTextBoxColumn9.HeaderText = "ESTADO";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TELEFONE_FORNECEDOR";
            this.dataGridViewTextBoxColumn10.HeaderText = "TELEFONE";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CELULAR_FORNECEDOR";
            this.dataGridViewTextBoxColumn11.HeaderText = "CELULAR";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "EMAIL_FORNECEDOR";
            this.dataGridViewTextBoxColumn12.HeaderText = "E-MAIL";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "OBS_FORNECEDOR";
            this.dataGridViewTextBoxColumn14.HeaderText = "OBS";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDataInfo);
            this.Controls.Add(this.rbtnCnpjFiltro);
            this.Controls.Add(this.rbtnCpfFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFornecedor";
            this.Text = "FrmFornecedor";
            this.Load += new System.EventHandler(this.FrmFornecedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetMadeireiraV2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORESDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bancos.DataSetMadeireiraV2 dataSetMadeireiraV2;
        private System.Windows.Forms.BindingSource fORNECEDORESBindingSource;
        private Bancos.DataSetMadeireiraV2TableAdapters.FORNECEDORESTableAdapter fORNECEDORESTableAdapter;
        private Bancos.DataSetMadeireiraV2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nOME_FORNECEDORTextBox;
        private System.Windows.Forms.TextBox rUA_FORNECEDORTextBox;
        private System.Windows.Forms.TextBox bAIRRO_FORNECEDORTextBox;
        private System.Windows.Forms.TextBox cIDADE_FORNECEDORTextBox;
        private System.Windows.Forms.TextBox eMAIL_FORNECEDORTextBox;
        private System.Windows.Forms.TextBox oBS_FORNECEDORTextBox;
        private System.Windows.Forms.TextBox nUMERO_FORNECEDORTextBox;
        private System.Windows.Forms.ComboBox cmbUf;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtIdentidade;
        private System.Windows.Forms.RadioButton rbtnCnpj;
        private System.Windows.Forms.RadioButton rbtnCpf;
        private System.Windows.Forms.Label lblDataInfo;
        private System.Windows.Forms.RadioButton rbtnCnpjFiltro;
        private System.Windows.Forms.RadioButton rbtnCpfFiltro;
        private System.Windows.Forms.MaskedTextBox txtFiltro;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView fORNECEDORESDataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}