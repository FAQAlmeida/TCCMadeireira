using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCCMadeireira.Model;

namespace TCCMadeireira.Views
{
    public partial class FrmCliente : Form
    {    
        #region @Atributos
        /// <summary>
        /// Objeto banco para acessar os TableAdapters de forma mais simplória
        /// </summary>
        private Bancos.Banco banco = new Bancos.Banco();
        #endregion
        #region @Construtor
        /// <summary>
        /// Método construtor do Form <see cref="FrmCliente"/>.
        /// <para>Inicializa todos os componentes do Form</para>
        /// </summary>
        public FrmCliente()
        {
            InitializeComponent();
        }
        #endregion
        #region @event.Load
        /// <summary>
        /// <para>Metodo do evento disparado no load do form</para>
        /// <para>Todas as rotinas de adequação da inicialização do form deverão estar aqui</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetMadeireira1.CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
            this.cLIENTESTableAdapter.Fill(this.dataSetMadeireira.CLIENTES);
            this.rbtnCpf.Checked = true;
            this.rbtnCpfFiltro.Checked = true;
            this.ControlEnable(false);
            this.cmbUf.SelectedItem = "SP";
            this.lblDataInfo.Text = "";
        }
        #endregion
        #region @event.Click
        /// <summary>
        /// Evento de CLICK do btnCadastrar
        /// <para>Possui 2 etapas:</para>
        /// <para>1) Preparar o form para receber as informações</para>
        /// <para>2) Registra as informações recebidas, enviados ao model Cliente depois ao objeto banco</para>
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnCadastrar.Text == "Cadastrar")
                {
                    ControlEnable(true);
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnCadastrar.Text = "Gravar";
                }
                else
                {
                    Cliente cliente = new Cliente(txtNome.Text, txtIdentidade.Text, txtCep.Text, txtRua.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text, cmbUf.Text, txtTelefone.Text, txtCelular.Text, txtEmail.Text, DateTime.Now, txtObs.Text);
                    banco.InsertCliente(cliente);
                    cLIENTESDataGridView.DataSource = dataSetMadeireira.CLIENTES;
                    cLIENTESDataGridView.Update();
                    ControlEnable(false);
                    btnExcluir.Enabled = true;
                    btnAlterar.Enabled = true;
                    btnCadastrar.Text = "Cadastrar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento de CLICK do btnExcluir
        /// <para>Possui 2 etapas:</para>
        /// <para>1) Preparar a txtIdentidade para receber a identidade</para>
        /// <para>2) Pergunta se o usuário deseja realmente excluir o registro basedo na X identidade e, se sim, exclui o registro</para>
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnExcluir.Text == "Excluir")
                {
                    txtIdentidade.Enabled = true;
                    btnExcluir.Text = "Gravar";
                }
                else
                {
                    if (MessageBox.Show(String.Format("Você deseja excluir o cliente de CPF {0}?", txtIdentidade.Text), "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Cliente cliente = new Cliente(txtIdentidade.Text);
                        cLIENTESTableAdapter.DeletePessoaIdentidade(cliente.Identidade);
                        btnExcluir.Text = "Excluir";
                        txtIdentidade.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento de CLICK do btnAlterar
        /// <para>Possui 3 etapas:</para>
        /// <para>1) Preparar a txtIdentidade para receber a identidade</para>
        /// <para>2) Recebe a identidade para pesquisa do cliente</para>
        /// <para>3) Armazena as informações recebidas se o usuário confirmar</para>
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAlterar.Text == "Alterar")
                {
                    txtIdentidade.Enabled = true;
                    btnExcluir.Enabled = false;
                    btnCadastrar.Enabled = false;
                    btnAlterar.Text = "Pesquisar";
                }
                else if (btnAlterar.Text == "Pesquisar")
                {
                    DataTable dt = new DataTable();
                    Cliente cliente = new Cliente(txtIdentidade.Text);
                    dt = banco.SelectCliente(cliente.Identidade);
                    txtNome.Text = dt.Rows[0]["NOME_CLIENTE"].ToString();
                    txtIdentidade.Text = dt.Rows[0]["CPF/CNPJ_CLIENTE"].ToString();
                    txtCep.Text = dt.Rows[0]["CEP_CLIENTE"].ToString();
                    txtRua.Text = dt.Rows[0]["RUA_CLIENTE"].ToString();
                    txtNumero.Text = dt.Rows[0]["NUMERO_CLIENTE"].ToString();
                    txtBairro.Text = dt.Rows[0]["BAIRRO_CLIENTE"].ToString();
                    txtCidade.Text = dt.Rows[0]["CIDADE_CLIENTE"].ToString();
                    cmbUf.Text = dt.Rows[0]["ESTADO_CLIENTE"].ToString();
                    txtTelefone.Text = dt.Rows[0]["TELEFONE_CLIENTE"].ToString();
                    txtCelular.Text = dt.Rows[0]["CELULAR_CLIENTE"].ToString();
                    txtEmail.Text = dt.Rows[0]["EMAIL_CLIENTE"].ToString();
                    lblDataInfo.Text = dt.Rows[0]["DATA_INFO_CLIENTE"].ToString();
                    txtObs.Text = dt.Rows[0]["OBS_CLIENTE"].ToString();
                    btnAlterar.Text = "Gravar";
                }
                else
                {
                    Cliente cliente = new Cliente(txtNome.Text, txtIdentidade.Text, txtCep.Text, txtRua.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text, cmbUf.Text, txtTelefone.Text, txtCelular.Text, txtEmail.Text, DateTime.Now, txtObs.Text);
                    banco.UpdateCliente(cliente);
                    cLIENTESDataGridView.DataSource = dataSetMadeireira.CLIENTES;
                    cLIENTESDataGridView.Update();
                    ControlEnable(false);
                    btnExcluir.Enabled = true;
                    btnCadastrar.Enabled = true;
                    btnCadastrar.Text = "Alterar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region @event.SelectChanged
        /// <summary>
        /// Evento de SelectionChanged do DataGridView
        /// <para>Preenche todos os Controls da GroupBox com os dados da seleção</para>
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CLIENTESDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (cLIENTESDataGridView.SelectedCells.Count == 14)
                {
                    txtNome.Text = cLIENTESDataGridView.SelectedCells[1].Value.ToString().Trim();
                    txtIdentidade.Text = cLIENTESDataGridView.SelectedCells[2].Value.ToString().Trim();
                    txtCep.Text = cLIENTESDataGridView.SelectedCells[3].Value.ToString().Trim();
                    txtRua.Text = cLIENTESDataGridView.SelectedCells[4].Value.ToString().Trim();
                    txtNumero.Text = cLIENTESDataGridView.SelectedCells[5].Value.ToString().Trim();
                    txtBairro.Text = cLIENTESDataGridView.SelectedCells[6].Value.ToString().Trim();
                    txtCidade.Text = cLIENTESDataGridView.SelectedCells[7].Value.ToString().Trim();
                    cmbUf.Text = cLIENTESDataGridView.SelectedCells[8].Value.ToString().Trim();
                    txtTelefone.Text = cLIENTESDataGridView.SelectedCells[9].Value.ToString().Trim();
                    txtCelular.Text = cLIENTESDataGridView.SelectedCells[10].Value.ToString().Trim();
                    txtEmail.Text = cLIENTESDataGridView.SelectedCells[11].Value.ToString().Trim();
                    lblDataInfo.Text = cLIENTESDataGridView.SelectedCells[12].Value.ToString().Trim();
                    txtObs.Text = cLIENTESDataGridView.SelectedCells[13].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region @event.CheckedChanged
        /// <summary>
        /// Ocorre quando o evento CheckedChanged é disparado no radioButton do CPF ou do CNPJ
        /// <para>Se o RadioButton do CPF for ativado, ele muda a máscara da TextoBox da identidade para a máscara do CPF, 
        /// o oposto também é verdade</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbtnIden_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCpf.Checked)
            {
                txtIdentidade.Size = new Size(85, 20);
                txtIdentidade.Mask = "999,999,999-99";
                txtFiltro.Mask = "999,999,999-99";
                txtFiltro.Size = new Size(85, 20);
            }
            else
            {
                txtIdentidade.Size = new Size(107, 20);
                txtIdentidade.Mask = "99,999,999/9999-99";
                txtFiltro.Mask = "99,999,999/9999-99";
                txtFiltro.Size = new Size(107, 20);
            }
        }
        /// <summary>
        /// Ocorre quando o evento CheckedChanged é disparado no radioButton do CPF Filtro CNPJ Filtro
        /// <para>Se o RadioButton do CPF Filtro for ativado, ele muda a máscara da TextoBox do filtro para a máscara do CPF
        /// o oposto também é verdade</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RbtnCpfFiltro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCpfFiltro.Checked)
            {
                txtFiltro.Mask = "999,999,999-99";
                txtFiltro.Size = new Size(85, 20);
            }
            else
            {
                txtFiltro.Mask = "99,999,999/9999-99";
                txtFiltro.Size = new Size(107, 20);
            }
        }
        #endregion
        #region @event.TextChanged
        // TODO Arrumar atualização do datagrid 
        /// <summary>
        /// Evento do txtFiltro para seleção de registros especificos
        /// <para>A seleção se dará por meio do número da identidade</para>
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            cLIENTESBindingSource.Filter = String.Format("{0} like '%{1}%'", "[CPF/CNPJ_CLIENTE]", txtFiltro.Text);
        }
        #endregion
        #region @Control.Methods
        /// <summary>
        /// Define o status de todos os controles de entrada presentes no GroupBox baseado no parâmetro status
        /// </summary>
        /// <param name="status">Define se o status vai ser true ou false</param>
        private void ControlEnable(bool status)
        {
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Enabled = status;
                }
                else if (ctrl is MaskedTextBox)
                {
                    (ctrl as MaskedTextBox).Enabled = status;
                }
                else if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).Enabled = status;
                }
                else if (ctrl is RadioButton)
                {
                    (ctrl as RadioButton).Enabled = status;
                }
            }
        }
        #endregion

    }
}
