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
using static TCCMadeireira.Bancos.DataSetMadeireiraV2;

namespace TCCMadeireira.Views
{
    /// <summary>
    /// Form responsavel por adicionar produtos a uma venda
    /// </summary>
    public partial class FrmProdOper : Form
    {
        private FrmVenda venda;
        private FrmFornecimento fornecimento;
        private Bancos.Banco banco = new Bancos.Banco();
        private ProdOper prodOper;

        internal ProdOper ProdOper { get => prodOper; set => prodOper = value; }

        /// <summary>
        /// Inicializa o Form ProdVenda
        /// </summary>
        /// <param name="frmVenda"></param>
        public FrmProdOper(FrmVenda frmVenda)
        {    
            InitializeComponent();
            venda = frmVenda;
        }
        /// <summary>
        /// Inicializa o Form ProdVenda
        /// </summary>
        /// <param name="frmFornecimento"></param>
        public FrmProdOper(FrmFornecimento frmFornecimento)
        {
            InitializeComponent();
            fornecimento = frmFornecimento;
        }

        private void FrmProdVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetMadeireiraV2.PRODUTOS'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.dataSetMadeireiraV2.PRODUTOS);
            cmbFiltro.SelectedIndex = 0;
            try
            {
                //TODO trocar o index dos datatables para o nome da coluna
                if (dvgProduto.SelectedRows.Count > 0)
                {
                    PRODUTOSDataTable produtosdt = banco.SelectProduto(Convert.ToInt32(dvgProduto.SelectedCells[0].Value));
                    if (produtosdt.Count > 0)
                    {
                        FORNECEDORESDataTable fornecedordt = banco.SelectFornecedor(produtosdt.Rows[0]["id_fornecedor_produto"].ToString());
                        if (fornecedordt.Count > 0)
                        {
                            Fornecedor fornecedor = new Fornecedor(
                                Convert.ToInt32(fornecedordt.Rows[0][0]), Convert.ToString(fornecedordt.Rows[0][1]),
                                Convert.ToString(fornecedordt.Rows[0][2]), Convert.ToString(fornecedordt.Rows[0][3]),
                                Convert.ToString(fornecedordt.Rows[0][4]), Convert.ToString(fornecedordt.Rows[0][5]),
                                Convert.ToString(fornecedordt.Rows[0][6]), Convert.ToString(fornecedordt.Rows[0][7]),
                                Convert.ToString(fornecedordt.Rows[0][8]), Convert.ToString(fornecedordt.Rows[0][9]),
                                Convert.ToString(fornecedordt.Rows[0][10]), Convert.ToString(fornecedordt.Rows[0][11]),
                                Convert.ToString(fornecedordt.Rows[0][12]), Convert.ToDateTime(fornecedordt.Rows[0][13])
                            );
                            Produto produto = new Produto(
                                   Convert.ToInt32(produtosdt.Rows[0]["id_produto"]), Convert.ToString(produtosdt.Rows[0]["nome_produto"]),
                                   fornecedor, Convert.ToDecimal(produtosdt.Rows[0]["valor_produto"]),
                                   Convert.ToDecimal(produtosdt.Rows[0]["quantidade_produto"]), produtosdt.Rows[0]["obs_produto"].ToString()
                           );
                            ProdOper = new ProdOper(produto, numQuantidade.Value);
                            
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um produto na tabela");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (!txtFiltro.Text.Trim().Equals(""))
            {
                if (cmbFiltro.SelectedItem.Equals("Código"))
                {
                    produtosBindingSource.Filter = String.Format("id_produto = '{0}'", txtFiltro.Text);
                }
                else
                {
                    produtosBindingSource.Filter = String.Concat("nome_produto like '%{0}%'", txtFiltro.Text);
                }
            }
            else
            {
                produtosBindingSource.RemoveFilter();
            }
        }

        //private void NumValor_Leave(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if(numValor.Value <= 0)
        //        {
        //            numValor.Value = 1;
        //            throw new Exception("O valor não pode ser menor ou igual a ZERO");
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void NumQuantidade_Leave(object sender, EventArgs e)
        {
            try
            {
                if (numQuantidade.Value <= 0)
                {
                    numQuantidade.Value = 1;
                    throw new Exception("O valor da quantidade não pode ser menor ou igual a ZERO");
                }
                else if (Convert.ToDecimal(dvgProduto.SelectedCells[2].ToString()) < numQuantidade.Value)
                {
                    numQuantidade.Value = Convert.ToDecimal(dvgProduto.SelectedCells[2].ToString());
                    throw new Exception("O valor da quantidade não pode ser maior que a quantidade no estoque");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO trocar o index dos datatables para o nome da coluna
                if (dvgProduto.SelectedRows.Count > 0)
                {
                    PRODUTOSDataTable produtosdt = banco.SelectProduto(Convert.ToInt32(dvgProduto.SelectedCells[0].Value));
                    if (produtosdt.Count > 0)
                    {
                        FORNECEDORESDataTable fornecedordt = banco.SelectFornecedor((int) produtosdt.Rows[0]["id_fornecedor_produto"]);
                        if (fornecedordt.Count > 0)
                        {

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
                            ProdOper = new ProdOper(produto, numQuantidade.Value);
                        }
                        else
                        {
                            MessageBox.Show("Fornecedor não encontrado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um produto na tabela");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //Close();
        }

        private void DvgProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
