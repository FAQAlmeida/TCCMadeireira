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
    /// Form responsável por manter o CRUD de Fornecedor
    /// </summary>
    public partial class FrmFornecedor : Form
    {
        /// <summary>
        /// Inicializa o Form de Fornecedor
        /// </summary>
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void FornecedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.FornecedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetMadeireiraV2);

        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSetMadeireiraV2.FORNECEDORES'. Você pode movê-la ou removê-la conforme necessário.
            this.FornecedoresTableAdapter.Fill(this.dataSetMadeireiraV2.FORNECEDORES);

        }
    }
}
