namespace Principal
{
    partial class frmProdMaisVend
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
            this.grbDadosPesq = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grbPeriodoVenda = new System.Windows.Forms.GroupBox();
            this.dtpPeriodoAte = new System.Windows.Forms.DateTimePicker();
            this.dtpPeriodoDe = new System.Windows.Forms.DateTimePicker();
            this.lblDataDe = new System.Windows.Forms.Label();
            this.lblDataAte = new System.Windows.Forms.Label();
            this.grbTpProd = new System.Windows.Forms.GroupBox();
            this.rbPratos = new System.Windows.Forms.RadioButton();
            this.rbProdutos = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.lstvMaisVend = new System.Windows.Forms.ListView();
            this.clhCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhQtdVend = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grbDadosPesq.SuspendLayout();
            this.grbPeriodoVenda.SuspendLayout();
            this.grbTpProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDadosPesq
            // 
            this.grbDadosPesq.Controls.Add(this.btnBuscar);
            this.grbDadosPesq.Controls.Add(this.grbPeriodoVenda);
            this.grbDadosPesq.Controls.Add(this.grbTpProd);
            this.grbDadosPesq.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDadosPesq.Location = new System.Drawing.Point(31, 17);
            this.grbDadosPesq.Name = "grbDadosPesq";
            this.grbDadosPesq.Size = new System.Drawing.Size(748, 206);
            this.grbDadosPesq.TabIndex = 0;
            this.grbDadosPesq.TabStop = false;
            this.grbDadosPesq.Text = "Dados da Pesquisa";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(66, 153);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 38);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // grbPeriodoVenda
            // 
            this.grbPeriodoVenda.Controls.Add(this.dtpPeriodoAte);
            this.grbPeriodoVenda.Controls.Add(this.dtpPeriodoDe);
            this.grbPeriodoVenda.Controls.Add(this.lblDataDe);
            this.grbPeriodoVenda.Controls.Add(this.lblDataAte);
            this.grbPeriodoVenda.Location = new System.Drawing.Point(35, 32);
            this.grbPeriodoVenda.Name = "grbPeriodoVenda";
            this.grbPeriodoVenda.Size = new System.Drawing.Size(430, 103);
            this.grbPeriodoVenda.TabIndex = 3;
            this.grbPeriodoVenda.TabStop = false;
            this.grbPeriodoVenda.Text = "Período de Venda";
            // 
            // dtpPeriodoAte
            // 
            this.dtpPeriodoAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPeriodoAte.Location = new System.Drawing.Point(260, 41);
            this.dtpPeriodoAte.Name = "dtpPeriodoAte";
            this.dtpPeriodoAte.Size = new System.Drawing.Size(136, 28);
            this.dtpPeriodoAte.TabIndex = 2;
            // 
            // dtpPeriodoDe
            // 
            this.dtpPeriodoDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPeriodoDe.Location = new System.Drawing.Point(64, 41);
            this.dtpPeriodoDe.Name = "dtpPeriodoDe";
            this.dtpPeriodoDe.Size = new System.Drawing.Size(136, 28);
            this.dtpPeriodoDe.TabIndex = 2;
            // 
            // lblDataDe
            // 
            this.lblDataDe.AutoSize = true;
            this.lblDataDe.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDe.Location = new System.Drawing.Point(27, 41);
            this.lblDataDe.Name = "lblDataDe";
            this.lblDataDe.Size = new System.Drawing.Size(37, 23);
            this.lblDataDe.TabIndex = 0;
            this.lblDataDe.Text = "De:";
            // 
            // lblDataAte
            // 
            this.lblDataAte.AutoSize = true;
            this.lblDataAte.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAte.Location = new System.Drawing.Point(218, 41);
            this.lblDataAte.Name = "lblDataAte";
            this.lblDataAte.Size = new System.Drawing.Size(43, 23);
            this.lblDataAte.TabIndex = 0;
            this.lblDataAte.Text = "Até:";
            // 
            // grbTpProd
            // 
            this.grbTpProd.Controls.Add(this.rbPratos);
            this.grbTpProd.Controls.Add(this.rbProdutos);
            this.grbTpProd.Controls.Add(this.rbTodos);
            this.grbTpProd.Location = new System.Drawing.Point(507, 27);
            this.grbTpProd.Name = "grbTpProd";
            this.grbTpProd.Size = new System.Drawing.Size(200, 134);
            this.grbTpProd.TabIndex = 2;
            this.grbTpProd.TabStop = false;
            this.grbTpProd.Text = "Pesquisar Por";
            // 
            // rbPratos
            // 
            this.rbPratos.AutoSize = true;
            this.rbPratos.Location = new System.Drawing.Point(25, 98);
            this.rbPratos.Name = "rbPratos";
            this.rbPratos.Size = new System.Drawing.Size(76, 25);
            this.rbPratos.TabIndex = 0;
            this.rbPratos.TabStop = true;
            this.rbPratos.Text = "Pratos";
            this.rbPratos.UseVisualStyleBackColor = true;
            // 
            // rbProdutos
            // 
            this.rbProdutos.AutoSize = true;
            this.rbProdutos.Location = new System.Drawing.Point(25, 64);
            this.rbProdutos.Name = "rbProdutos";
            this.rbProdutos.Size = new System.Drawing.Size(95, 25);
            this.rbProdutos.TabIndex = 0;
            this.rbProdutos.TabStop = true;
            this.rbProdutos.Text = "Produtos";
            this.rbProdutos.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(25, 34);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(72, 25);
            this.rbTodos.TabIndex = 0;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // lstvMaisVend
            // 
            this.lstvMaisVend.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhCodigo,
            this.clhDesc,
            this.clhQtdVend,
            this.clhPreco});
            this.lstvMaisVend.FullRowSelect = true;
            this.lstvMaisVend.GridLines = true;
            this.lstvMaisVend.Location = new System.Drawing.Point(31, 242);
            this.lstvMaisVend.Name = "lstvMaisVend";
            this.lstvMaisVend.Size = new System.Drawing.Size(748, 252);
            this.lstvMaisVend.TabIndex = 1;
            this.lstvMaisVend.UseCompatibleStateImageBehavior = false;
            this.lstvMaisVend.View = System.Windows.Forms.View.Details;
            // 
            // clhCodigo
            // 
            this.clhCodigo.Text = "Código";
            this.clhCodigo.Width = 122;
            // 
            // clhDesc
            // 
            this.clhDesc.Text = "Descrição";
            this.clhDesc.Width = 283;
            // 
            // clhQtdVend
            // 
            this.clhQtdVend.Text = "Quantidade Vendida";
            this.clhQtdVend.Width = 152;
            // 
            // clhPreco
            // 
            this.clhPreco.Text = "Preço Unitário";
            this.clhPreco.Width = 121;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(511, 529);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(97, 43);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(646, 529);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 43);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmProdMaisVend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(818, 583);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lstvMaisVend);
            this.Controls.Add(this.grbDadosPesq);
            this.Name = "frmProdMaisVend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos Mais Vendidos";
            this.grbDadosPesq.ResumeLayout(false);
            this.grbPeriodoVenda.ResumeLayout(false);
            this.grbPeriodoVenda.PerformLayout();
            this.grbTpProd.ResumeLayout(false);
            this.grbTpProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDadosPesq;
        private System.Windows.Forms.Label lblDataAte;
        private System.Windows.Forms.Label lblDataDe;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListView lstvMaisVend;
        private System.Windows.Forms.GroupBox grbTpProd;
        private System.Windows.Forms.RadioButton rbPratos;
        private System.Windows.Forms.RadioButton rbProdutos;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox grbPeriodoVenda;
        private System.Windows.Forms.ColumnHeader clhCodigo;
        private System.Windows.Forms.ColumnHeader clhDesc;
        private System.Windows.Forms.ColumnHeader clhQtdVend;
        private System.Windows.Forms.ColumnHeader clhPreco;
        private System.Windows.Forms.DateTimePicker dtpPeriodoAte;
        private System.Windows.Forms.DateTimePicker dtpPeriodoDe;
    }
}

