namespace Principal
{
    partial class frmCadProdutos
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
            this.grbConsulta = new System.Windows.Forms.GroupBox();
            this.grbVisual = new System.Windows.Forms.GroupBox();
            this.rbMostrar = new System.Windows.Forms.RadioButton();
            this.rbOcultar = new System.Windows.Forms.RadioButton();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.lstvProdutos = new System.Windows.Forms.ListView();
            this.clhCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhGrupo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.grbConsulta.SuspendLayout();
            this.grbVisual.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbConsulta
            // 
            this.grbConsulta.Controls.Add(this.grbVisual);
            this.grbConsulta.Controls.Add(this.lblGrupo);
            this.grbConsulta.Controls.Add(this.btnConsultar);
            this.grbConsulta.Controls.Add(this.cmbGrupo);
            this.grbConsulta.Controls.Add(this.txtNome);
            this.grbConsulta.Controls.Add(this.lblNome);
            this.grbConsulta.Controls.Add(this.txtCod);
            this.grbConsulta.Controls.Add(this.lblCod);
            this.grbConsulta.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbConsulta.Location = new System.Drawing.Point(21, 12);
            this.grbConsulta.Name = "grbConsulta";
            this.grbConsulta.Size = new System.Drawing.Size(814, 213);
            this.grbConsulta.TabIndex = 0;
            this.grbConsulta.TabStop = false;
            this.grbConsulta.Text = "Consulta de Produtos";
            // 
            // grbVisual
            // 
            this.grbVisual.Controls.Add(this.rbMostrar);
            this.grbVisual.Controls.Add(this.rbOcultar);
            this.grbVisual.Location = new System.Drawing.Point(68, 109);
            this.grbVisual.Name = "grbVisual";
            this.grbVisual.Size = new System.Drawing.Size(313, 85);
            this.grbVisual.TabIndex = 6;
            this.grbVisual.TabStop = false;
            this.grbVisual.Text = "Visualização";
            // 
            // rbMostrar
            // 
            this.rbMostrar.AutoSize = true;
            this.rbMostrar.Location = new System.Drawing.Point(155, 30);
            this.rbMostrar.Name = "rbMostrar";
            this.rbMostrar.Size = new System.Drawing.Size(148, 25);
            this.rbMostrar.TabIndex = 3;
            this.rbMostrar.TabStop = true;
            this.rbMostrar.Text = "Mostrar Inativos";
            this.rbMostrar.UseVisualStyleBackColor = true;
            // 
            // rbOcultar
            // 
            this.rbOcultar.AutoSize = true;
            this.rbOcultar.Checked = true;
            this.rbOcultar.Location = new System.Drawing.Point(6, 30);
            this.rbOcultar.Name = "rbOcultar";
            this.rbOcultar.Size = new System.Drawing.Size(143, 25);
            this.rbOcultar.TabIndex = 3;
            this.rbOcultar.TabStop = true;
            this.rbOcultar.Text = "Ocultar Inativos";
            this.rbOcultar.UseVisualStyleBackColor = true;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Location = new System.Drawing.Point(515, 39);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(69, 24);
            this.lblGrupo.TabIndex = 5;
            this.lblGrupo.Text = "Grupo:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(656, 149);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(113, 39);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Items.AddRange(new object[] {
            "Produtos",
            "Pratos",
            "Sobremesas"});
            this.cmbGrupo.Location = new System.Drawing.Point(516, 71);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(147, 29);
            this.cmbGrupo.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(213, 71);
            this.txtNome.MaxLength = 35;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(274, 28);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(209, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(66, 24);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(23, 71);
            this.txtCod.MaxLength = 13;
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(166, 28);
            this.txtCod.TabIndex = 1;
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_KeyPress);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(19, 39);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(118, 24);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código/EAN:";
            // 
            // lstvProdutos
            // 
            this.lstvProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhCodigo,
            this.clhNome,
            this.clhGrupo,
            this.clhPreco,
            this.clhData});
            this.lstvProdutos.GridLines = true;
            this.lstvProdutos.Location = new System.Drawing.Point(21, 243);
            this.lstvProdutos.Name = "lstvProdutos";
            this.lstvProdutos.Size = new System.Drawing.Size(814, 272);
            this.lstvProdutos.TabIndex = 1;
            this.lstvProdutos.UseCompatibleStateImageBehavior = false;
            this.lstvProdutos.View = System.Windows.Forms.View.Details;
            // 
            // clhCodigo
            // 
            this.clhCodigo.Text = "Código";
            this.clhCodigo.Width = 100;
            // 
            // clhNome
            // 
            this.clhNome.Text = "Nome";
            this.clhNome.Width = 324;
            // 
            // clhGrupo
            // 
            this.clhGrupo.Text = "Grupo";
            this.clhGrupo.Width = 146;
            // 
            // clhPreco
            // 
            this.clhPreco.Text = "Preço Atual";
            this.clhPreco.Width = 132;
            // 
            // clhData
            // 
            this.clhData.Text = "Dt.Oferta";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(415, 536);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(103, 39);
            this.btnVisualizar.TabIndex = 4;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(546, 536);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(103, 39);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(709, 536);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(103, 39);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(285, 537);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(103, 39);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmCadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(862, 587);
            this.Controls.Add(this.lstvProdutos);
            this.Controls.Add(this.grbConsulta);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnVisualizar);
            this.Name = "frmCadProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.grbConsulta.ResumeLayout(false);
            this.grbConsulta.PerformLayout();
            this.grbVisual.ResumeLayout(false);
            this.grbVisual.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.RadioButton rbOcultar;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.GroupBox grbVisual;
        private System.Windows.Forms.RadioButton rbMostrar;
        private System.Windows.Forms.ListView lstvProdutos;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ColumnHeader clhCodigo;
        private System.Windows.Forms.ColumnHeader clhNome;
        private System.Windows.Forms.ColumnHeader clhGrupo;
        private System.Windows.Forms.ColumnHeader clhPreco;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ColumnHeader clhData;
    }
}