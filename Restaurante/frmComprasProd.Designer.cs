namespace Principal
{
    partial class frmComprasProd
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
            this.lstvProdutos = new System.Windows.Forms.ListView();
            this.clhCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstvProdutos
            // 
            this.lstvProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhCodigo,
            this.clhNome});
            this.lstvProdutos.FullRowSelect = true;
            this.lstvProdutos.GridLines = true;
            this.lstvProdutos.Location = new System.Drawing.Point(23, 21);
            this.lstvProdutos.Name = "lstvProdutos";
            this.lstvProdutos.Size = new System.Drawing.Size(469, 295);
            this.lstvProdutos.TabIndex = 6;
            this.lstvProdutos.UseCompatibleStateImageBehavior = false;
            this.lstvProdutos.View = System.Windows.Forms.View.Details;
            // 
            // clhCodigo
            // 
            this.clhCodigo.Text = "Código";
            this.clhCodigo.Width = 150;
            // 
            // clhNome
            // 
            this.clhNome.Text = "Nome";
            this.clhNome.Width = 310;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(355, 337);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(103, 39);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(219, 337);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(103, 39);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // frmComprasProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(516, 388);
            this.Controls.Add(this.lstvProdutos);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnOk);
            this.Name = "frmComprasProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Produtos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstvProdutos;
        private System.Windows.Forms.ColumnHeader clhCodigo;
        private System.Windows.Forms.ColumnHeader clhNome;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnOk;
    }
}