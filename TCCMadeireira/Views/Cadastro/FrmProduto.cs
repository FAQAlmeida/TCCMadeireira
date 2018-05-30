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
    public partial class FrmProduto : Form
    {
        /// <summary>
        /// Inicializa o Form de Produtos
        /// </summary>
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void ProdutosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ProdutosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetMadeireiraV2);

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetMadeireiraV2.FORNECEDORES'. Você pode movê-la ou removê-la conforme necessário.
            this.FornecedoresTableAdapter.Fill(this.dataSetMadeireiraV2.FORNECEDORES);
            // TODO: esta linha de código carrega dados na tabela 'dataSetMadeireiraV2.PRODUTOS'. Você pode movê-la ou removê-la conforme necessário.
            this.ProdutosTableAdapter.Fill(this.dataSetMadeireiraV2.PRODUTOS);
        }
    }
}
