using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Common;
using MaterialSkin.Controls;

namespace TCCMadeireira.Views.Sistema
{
    public partial class FrmBackup : MaterialForm
    {
        string path = Application.StartupPath;
        string filename = "Backup.bak";
        //enumera uma lista de instâncias locais disponíveis do SQL Server
        static DataTable tabelaServidores;
        //define o objeto do tipo Server
        private Server servidor;
        //define o caminho para o backup/restore
        private string dbName;


        public FrmBackup()
        {
            InitializeComponent();
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            lblPath.Text = path;
            FileStartName();
            //servidor = SelectServidor(tabelaServidores);
            Cursor = Cursors.Default;
        }
        private void SelectPath()
        {
            folderBrowserDialog.SelectedPath = path;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path = folderBrowserDialog.SelectedPath;
                lblPath.Text = path;
            }
        }
        private void FileStartName()
        {
            string filename = this.filename;
            for (int i = 1; i >= 0; i++)
            {
                //MessageBox.Show(filename);
                if (!File.Exists(String.Format("{0}\\{1}", path, filename)))
                {
                    this.filename = filename;
                    txtFileName.Text = this.filename.Split('.')[0];
                    break;
                }
                filename = String.Format("{0}{1}.bak", "Backup", i);
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFileName.Enabled)
                {
                    if (!File.Exists(String.Format("{0}\\{1}", path, txtFileName.Text)))
                    {
                        if (IsValidFileName(txtFileName.Text))
                        {
                            filename = String.Format("{0}.bak", txtFileName.Text);
                        }
                        else
                        {
                            throw new Exception("Nome de arquivo inválido, escolha outro nome por favor");
                        }
                    }
                    else
                    {
                        throw new Exception("Arquivo já existe, escolha outro nome por favor");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtFileName.Enabled = !txtFileName.Enabled;
            }
            finally
            {
                txtFileName.Enabled = !txtFileName.Enabled;
            }
        }
        private bool IsValidFileName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return false;
            if (name.Length > 1 && name[1] == ':')
            {
                if (name.Length < 4 || name.ToLower()[0] < 'a' || name.ToLower()[0] > 'z' || name[2] != '\\') return false;
                name = name.Substring(3);
            }
            if (name.StartsWith("\\\\")) name = name.Substring(1);
            if (name.EndsWith("\\") || !name.Trim().Equals(name) || name.Contains("\\\\") ||
                name.IndexOfAny(Path.GetInvalidFileNameChars().Where(x => x != '\\').ToArray()) >= 0) return false;
            return true;
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            tabelaServidores = SmoApplication.EnumAvailableSqlServers(true);
            servidor = SelectServidor();
            if (servidor != null)
            {
                try
                {
                    //desabilita os botões
                    btnBackup.Enabled = false;
                    btnRestore.Enabled = false;
                    btnChange.Enabled = false;
                    btnChangePath.Enabled = false;

                    //Este codigo é usado se você já criou o arquivo de backup.
                    File.Delete(String.Format("{0}\\{1}", path, filename));
                    this.Cursor = Cursors.WaitCursor;
                    Backup bkpDatabase = new Backup
                    {
                        Action = BackupActionType.Database,
                        Database = dbName
                    };
                    BackupDeviceItem bkpDevice = new BackupDeviceItem(String.Format("{0}\\{1}", path, filename), DeviceType.File);
                    bkpDatabase.Devices.Add(bkpDevice);
                    bkpDatabase.SqlBackup(servidor);
                    MessageBox.Show("Backup do Database " + dbName + " criado com sucesso", "Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception x)
                {
                    MessageBox.Show("ERRO: Ocorreu um erro durante o BACKUP do DataBase " + x, "Erro no Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;
                    btnBackup.Enabled = true;
                    btnRestore.Enabled = true;
                    btnChange.Enabled = true;
                    btnChangePath.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("ERRO: Não foi estabelecida uma conexão com o SQL Server", "Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Arrow;
            }
        }

        private void BtnChangePath_Click(object sender, EventArgs e)
        {
            SelectPath();
        }
        private Server SelectServidor()
        {
            try
            {
                string server = Properties.Settings.Default.ServerName;
                string instance = Properties.Settings.Default.ServerInstance;
                dbName = Properties.Settings.Default.DBName;
                ServerConnection srvConn = new ServerConnection(String.Format("{0}\\{1}", server, instance))
                {
                    LoginSecure = false,
                    Login = Properties.Settings.Default.LoginServer,
                    Password = Properties.Settings.Default.PwdServer,
                };
                
                Server servidor = new Server(srvConn);
                return servidor;
            }catch(SqlServerManagementException ex)
            {
                throw ex;
            }            
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Multiselect = false;
                //openFileDialog.Filter = ("*.bak");
                openFileDialog.Title = "Selecione um arquivo .bak";
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    throw new Exception("Selecione um arquivo para restaurar");
                if (!openFileDialog.FileName.EndsWith(".bak"))
                    throw new Exception("Selecione um arquivo .bak para restaurar");

                tabelaServidores = SmoApplication.EnumAvailableSqlServers(true);
                servidor = SelectServidor();
                
                if (servidor != null)
                {
                    try
                    {
                        btnBackup.Enabled = false;
                        btnRestore.Enabled = false;
                        btnChange.Enabled = false;
                        btnChangePath.Enabled = false;

                        this.Cursor = Cursors.WaitCursor;
                        Restore rstDatabase = new Restore
                        {
                            Action = RestoreActionType.Database,
                            Database = dbName
                        };
                        BackupDeviceItem bkpDevice = new BackupDeviceItem(openFileDialog.FileName, DeviceType.File);
                        rstDatabase.Devices.Add(bkpDevice);
                        rstDatabase.ReplaceDatabase = true;
                        rstDatabase.SqlRestore(servidor);
                        MessageBox.Show("Database " + dbName + " RESTAURADO com sucesso", "Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO: Ocorreu um erro durante o BACKUP do DataBase " + ex, "Erro no Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.Cursor = Cursors.Arrow;
                        btnBackup.Enabled = true;
                        btnRestore.Enabled = true;
                        btnChange.Enabled = true;
                        btnChangePath.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("ERRO: Não foi estabelecida uma conexão com o SQL Server", "Servidor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Cursor = Cursors.Arrow;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
