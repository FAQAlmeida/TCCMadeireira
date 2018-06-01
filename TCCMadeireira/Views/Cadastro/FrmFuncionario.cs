using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCCMadeireira.Models;

namespace TCCMadeireira.Views
{
    public partial class FrmFuncionario : Form
    {
        #region @Atributos
        /// <summary>
        /// Objeto banco para acessar os TableAdapters de forma mais simplória
        /// </summary>
        private Bancos.Banco banco = new Bancos.Banco();
        #endregion
        #region @Construtor
        /// <summary>
        /// Método construtor do Form <see cref="FrmFuncionario"/>.
        /// <para>Inicializa todos os componentes do Form</para>
        /// </summary>
        public FrmFuncionario()
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
        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetMadeireiraV2.FUNCIONARIOS'. Você pode movê-la ou removê-la conforme necessário.
            this.fUNCIONARIOSTableAdapter.Fill(this.dataSetMadeireiraV2.FUNCIONARIOS);
            this.rbtnCpf.Checked = true;
            this.rbtnCpfFiltro.Checked = true;
            this.ControlEnable(false);
            this.cmbUf.SelectedItem = "SP";
            this.lblDataInfo.Text = "";
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
        private void TableRefresh()
        {
            fUNCIONARIOSTableAdapter.Fill(dataSetMadeireiraV2.FUNCIONARIOS);
            fUNCIONARIOSDataGridView.Refresh();
        }
        #endregion
        #region @event.SelectChanged
        /// <summary>
        /// Evento de SelectionChanged do DataGridView
        /// <para>Preenche todos os Controls da GroupBox com os dados da seleção</para>
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FUNCIONARIOSDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (fUNCIONARIOSDataGridView.SelectedCells.Count == 15)
                {
                    txtNome.Text = fUNCIONARIOSDataGridView.SelectedCells[1].Value.ToString().Trim();
                    txtIdentidade.Text = fUNCIONARIOSDataGridView.SelectedCells[2].Value.ToString().Trim();
                    txtCargo.Text = fUNCIONARIOSDataGridView.SelectedCells[3].Value.ToString().Trim();
                    txtCep.Text = fUNCIONARIOSDataGridView.SelectedCells[4].Value.ToString().Trim();
                    txtRua.Text = fUNCIONARIOSDataGridView.SelectedCells[5].Value.ToString().Trim();
                    txtNumero.Text = fUNCIONARIOSDataGridView.SelectedCells[6].Value.ToString().Trim();
                    txtBairro.Text = fUNCIONARIOSDataGridView.SelectedCells[7].Value.ToString().Trim();
                    txtCidade.Text = fUNCIONARIOSDataGridView.SelectedCells[8].Value.ToString().Trim();
                    cmbUf.Text = fUNCIONARIOSDataGridView.SelectedCells[9].Value.ToString().Trim();
                    txtTelefone.Text = fUNCIONARIOSDataGridView.SelectedCells[10].Value.ToString().Trim();
                    txtCelular.Text = fUNCIONARIOSDataGridView.SelectedCells[11].Value.ToString().Trim();
                    txtEmail.Text = fUNCIONARIOSDataGridView.SelectedCells[12].Value.ToString().Trim();
                    lblDataInfo.Text = fUNCIONARIOSDataGridView.SelectedCells[13].Value.ToString().Trim();
                    txtObs.Text = fUNCIONARIOSDataGridView.SelectedCells[14].Value.ToString().Trim();                    
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
            fUNCIONARIOSBindingSource.Filter = String.Format("{0} like '%{1}%'", "[CPF/CNPJ_FUNCIONARIO]", txtFiltro.Text);
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
                    Funcionario funcionario = new Funcionario(txtNome.Text, txtIdentidade.Text,txtCargo.Text, txtCep.Text, txtRua.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text, cmbUf.Text, txtTelefone.Text, txtCelular.Text, txtEmail.Text, DateTime.Now, txtObs.Text);
                    banco.InsertFuncionario(funcionario);
                    fUNCIONARIOSDataGridView.DataSource = dataSetMadeireiraV2.CLIENTES;
                    fUNCIONARIOSDataGridView.Update();
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
            finally
            {
                TableRefresh();
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
                if (fUNCIONARIOSDataGridView.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show(String.Format("Você deseja excluir o cliente de identidade {0}?", fUNCIONARIOSDataGridView.SelectedCells[2].Value.ToString()), "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Funcionario funcionario = new Funcionario(fUNCIONARIOSDataGridView.SelectedCells[2].Value.ToString());
                        banco.DeleteFuncionario(funcionario);
                        //log.WriteEntry(String.Format("Funcionário {0} excluido", funcionario.Identidade));
                        BtnCancelar_Click(null, null);
                    }
                }
                else
                {
                    throw new Exception("Selecione uma e apenas uma linha na tabela para excluir");
                }
            }
            catch (Exception ex)
            {
                //log.WriteEntry(ex);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                TableRefresh();
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
                    if(fUNCIONARIOSDataGridView.SelectedRows.Count == 1)
                    {
                        ControlEnable(true);
                        btnCadastrar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnCancelar.Visible = true;
                        DataTable dt = new DataTable();
                        Funcionario funcionario = new Funcionario(txtIdentidade.Text);
                        dt = banco.SelectFuncionario(funcionario.Identidade);
                        txtNome.Text = dt.Rows[0]["NOME_FUNCIONARIO"].ToString();
                        txtIdentidade.Text = dt.Rows[0]["CPF/CNPJ_FUNCIONARIO"].ToString();
                        txtCargo.Text = dt.Rows[0]["CARGO_FUNCIONARIO"].ToString();
                        txtCep.Text = dt.Rows[0]["CEP_FUNCIONARIO"].ToString();
                        txtRua.Text = dt.Rows[0]["RUA_FUNCIONARIO"].ToString();
                        txtNumero.Text = dt.Rows[0]["NUMERO_FUNCIONARIO"].ToString();
                        txtBairro.Text = dt.Rows[0]["BAIRRO_FUNCIONARIO"].ToString();
                        txtCidade.Text = dt.Rows[0]["CIDADE_FUNCIONARIO"].ToString();
                        cmbUf.Text = dt.Rows[0]["ESTADO_FUNCIONARIO"].ToString();
                        txtTelefone.Text = dt.Rows[0]["TELEFONE_FUNCIONARIO"].ToString();
                        txtCelular.Text = dt.Rows[0]["CELULAR_FUNCIONARIO"].ToString();
                        txtEmail.Text = dt.Rows[0]["EMAIL_FUNCIONARIO"].ToString();
                        lblDataInfo.Text = dt.Rows[0]["DATA_INFO_FUNCIONARIO"].ToString();
                        txtObs.Text = dt.Rows[0]["OBS_FUNCIONARIO"].ToString();
                        btnAlterar.Text = "Gravar";
                    }
                    else
                    {
                        throw new Exception("Selecione uma e apenas uma linha na tabela para alterar");
                    }
                }
                else
                {
                    Funcionario funcionario = new Funcionario(txtNome.Text, txtIdentidade.Text,txtCargo.Text, txtCep.Text, txtRua.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text, cmbUf.Text, txtTelefone.Text, txtCelular.Text, txtEmail.Text, DateTime.Now, txtObs.Text);
                    banco.UpdateFuncionario(funcionario);
                    ControlEnable(false);
                    BtnCancelar_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                TableRefresh();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in groupBox1.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                }
                else if (ctrl is MaskedTextBox)
                {
                    (ctrl as MaskedTextBox).Clear();
                }
                else if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).SelectedItem = "SP";
                }
            }
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCadastrar.Text = "Cadastrar";
            btnAlterar.Text = "Alterar";
            btnExcluir.Text = "Excluir";
            btnCancelar.Visible = false;
            ControlEnable(false);
            txtFiltro.Clear();
        }
        #endregion
    }
}
