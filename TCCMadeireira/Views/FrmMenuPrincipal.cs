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
    /// Formulário do menuPrincipal
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// TODO Edit XML Comment Template for FrmMenuPrincipal
    public partial class FrmMenuPrincipal : Form
    {
        #region Construtor
        /// <summary>
        /// Método construtor do <see cref="FrmMenuPrincipal"/>.
        /// </summary>
        /// TODO Edit XML Comment Template for #ctor
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region toolStripMenu @event.Click
        /// <summary>
        /// Evento CLICK do menuStrip Cliente
        /// <para>Instância e exibe o formulário do Cliente</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmCliente frmCliente = new FrmCliente
                {
                    MdiParent = this
                };
                frmCliente.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Evento CLICK do menuStrip Funcionário
        /// <para>Instância e exibe o formulário do funcionário</para>
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmFuncionario frmCliente = new FrmFuncionario
                {
                    MdiParent = this
                };
                frmCliente.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void FornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmFornecedor frmFornecedor = new FrmFornecedor
                {
                    MdiParent = this
                };
                frmFornecedor.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
