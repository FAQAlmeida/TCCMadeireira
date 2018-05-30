using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCCMadeireira.Views.Sistema;

namespace TCCMadeireira.Views
{
    /// <summary>
    /// Formulário do menuPrincipal
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    /// TODO Edit XML Comment Template for FrmMenuPrincipal
    public partial class FrmMenuPrincipal : Form
    {
        #region @Objects
        FrmCliente frmCliente;
        FrmFuncionario frmFuncionario;
        FrmFornecedor frmFornecedor;
        FrmProduto frmProduto;
        FrmVenda frmVenda;
        FrmFornecimento frmFornecimento;
        FrmUsuario frmUsuario;
        FrmBackup frmBackup;
        #endregion
        #region Construtor
        /// <summary>
        /// Método construtor do <see cref="FrmMenuPrincipal"/>.
        /// </summary>
        /// TODO Edit XML Comment Template for #ctor
        public FrmMenuPrincipal()
        {            
            InitializeComponent();
            toolStripStatusLabelData.Text = DateTime.Now.ToString();
            timer.Start();
        }
        #endregion
        #region toolStripMenu @event.Click
        private void BackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["FrmBackup"] == null)
                {
                    frmBackup = new FrmBackup
                    {
                        MdiParent = this
                    };
                    frmBackup.Show();
                }
                else
                {
                    Application.OpenForms["FrmBackup"].BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
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
                if (Application.OpenForms["FrmCliente"] == null)
                {
                    frmCliente = new FrmCliente
                    {
                        MdiParent = this
                    };
                    frmCliente.Show();
                }
                else
                {
                    Application.OpenForms["FrmCliente"].BringToFront();
                }
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
                if (Application.OpenForms["FrmFuncionario"] == null)
                {
                    frmFuncionario = new FrmFuncionario
                    {
                        MdiParent = this
                    };
                    frmFuncionario.Show();
                }
                else
                {
                    Application.OpenForms[frmFuncionario.Name].BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void FornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                if (Application.OpenForms["FrmFornecedor"] == null)
                {
                    frmFornecedor = new FrmFornecedor
                    {
                        MdiParent = this
                    };
                    frmFornecedor.Show();
                }
                else
                {
                    Application.OpenForms[frmFornecedor.Name].BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["FrmProduto"] == null)
                {
                    frmProduto = new FrmProduto
                    {
                        MdiParent = this
                    };
                    frmProduto.Show();
                }
                else
                {
                    Application.OpenForms[frmProduto.Name].BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["FrmVenda"] == null)
                {
                    frmVenda = new FrmVenda
                    {
                        MdiParent = this
                    };
                    frmVenda.Show();
                }
                else
                {
                    Application.OpenForms[frmVenda.Name].BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FonecimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["FrmFornecimento"] == null)
                {
                    frmFornecimento = new FrmFornecimento
                    {
                        MdiParent = this
                    };
                    frmFornecimento.Show();
                }
                else
                {
                    Application.OpenForms[frmFornecimento.Name].BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["FrmUsuario"] == null)
                {
                    frmUsuario = new FrmUsuario
                    {
                        MdiParent = this
                    };
                    frmUsuario.Show();
                }
                else
                {
                    Application.OpenForms[frmUsuario.Name].BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Test
        private void MdiParentSetter(Form[] forms)
        {
            for (int i = 0; i < forms.Length; i++)
            {
                forms[i].MdiParent = this;
            }
        }
        #endregion
        #region @event.FormClosed
        private void FrmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region @timer.Tick
        private void Timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelData.Text = DateTime.Now.ToString();
        }
        #endregion

        
    }
}
