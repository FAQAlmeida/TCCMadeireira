using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCCMadeireira.Views
{
    /// <summary>
    /// Form responsavel por adicionar produtos a uma venda
    /// </summary>
    public partial class FrmProdVenda : Form
    {
        private FrmVenda venda;
        /// <summary>
        /// Inicializa o Form ProdVenda
        /// </summary>
        /// <param name="frmVenda"></param>
        public FrmProdVenda(FrmVenda frmVenda)
        {    
            InitializeComponent();
            venda = frmVenda;
        }

        private void FrmProdVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetMadeireiraV2.PRODUTOS'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.dataSetMadeireiraV2.PRODUTOS);
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
                if (dvgProduto.SelectedRows.Count > 0)
                {
                    venda.InsertDataProd(dvgProduto.SelectedCells[0].ToString(), dvgProduto.SelectedCells[1].ToString(),
                        numQuantidade.ToString());

                    Close();
                    if (MessageBox.Show("Deseja adicionar mais produtos?", "Dialogo", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                    {
                        FrmProdVenda frmProdVenda = new FrmProdVenda(venda);
                        frmProdVenda.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um produto na tabela");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DvgProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
