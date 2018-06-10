using MaterialSkin.Controls;
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
using TCCMadeireira.Models;
using TCCMadeireira.Util;
using static TCCMadeireira.Bancos.DataSetMadeireiraV2;

namespace TCCMadeireira.Views
{
    /// <summary>
    /// Form responsável por manter o CRUD de Fornecedor
    /// </summary>
    public partial class FrmFornecedor : MaterialForm
    {
        #region Atributes
        Log log = new Log();
        Bancos.Banco banco = new Bancos.Banco();
        int id;
        #endregion
        #region Constructor
        /// <summary>
        /// Inicializa o Form de Fornecedor
        /// </summary>
        public FrmFornecedor()
        {
            InitializeComponent();
        }
        #endregion
        #region @event.Load
        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dataSetMadeireiraV2.FORNECEDORES'. Você pode movê-la ou removê-la conforme necessário.
                this.FornecedoresTableAdapter.Fill(this.dataSetMadeireiraV2.FORNECEDORES);
                this.btnCancelar.Visible = false;
                this.dgvFornecedores.DataSource = this.FornecedoresBindingSource;
                this.rbtnCpf.Checked = true;
                this.rbtnCpfFiltro.Checked = true;
                this.ControlEnable(false);
                this.cmbUf.SelectedItem = "SP";
                this.lblDataInfo.Text = "";
                log.WriteEntry("FrmFornecedores load");
            }
            catch (Exception ex)
            {
                log.WriteEntry(ex);
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
        #region @event.SelectChanged
        /// <summary>
        /// Evento de SelectionChanged do DataGridView
        /// <para>Preenche todos os Controls da GroupBox com os dados da seleção</para>
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FornecedoresDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvFornecedores.SelectedCells.Count == 14)
                {
                    txtFornecedor.Text = dgvFornecedores.SelectedCells[1].Value.ToString().Trim();
                    txtIdentidade.Text = dgvFornecedores.SelectedCells[2].Value.ToString().Trim();
                    txtCep.Text = dgvFornecedores.SelectedCells[3].Value.ToString().Trim();
                    txtRua.Text = dgvFornecedores.SelectedCells[4].Value.ToString().Trim();
                    txtNumero.Text = dgvFornecedores.SelectedCells[5].Value.ToString().Trim();
                    txtBairro.Text = dgvFornecedores.SelectedCells[6].Value.ToString().Trim();
                    txtCidade.Text = dgvFornecedores.SelectedCells[7].Value.ToString().Trim();
                    cmbUf.Text = dgvFornecedores.SelectedCells[8].Value.ToString().Trim();
                    txtTelefone.Text = dgvFornecedores.SelectedCells[9].Value.ToString().Trim();
                    txtCelular.Text = dgvFornecedores.SelectedCells[10].Value.ToString().Trim();
                    txtEmail.Text = dgvFornecedores.SelectedCells[11].Value.ToString().Trim();
                    lblDataInfo.Text = String.Concat("DATA INFO: ", dgvFornecedores.SelectedCells[12].Value.ToString().Trim());
                    txtObs.Text = dgvFornecedores.SelectedCells[13].Value.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                log.WriteEntry(ex);
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Control Methods
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
            FornecedoresTableAdapter.Fill(this.dataSetMadeireiraV2.FORNECEDORES);
            dgvFornecedores.Refresh();
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
        #region @event.Click
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
                    Fornecedor fornecedor = new Fornecedor(txtFornecedor.Text, txtIdentidade.Text, txtCep.Text, txtRua.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text, cmbUf.Text, txtTelefone.Text, txtCelular.Text, txtEmail.Text, txtObs.Text, DateTime.Now);
                    if (banco.SelectFornecedor(fornecedor.Identidade).Rows.Count == 0)
                    {
                        banco.InsertFornecedor(fornecedor);
                        BtnCancelar_Click(null, null);
                        log.WriteEntry(String.Format("fornecedor {0} cadastrado", fornecedor.Identidade));
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

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvFornecedores.SelectedRows.Count == 1)
                {
                    string identidade = dgvFornecedores.SelectedCells[2].Value.ToString();
                    if (MessageBox.Show(String.Format("Você deseja excluir o fornecedor de identidade {0}?", identidade), "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        FORNECEDORESDataTable fornecedordt = banco.SelectFornecedor(identidade);
                        if (fornecedordt.Count == 1)
                        {
                            Fornecedor fornecedor = new Fornecedor(
                                Convert.ToInt32(fornecedordt.Rows[0]["Id_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["nome_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["identidade_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["cep_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["rua_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["numero_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["bairro_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["cidade_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["estado_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["telefone_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["celular_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["email_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["obs_fornecedor"]), Convert.ToDateTime(fornecedordt.Rows[0]["data_info_fornecedor"])
                                );
                            banco.DeleteFornecedor(fornecedor);
                            log.WriteEntry(String.Format("fornecedor {0} excluido", fornecedor.Identidade));
                            BtnCancelar_Click(null, null);
                        }
                        else
                        {
                            throw new Exception("Nenhum ou mais de um fornecedor encontrado\nComunicar erro");
                        }
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

        private void BtnAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                if (btnAlterar.Text == "Alterar")
                {
                    Fornecedor fornecedor = null;
                    if (dgvFornecedores.SelectedRows.Count == 1)
                    {
                        ControlEnable(true);
                        btnCadastrar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnCancelar.Visible = true;
                        fornecedor = new Fornecedor(dgvFornecedores.SelectedCells[2].Value.ToString());
                        FORNECEDORESDataTable fornecedordt = banco.SelectFornecedor(fornecedor.Identidade);
                        if (fornecedordt.Count == 1)
                        {
                            fornecedor = new Fornecedor(
                                Convert.ToInt32(fornecedordt.Rows[0]["Id_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["nome_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["identidade_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["cep_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["rua_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["numero_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["bairro_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["cidade_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["estado_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["telefone_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["celular_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["email_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["obs_fornecedor"]), Convert.ToDateTime(fornecedordt.Rows[0]["data_info_fornecedor"])
                                );
                            id = fornecedor.Id;
                            txtFornecedor.Text = fornecedor.Nome;
                            txtIdentidade.Text = fornecedor.Identidade;
                            txtCep.Text = fornecedor.Cep;
                            txtRua.Text = fornecedor.Rua;
                            txtNumero.Text = fornecedor.Numero;
                            txtBairro.Text = fornecedor.Bairro;
                            txtCidade.Text = fornecedor.Cidade;
                            cmbUf.SelectedItem = fornecedor.Estado;
                            txtTelefone.Text = fornecedor.Telefone;
                            txtCelular.Text = fornecedor.Celular;
                            txtEmail.Text = fornecedor.Email;
                            lblDataInfo.Text = "DATA INFO: " + fornecedor.DataInfo;
                            txtObs.Text = fornecedor.Obs;
                            btnAlterar.Text = "Gravar";
                        }
                        else
                        {
                            throw new Exception("Há um erro no DB, há mais de uma identidade registrada com esses digitos\n" +
                                "Contate a central para reparar o DB");
                        }
                    }
                    else
                    {
                        throw new Exception("Selecione uma e apenas uma linha na tabela para alterar");
                    }
                }
                else
                {
                    Fornecedor fornecedor = new Fornecedor(id, txtFornecedor.Text, txtIdentidade.Text, txtCep.Text, txtRua.Text, txtNumero.Text, txtBairro.Text, txtCidade.Text, cmbUf.Text, txtTelefone.Text, txtCelular.Text, txtEmail.Text, txtObs.Text, DateTime.Now);
                    banco.UpdateFornecedor(fornecedor);
                    id = -1;
                    log.WriteEntry(String.Format("fornecedor {0} alterado", fornecedor.Identidade));
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
        #region @event.TextChanged
        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            FornecedoresBindingSource.Filter = String.Format("{0} like '%{1}%'", "IDENTIDADE_FORNECEDOR", txtFiltro.Text);
            if(dgvFornecedores.RowCount == 0)
            {
                FornecedoresBindingSource.RemoveFilter();
            }
        }
        #endregion
    }
}
