﻿using MaterialSkin.Controls;
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
using TCCMadeireira.Views.Relatorios;
using TCCMadeireira.Views.Relatorios.Views;
using TCCMadeireira.Views.Relatorios.Views.Fornecimento;
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
        FrmRelatorioVendas frmRelatorioVendas;
        FrmFiltrarVendasData frmRelatorioVendasFiltro;
        FrmRelatorioFornecimento frmRelatoriofornecimento;
        #endregion
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
            try
            {
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
        #region Relatorios
        private void VendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["FrmRelatorioVendas"] == null)
                {
                    frmRelatorioVendas = new FrmRelatorioVendas
                    {
                        MdiParent = this
                    };
                    frmRelatorioVendas.Show();
                }
                else
                {
                    Application.OpenForms[frmRelatorioVendas.Name].Close();
                    frmRelatorioVendas = new FrmRelatorioVendas
                    {
                        MdiParent = this
                    };
                    frmRelatorioVendas.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void vendasMêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["FrmFiltrarVendasData"] == null)
                {
                    frmRelatorioVendasFiltro = new FrmFiltrarVendasData
                    {
                        MdiParent = this
                    };
                    frmRelatorioVendasFiltro.Show();
                }
                else
                {
                    Application.OpenForms[frmRelatorioVendasFiltro.Name].Close();
                    frmRelatorioVendas = new FrmRelatorioVendas
                    {
                        MdiParent = this
                    };
                    frmRelatorioVendasFiltro.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
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
        #region @event.Load
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            toolStripStatusLabelData.Text = DateTime.Now.ToString();
            toolStripStatusLabelUser.Text = Properties.Settings.Default.nomeUsuario;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.White;
                }
            }
            timer.Start();
        }


        #endregion

        private void totalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["FrmRelatorioVendas"] == null)
                {
                    frmRelatorioVendas = new FrmRelatorioVendas
                    {
                        MdiParent = this
                    };
                    frmRelatorioVendas.Show();
                }
                else
                {
                    Application.OpenForms[frmRelatorioVendas.Name].BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["FrmFiltrarVendasData"] == null)
                {
                    frmRelatorioVendasFiltro = new FrmFiltrarVendasData
                    {
                        MdiParent = this
                    };
                    frmRelatorioVendasFiltro.Show();
                }
                else
                {
                    Application.OpenForms[frmRelatorioVendasFiltro.Name].BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["FrmRelatorioFornecimento"] == null)
                {
                    frmRelatoriofornecimento = new FrmRelatorioFornecimento
                    {
                        MdiParent = this
                    };
                    frmRelatoriofornecimento.Show();
                }
                else
                {
                    Application.OpenForms[frmRelatoriofornecimento.Name].BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
