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
    /// Form responsavel por Registrar o consultar Fornecimentos
    /// </summary>
    public partial class FrmFornecimento : Form
    {
        #region Atributes
        Banco banco = new Banco();
        List<ProdOper> produtos = new List<ProdOper>();
        Fornecedor fornecedor = null;
        Usuario usuario;
        decimal valor;
        #endregion
        /// <summary>
        /// Inicializa o Form de Fornecimento
        /// </summary>
        public FrmFornecimento()
        {
            InitializeComponent();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            FrmProdOper frmProdVenda = new FrmProdOper(this);
            frmProdVenda.Show();
        }
        private void TxtIdentidade_Leave(object sender, EventArgs e)
        {
            try
            {
                fornecedor = new Fornecedor(txtIdentidade.Text);
                FORNECEDORESDataTable fornecedordt = new FORNECEDORESDataTable();
                fornecedordt = banco.SelectFornecedor(fornecedor.Identidade);                
                //TODO arrumar lbls
                if (fornecedordt.Rows.Count == 1)
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
                    lblNome.Text = fornecedordt.Rows[0][1].ToString();
                    lblEndereco.Text = String.Format("CEP: {0} RUA: {1} Nº: {1} BAIRRO: {2} CIDADE: {3} UF: {4}",
                        fornecedordt.Rows[0][3].ToString(), fornecedordt.Rows[0][4].ToString(), fornecedordt.Rows[0][5].ToString(),
                        fornecedordt.Rows[0][6].ToString(), fornecedordt.Rows[0][7].ToString(), fornecedordt.Rows[0][8].ToString());
                }
                else
                {
                    FrmFornecedor frmFornecedor = new FrmFornecedor();
                    frmFornecedor.Show();
                    frmFornecedor.IdentidadeInput(txtIdentidade.Text, SelectedRadioButton());
                }
                //TODO Rever este erro
                if (fornecedordt.Rows.Count > 1)
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
        /// Insere os dados provinientes do FrmProdOper
        /// </summary>
        /// <param name="id"></param>
        /// <param name="produto"></param>
        /// <param name="quantidade"></param>
        // TODO Rever InsertData overload
        public void InsertDataProd(string id, string produto, string quantidade, string valor)
        {
            dgvProdutos.Rows.Add(id, produto, quantidade, valor);
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
                dgvProdutos.Rows.Add(prodVenda.Produto.Id, prodVenda.Produto.Nome, prodVenda.Quantidade, prodVenda.Produto.Valor);
            }
            else
            {
                produtos.Find(x => x.Produto.Id == prodVenda.Produto.Id).Quantidade += prodVenda.Quantidade;
                dgvProdutos.Rows.Cast<DataGridViewRow>().Where(x => (int)x.Cells["IdProduto"].Value == prodVenda.Produto.Id).
                    First().Cells["QuantidadeProduto"].Value = produtos.Find(x => x.Produto.Id == prodVenda.Produto.Id).Quantidade;
                ValorSet();
            }
        }
        private void ValorSet()
        {
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
        #endregion
        private void FrmFornecimento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms["FrmProdVenda"] != null)
            {
                e.Cancel = true;
                throw new Exception("O formuçário para inserir produtos deve ser fechado primeiro");
            }
        }

        private void FrmFornecimento_Load(object sender, EventArgs e)
        {
            USERSDataTable usersdt = banco.SelectUsuario(Properties.Settings.Default.idUsuario);
            usuario = new Usuario(
                Convert.ToInt32(usersdt.Rows[0]["id_usuario"]), Convert.ToString(usersdt.Rows[0]["login_usuario"]),
                Convert.ToString(usersdt.Rows[0]["nivel_usuario"])
            );
        }

        private void btnRemover_Click(object sender, EventArgs e)
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

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (fornecedor is null)
                {
                    throw new Exception("Um fornecedor deve ser informado");
                }
                if (dgvProdutos.Rows.Count <= 0)
                {
                    throw new Exception("O fornecimento não pode conter nenhum produto");
                }
                Fornecimento fornecimento = new Fornecimento(fornecedor, produtos, usuario, DateTime.Now, valor);
                banco.InsertFornecimento(fornecimento);
                MessageBox.Show("Fornecimento efetuado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
