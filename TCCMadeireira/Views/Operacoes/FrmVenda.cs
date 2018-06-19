using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCCMadeireira.Bancos;
using TCCMadeireira.Model;
using TCCMadeireira.Models;
using static TCCMadeireira.Bancos.DataSetMadeireiraV2;

namespace TCCMadeireira.Views
{
    /// <summary>
    /// Form responsavel por registrar uma venda
    /// </summary>
    public partial class FrmVenda : MaterialForm
    {
        #region Atributes
        Banco banco = new Banco();
        List<ProdOper> produtos = new List<ProdOper>();
        Cliente cliente = null;
        Usuario usuario;
        decimal valor;
        FrmProdOper frmProdOper;
        #endregion
        #region Constructor
        /// <summary>
        /// Inicializa o form de venda
        /// </summary>
        public FrmVenda()
        {
            InitializeComponent();
        }
        #endregion
        #region @event.Leave
        private void TxtIdentidade_Leave(object sender, EventArgs e)
        {
            Regex regex;
            if (rbtnCnpj.Checked)
                regex = new Regex("[0-9]{2}[.,/-]?[0-9]{3}[.,/-]?[0-9]{3}[.,/-]?[0-9]{4}[.,/-]?[0-9]{2}",
                    RegexOptions.None);
            else
                regex = new Regex("[0-9]{3}[.,/-]?[0-9]{3}[.,/-]?[0-9]{3}[.,/-]?[0-9]{2}",
                    RegexOptions.None);
            if (regex.Match(txtIdentidade.Text).Success)
            {
                try
                {
                    cliente = new Cliente(txtIdentidade.Text);
                    CLIENTESDataTable dt = new CLIENTESDataTable();
                    dt = banco.SelectCliente(cliente.Identidade);
                    //TODO arruamar lbls
                    if (dt.Rows.Count == 1)
                    {
                        cliente = new Cliente(
                        Convert.ToInt32(dt.Rows[0]["Id_cliente"]), Convert.ToString(dt.Rows[0]["nome_cliente"]),
                        Convert.ToString(dt.Rows[0]["identidade_cliente"]), Convert.ToString(dt.Rows[0]["cep_cliente"]),
                        Convert.ToString(dt.Rows[0]["rua_cliente"]), Convert.ToString(dt.Rows[0]["numero_cliente"]),
                        Convert.ToString(dt.Rows[0]["bairro_cliente"]), Convert.ToString(dt.Rows[0]["cidade_cliente"]),
                        Convert.ToString(dt.Rows[0]["estado_cliente"]), Convert.ToString(dt.Rows[0]["telefone_cliente"]),
                        Convert.ToString(dt.Rows[0]["celular_cliente"]), Convert.ToString(dt.Rows[0]["email_cliente"]),
                        Convert.ToDateTime(dt.Rows[0]["data_info_cliente"]), Convert.ToString(dt.Rows[0]["obs_cliente"])
                        );
                        lblNome.Text = dt.Rows[0][1].ToString();
                        lblEndereco.Text = String.Format("CEP: {0} RUA: {1} Nº: {2}\nBAIRRO: {3} CIDADE: {4} UF: {5}",
                            dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(),
                            dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString(), dt.Rows[0][8].ToString());
                    }
                    else
                    {
                        FrmCliente frmCliente = new FrmCliente();
                        frmCliente.Show();
                        frmCliente.IdentidadeInput(txtIdentidade.Text, SelectedRadioButton());
                    }
                    //TODO Rever este erro
                    if (dt.Rows.Count > 1)
                    {
                        throw new Exception("Há um erro no DB, há mais de uma identidade registrada com esses digitos\n" +
                            "Contate a central para reparar o DB");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion
        #region @event.Load
        private void FrmVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetMadeireiraV2.VENDAS'. Você pode movê-la ou removê-la conforme necessário.
            this.vendasTableAdapter.Fill(this.dataSetMadeireiraV2.VENDAS);
            USERSDataTable usersdt = banco.SelectUsuario(Properties.Settings.Default.idUsuario);
            usuario = new Usuario(
                Convert.ToInt32(usersdt.Rows[0]["id_usuario"]), Convert.ToString(usersdt.Rows[0]["login_usuario"]),
                Convert.ToString(usersdt.Rows[0]["nivel_usuario"])
            );
             frmProdOper = new FrmProdOper(this);
            cmbOper.SelectedIndex = 0;
        }
        #endregion
        #region @event.Click
        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cliente is null)
                {
                    throw new Exception("Um cliente deve ser informado");
                }
                if (dgvProdutos.Rows.Count <= 1)
                {
                    throw new Exception("A venda não pode conter nenhum produto");
                }
                Venda venda = new Venda(cliente, produtos, usuario, DateTime.Now, valor);
                banco.InsertVenda(venda);
                MessageBox.Show("Venda efetuada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            frmProdOper.ShowDialog();
            if (frmProdOper.DialogResult == DialogResult.OK)
            {
                ProdOper prodOper = frmProdOper.ProdOper;
                InsertDataProd(prodOper);
            }
        }
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedCells.Count == 1)
            {
                ProdOper prodVenda = produtos.Find(x => x.Produto.Id == Convert.ToInt32(dgvProdutos["IdProduto", dgvProdutos.SelectedCells[0].RowIndex].Value));
                if (prodVenda is null)
                    MessageBox.Show("Selecione um produto na tabela para remover");
                else
                {
                    if (MessageBox.Show(
                        String.Format("Deseja mesmo remover o produto {0} de código {1}?", prodVenda.Produto.Nome, prodVenda.Produto.Id),
                        "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                    {
                        produtos.Remove(prodVenda);
                        dgvProdutos.Rows.Remove(dgvProdutos.Rows[dgvProdutos.SelectedCells[0].RowIndex]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto na tabela para remover", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        #endregion
        #region Control.methods
        /// <summary>
        /// Insere os dados provinientes do FrmProdVenda e atualiza a lblValorTotal
        /// </summary>
        /// <param name="id"></param>
        /// <param name="produto"></param>
        /// <param name="quantidade"></param>
        public void InsertDataProd(string id, string produto, string quantidade)
        {
            dgvProdutos.Rows.Add(id, produto, quantidade);
        }
        /// <summary>
        /// Insere os dados provinientes do FrmProdOper
        /// </summary>
        /// <param name="prodVenda"></param>
        internal void InsertDataProd(ProdOper prodVenda)
        {
            if (!produtos.Exists(x => x.Produto.Id == prodVenda.Produto.Id))
            {
                produtos.Add(prodVenda);
                //dgvProdutos.Rows.Add(prodVenda.Produto.Id, prodVenda.Produto.Nome, prodVenda.Quantidade, prodVenda.Produto.Valor);
            }
            else
            {
                produtos.Find(x => x.Produto.Id == prodVenda.Produto.Id).Quantidade = prodVenda.Quantidade;
                //DataGridViewRow row = dgvProdutos.Rows.Cast<DataGridViewRow>().Where(x => (int)x.Cells["IdProduto"].Value == prodVenda.Produto.Id).First();
                //dgvProdutos.Rows[row.Index].Cells["QuantidadeProduto"].Value = produtos.Find(x => x.Produto.Id == prodVenda.Produto.Id).Quantidade;
            }
        }
        private void ValorSet()
        {
            CheckEstoque();
            decimal valorTotal = 0;
            foreach (ProdOper prod in produtos)
            {
                valorTotal += (prod.Quantidade * prod.Produto.Valor);
            }
            valor = cmbOper.SelectedIndex == 0 ? valorTotal - (valorTotal * numDesc.Value / 100) : valorTotal - numDesc.Value;
            lblValorTotal.Text = String.Format("Valor Total: R$ {0:f2}", valor);
        }
        private void ValorSet(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ValorSet();
        }
        private void ValorSet(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ValorSet();
        }

        private string SelectedRadioButton()
        {
            if (rbtnCpf.Checked)
            {
                return "CPF";
            }
            return "CNPJ";
        }
        private void CheckEstoque()
        {
            Dictionary<int, decimal> estoqueReal = new Dictionary<int, decimal>();
            foreach(int id in IdsRepetidosInRows(dgvProdutos.Rows))
            {
                estoqueReal.Add(id, 0);
                foreach(ProdOper produto in this.produtos)
                {
                    if(id == produto.Produto.Id)
                    {
                        estoqueReal[id] += produto.Quantidade;
                    }
                }
            }
            foreach(int id in estoqueReal.Keys)
            {
                PRODUTOSDataTable produto = banco.SelectProduto(id);
                string msg = String.Empty;
                if(produto.Rows.Count == 1)
                {
                    if ((decimal)produto.Rows[0]["quantidade_produto"] < estoqueReal[id])
                        msg += String.Format("\nQuantidade do produto {0} insuficiente para a venda",
                            produto.Rows[0]["nome_produto"]);
                    if((decimal)produto.Rows[0]["quantidade_produto"] == estoqueReal[id])
                        msg += String.Format("\nQuantidade do produto {0} suficiente para a venda, " +
                            "mas o estoque será zerado", produto.Rows[0]["nome_produto"]);
                }
                if(msg != String.Empty)
                {
                    throw new Exception(msg);
                }
            }
        }
        private List<int> IdsRepetidosInRows(DataGridViewRowCollection rows)
        {
            List<int> todos = IdsDgv(rows);
            List<int> repetidos = new List<int>();
            foreach (DataGridViewRow row in rows)
            {
                int id = Convert.ToInt32(row.Cells["IdProduto"].Value);
                if (!todos.Contains(id))
                {
                    todos.Add(id);
                }
                else
                {
                    repetidos.Add(id);
                }
            }
            return repetidos;
        }
        private List<int> IdsDgv(DataGridViewRowCollection rows)
        {
            List<int> todos = new List<int>();
            foreach(DataGridViewRow row in dgvProdutos.Rows)
            {
                todos.Add(Convert.ToInt32(row.Cells["IdProduto"].Value));
            }
            return todos;
        }
        private bool FindRowById(int id, out DataGridViewRow row)
        {
            row = null;
            if (IdsDgv(dgvProdutos.Rows).Contains(id))
            {
                foreach(DataGridViewRow r in dgvProdutos.Rows)
                {
                    if((int) r.Cells["idProduto"].Value == id)
                    {
                        row = r;
                        return true;
                    }
                }
            }
            return false;
        }
        private ProdOper FindProdById(int id)
        {
            foreach(ProdOper prod in produtos)
            {
                if(prod.Produto.Id == id)
                {
                    return prod;
                }
            }
            return null;
        }
        #endregion
        #region @event.FormClosing
        private void FrmVenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Application.OpenForms["FrmProdOper"] != null)
            {
                e.Cancel = true;
                throw new Exception("O formulário para inserir produtos deve ser fechado primeiro");
            }
        }

        #endregion

        private void dgvProdutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                e.Handled = true;
            }
        }

        private void dgvProdutos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdutos.Columns[e.ColumnIndex].HeaderText.Equals("ID"))
            {
                dgvProdutos.Rows[e.RowIndex].ReadOnly = true;
                dgvProdutos.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                dgvProdutos[e.ColumnIndex, e.RowIndex].ReadOnly = false;
                dgvProdutos[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                dgvProdutos.CurrentCell = dgvProdutos[e.ColumnIndex, e.RowIndex];
            }
        }

        private void dgvProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void dgvProdutos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdutos.Columns[e.ColumnIndex].HeaderText.Equals("ID"))
            {
                PRODUTOSDataTable prodsdt = banco.SelectProduto(Convert.ToInt32(dgvProdutos[e.ColumnIndex, e.RowIndex].Value));
                if (prodsdt.Rows.Count == 1)
                {
                    dgvProdutos[e.ColumnIndex + 1, e.RowIndex].Value = prodsdt.Rows[0]["Nome_Produto"];
                    dgvProdutos[e.ColumnIndex + 3, e.RowIndex].Value = prodsdt.Rows[0]["Valor_Produto"];
                    dgvProdutos[e.ColumnIndex, e.RowIndex].ReadOnly = true;
                    dgvProdutos[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.LightGray;
                    BeginInvoke((MethodInvoker)delegate ()
                    {
                        dgvProdutos.CurrentCell = dgvProdutos[e.ColumnIndex + 2, e.RowIndex];
                        dgvProdutos.CurrentCell.ReadOnly = false;
                        dgvProdutos.CurrentCell.ToolTipText = "Quantidade Máxima " + prodsdt.Rows[0]["Quantidade_Produto"].ToString();
                        dgvProdutos.CurrentCell.Style.BackColor = Color.White;
                    }
                    );
                }
                else
                {
                    MessageBox.Show("ID não encontrado");
                    BeginInvoke((MethodInvoker)delegate ()
                    {
                        dgvProdutos[e.ColumnIndex, e.RowIndex].ReadOnly = false;
                        dgvProdutos[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.White;
                        dgvProdutos.CurrentCell = dgvProdutos[e.ColumnIndex, e.RowIndex];
                    });
                }
            }
            if (dgvProdutos.Columns[e.ColumnIndex].HeaderText.Equals("QUANTIDADE"))
            {
                try
                {
                    PRODUTOSDataTable produtosdt = banco.SelectProduto(Convert.ToInt32(dgvProdutos["IdProduto", e.RowIndex].Value));
                    FORNECEDORESDataTable fornecedordt = banco.SelectFornecedor(Convert.ToInt32(produtosdt.Rows[0]["id_fornecedor_produto"]));
                    Fornecedor fornecedor = new Fornecedor(
                        Convert.ToInt32(fornecedordt.Rows[0]["id_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["nome_fornecedor"]),
                        Convert.ToString(fornecedordt.Rows[0]["identidade_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["cep_fornecedor"]),
                        Convert.ToString(fornecedordt.Rows[0]["rua_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["numero_fornecedor"]),
                        Convert.ToString(fornecedordt.Rows[0]["bairro_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["cidade_fornecedor"]),
                        Convert.ToString(fornecedordt.Rows[0]["estado_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["telefone_fornecedor"]),
                        Convert.ToString(fornecedordt.Rows[0]["celular_fornecedor"]), Convert.ToString(fornecedordt.Rows[0]["email_fornecedor"]),
                        Convert.ToString(fornecedordt.Rows[0]["obs_fornecedor"]), Convert.ToDateTime(fornecedordt.Rows[0]["data_info_fornecedor"])
                    );
                    Produto produto = new Produto(
                           Convert.ToInt32(produtosdt.Rows[0]["id_produto"]), Convert.ToString(produtosdt.Rows[0]["nome_produto"]),
                           fornecedor, Convert.ToDecimal(produtosdt.Rows[0]["valor_produto"]),
                           Convert.ToDecimal(produtosdt.Rows[0]["quantidade_produto"]), produtosdt.Rows[0]["obs_produto"].ToString()
                    );
                    ProdOper prodOper = new ProdOper(produto, Convert.ToDecimal(dgvProdutos[e.ColumnIndex, e.RowIndex].Value));
                    InsertDataProd(prodOper);
                    ValorSet();
                    BeginInvoke((MethodInvoker)delegate ()
                    {
                        dgvProdutos[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.LightGray;
                        dgvProdutos[e.ColumnIndex, e.RowIndex].ReadOnly = true;
                        dgvProdutos.CurrentCell = dgvProdutos["IdProduto", dgvProdutos.NewRowIndex];
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    PRODUTOSDataTable prodsdt = banco.SelectProduto(Convert.ToInt32(dgvProdutos["IdProduto", e.RowIndex].Value));
                    dgvProdutos.CurrentCell.Value = prodsdt.Rows[0]["Quantidade_Produto"];
                }
            }
        }

        private void dgvProdutos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void dgvProdutos_MouseHover(object sender, EventArgs e)
        {
            //if(!(dgvProdutos.CurrentCell is null))
            //    if(dgvProdutos.Columns[dgvProdutos.CurrentCell.ColumnIndex].HeaderText.Equals("QUANTIDADE"))
            //        toolTip.Show("Quantidade Máxima" + dgvProdutos.CurrentCell.Value.ToString(), this);
        }

        private void CmbOper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOper.SelectedIndex == 0)
            {
                numDesc.DecimalPlaces = 0;
                numDesc.Maximum = 100;
            }

            else
            {
                numDesc.DecimalPlaces = 2;
                numDesc.Maximum = valor;
            }
        }

        private void NumDesc_ValueChanged(object sender, EventArgs e)
        {
            ValorSet();
        }

        private void NumDesc_Leave(object sender, EventArgs e)
        {
            ValorSet();
        }
    }
}
