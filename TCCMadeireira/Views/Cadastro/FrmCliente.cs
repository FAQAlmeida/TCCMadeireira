using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCCMadeireira.Bancos;
using TCCMadeireira.Model;
using TCCMadeireira.Util;

namespace TCCMadeireira.Views
{
    /// <summary>
    /// Classe do FrmCliente
    /// <para>Responsável por toda a funcionalidade do Form</para>
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FrmCliente : Form
    {    
        #region @Atributos
        /// <summary>
        /// Objeto banco para acessar os TableAdapters de forma mais simplória
        /// </summary>
        private Banco banco = new Banco();
        //private DataTable dataTable = new DataTable();
        private Log log = new Log();
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
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dataSetMadeireira1.CLIENTES'. Você pode movê-la ou removê-la conforme necessário.
                this.cLIENTESTableAdapter.Fill(this.dataSetMadeireiraV2.CLIENTES);
                this.btnCancelar.Visible = false;
                this.dvgClientes.DataSource = this.cLIENTESBindingSource;
                this.rbtnCpf.Checked = true;
                this.rbtnCpfFiltro.Checked = true;
                this.ControlEnable(false);
                this.cmbUf.SelectedItem = "SP";
                this.lblDataInfo.Text = "";
                log.WriteEntry("FrmCliente load");
            }catch(Exception ex)
            {
                log.WriteEntry(ex);
            }
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
                    btnCancelar.Visible = true;
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnCadastrar.Text = "Gravar";
                }
                else
                {
                    Cliente cliente = new Cliente(txtNome.Text, txtIdentidade.Text, txtCep.Text, txtRua.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text, cmbUf.Text, txtTelefone.Text, txtCelular.Text, txtEmail.Text, DateTime.Now, txtObs.Text);
                    if (banco.SelectCliente(cliente.Identidade).Rows.Count == 0)
                    {
                        banco.InsertCliente(cliente);
                        BtnCancelar_Click(null, null);
                        log.WriteEntry(String.Format("cliente {0} cadastrado", cliente.Identidade));
                    }
                    else
                    {
                        throw new Exception("Identidade já cadastrada");
                    }
                }
            }
            catch (Exception ex)
            {
                log.WriteEntry(ex);
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
                if (dvgClientes.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show(String.Format("Você deseja excluir o cliente de identidade {0}?", dvgClientes.SelectedCells[2].Value.ToString()), "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Cliente cliente = new Cliente(dvgClientes.SelectedCells[2].Value.ToString());
                        banco.DeleteCliente(cliente);
                        log.WriteEntry(String.Format("cliente {0} excluido", cliente.Identidade));
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
                log.WriteEntry(ex);
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
                    if (dvgClientes.SelectedRows.Count == 1)
                    {
                        ControlEnable(true);
                        txtIdentidade.Enabled = false;
                        btnCadastrar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnCancelar.Visible = true;
                        DataTable dt = new DataTable();
                        Cliente cliente = new Cliente(dvgClientes.SelectedCells[2].Value.ToString());
                        dt = banco.SelectCliente(cliente.Identidade);
                        txtNome.Text = dt.Rows[0]["NOME_CLIENTE"].ToString();
                        txtIdentidade.Text = dt.Rows[0]["IDENTIDADE_CLIENTE"].ToString();
                        txtCep.Text = dt.Rows[0]["CEP_CLIENTE"].ToString();
                        txtRua.Text = dt.Rows[0]["RUA_CLIENTE"].ToString();
                        txtNumero.Text = dt.Rows[0]["NUMERO_CLIENTE"].ToString();
                        txtBairro.Text = dt.Rows[0]["BAIRRO_CLIENTE"].ToString();
                        txtCidade.Text = dt.Rows[0]["CIDADE_CLIENTE"].ToString();
                        cmbUf.Text = dt.Rows[0]["ESTADO_CLIENTE"].ToString();
                        txtTelefone.Text = dt.Rows[0]["TELEFONE_CLIENTE"].ToString();
                        txtCelular.Text = dt.Rows[0]["CELULAR_CLIENTE"].ToString();
                        txtEmail.Text = dt.Rows[0]["EMAIL_CLIENTE"].ToString();
                        lblDataInfo.Text = "DATA INFO: " + dt.Rows[0]["DATA_INFO_CLIENTE"].ToString();
                        txtObs.Text = dt.Rows[0]["OBS_CLIENTE"].ToString();
                        btnAlterar.Text = "Gravar";
                    }
                    else
                    {
                        throw new Exception("Selecione uma e apenas uma linha na tabela para alterar");
                    }
                }
                else
                {
                    Cliente cliente = new Cliente(txtNome.Text, txtIdentidade.Text, txtCep.Text, txtRua.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text, cmbUf.Text, txtTelefone.Text, txtCelular.Text, txtEmail.Text, DateTime.Now, txtObs.Text);
                    banco.UpdateCliente(cliente);
                    log.WriteEntry(String.Format("cliente {0} alterado", cliente.Identidade));
                    BtnCancelar_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                log.WriteEntry(ex);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                TableRefresh();
            }
        }
        /// <summary>
        /// Evento de CLICK do btnCancelar
        /// <para>Retorna o form ao seu estado inicial</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in groupComp.Controls)
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
        #region @event.SelectChanged
        /// <summary>
        /// Evento de SelectionChanged do DataGridView
        /// <para>Preenche todos os Controls da GroupBox com os dados da seleção</para>
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ClientesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dvgClientes.SelectedCells.Count == 14)
                {
                    txtNome.Text = dvgClientes.SelectedCells[1].Value.ToString().Trim();
                    txtIdentidade.Text = dvgClientes.SelectedCells[2].Value.ToString().Trim();
                    txtCep.Text = dvgClientes.SelectedCells[3].Value.ToString().Trim();
                    txtRua.Text = dvgClientes.SelectedCells[4].Value.ToString().Trim();
                    txtNumero.Text = dvgClientes.SelectedCells[5].Value.ToString().Trim();
                    txtBairro.Text = dvgClientes.SelectedCells[6].Value.ToString().Trim();
                    txtCidade.Text = dvgClientes.SelectedCells[7].Value.ToString().Trim();
                    cmbUf.Text = dvgClientes.SelectedCells[8].Value.ToString().Trim();
                    txtTelefone.Text = dvgClientes.SelectedCells[9].Value.ToString().Trim();
                    txtCelular.Text = dvgClientes.SelectedCells[10].Value.ToString().Trim();
                    txtEmail.Text = dvgClientes.SelectedCells[11].Value.ToString().Trim();
                    lblDataInfo.Text = String.Concat("DATA INFO: ", dvgClientes.SelectedCells[12].Value.ToString().Trim());
                    txtObs.Text = dvgClientes.SelectedCells[13].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                log.WriteEntry(ex);
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
            }
            else
            {
                txtIdentidade.Size = new Size(107, 20);
                txtIdentidade.Mask = "99,999,999/9999-99";
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
            this.cLIENTESBindingSource.Filter = String.Format("{0} like '%{1}%'", "IDENTIDADE_CLIENTE", txtFiltro.Text);
            if(dvgClientes.RowCount <= 0)
            {
                this.cLIENTESBindingSource.RemoveFilter();
            }
        }
        #endregion
        #region @Control.Methods
        /// <summary>
        /// Define o status de todos os controles de entrada presentes no GroupBox baseado no parâmetro status
        /// </summary>
        /// <param name="status">Define se o status vai ser true ou false</param>
        private void ControlEnable(bool status)
        {
            foreach (Control ctrl in groupComp.Controls)
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
            cLIENTESTableAdapter.Fill(this.dataSetMadeireiraV2.CLIENTES);
            dvgClientes.Refresh();
        }

        private string CharResearch(string statement)
        {
            char[] chars = { '.', '-', '/', ',' };
            char[] lista = statement.ToCharArray();
            string retorno = "";

            for (int i = 0; i < lista.Length; i++)
            {
                if (chars.Contains(lista[i]))
                {
                    lista[i] = ' ';
                }
                retorno += lista[i];
            }            
            return retorno;
        }

        /// <summary>
        /// Atribui o valor da txtIdentidade e a mask baseado nos parametros
        /// </summary>
        /// <param name="identidade">Identidade a ser atribuida</param>
        /// <param name="tipo">Tipo para mudar a mask</param>
        public void IdentidadeInput(string identidade, string tipo)
        {
            try
            {
                if (tipo.Equals("CPF"))
                {
                    txtIdentidade.Mask = "999,999,999-99";
                    txtIdentidade.Text = identidade;
                }
                else
                {
                    txtIdentidade.Mask = "99,999,999/9999-99";
                    txtIdentidade.Text = identidade;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
