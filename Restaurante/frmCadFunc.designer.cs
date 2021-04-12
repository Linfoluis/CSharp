namespace Principal
{
    partial class frmCadFunc
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
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.grbPesquisa = new System.Windows.Forms.GroupBox();
            this.grbFuncInat = new System.Windows.Forms.GroupBox();
            this.rbOcultar = new System.Windows.Forms.RadioButton();
            this.rbMostrar = new System.Windows.Forms.RadioButton();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.lstvFunc = new System.Windows.Forms.ListView();
            this.clhCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNovo = new System.Windows.Forms.Button();
            this.grbPesquisa.SuspendLayout();
            this.grbFuncInat.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Captain",
            "Commis",
            "Garçom",
            "Hostess",
            "Maitre",
            "Sommelier",
            "Chefe de Bar",
            "Barman",
            "Garçom de Bar"});
            this.cmbCargo.Location = new System.Drawing.Point(333, 86);
            this.cmbCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(156, 30);
            this.cmbCargo.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(766, 73);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(103, 38);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(263, 84);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(64, 24);
            this.lblCargo.TabIndex = 0;
            this.lblCargo.Text = "Cargo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(107, 84);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(140, 29);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(95, 34);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(394, 29);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(21, 86);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(74, 24);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(21, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(66, 24);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // grbPesquisa
            // 
            this.grbPesquisa.Controls.Add(this.grbFuncInat);
            this.grbPesquisa.Controls.Add(this.cmbCargo);
            this.grbPesquisa.Controls.Add(this.btnPesquisar);
            this.grbPesquisa.Controls.Add(this.lblCargo);
            this.grbPesquisa.Controls.Add(this.txtCodigo);
            this.grbPesquisa.Controls.Add(this.txtNome);
            this.grbPesquisa.Controls.Add(this.lblCodigo);
            this.grbPesquisa.Controls.Add(this.lblNome);
            this.grbPesquisa.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPesquisa.Location = new System.Drawing.Point(17, 12);
            this.grbPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbPesquisa.Name = "grbPesquisa";
            this.grbPesquisa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbPesquisa.Size = new System.Drawing.Size(900, 146);
            this.grbPesquisa.TabIndex = 1;
            this.grbPesquisa.TabStop = false;
            this.grbPesquisa.Text = "Filtro de Pesquisa";
            // 
            // grbFuncInat
            // 
            this.grbFuncInat.Controls.Add(this.rbOcultar);
            this.grbFuncInat.Controls.Add(this.rbMostrar);
            this.grbFuncInat.Location = new System.Drawing.Point(531, 27);
            this.grbFuncInat.Margin = new System.Windows.Forms.Padding(4);
            this.grbFuncInat.Name = "grbFuncInat";
            this.grbFuncInat.Padding = new System.Windows.Forms.Padding(4);
            this.grbFuncInat.Size = new System.Drawing.Size(179, 101);
            this.grbFuncInat.TabIndex = 5;
            this.grbFuncInat.TabStop = false;
            this.grbFuncInat.Text = "Func. Inativos";
            // 
            // rbOcultar
            // 
            this.rbOcultar.AutoSize = true;
            this.rbOcultar.Checked = true;
            this.rbOcultar.Location = new System.Drawing.Point(24, 28);
            this.rbOcultar.Margin = new System.Windows.Forms.Padding(4);
            this.rbOcultar.Name = "rbOcultar";
            this.rbOcultar.Size = new System.Drawing.Size(83, 25);
            this.rbOcultar.TabIndex = 0;
            this.rbOcultar.TabStop = true;
            this.rbOcultar.Text = "Ocultar";
            this.rbOcultar.UseVisualStyleBackColor = true;
            // 
            // rbMostrar
            // 
            this.rbMostrar.AutoSize = true;
            this.rbMostrar.Location = new System.Drawing.Point(24, 62);
            this.rbMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.rbMostrar.Name = "rbMostrar";
            this.rbMostrar.Size = new System.Drawing.Size(88, 25);
            this.rbMostrar.TabIndex = 0;
            this.rbMostrar.Text = "Mostrar";
            this.rbMostrar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(653, 545);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 39);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(796, 545);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 39);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(519, 545);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(99, 39);
            this.btnVisualizar.TabIndex = 2;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // lstvFunc
            // 
            this.lstvFunc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhCodigo,
            this.clhNome,
            this.clhCpf,
            this.clhCargo,
            this.clhTel});
            this.lstvFunc.FullRowSelect = true;
            this.lstvFunc.GridLines = true;
            this.lstvFunc.Location = new System.Drawing.Point(17, 179);
            this.lstvFunc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstvFunc.Name = "lstvFunc";
            this.lstvFunc.Size = new System.Drawing.Size(900, 326);
            this.lstvFunc.TabIndex = 3;
            this.lstvFunc.TileSize = new System.Drawing.Size(358, 36);
            this.lstvFunc.UseCompatibleStateImageBehavior = false;
            this.lstvFunc.View = System.Windows.Forms.View.Details;
            // 
            // clhCodigo
            // 
            this.clhCodigo.Text = "Código";
            this.clhCodigo.Width = 78;
            // 
            // clhNome
            // 
            this.clhNome.Text = "Nome";
            this.clhNome.Width = 301;
            // 
            // clhCpf
            // 
            this.clhCpf.Text = "CPF";
            this.clhCpf.Width = 143;
            // 
            // clhCargo
            // 
            this.clhCargo.Text = "Cargo";
            this.clhCargo.Width = 143;
            // 
            // clhTel
            // 
            this.clhTel.Text = "Telefone";
            this.clhTel.Width = 124;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(393, 545);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(91, 39);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmCadFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(935, 604);
            this.Controls.Add(this.lstvFunc);
            this.Controls.Add(this.grbPesquisa);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCadFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionário";
            this.Load += new System.EventHandler(this.frmCadFunc_Load);
            this.grbPesquisa.ResumeLayout(false);
            this.grbPesquisa.PerformLayout();
            this.grbFuncInat.ResumeLayout(false);
            this.grbFuncInat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox grbPesquisa;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.ListView lstvFunc;
        private System.Windows.Forms.ColumnHeader clhCodigo;
        private System.Windows.Forms.ColumnHeader clhNome;
        private System.Windows.Forms.ColumnHeader clhCpf;
        private System.Windows.Forms.ColumnHeader clhCargo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox grbFuncInat;
        private System.Windows.Forms.RadioButton rbOcultar;
        private System.Windows.Forms.RadioButton rbMostrar;
        private System.Windows.Forms.ColumnHeader clhTel;
    }
}

