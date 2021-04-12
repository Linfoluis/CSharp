namespace Principal
{
    partial class frmCadForn
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.clhCnpj = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTpForn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvFunc = new System.Windows.Forms.ListView();
            this.clhTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.grbFornStatus = new System.Windows.Forms.GroupBox();
            this.grbPesquisa = new System.Windows.Forms.GroupBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.cmbTpForn = new System.Windows.Forms.ComboBox();
            this.lblTpForn = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.mtxtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.grbFornStatus.SuspendLayout();
            this.grbPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(391, 544);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(91, 39);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // clhCnpj
            // 
            this.clhCnpj.Text = "CNPJ";
            this.clhCnpj.Width = 143;
            // 
            // clhTpForn
            // 
            this.clhTpForn.Text = "Tipo Forn.";
            this.clhTpForn.Width = 143;
            // 
            // clhNome
            // 
            this.clhNome.Text = "Nome";
            this.clhNome.Width = 301;
            // 
            // clhCodigo
            // 
            this.clhCodigo.Text = "Código";
            this.clhCodigo.Width = 78;
            // 
            // lstvFunc
            // 
            this.lstvFunc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhCodigo,
            this.clhNome,
            this.clhTpForn,
            this.clhCnpj,
            this.clhTel});
            this.lstvFunc.FullRowSelect = true;
            this.lstvFunc.GridLines = true;
            this.lstvFunc.Location = new System.Drawing.Point(15, 200);
            this.lstvFunc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstvFunc.Name = "lstvFunc";
            this.lstvFunc.Size = new System.Drawing.Size(900, 304);
            this.lstvFunc.TabIndex = 9;
            this.lstvFunc.TileSize = new System.Drawing.Size(358, 36);
            this.lstvFunc.UseCompatibleStateImageBehavior = false;
            this.lstvFunc.View = System.Windows.Forms.View.Details;
            // 
            // clhTel
            // 
            this.clhTel.Text = "Telefone";
            this.clhTel.Width = 124;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(517, 544);
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(99, 39);
            this.btnVisualizar.TabIndex = 6;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(794, 544);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(107, 39);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(651, 544);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 39);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Location = new System.Drawing.Point(27, 28);
            this.rbAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(67, 25);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(102, 28);
            this.rbInativo.Margin = new System.Windows.Forms.Padding(4);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(80, 25);
            this.rbInativo.TabIndex = 0;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // grbFornStatus
            // 
            this.grbFornStatus.Controls.Add(this.rbAtivo);
            this.grbFornStatus.Controls.Add(this.rbInativo);
            this.grbFornStatus.Location = new System.Drawing.Point(632, 27);
            this.grbFornStatus.Margin = new System.Windows.Forms.Padding(4);
            this.grbFornStatus.Name = "grbFornStatus";
            this.grbFornStatus.Padding = new System.Windows.Forms.Padding(4);
            this.grbFornStatus.Size = new System.Drawing.Size(209, 70);
            this.grbFornStatus.TabIndex = 5;
            this.grbFornStatus.TabStop = false;
            this.grbFornStatus.Text = "Forn. Status";
            // 
            // grbPesquisa
            // 
            this.grbPesquisa.Controls.Add(this.mtxtCnpj);
            this.grbPesquisa.Controls.Add(this.lblCnpj);
            this.grbPesquisa.Controls.Add(this.cmbTpForn);
            this.grbPesquisa.Controls.Add(this.lblTpForn);
            this.grbPesquisa.Controls.Add(this.grbFornStatus);
            this.grbPesquisa.Controls.Add(this.btnPesquisar);
            this.grbPesquisa.Controls.Add(this.txtCodigo);
            this.grbPesquisa.Controls.Add(this.txtNome);
            this.grbPesquisa.Controls.Add(this.lblCodigo);
            this.grbPesquisa.Controls.Add(this.lblNome);
            this.grbPesquisa.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPesquisa.Location = new System.Drawing.Point(15, 11);
            this.grbPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbPesquisa.Name = "grbPesquisa";
            this.grbPesquisa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbPesquisa.Size = new System.Drawing.Size(900, 166);
            this.grbPesquisa.TabIndex = 4;
            this.grbPesquisa.TabStop = false;
            this.grbPesquisa.Text = "Filtro de Pesquisa";
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(9, 94);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(53, 23);
            this.lblCnpj.TabIndex = 7;
            this.lblCnpj.Text = "CNPJ:";
            // 
            // cmbTpForn
            // 
            this.cmbTpForn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTpForn.FormattingEnabled = true;
            this.cmbTpForn.Items.AddRange(new object[] {
            "Alimentos Básicos",
            "Não Alcóolicos",
            "Doces",
            "Alcoólicos",
            "Frigorífico",
            "Vegetais"});
            this.cmbTpForn.Location = new System.Drawing.Point(385, 93);
            this.cmbTpForn.Name = "cmbTpForn";
            this.cmbTpForn.Size = new System.Drawing.Size(155, 29);
            this.cmbTpForn.TabIndex = 6;
            // 
            // lblTpForn
            // 
            this.lblTpForn.AutoSize = true;
            this.lblTpForn.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpForn.Location = new System.Drawing.Point(268, 94);
            this.lblTpForn.Name = "lblTpForn";
            this.lblTpForn.Size = new System.Drawing.Size(110, 23);
            this.lblTpForn.TabIndex = 5;
            this.lblTpForn.Text = "Tipo de forn:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(756, 113);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(103, 38);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(95, 42);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(115, 29);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(298, 46);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.MaxLength = 35;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(281, 29);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(9, 44);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(74, 24);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(224, 46);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(66, 24);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // mtxtCnpj
            // 
            this.mtxtCnpj.Location = new System.Drawing.Point(64, 93);
            this.mtxtCnpj.Mask = "00,000,000/0000-00";
            this.mtxtCnpj.Name = "mtxtCnpj";
            this.mtxtCnpj.Size = new System.Drawing.Size(187, 28);
            this.mtxtCnpj.TabIndex = 9;
            // 
            // frmCadForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(933, 595);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lstvFunc);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.grbPesquisa);
            this.Name = "frmCadForn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedor";
            this.grbFornStatus.ResumeLayout(false);
            this.grbFornStatus.PerformLayout();
            this.grbPesquisa.ResumeLayout(false);
            this.grbPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ColumnHeader clhCnpj;
        private System.Windows.Forms.ColumnHeader clhTpForn;
        private System.Windows.Forms.ColumnHeader clhNome;
        private System.Windows.Forms.ColumnHeader clhCodigo;
        private System.Windows.Forms.ListView lstvFunc;
        private System.Windows.Forms.ColumnHeader clhTel;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.GroupBox grbFornStatus;
        private System.Windows.Forms.GroupBox grbPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cmbTpForn;
        private System.Windows.Forms.Label lblTpForn;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.MaskedTextBox mtxtCnpj;
    }
}