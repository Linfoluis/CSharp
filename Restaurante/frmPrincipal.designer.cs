namespace Principal
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlLogin2 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnTrocSenha = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.mstpMenu = new System.Windows.Forms.MenuStrip();
            this.acessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstpPnlLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tstpPnlLogin2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tstpSair = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstpFrmCadFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstpFrmCadForn = new System.Windows.Forms.ToolStripMenuItem();
            this.tstpFrmCadProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.funçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstpFrmCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.tstpFrmVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstpFrmProdMaisVend = new System.Windows.Forms.ToolStripMenuItem();
            this.tstpFrmClienteFidel = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstpFrmCtrlReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.reservarMesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstpFecharGuias = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlLogin.SuspendLayout();
            this.pnlLogin2.SuspendLayout();
            this.mstpMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.pnlLogin2);
            this.pnlLogin.Location = new System.Drawing.Point(257, 153);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(574, 282);
            this.pnlLogin.TabIndex = 1;
            // 
            // pnlLogin2
            // 
            this.pnlLogin2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlLogin2.Controls.Add(this.btnCancelar);
            this.pnlLogin2.Controls.Add(this.btnTrocSenha);
            this.pnlLogin2.Controls.Add(this.btnConfirmar);
            this.pnlLogin2.Controls.Add(this.txtSenha);
            this.pnlLogin2.Controls.Add(this.txtUsuario);
            this.pnlLogin2.Controls.Add(this.lblSenha);
            this.pnlLogin2.Controls.Add(this.lblUsuario);
            this.pnlLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLogin2.Location = new System.Drawing.Point(47, 38);
            this.pnlLogin2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogin2.Name = "pnlLogin2";
            this.pnlLogin2.Size = new System.Drawing.Size(481, 203);
            this.pnlLogin2.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(250, 151);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 35);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnTrocSenha
            // 
            this.btnTrocSenha.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrocSenha.Location = new System.Drawing.Point(337, 63);
            this.btnTrocSenha.Name = "btnTrocSenha";
            this.btnTrocSenha.Size = new System.Drawing.Size(127, 35);
            this.btnTrocSenha.TabIndex = 2;
            this.btnTrocSenha.Text = "Trocar Senha";
            this.btnTrocSenha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTrocSenha.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(118, 151);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(105, 35);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click_1);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(140, 96);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(175, 22);
            this.txtSenha.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(140, 47);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(175, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(46, 90);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(74, 27);
            this.lblSenha.TabIndex = 0;
            this.lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(46, 42);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(89, 27);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário:";
            // 
            // mstpMenu
            // 
            this.mstpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acessoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.funçõesToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.tstpFecharGuias});
            this.mstpMenu.Location = new System.Drawing.Point(0, 0);
            this.mstpMenu.Name = "mstpMenu";
            this.mstpMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mstpMenu.Size = new System.Drawing.Size(1360, 28);
            this.mstpMenu.TabIndex = 3;
            this.mstpMenu.Text = "menuStrip1";
            // 
            // acessoToolStripMenuItem
            // 
            this.acessoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstpPnlLogin,
            this.tstpPnlLogin2,
            this.tstpSair});
            this.acessoToolStripMenuItem.Name = "acessoToolStripMenuItem";
            this.acessoToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.acessoToolStripMenuItem.Text = "&Acesso";
            // 
            // tstpPnlLogin
            // 
            this.tstpPnlLogin.Image = ((System.Drawing.Image)(resources.GetObject("tstpPnlLogin.Image")));
            this.tstpPnlLogin.Name = "tstpPnlLogin";
            this.tstpPnlLogin.Size = new System.Drawing.Size(128, 24);
            this.tstpPnlLogin.Text = "Admin";
            this.tstpPnlLogin.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // tstpPnlLogin2
            // 
            this.tstpPnlLogin2.Name = "tstpPnlLogin2";
            this.tstpPnlLogin2.Size = new System.Drawing.Size(128, 24);
            this.tstpPnlLogin2.Text = "Usuário";
            this.tstpPnlLogin2.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // tstpSair
            // 
            this.tstpSair.Image = ((System.Drawing.Image)(resources.GetObject("tstpSair.Image")));
            this.tstpSair.Name = "tstpSair";
            this.tstpSair.Size = new System.Drawing.Size(128, 24);
            this.tstpSair.Text = "Sair";
            this.tstpSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstpFrmCadFunc,
            this.toolStripSeparator1,
            this.tstpFrmCadForn,
            this.tstpFrmCadProdutos});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.cadastroToolStripMenuItem.Text = "&Cadastros";
            // 
            // tstpFrmCadFunc
            // 
            this.tstpFrmCadFunc.Name = "tstpFrmCadFunc";
            this.tstpFrmCadFunc.Size = new System.Drawing.Size(239, 24);
            this.tstpFrmCadFunc.Text = "Cadastro de Funcionário";
            this.tstpFrmCadFunc.Click += new System.EventHandler(this.tstpCadFunc_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(236, 6);
            // 
            // tstpFrmCadForn
            // 
            this.tstpFrmCadForn.Name = "tstpFrmCadForn";
            this.tstpFrmCadForn.Size = new System.Drawing.Size(239, 24);
            this.tstpFrmCadForn.Text = "Cadastro de Fornecedor";
            this.tstpFrmCadForn.Click += new System.EventHandler(this.cadastroDeFornecedorToolStripMenuItem_Click);
            // 
            // tstpFrmCadProdutos
            // 
            this.tstpFrmCadProdutos.Name = "tstpFrmCadProdutos";
            this.tstpFrmCadProdutos.Size = new System.Drawing.Size(239, 24);
            this.tstpFrmCadProdutos.Text = "Cadastro de Produtos";
            this.tstpFrmCadProdutos.Click += new System.EventHandler(this.cadastroDeProdutosToolStripMenuItem_Click);
            // 
            // funçõesToolStripMenuItem
            // 
            this.funçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstpFrmCompras,
            this.tstpFrmVendas});
            this.funçõesToolStripMenuItem.Name = "funçõesToolStripMenuItem";
            this.funçõesToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.funçõesToolStripMenuItem.Text = "Funções";
            // 
            // tstpFrmCompras
            // 
            this.tstpFrmCompras.Name = "tstpFrmCompras";
            this.tstpFrmCompras.Size = new System.Drawing.Size(137, 24);
            this.tstpFrmCompras.Text = "Compras";
            this.tstpFrmCompras.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // tstpFrmVendas
            // 
            this.tstpFrmVendas.Name = "tstpFrmVendas";
            this.tstpFrmVendas.Size = new System.Drawing.Size(137, 24);
            this.tstpFrmVendas.Text = "Vendas";
            this.tstpFrmVendas.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstpFrmProdMaisVend,
            this.tstpFrmClienteFidel});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // tstpFrmProdMaisVend
            // 
            this.tstpFrmProdMaisVend.Name = "tstpFrmProdMaisVend";
            this.tstpFrmProdMaisVend.Size = new System.Drawing.Size(238, 24);
            this.tstpFrmProdMaisVend.Text = "Produtos Mais Vendidos";
            this.tstpFrmProdMaisVend.Click += new System.EventHandler(this.produtosMaisVendidosToolStripMenuItem_Click);
            // 
            // tstpFrmClienteFidel
            // 
            this.tstpFrmClienteFidel.Name = "tstpFrmClienteFidel";
            this.tstpFrmClienteFidel.Size = new System.Drawing.Size(238, 24);
            this.tstpFrmClienteFidel.Text = "Cliente Fidelidade";
            this.tstpFrmClienteFidel.Click += new System.EventHandler(this.clienteFidelidadeToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstpFrmCtrlReservas,
            this.reservarMesaToolStripMenuItem});
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // tstpFrmCtrlReservas
            // 
            this.tstpFrmCtrlReservas.Name = "tstpFrmCtrlReservas";
            this.tstpFrmCtrlReservas.Size = new System.Drawing.Size(217, 24);
            this.tstpFrmCtrlReservas.Text = "Controle de Reservas";
            this.tstpFrmCtrlReservas.Click += new System.EventHandler(this.controleDeReservasToolStripMenuItem_Click);
            // 
            // reservarMesaToolStripMenuItem
            // 
            this.reservarMesaToolStripMenuItem.Name = "reservarMesaToolStripMenuItem";
            this.reservarMesaToolStripMenuItem.Size = new System.Drawing.Size(217, 24);
            this.reservarMesaToolStripMenuItem.Text = "Reservar Mesa";
            this.reservarMesaToolStripMenuItem.Click += new System.EventHandler(this.reservarMesaToolStripMenuItem_Click);
            // 
            // tstpFecharGuias
            // 
            this.tstpFecharGuias.Name = "tstpFecharGuias";
            this.tstpFecharGuias.Size = new System.Drawing.Size(104, 24);
            this.tstpFecharGuias.Text = "Fechar Guias";
            this.tstpFecharGuias.Click += new System.EventHandler(this.fecharGuiasToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Restaurante.Properties.Resources._48px_Crystal_Clear_app_korganizer;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(17, 471);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.button3.Size = new System.Drawing.Size(102, 98);
            this.button3.TabIndex = 5;
            this.button3.Text = "Cadastro de Produtos";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Restaurante.Properties.Resources._48px_Crystal_Clear_app_business;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(17, 358);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 13);
            this.button1.Size = new System.Drawing.Size(102, 98);
            this.button1.TabIndex = 5;
            this.button1.Text = "Vendas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Restaurante.Properties.Resources._48px_Crystal_Clear_app_Login_Manager;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(17, 245);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.button4.Size = new System.Drawing.Size(102, 98);
            this.button4.TabIndex = 5;
            this.button4.Text = "Cadastro de Fornecedor";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Restaurante.Properties.Resources._48px_Crystal_Clear_app_business1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(17, 132);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 8, 0, 13);
            this.button2.Size = new System.Drawing.Size(102, 98);
            this.button2.TabIndex = 5;
            this.button2.Text = "Compras";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservar.Image = global::Restaurante.Properties.Resources._48px_Crystal_Clear_app_kaddressbook;
            this.btnReservar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReservar.Location = new System.Drawing.Point(17, 19);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(102, 98);
            this.btnReservar.TabIndex = 5;
            this.btnReservar.Text = "Reservar Mesas";
            this.btnReservar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnReservar);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 600);
            this.panel1.TabIndex = 6;
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.Color.Teal;
            this.txtHora.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.ForeColor = System.Drawing.Color.Transparent;
            this.txtHora.Location = new System.Drawing.Point(1177, 48);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(174, 60);
            this.txtHora.TabIndex = 8;
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 720);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.mstpMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstpMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.Text = "Sistema - Restaurante Sabor Brasileiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin2.ResumeLayout(false);
            this.pnlLogin2.PerformLayout();
            this.mstpMenu.ResumeLayout(false);
            this.mstpMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.MenuStrip mstpMenu;
        private System.Windows.Forms.ToolStripMenuItem acessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tstpPnlLogin;
        private System.Windows.Forms.ToolStripMenuItem tstpPnlLogin2;
        private System.Windows.Forms.ToolStripMenuItem tstpSair;
        private System.Windows.Forms.ToolStripMenuItem funçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tstpFrmCompras;
        private System.Windows.Forms.ToolStripMenuItem tstpFrmVendas;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tstpFrmCadFunc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel pnlLogin2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnTrocSenha;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.ToolStripMenuItem tstpFrmCadForn;
        private System.Windows.Forms.ToolStripMenuItem tstpFrmCadProdutos;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tstpFrmProdMaisVend;
        private System.Windows.Forms.ToolStripMenuItem tstpFrmClienteFidel;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tstpFrmCtrlReservas;
        private System.Windows.Forms.ToolStripMenuItem tstpFecharGuias;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem reservarMesaToolStripMenuItem;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Timer timer1;
    }
}