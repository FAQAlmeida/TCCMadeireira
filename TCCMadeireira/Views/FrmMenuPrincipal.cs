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
        /// <summary>
        /// Método construtor do <see cref="FrmMenuPrincipal"/>.
        /// </summary>
        /// TODO Edit XML Comment Template for #ctor
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// evento CLICK do menuStrip do menu principal
        /// <para>Instância e exibe os formulários e relatórios do projeto</para>
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
    }
}
