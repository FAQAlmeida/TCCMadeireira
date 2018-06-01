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

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetMadeireiraV2.FORNECEDORES'. Você pode movê-la ou removê-la conforme necessário.
            this.fORNECEDORESTableAdapter.Fill(this.dataSetMadeireiraV2.FORNECEDORES);
            // TODO: esta linha de código carrega dados na tabela 'dataSetMadeireiraV2.PRODUTOS'. Você pode movê-la ou removê-la conforme necessário.
            this.pRODUTOSTableAdapter.Fill(this.dataSetMadeireiraV2.PRODUTOS);
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            //comboBox1.DisplayMember = dataSetMadeireiraV2.FORNECEDORES.NOME_FORNECEDORColumn.ColumnName;
            //comboBox1.Update();
        }
    }
}
