namespace Principal
{
    partial class frmCompras
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
            this.lblCodPedido = new System.Windows.Forms.Label();
            this.txtCodPedido = new System.Windows.Forms.TextBox();
            this.lblDtPedido = new System.Windows.Forms.Label();
            this.dtpPedido = new System.Windows.Forms.DateTimePicker();
            this.grbInfoPedido = new System.Windows.Forms.GroupBox();
            this.grbDetPedido = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnPesqProduto = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.lstvPedido = new System.Windows.Forms.ListView();
            this.clhCodProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhQtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.grbInfoPedido.SuspendLayout();
            this.grbDetPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodPedido
            // 
            this.lblCodPedido.AutoSize = true;
            this.lblCodPedido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPedido.Location = new System.Drawing.Point(12, 44);
            this.lblCodPedido.Name = "lblCodPedido";
            this.lblCodPedido.Size = new System.Drawing.Size(118, 24);
            this.lblCodPedido.TabIndex = 4;
            this.lblCodPedido.Text = "Cod. Pedido:";
            // 
            // txtCodPedido
            // 
            this.txtCodPedido.Enabled = false;
            this.txtCodPedido.Location = new System.Drawing.Point(130, 44);
            this.txtCodPedido.MaxLength = 6;
            this.txtCodPedido.Name = "txtCodPedido";
            this.txtCodPedido.Size = new System.Drawing.Size(100, 28);
            this.txtCodPedido.TabIndex = 3;
            // 
            // lblDtPedido
            // 
            this.lblDtPedido.AutoSize = true;
            this.lblDtPedido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtPedido.Location = new System.Drawing.Point(253, 44);
            this.lblDtPedido.Name = "lblDtPedido";
            this.lblDtPedido.Size = new System.Drawing.Size(147, 24);
            this.lblDtPedido.TabIndex = 4;
            this.lblDtPedido.Text = "Data do Pedido:";
            // 
            // dtpPedido
            // 
            this.dtpPedido.Enabled = false;
            this.dtpPedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPedido.Location = new System.Drawing.Point(406, 44);
            this.dtpPedido.Name = "dtpPedido";
            this.dtpPedido.Size = new System.Drawing.Size(124, 28);
            this.dtpPedido.TabIndex = 5;
            // 
            // grbInfoPedido
            // 
            this.grbInfoPedido.Controls.Add(this.txtCodPedido);
            this.grbInfoPedido.Controls.Add(this.dtpPedido);
            this.grbInfoPedido.Controls.Add(this.lblCodPedido);
            this.grbInfoPedido.Controls.Add(this.lblDtPedido);
            this.grbInfoPedido.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfoPedido.Location = new System.Drawing.Point(12, 19);
            this.grbInfoPedido.Name = "grbInfoPedido";
            this.grbInfoPedido.Size = new System.Drawing.Size(649, 98);
            this.grbInfoPedido.TabIndex = 6;
            this.grbInfoPedido.TabStop = false;
            this.grbInfoPedido.Text = "Informações do Pedido";
            // 
            // grbDetPedido
            // 
            this.grbDetPedido.Controls.Add(this.cmbFornecedor);
            this.grbDetPedido.Controls.Add(this.cmbCategoria);
            this.grbDetPedido.Controls.Add(this.cmbGrupo);
            this.grbDetPedido.Controls.Add(this.btnAdicionar);
            this.grbDetPedido.Controls.Add(this.btnPesqProduto);
            this.grbDetPedido.Controls.Add(this.txtNome);
            this.grbDetPedido.Controls.Add(this.txtQtd);
            this.grbDetPedido.Controls.Add(this.txtCodProduto);
            this.grbDetPedido.Controls.Add(this.lblNome);
            this.grbDetPedido.Controls.Add(this.lblFornecedor);
            this.grbDetPedido.Controls.Add(this.lblCategoria);
            this.grbDetPedido.Controls.Add(this.lblGrupo);
            this.grbDetPedido.Controls.Add(this.lblQtd);
            this.grbDetPedido.Controls.Add(this.lblCodProduto);
            this.grbDetPedido.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetPedido.Location = new System.Drawing.Point(12, 127);
            this.grbDetPedido.Name = "grbDetPedido";
            this.grbDetPedido.Size = new System.Drawing.Size(840, 197);
            this.grbDetPedido.TabIndex = 7;
            this.grbDetPedido.TabStop = false;
            this.grbDetPedido.Text = "Detalhes do Pedido";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Alimentos Basicos",
            "Hortifruti",
            "Frigorífico",
            "Alcoólicas",
            "Não Alcoólicas",
            "Bomboniere",
            "Sobremesas",
            "Limpeza"});
            this.cmbCategoria.Location = new System.Drawing.Point(217, 69);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(159, 29);
            this.cmbCategoria.TabIndex = 7;
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Items.AddRange(new object[] {
            "Alimentos ",
            "Bebidas",
            "Complementares",
            "Não Alimentos"});
            this.cmbGrupo.Location = new System.Drawing.Point(16, 69);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(168, 29);
            this.cmbGrupo.TabIndex = 7;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(704, 146);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(99, 35);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnPesqProduto
            // 
            this.btnPesqProduto.Image = global::Restaurante.Properties.Resources._48px_Crystal_Clear_app_korganizer;
            this.btnPesqProduto.Location = new System.Drawing.Point(148, 121);
            this.btnPesqProduto.Name = "btnPesqProduto";
            this.btnPesqProduto.Size = new System.Drawing.Size(36, 27);
            this.btnPesqProduto.TabIndex = 5;
            this.btnPesqProduto.UseVisualStyleBackColor = true;
            this.btnPesqProduto.Click += new System.EventHandler(this.btnPesqProduto_Click);
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(215, 153);
            this.txtNome.MaxLength = 35;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(303, 28);
            this.txtNome.TabIndex = 3;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(567, 153);
            this.txtQtd.MaxLength = 3;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(82, 28);
            this.txtQtd.TabIndex = 3;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Enabled = false;
            this.txtCodProduto.Location = new System.Drawing.Point(15, 153);
            this.txtCodProduto.MaxLength = 13;
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(137, 28);
            this.txtCodProduto.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(211, 124);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(66, 24);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(407, 40);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(111, 24);
            this.lblFornecedor.TabIndex = 4;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(215, 36);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(96, 24);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Location = new System.Drawing.Point(14, 36);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(69, 24);
            this.lblGrupo.TabIndex = 4;
            this.lblGrupo.Text = "Grupo:";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(563, 121);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(116, 24);
            this.lblQtd.TabIndex = 4;
            this.lblQtd.Text = "Quantidade:";
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProduto.Location = new System.Drawing.Point(14, 124);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(128, 24);
            this.lblCodProduto.TabIndex = 4;
            this.lblCodProduto.Text = "Cod. Produto:";
            // 
            // lstvPedido
            // 
            this.lstvPedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhCodProduto,
            this.clhNome,
            this.clhQtd});
            this.lstvPedido.FullRowSelect = true;
            this.lstvPedido.GridLines = true;
            this.lstvPedido.Location = new System.Drawing.Point(12, 341);
            this.lstvPedido.Name = "lstvPedido";
            this.lstvPedido.Size = new System.Drawing.Size(837, 213);
            this.lstvPedido.TabIndex = 8;
            this.lstvPedido.UseCompatibleStateImageBehavior = false;
            this.lstvPedido.View = System.Windows.Forms.View.Details;
            // 
            // clhCodProduto
            // 
            this.clhCodProduto.Text = "Cod.Produto";
            this.clhCodProduto.Width = 121;
            // 
            // clhNome
            // 
            this.clhNome.Text = "Nome";
            this.clhNome.Width = 291;
            // 
            // clhQtd
            // 
            this.clhQtd.Text = "Quantidade";
            this.clhQtd.Width = 96;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(716, 569);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 40);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(579, 569);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(99, 40);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(433, 569);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(99, 40);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(406, 69);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(273, 29);
            this.cmbFornecedor.TabIndex = 7;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(871, 615);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lstvPedido);
            this.Controls.Add(this.grbDetPedido);
            this.Controls.Add(this.grbInfoPedido);
            this.Name = "frmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras- Pedido Para Fornecedor";
            this.grbInfoPedido.ResumeLayout(false);
            this.grbInfoPedido.PerformLayout();
            this.grbDetPedido.ResumeLayout(false);
            this.grbDetPedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodPedido;
        private System.Windows.Forms.TextBox txtCodPedido;
        private System.Windows.Forms.Label lblDtPedido;
        private System.Windows.Forms.DateTimePicker dtpPedido;
        private System.Windows.Forms.GroupBox grbInfoPedido;
        private System.Windows.Forms.GroupBox grbDetPedido;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnPesqProduto;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.ListView lstvPedido;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ColumnHeader clhCodProduto;
        private System.Windows.Forms.ColumnHeader clhNome;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ColumnHeader clhQtd;
        private System.Windows.Forms.ComboBox cmbFornecedor;
    }
}