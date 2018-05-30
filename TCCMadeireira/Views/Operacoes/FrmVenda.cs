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
using TCCMadeireira.Models;
using static TCCMadeireira.Bancos.DataSetMadeireiraV2;

namespace TCCMadeireira.Views
{
    /// <summary>
    /// Form responsavel por registrar uma venda
    /// </summary>
    public partial class FrmVenda : Form
    {
        #region Atributes
        Banco banco = new Banco();
        List<ProdOper> produtos = new List<ProdOper>();
        Cliente cliente = null;
        Usuario usuario;
        decimal valor;
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
                    lblEndereco.Text = String.Format("CEP: {0} RUA: {1} Nº: {1} BAIRRO: {2} CIDADE: {3} UF: {4}",
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
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                if (dgvProdutos.Rows.Count <= 0)
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
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            FrmProdOper frmProdVenda = new FrmProdOper(this);
            frmProdVenda.Show();
        }
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 1)
            {
                ProdOper prodVenda = produtos.ElementAt(dgvProdutos.SelectedRows[0].Index);
                if (MessageBox.Show(
                    String.Format("Deseja mesmo remover o produto {0} de código {1}?", prodVenda.Produto.Nome, prodVenda.Produto.Id),
                    "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                {
                    produtos.Remove(prodVenda);
                    dgvProdutos.Rows.Remove(dgvProdutos.SelectedRows[0]);
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
            produtos.Add(prodVenda);
            dgvProdutos.Rows.Add(prodVenda.Produto.Id, prodVenda.Produto.Nome, prodVenda.Quantidade, prodVenda.Produto.Valor);
        }
        private void ValorSet()
        {
            CheckEstoque();
            decimal valorTotal = 0;
            for (int i = 0; i < dgvProdutos.Rows.Count; i++)
            {
                valorTotal += Convert.ToDecimal(dgvProdutos.Rows[i].Cells[2]) * Convert.ToDecimal(dgvProdutos.Rows[i].Cells[3]);
            }
            valor = valorTotal;
            lblValorTotal.Text = String.Format("Valor Total: R$ {0:.2}", valor);
        }
        private void ValorSet(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CheckEstoque();
            decimal valorTotal = 0;
            for (int i = 0; i < dgvProdutos.Rows.Count; i++)
            {
                valorTotal += Convert.ToDecimal(dgvProdutos.Rows[i].Cells[2]) * Convert.ToDecimal(dgvProdutos.Rows[i].Cells[3]);
            }
            valor = valorTotal;
            lblValorTotal.Text = String.Format("Valor Total: R$ {0:.2}", valor);
        }
        private void ValorSet(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CheckEstoque();
            decimal valorTotal = 0;
            for (int i = 0; i < dgvProdutos.Rows.Count; i++)
            {
                valorTotal += Convert.ToDecimal(dgvProdutos.Rows[i].Cells[2]) * Convert.ToDecimal(dgvProdutos.Rows[i].Cells[3]);
            }
            valor = valorTotal;
            lblValorTotal.Text = String.Format("Valor Total: R$ {0:.2}", valor);
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
            List<int> todos = new List<int>();
            List<int> repetidos = new List<int>();
            foreach(DataGridViewRow row in rows)
            {
                int id = (int)row.Cells["ID"].Value;
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

        
    }
}
