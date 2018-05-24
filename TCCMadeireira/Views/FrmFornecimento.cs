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

namespace TCCMadeireira.Views
{
    /// <summary>
    /// Form responsavel por Registrar o consultar Fornecimentos
    /// </summary>
    public partial class FrmFornecimento : Form
    {
        #region Atributes
        Banco banco = new Banco();
        #endregion
        /// <summary>
        /// Inicializa o Form de Fornecimento
        /// </summary>
        public FrmFornecimento()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }
        private void TxtIdentidade_Leave(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente(txtIdentidade.Text);
                DataTable dt = new DataTable();
                dt = banco.SelectCliente(cliente.Identidade);
                if (dt.Rows.Count > 0)
                {
                    lblNome.Text = dt.Rows[0][1].ToString();
                    lblNome.Text = String.Format("CEP: {0} RUA: {1} Nº: {1} BAIRRO: {2} CIDADE: {3} UF: {4}",
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
                if (dt.Rows.Count < 0)
                {
                    lblNome.Text = dt.Rows[0][1].ToString();
                    lblNome.Text = String.Format("CEP: {0} RUA: {1} Nº: {1}\nBAIRRO: {2} CIDADE: {3} UF: {4}",
                        dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(),
                        dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString(), dt.Rows[0][8].ToString());
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
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            FrmProdVenda frmProdVenda = new FrmProdVenda(this);
            frmProdVenda.Show();
        }
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
        private void ValorSet()
        {
            decimal valorTotal = 0;
            for (int i = 0; i < dgvProdutos.Rows.Count; i++)
            {
                valorTotal += Convert.ToDecimal(dgvProdutos.Rows[i].Cells[2]) * Convert.ToDecimal(dgvProdutos.Rows[i].Cells[3]);
            }
            lblValorTotal.Text = String.Format("Valor Total: R$ {0:.2}", valorTotal);
        }
        private void ValorSet(object sender, DataGridViewRowsAddedEventArgs e)
        {
            decimal valorTotal = 0;
            for (int i = 0; i < dgvProdutos.Rows.Count; i++)
            {
                valorTotal += Convert.ToDecimal(dgvProdutos.Rows[i].Cells[2]) * Convert.ToDecimal(dgvProdutos.Rows[i].Cells[3]);
            }
            lblValorTotal.Text = String.Format("Valor Total: R$ {0:.2}", valorTotal);
        }
        private void ValorSet(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            decimal valorTotal = 0;
            for (int i = 0; i < dgvProdutos.Rows.Count; i++)
            {
                valorTotal += Convert.ToDecimal(dgvProdutos.Rows[i].Cells[2]) * Convert.ToDecimal(dgvProdutos.Rows[i].Cells[3]);
            }
            lblValorTotal.Text = String.Format("Valor Total: R$ {0:.2}", valorTotal);
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
    }
}
