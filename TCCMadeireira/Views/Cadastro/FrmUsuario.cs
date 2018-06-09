using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCCMadeireira.Bancos;
using TCCMadeireira.Models;
using TCCMadeireira.Util;
using static TCCMadeireira.Bancos.DataSetMadeireiraV2;

namespace TCCMadeireira.Views
{
    /// <summary>
    /// Form responsavel por adicionar e excluir Usuarios do sistema
    /// </summary>
    public partial class FrmUsuario : Form
    {
        private Banco banco = new Banco();
        private Log log = new Log();
        /// <summary>
        /// Inicializa o Form de Usuário
        /// </summary>
        public FrmUsuario()
        {
            InitializeComponent();
        }
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetMadeireiraV2.USERS' table. You can move, or remove it, as needed.
            this.uSERSTableAdapter.Fill(this.dataSetMadeireiraV2.USERS);
            ControlEnable(false);
            cmbNivel.SelectedIndex = 0;
        }

        #region @event.Click
        /// <summary>
        /// Evento de CLICK do btnCadastrar
        /// <para>Possui 2 etapas:</para>
        /// <para>1) Preparar o form para receber as informações</para>
        /// <para>2) Registra as informações recebidas, enviados ao model Cliente depois ao objeto banco</para>
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnCadastrar.Text.ToUpper() == "Cadastrar".ToUpper())
                {
                    ControlEnable(true);
                    btnCancelar.Visible = true;
                    btnExcluir.Enabled = false;
                    btnAlterar.Enabled = false;
                    btnCadastrar.Text = "Gravar".ToUpper();
                }
                else
                {
                    Usuario user = new Usuario(txtUsuario.Text, txtSenha.Text, Convert.ToString(cmbNivel.SelectedItem));
                    if (banco.SelectUser(user.Nome, user.Senha).Rows.Count == 0)
                    {
                        banco.InsertUsuario(user);
                        BtnCancelar_Click(null, null);
                        log.WriteEntry(String.Format("Usuário {0} cadastrado", user.Id));
                    }
                    else
                    {
                        throw new Exception("Usuário já cadastrado");
                    }
                TableRefresh();
                }
            }
            catch (Exception ex)
            {
                log.WriteEntry(ex);
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Evento de CLICK do btnExcluir
        /// <para>Possui 2 etapas:</para>
        /// <para>1) Preparar a txtIdentidade para receber a identidade</para>
        /// <para>2) Pergunta se o usuário deseja realmente excluir o registro basedo na X identidade e, se sim, exclui o registro</para>
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsers.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show(String.Format("Você deseja excluir o usuario de ID {0}?", dgvUsers.SelectedCells[0].Value.ToString()), "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Usuario user = new Usuario((int)dgvUsers.SelectedCells[0].Value);
                        banco.DeleteUSuario(user);
                        log.WriteEntry(String.Format("cliente {0} excluido", user.Id));
                        BtnCancelar_Click(null, null);
                    }
                }
                else
                {
                    throw new Exception("Selecione uma e apenas uma linha na tabela para excluir");
                }
            }
            catch (Exception ex)
            {
                log.WriteEntry(ex);
                MessageBox.Show(ex.Message);
            }
            finally
            {
                TableRefresh();
            }
        }

        /// <summary>
        /// Evento de CLICK do btnAlterar
        /// <para>Possui 3 etapas:</para>
        /// <para>1) Preparar a txtIdentidade para receber a identidade</para>
        /// <para>2) Recebe a identidade para pesquisa do cliente</para>
        /// <para>3) Armazena as informações recebidas se o usuário confirmar</para>
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAlterar.Text.ToUpper() == "Alterar".ToUpper())
                {
                    if (dgvUsers.SelectedRows.Count == 1)
                    {
                        ControlEnable(true);
                        btnCadastrar.Enabled = false;
                        btnExcluir.Enabled = false;
                        btnCancelar.Visible = true;
                        USERSDataTable dt = new USERSDataTable();
                        Usuario user = new Usuario((int)dgvUsers.SelectedCells[0].Value);
                        dt = banco.SelectUsuario(user.Id);
                        txtUsuario.Text = dt.Rows[0]["LOGIN_USUARIO"].ToString();
                        txtSenha.Text = dt.Rows[0]["SENHA_USUARIO"].ToString();
                        cmbNivel.SelectedItem = dt.Rows[0]["NIVEL_USUARIO"].ToString();
                        btnAlterar.Text = "Gravar".ToUpper();
                    }
                    else
                    {
                        throw new Exception("Selecione uma e apenas uma linha na tabela para alterar");
                    }
                }
                else
                {
                    Usuario user = new Usuario(txtUsuario.Text, txtSenha.Text, Convert.ToString(cmbNivel.SelectedItem));
                    banco.UpdateUsuario(user);
                    log.WriteEntry(String.Format("usuario {0} alterado", user.Nome));
                    BtnCancelar_Click(null, null);
                TableRefresh();
                }
            }
            catch (Exception ex)
            {
                log.WriteEntry(ex);
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Evento de CLICK do btnCancelar
        /// <para>Retorna o form ao seu estado inicial</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in grbUsuario.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                }
                else if (ctrl is MaskedTextBox)
                {
                    (ctrl as MaskedTextBox).Clear();
                }
                else if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).SelectedIndex = 0;
                }
            }
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCadastrar.Text = "Cadastrar".ToUpper();
            btnAlterar.Text = "Alterar".ToUpper();
            btnExcluir.Text = "Excluir".ToUpper();
            btnCancelar.Visible = false;
            ControlEnable(false);
            dgvUsers.Enabled = true;
        }
        #endregion
        #region @Control.Methods
        /// <summary>
        /// Define o status de todos os controles de entrada presentes no GroupBox baseado no parâmetro status
        /// </summary>
        /// <param name="status">Define se o status vai ser true ou false</param>
        private void ControlEnable(bool status)
        {
            foreach (Control ctrl in grbUsuario.Controls)
            {
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Enabled = status;
                }
                else if (ctrl is MaskedTextBox)
                {
                    (ctrl as MaskedTextBox).Enabled = status;
                }
                else if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).Enabled = status;
                }
                else if (ctrl is RadioButton)
                {
                    (ctrl as RadioButton).Enabled = status;
                }
            }
        }

        private void TableRefresh()
        {
            uSERSTableAdapter.Fill(this.dataSetMadeireiraV2.USERS);
            dgvUsers.Refresh();
        }

        private string CharResearch(string statement)
        {
            char[] chars = { '.', '-', '/', ',' };
            char[] lista = statement.ToCharArray();
            string retorno = "";

            for (int i = 0; i < lista.Length; i++)
            {
                if (chars.Contains(lista[i]))
                {
                    lista[i] = ' ';
                }
                retorno += lista[i];
            }
            return retorno;
        }
        #endregion
    }
}
