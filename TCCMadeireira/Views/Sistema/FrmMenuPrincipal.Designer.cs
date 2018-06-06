namespace TCCMadeireira.Views
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonecimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cadastrosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.operaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.forneceimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.funcionarioToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.fonecimentoToolStripMenuItem,
            this.usuárioToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.clienteToolStripMenuItem.Text = "Clientes";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.ClienteToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.funcionarioToolStripMenuItem.Text = "Funcionários";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.FuncionarioToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.produtoToolStripMenuItem.Text = "Produtos";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.ProdutoToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedores";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.FornecedorToolStripMenuItem_Click);
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.vendaToolStripMenuItem.Text = "Vendas";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.VendaToolStripMenuItem_Click);
            // 
            // fonecimentoToolStripMenuItem
            // 
            this.fonecimentoToolStripMenuItem.Name = "fonecimentoToolStripMenuItem";
            this.fonecimentoToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.fonecimentoToolStripMenuItem.Text = "Fornecimentos";
            this.fonecimentoToolStripMenuItem.Click += new System.EventHandler(this.FonecimentoToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.usuárioToolStripMenuItem.Text = "Usuários";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.UsuárioToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.BackupToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabelData
            // 
            this.toolStripStatusLabelData.Name = "toolStripStatusLabelData";
            this.toolStripStatusLabelData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabelData.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabelData.Text = "DATA";
            // 
            // toolStripStatusLabelUser
            // 
            this.toolStripStatusLabelUser.Name = "toolStripStatusLabelUser";
            this.toolStripStatusLabelUser.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabelUser.Text = "USER";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // cadastrosToolStripMenuItem1
            // 
            this.cadastrosToolStripMenuItem1.Name = "cadastrosToolStripMenuItem1";
            this.cadastrosToolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem1.Text = "Cadastros";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.ClienteToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem1
            // 
            this.fornecedorToolStripMenuItem1.Name = "fornecedorToolStripMenuItem1";
            this.fornecedorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.fornecedorToolStripMenuItem1.Text = "Fornecedor";
            this.fornecedorToolStripMenuItem1.Click += new System.EventHandler(this.FornecedorToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem1
            // 
            this.funcionarioToolStripMenuItem1.Name = "funcionarioToolStripMenuItem1";
            this.funcionarioToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.funcionarioToolStripMenuItem1.Text = "Funcionário";
            this.funcionarioToolStripMenuItem1.Click += new System.EventHandler(this.FuncionarioToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem1
            // 
            this.produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            this.produtoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.produtoToolStripMenuItem1.Text = "Produto";
            this.produtoToolStripMenuItem1.Click += new System.EventHandler(this.ProdutoToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem1
            // 
            this.usuárioToolStripMenuItem1.Name = "usuárioToolStripMenuItem1";
            this.usuárioToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.usuárioToolStripMenuItem1.Text = "Usuário";
            this.usuárioToolStripMenuItem1.Click += new System.EventHandler(this.UsuárioToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem1
            // 
            this.relatoriosToolStripMenuItem1.Name = "relatoriosToolStripMenuItem1";
            this.relatoriosToolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem1.Text = "Relatórios";
            // 
            // sistemaToolStripMenuItem1
            // 
            this.sistemaToolStripMenuItem1.Name = "sistemaToolStripMenuItem1";
            this.sistemaToolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem1.Text = "Sistema";
            // 
            // backupToolStripMenuItem1
            // 
            this.backupToolStripMenuItem1.Name = "backupToolStripMenuItem1";
            this.backupToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.backupToolStripMenuItem1.Text = "Backup";
            this.backupToolStripMenuItem1.Click += new System.EventHandler(this.BackupToolStripMenuItem_Click);
            // 
            // operaToolStripMenuItem
            // 
            this.operaToolStripMenuItem.Name = "operaToolStripMenuItem";
            this.operaToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.operaToolStripMenuItem.Text = "Operações";
            // 
            // vendaToolStripMenuItem1
            // 
            this.vendaToolStripMenuItem1.Name = "vendaToolStripMenuItem1";
            this.vendaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.vendaToolStripMenuItem1.Text = "Venda";
            // 
            // forneceimentoToolStripMenuItem
            // 
            this.forneceimentoToolStripMenuItem.Name = "forneceimentoToolStripMenuItem";
            this.forneceimentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.forneceimentoToolStripMenuItem.Text = "Fornecimento";
            // 
            // relatóriosToolStripMenuItem1
            // 
            this.relatóriosToolStripMenuItem1.Name = "relatóriosToolStripMenuItem1";
            this.relatóriosToolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem1.Text = "Relatórios";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenuPrincipal_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonecimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUser;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem operaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem forneceimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem1;
    }
}