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
using TCCMadeireira.Bancos;
using TCCMadeireira.Models;
using TCCMadeireira.Views;
using TCCMadeireira.Views.Sistema;
using static TCCMadeireira.Bancos.DataSetMadeireiraV2;

namespace TCCMadeireira.Views
{
    /// <summary>
    /// Form para fazer login no sistema
    /// </summary>
    public partial class Login : Form
    {
    Banco banco = new Banco();
        /// <summary>
        /// Inicializa o Form
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(txtUsuario.Text, txtSenha.Text);
            if (banco.SelectUsuario(usuario.Nome, usuario.Senha) >= 1)
            {
                USERSDataTable usersdt = banco.SelectUser(usuario.Nome, usuario.Senha);
                usuario.Id = (int)usersdt.Rows[0]["id_usuario"];
                usuario.Nivel = (string)usersdt.Rows[0]["nivel_usuario"];
                Properties.Settings.Default.idUsuario = usuario.Id;
                Properties.Settings.Default.nomeUsuario = usuario.Nome;
                Properties.Settings.Default.nivelUsuario = usuario.Nivel;
                FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
                frmMenuPrincipal.Show();
                Hide();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnEntrar.Focus();
                btnEntrar_Click(null, null);
            }
        }
    }
}
