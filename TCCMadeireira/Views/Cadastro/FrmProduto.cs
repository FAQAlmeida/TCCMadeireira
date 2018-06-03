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
using TCCMadeireira.Models;
using static TCCMadeireira.Bancos.DataSetMadeireiraV2;

namespace TCCMadeireira.Views
{
    public partial class FrmProduto : Form
    {
        Banco banco = new Banco();
        int id;
        /// <summary>
        /// Inicializa o Form de Produtos
        /// </summary>
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'dataSetMadeireiraV2.FORNECEDORES'. Você pode movê-la ou removê-la conforme necessário.
                this.fORNECEDORESTableAdapter.Fill(this.dataSetMadeireiraV2.FORNECEDORES);
                // TODO: esta linha de código carrega dados na tabela 'dataSetMadeireiraV2.PRODUTOS'. Você pode movê-la ou removê-la conforme necessário.
                this.pRODUTOSTableAdapter.Fill(this.dataSetMadeireiraV2.PRODUTOS);
                this.btnCancelar.Visible = false;
                this.dgvProdutos.DataSource = this.pRODUTOSBindingSource;
                this.ControlEnable(false);
            }catch(Exception ex)
            {
                //log.WriteEntry(ex);

            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            //comboBox1.DisplayMember = dataSetMadeireiraV2.FORNECEDORES.NOME_FORNECEDORColumn.ColumnName;
            //comboBox1.Update();
        }
        #region @event.SelectChanged
        /// <summary>
        /// Evento de SelectionChanged do DataGridView
        /// <para>Preenche todos os Controls da GroupBox com os dados da seleção</para>
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ProdutosDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutos.SelectedRows.Count == 1)
                {
                    txtNome.Text = (string)dgvProdutos.SelectedCells[1].Value;
                    numQuantidade.Value = (decimal)dgvProdutos.SelectedCells[2].Value;
                    txtValor.Text = (string) dgvProdutos.SelectedCells[3].Value;
                    comboBox1.SelectedValue = dgvProdutos.SelectedCells[4].Value;
                    txtObs.Text = (string)dgvProdutos.SelectedCells[5].Value;
                }
            }
            catch (Exception ex)
            {
                //log.WriteEntry(ex);
                MessageBox.Show(ex.Message);
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
                else if (ctrl is NumericUpDown)
                {
                    (ctrl as NumericUpDown).Enabled = status;
                }
            }
        }
        private void TableRefresh()
        {
            pRODUTOSTableAdapter.Fill(this.dataSetMadeireiraV2.PRODUTOS);
            dgvProdutos.Refresh();
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
            this.pRODUTOSBindingSource.Filter = String.Format("{0} like '%{1}%'", "IDENTIDADE_CLIENTE", txtFiltro.Text);
            if (dgvProdutos.RowCount <= 0)
            {
                this.pRODUTOSBindingSource.RemoveFilter();
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
                    FORNECEDORESDataTable fornecedordt = fORNECEDORESTableAdapter.GetDataFornecedor((int) comboBox1.SelectedValue);
                    Fornecedor fornecedor = new Fornecedor(
                                Convert.ToInt32(fornecedordt.Rows[0]["Id_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["nome_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["identidade_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["cep_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["rua_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["numero_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["bairro_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["cidade_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["estado_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["telefone_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["celular_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["email_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["obs_fornecedor"]), Convert.ToDateTime(fornecedordt.Rows[0]["data_info_fornecedor"])
                                );
                    Produto produto = new Produto(txtNome.Text, fornecedor, Convert.ToDecimal(txtValor.Text), numQuantidade.Value, txtObs.Text);
                    if (banco.SelectProduto(produto.Nome).Rows.Count == 0)
                    {
                        banco.InsertProduto(produto);
                        BtnCancelar_Click(null, null);
                        //log.WriteEntry(String.Format("produto {0} cadastrado", produto.Nome));
                    }
                    else
                    {
                        throw new Exception("Produto já cadastrado");
                    }
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
                if (dgvProdutos.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show(String.Format("Você deseja excluir {0}?", (string)dgvProdutos.SelectedCells[1].Value), "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Produto produto = new Produto((int)dgvProdutos.SelectedCells[0].Value);
                        banco.DeleteProduto(produto);
                        //log.WriteEntry(String.Format("cliente {0} excluido", cliente.Identidade));
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
                    if (dgvProdutos.SelectedRows.Count == 1)
                    {
                        ControlEnable(true);
                        btnCadastrar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnCancelar.Visible = true;
                        PRODUTOSDataTable dt = new PRODUTOSDataTable();
                        id = (int)dgvProdutos.SelectedCells[0].Value;
                        Produto produto = new Produto(id);
                        dt = banco.SelectProduto(produto.Id);
                        txtNome.Text = dt.Rows[0]["NOME_PRODUTO"].ToString();
                        numQuantidade.Value = (decimal)dt.Rows[0]["QUANTIDADE_PRODUTO"];
                        txtValor.Text = dt.Rows[0]["VALOR_PRODUTO"].ToString();
                        comboBox1.SelectedValue = dt.Rows[0]["ID_FORNECEDOR_PRODUTO"];
                        txtObs.Text = dt.Rows[0]["OBS_PRODUTO"].ToString();
                        btnAlterar.Text = "Gravar";
                    }
                    else
                    {
                        throw new Exception("Selecione uma e apenas uma linha na tabela para alterar");
                    }
                }
                else
                {
                    FORNECEDORESDataTable fornecedordt = fORNECEDORESTableAdapter.GetDataFornecedor((int) comboBox1.SelectedValue);
                    Fornecedor fornecedor = new Fornecedor(
                                Convert.ToInt32(fornecedordt.Rows[0]["Id_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["nome_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["identidade_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["cep_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["rua_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["numero_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["bairro_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["cidade_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["estado_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["telefone_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["celular_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["email_fornecedor"]),
                                Convert.ToString(fornecedordt.Rows[0]["obs_fornecedor"]), Convert.ToDateTime(fornecedordt.Rows[0]["data_info_fornecedor"])
                                );
                    Produto produto = new Produto(id, txtNome.Text, fornecedor, Convert.ToDecimal(txtValor.Text), numQuantidade.Value, txtObs.Text);
                    banco.UpdateProduto(produto);
                    //log.WriteEntry(String.Format("produto {0} alterado", produto.Nome));
                    BtnCancelar_Click(null, null);
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
        /// Evento de CLICK do btnCancelar
        /// <para>Retorna o form ao seu estado inicial</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            id = -1;
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
                    (ctrl as ComboBox).SelectedIndex = 0;
                }
                else if (ctrl is NumericUpDown)
                {
                    (ctrl as NumericUpDown).Value = 1;
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
