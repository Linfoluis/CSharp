namespace Principal
{
    partial class frmVendas
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
            this.grbInfoVenda = new System.Windows.Forms.GroupBox();
            this.mTxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCodVenda = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCodVenda = new System.Windows.Forms.TextBox();
            this.txtAtendente = new System.Windows.Forms.TextBox();
            this.txtCodAtend = new System.Windows.Forms.TextBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpVenda = new System.Windows.Forms.DateTimePicker();
            this.txtComanda = new System.Windows.Forms.TextBox();
            this.txtNroMesa = new System.Windows.Forms.TextBox();
            this.lblAtendente = new System.Windows.Forms.Label();
            this.lblCodAtend = new System.Windows.Forms.Label();
            this.lblComanda = new System.Windows.Forms.Label();
            this.lblNroMesa = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDtVenda = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.grbDetVenda = new System.Windows.Forms.GroupBox();
            this.mtxtPreço = new System.Windows.Forms.MaskedTextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.lblPreço = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lstvVenda = new System.Windows.Forms.ListView();
            this.clhCodProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhQtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.grbInfoVenda.SuspendLayout();
            this.grbDetVenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInfoVenda
            // 
            this.grbInfoVenda.Controls.Add(this.mTxtCpf);
            this.grbInfoVenda.Controls.Add(this.lblCodVenda);
            this.grbInfoVenda.Controls.Add(this.txtCliente);
            this.grbInfoVenda.Controls.Add(this.txtCodVenda);
            this.grbInfoVenda.Controls.Add(this.txtAtendente);
            this.grbInfoVenda.Controls.Add(this.txtCodAtend);
            this.grbInfoVenda.Controls.Add(this.dtpHora);
            this.grbInfoVenda.Controls.Add(this.dtpVenda);
            this.grbInfoVenda.Controls.Add(this.txtComanda);
            this.grbInfoVenda.Controls.Add(this.txtNroMesa);
            this.grbInfoVenda.Controls.Add(this.lblAtendente);
            this.grbInfoVenda.Controls.Add(this.lblCodAtend);
            this.grbInfoVenda.Controls.Add(this.lblComanda);
            this.grbInfoVenda.Controls.Add(this.lblNroMesa);
            this.grbInfoVenda.Controls.Add(this.lblCpf);
            this.grbInfoVenda.Controls.Add(this.lblHora);
            this.grbInfoVenda.Controls.Add(this.lblDtVenda);
            this.grbInfoVenda.Controls.Add(this.lblCliente);
            this.grbInfoVenda.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfoVenda.Location = new System.Drawing.Point(12, 12);
            this.grbInfoVenda.Name = "grbInfoVenda";
            this.grbInfoVenda.Size = new System.Drawing.Size(868, 179);
            this.grbInfoVenda.TabIndex = 7;
            this.grbInfoVenda.TabStop = false;
            this.grbInfoVenda.Text = "Informações da Venda";
            // 
            // mTxtCpf
            // 
            this.mTxtCpf.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtCpf.Location = new System.Drawing.Point(60, 132);
            this.mTxtCpf.Mask = "000,000,000-00";
            this.mTxtCpf.Name = "mTxtCpf";
            this.mTxtCpf.Size = new System.Drawing.Size(149, 29);
            this.mTxtCpf.TabIndex = 6;
            // 
            // lblCodVenda
            // 
            this.lblCodVenda.AutoSize = true;
            this.lblCodVenda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodVenda.Location = new System.Drawing.Point(12, 84);
            this.lblCodVenda.Name = "lblCodVenda";
            this.lblCodVenda.Size = new System.Drawing.Size(112, 24);
            this.lblCodVenda.TabIndex = 4;
            this.lblCodVenda.Text = "Cod. Venda:";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(305, 135);
            this.txtCliente.MaxLength = 35;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(280, 28);
            this.txtCliente.TabIndex = 3;
            // 
            // txtCodVenda
            // 
            this.txtCodVenda.Enabled = false;
            this.txtCodVenda.Location = new System.Drawing.Point(130, 84);
            this.txtCodVenda.MaxLength = 10;
            this.txtCodVenda.Name = "txtCodVenda";
            this.txtCodVenda.Size = new System.Drawing.Size(100, 28);
            this.txtCodVenda.TabIndex = 3;
            // 
            // txtAtendente
            // 
            this.txtAtendente.Enabled = false;
            this.txtAtendente.Location = new System.Drawing.Point(568, 85);
            this.txtAtendente.MaxLength = 35;
            this.txtAtendente.Name = "txtAtendente";
            this.txtAtendente.Size = new System.Drawing.Size(284, 28);
            this.txtAtendente.TabIndex = 3;
            // 
            // txtCodAtend
            // 
            this.txtCodAtend.Location = new System.Drawing.Point(348, 84);
            this.txtCodAtend.MaxLength = 6;
            this.txtCodAtend.Name = "txtCodAtend";
            this.txtCodAtend.Size = new System.Drawing.Size(100, 28);
            this.txtCodAtend.TabIndex = 3;
            this.txtCodAtend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodAtend_KeyPress);
            // 
            // dtpHora
            // 
            this.dtpHora.CustomFormat = "";
            this.dtpHora.Enabled = false;
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(354, 37);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(95, 28);
            this.dtpHora.TabIndex = 5;
            // 
            // dtpVenda
            // 
            this.dtpVenda.CustomFormat = "";
            this.dtpVenda.Enabled = false;
            this.dtpVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVenda.Location = new System.Drawing.Point(157, 37);
            this.dtpVenda.Name = "dtpVenda";
            this.dtpVenda.Size = new System.Drawing.Size(111, 28);
            this.dtpVenda.TabIndex = 5;
            // 
            // txtComanda
            // 
            this.txtComanda.Location = new System.Drawing.Point(733, 41);
            this.txtComanda.MaxLength = 10;
            this.txtComanda.Name = "txtComanda";
            this.txtComanda.Size = new System.Drawing.Size(102, 28);
            this.txtComanda.TabIndex = 3;
            this.txtComanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComanda_KeyPress);
            // 
            // txtNroMesa
            // 
            this.txtNroMesa.Location = new System.Drawing.Point(564, 41);
            this.txtNroMesa.MaxLength = 2;
            this.txtNroMesa.Name = "txtNroMesa";
            this.txtNroMesa.Size = new System.Drawing.Size(60, 28);
            this.txtNroMesa.TabIndex = 3;
            this.txtNroMesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroMesa_KeyPress);
            // 
            // lblAtendente
            // 
            this.lblAtendente.AutoSize = true;
            this.lblAtendente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtendente.Location = new System.Drawing.Point(465, 85);
            this.lblAtendente.Name = "lblAtendente";
            this.lblAtendente.Size = new System.Drawing.Size(104, 24);
            this.lblAtendente.TabIndex = 4;
            this.lblAtendente.Text = "Atendente:";
            // 
            // lblCodAtend
            // 
            this.lblCodAtend.AutoSize = true;
            this.lblCodAtend.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodAtend.Location = new System.Drawing.Point(238, 84);
            this.lblCodAtend.Name = "lblCodAtend";
            this.lblCodAtend.Size = new System.Drawing.Size(109, 24);
            this.lblCodAtend.TabIndex = 4;
            this.lblCodAtend.Text = "Cod. Atend:";
            // 
            // lblComanda
            // 
            this.lblComanda.AutoSize = true;
            this.lblComanda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComanda.Location = new System.Drawing.Point(639, 41);
            this.lblComanda.Name = "lblComanda";
            this.lblComanda.Size = new System.Drawing.Size(96, 24);
            this.lblComanda.TabIndex = 4;
            this.lblComanda.Text = "Comanda:";
            // 
            // lblNroMesa
            // 
            this.lblNroMesa.AutoSize = true;
            this.lblNroMesa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroMesa.Location = new System.Drawing.Point(467, 41);
            this.lblNroMesa.Name = "lblNroMesa";
            this.lblNroMesa.Size = new System.Drawing.Size(97, 24);
            this.lblNroMesa.TabIndex = 4;
            this.lblNroMesa.Text = "Nro.Mesa:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(12, 133);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(47, 24);
            this.lblCpf.TabIndex = 4;
            this.lblCpf.Text = "CPF:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(291, 37);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(57, 24);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora:";
            // 
            // lblDtVenda
            // 
            this.lblDtVenda.AutoSize = true;
            this.lblDtVenda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtVenda.Location = new System.Drawing.Point(12, 37);
            this.lblDtVenda.Name = "lblDtVenda";
            this.lblDtVenda.Size = new System.Drawing.Size(140, 24);
            this.lblDtVenda.TabIndex = 4;
            this.lblDtVenda.Text = "Data da Venda:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(227, 134);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(75, 24);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente:";
            // 
            // grbDetVenda
            // 
            this.grbDetVenda.Controls.Add(this.mtxtPreço);
            this.grbDetVenda.Controls.Add(this.btnAdicionar);
            this.grbDetVenda.Controls.Add(this.txtNome);
            this.grbDetVenda.Controls.Add(this.txtCodProduto);
            this.grbDetVenda.Controls.Add(this.txtQtd);
            this.grbDetVenda.Controls.Add(this.lblNome);
            this.grbDetVenda.Controls.Add(this.lblCodProduto);
            this.grbDetVenda.Controls.Add(this.lblPreço);
            this.grbDetVenda.Controls.Add(this.lblQtd);
            this.grbDetVenda.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetVenda.Location = new System.Drawing.Point(14, 200);
            this.grbDetVenda.Name = "grbDetVenda";
            this.grbDetVenda.Size = new System.Drawing.Size(866, 134);
            this.grbDetVenda.TabIndex = 8;
            this.grbDetVenda.TabStop = false;
            this.grbDetVenda.Text = "Detalhes da Venda";
            // 
            // mtxtPreço
            // 
            this.mtxtPreço.Enabled = false;
            this.mtxtPreço.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPreço.Location = new System.Drawing.Point(73, 90);
            this.mtxtPreço.Mask = "$ 000.00";
            this.mtxtPreço.Name = "mtxtPreço";
            this.mtxtPreço.Size = new System.Drawing.Size(108, 29);
            this.mtxtPreço.TabIndex = 6;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(734, 74);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(99, 40);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(377, 33);
            this.txtNome.MaxLength = 35;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(317, 28);
            this.txtNome.TabIndex = 3;
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Location = new System.Drawing.Point(137, 34);
            this.txtCodProduto.MaxLength = 13;
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(161, 28);
            this.txtCodProduto.TabIndex = 3;
            this.txtCodProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProduto_KeyPress);
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(248, 90);
            this.txtQtd.MaxLength = 2;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(75, 28);
            this.txtQtd.TabIndex = 3;
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtd_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(312, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(66, 24);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodProduto.Location = new System.Drawing.Point(10, 35);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(128, 24);
            this.lblCodProduto.TabIndex = 4;
            this.lblCodProduto.Text = "Cod. Produto:";
            // 
            // lblPreço
            // 
            this.lblPreço.AutoSize = true;
            this.lblPreço.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreço.Location = new System.Drawing.Point(10, 90);
            this.lblPreço.Name = "lblPreço";
            this.lblPreço.Size = new System.Drawing.Size(63, 24);
            this.lblPreço.TabIndex = 4;
            this.lblPreço.Text = "Preço:";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.Location = new System.Drawing.Point(202, 90);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(48, 24);
            this.lblQtd.TabIndex = 4;
            this.lblQtd.Text = "Qtd:";
            // 
            // lstvVenda
            // 
            this.lstvVenda.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhCodProd,
            this.clhProduto,
            this.clhQtd,
            this.clhPreco});
            this.lstvVenda.FullRowSelect = true;
            this.lstvVenda.GridLines = true;
            this.lstvVenda.Location = new System.Drawing.Point(12, 340);
            this.lstvVenda.Name = "lstvVenda";
            this.lstvVenda.Size = new System.Drawing.Size(868, 203);
            this.lstvVenda.TabIndex = 9;
            this.lstvVenda.UseCompatibleStateImageBehavior = false;
            this.lstvVenda.View = System.Windows.Forms.View.Details;
            // 
            // clhCodProd
            // 
            this.clhCodProd.Text = "Cod.Produto";
            this.clhCodProd.Width = 126;
            // 
            // clhProduto
            // 
            this.clhProduto.Text = "Produto";
            this.clhProduto.Width = 260;
            // 
            // clhQtd
            // 
            this.clhQtd.Text = "Quantidade";
            this.clhQtd.Width = 96;
            // 
            // clhPreco
            // 
            this.clhPreco.Text = "Preço";
            this.clhPreco.Width = 95;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(726, 564);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(99, 40);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(391, 564);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(127, 40);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(895, 612);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lstvVenda);
            this.Controls.Add(this.grbDetVenda);
            this.Controls.Add(this.grbInfoVenda);
            this.MaximizeBox = false;
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.grbInfoVenda.ResumeLayout(false);
            this.grbInfoVenda.PerformLayout();
            this.grbDetVenda.ResumeLayout(false);
            this.grbDetVenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInfoVenda;
        private System.Windows.Forms.TextBox txtAtendente;
        private System.Windows.Forms.TextBox txtCodVenda;
        private System.Windows.Forms.DateTimePicker dtpVenda;
        private System.Windows.Forms.Label lblAtendente;
        private System.Windows.Forms.Label lblCodVenda;
        private System.Windows.Forms.Label lblDtVenda;
        private System.Windows.Forms.TextBox txtCodAtend;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label lblCodAtend;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.GroupBox grbDetVenda;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblPreço;
        private System.Windows.Forms.TextBox txtComanda;
        private System.Windows.Forms.TextBox txtNroMesa;
        private System.Windows.Forms.Label lblComanda;
        private System.Windows.Forms.Label lblNroMesa;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListView lstvVenda;
        private System.Windows.Forms.ColumnHeader clhCodProd;
        private System.Windows.Forms.ColumnHeader clhProduto;
        private System.Windows.Forms.ColumnHeader clhQtd;
        private System.Windows.Forms.ColumnHeader clhPreco;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.MaskedTextBox mTxtCpf;
        private System.Windows.Forms.MaskedTextBox mtxtPreço;
    }
}