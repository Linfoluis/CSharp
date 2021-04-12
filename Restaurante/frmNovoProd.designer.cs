namespace Principal
{
    partial class frmNovoProd
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
            this.grbDetalhes = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grbSituacao = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.grbValores = new System.Windows.Forms.GroupBox();
            this.grbPreçoCusto = new System.Windows.Forms.GroupBox();
            this.mtxtPreçoCusto = new System.Windows.Forms.MaskedTextBox();
            this.lblPreçoCusto = new System.Windows.Forms.Label();
            this.grbPreços = new System.Windows.Forms.GroupBox();
            this.mtxtVlrOferta = new System.Windows.Forms.MaskedTextBox();
            this.mtxtVlrVenda = new System.Windows.Forms.MaskedTextBox();
            this.rbVlrVenda = new System.Windows.Forms.RadioButton();
            this.rbVlrOferta = new System.Windows.Forms.RadioButton();
            this.grbDtOfertas = new System.Windows.Forms.GroupBox();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDtFim = new System.Windows.Forms.Label();
            this.lblDtInicio = new System.Windows.Forms.Label();
            this.grbDesc = new System.Windows.Forms.GroupBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblImagem = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnSelecImg = new System.Windows.Forms.Button();
            this.pcbImagem = new System.Windows.Forms.PictureBox();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblNomeForn = new System.Windows.Forms.Label();
            this.lblCodForn = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNomeForn = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodForn = new System.Windows.Forms.TextBox();
            this.txtEan = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.rbEan = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grbDetalhes.SuspendLayout();
            this.grbSituacao.SuspendLayout();
            this.grbValores.SuspendLayout();
            this.grbPreçoCusto.SuspendLayout();
            this.grbPreços.SuspendLayout();
            this.grbDtOfertas.SuspendLayout();
            this.grbDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDetalhes
            // 
            this.grbDetalhes.Controls.Add(this.btnAdd);
            this.grbDetalhes.Controls.Add(this.grbSituacao);
            this.grbDetalhes.Controls.Add(this.grbValores);
            this.grbDetalhes.Controls.Add(this.grbDesc);
            this.grbDetalhes.Controls.Add(this.cmbGrupo);
            this.grbDetalhes.Controls.Add(this.lblGrupo);
            this.grbDetalhes.Controls.Add(this.lblNomeForn);
            this.grbDetalhes.Controls.Add(this.lblCodForn);
            this.grbDetalhes.Controls.Add(this.lblNome);
            this.grbDetalhes.Controls.Add(this.txtNomeForn);
            this.grbDetalhes.Controls.Add(this.txtNome);
            this.grbDetalhes.Controls.Add(this.txtCodForn);
            this.grbDetalhes.Controls.Add(this.txtEan);
            this.grbDetalhes.Controls.Add(this.txtCodigo);
            this.grbDetalhes.Controls.Add(this.rbEan);
            this.grbDetalhes.Controls.Add(this.rbCodigo);
            this.grbDetalhes.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetalhes.Location = new System.Drawing.Point(19, 12);
            this.grbDetalhes.Name = "grbDetalhes";
            this.grbDetalhes.Size = new System.Drawing.Size(856, 554);
            this.grbDetalhes.TabIndex = 0;
            this.grbDetalhes.TabStop = false;
            this.grbDetalhes.Text = "Detalhes do Produto";
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Crimson;
            this.btnAdd.Location = new System.Drawing.Point(796, 52);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 33);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grbSituacao
            // 
            this.grbSituacao.Controls.Add(this.rbInativo);
            this.grbSituacao.Controls.Add(this.rbAtivo);
            this.grbSituacao.Location = new System.Drawing.Point(19, 467);
            this.grbSituacao.Name = "grbSituacao";
            this.grbSituacao.Size = new System.Drawing.Size(280, 67);
            this.grbSituacao.TabIndex = 6;
            this.grbSituacao.TabStop = false;
            this.grbSituacao.Text = "Situação";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(99, 27);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(80, 25);
            this.rbInativo.TabIndex = 0;
            this.rbInativo.TabStop = true;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Location = new System.Drawing.Point(16, 27);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(67, 25);
            this.rbAtivo.TabIndex = 0;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // grbValores
            // 
            this.grbValores.Controls.Add(this.grbPreçoCusto);
            this.grbValores.Controls.Add(this.grbPreços);
            this.grbValores.Controls.Add(this.grbDtOfertas);
            this.grbValores.Location = new System.Drawing.Point(464, 189);
            this.grbValores.Name = "grbValores";
            this.grbValores.Size = new System.Drawing.Size(379, 309);
            this.grbValores.TabIndex = 5;
            this.grbValores.TabStop = false;
            this.grbValores.Text = "Valores";
            // 
            // grbPreçoCusto
            // 
            this.grbPreçoCusto.Controls.Add(this.mtxtPreçoCusto);
            this.grbPreçoCusto.Controls.Add(this.lblPreçoCusto);
            this.grbPreçoCusto.Location = new System.Drawing.Point(15, 18);
            this.grbPreçoCusto.Name = "grbPreçoCusto";
            this.grbPreçoCusto.Size = new System.Drawing.Size(341, 76);
            this.grbPreçoCusto.TabIndex = 4;
            this.grbPreçoCusto.TabStop = false;
            // 
            // mtxtPreçoCusto
            // 
            this.mtxtPreçoCusto.Location = new System.Drawing.Point(147, 30);
            this.mtxtPreçoCusto.Mask = "$ 000.00";
            this.mtxtPreçoCusto.Name = "mtxtPreçoCusto";
            this.mtxtPreçoCusto.Size = new System.Drawing.Size(119, 28);
            this.mtxtPreçoCusto.TabIndex = 2;
            this.mtxtPreçoCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtPreçoCusto_KeyPress);
            // 
            // lblPreçoCusto
            // 
            this.lblPreçoCusto.AutoSize = true;
            this.lblPreçoCusto.Location = new System.Drawing.Point(19, 34);
            this.lblPreçoCusto.Name = "lblPreçoCusto";
            this.lblPreçoCusto.Size = new System.Drawing.Size(121, 21);
            this.lblPreçoCusto.TabIndex = 0;
            this.lblPreçoCusto.Text = "Preço de Custo:";
            // 
            // grbPreços
            // 
            this.grbPreços.Controls.Add(this.mtxtVlrOferta);
            this.grbPreços.Controls.Add(this.mtxtVlrVenda);
            this.grbPreços.Controls.Add(this.rbVlrVenda);
            this.grbPreços.Controls.Add(this.rbVlrOferta);
            this.grbPreços.Location = new System.Drawing.Point(14, 107);
            this.grbPreços.Name = "grbPreços";
            this.grbPreços.Size = new System.Drawing.Size(172, 172);
            this.grbPreços.TabIndex = 3;
            this.grbPreços.TabStop = false;
            this.grbPreços.Text = "Preços";
            // 
            // mtxtVlrOferta
            // 
            this.mtxtVlrOferta.Location = new System.Drawing.Point(18, 129);
            this.mtxtVlrOferta.Mask = "$ 000.00";
            this.mtxtVlrOferta.Name = "mtxtVlrOferta";
            this.mtxtVlrOferta.Size = new System.Drawing.Size(109, 28);
            this.mtxtVlrOferta.TabIndex = 2;
            this.mtxtVlrOferta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtPreçoCusto_KeyPress);
            // 
            // mtxtVlrVenda
            // 
            this.mtxtVlrVenda.Location = new System.Drawing.Point(18, 63);
            this.mtxtVlrVenda.Mask = "$ 000.00";
            this.mtxtVlrVenda.Name = "mtxtVlrVenda";
            this.mtxtVlrVenda.Size = new System.Drawing.Size(109, 28);
            this.mtxtVlrVenda.TabIndex = 2;
            this.mtxtVlrVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtPreçoCusto_KeyPress);
            // 
            // rbVlrVenda
            // 
            this.rbVlrVenda.AutoSize = true;
            this.rbVlrVenda.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVlrVenda.Location = new System.Drawing.Point(11, 27);
            this.rbVlrVenda.Name = "rbVlrVenda";
            this.rbVlrVenda.Size = new System.Drawing.Size(154, 27);
            this.rbVlrVenda.TabIndex = 0;
            this.rbVlrVenda.TabStop = true;
            this.rbVlrVenda.Text = "Valor de Venda:";
            this.rbVlrVenda.UseVisualStyleBackColor = true;
            this.rbVlrVenda.CheckedChanged += new System.EventHandler(this.rbVlrVenda_CheckedChanged);
            // 
            // rbVlrOferta
            // 
            this.rbVlrOferta.AutoSize = true;
            this.rbVlrOferta.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVlrOferta.Location = new System.Drawing.Point(11, 98);
            this.rbVlrOferta.Name = "rbVlrOferta";
            this.rbVlrOferta.Size = new System.Drawing.Size(157, 27);
            this.rbVlrOferta.TabIndex = 0;
            this.rbVlrOferta.TabStop = true;
            this.rbVlrOferta.Text = "Valor de Oferta:";
            this.rbVlrOferta.UseVisualStyleBackColor = true;
            this.rbVlrOferta.CheckedChanged += new System.EventHandler(this.rbVlrOferta_CheckedChanged);
            // 
            // grbDtOfertas
            // 
            this.grbDtOfertas.Controls.Add(this.dtpFim);
            this.grbDtOfertas.Controls.Add(this.dtpInicio);
            this.grbDtOfertas.Controls.Add(this.lblDtFim);
            this.grbDtOfertas.Controls.Add(this.lblDtInicio);
            this.grbDtOfertas.Location = new System.Drawing.Point(199, 108);
            this.grbDtOfertas.Name = "grbDtOfertas";
            this.grbDtOfertas.Size = new System.Drawing.Size(163, 172);
            this.grbDtOfertas.TabIndex = 3;
            this.grbDtOfertas.TabStop = false;
            this.grbDtOfertas.Text = "Data de Oferta";
            // 
            // dtpFim
            // 
            this.dtpFim.Enabled = false;
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(17, 125);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(132, 28);
            this.dtpFim.TabIndex = 3;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Enabled = false;
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(17, 57);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(132, 28);
            this.dtpInicio.TabIndex = 3;
            // 
            // lblDtFim
            // 
            this.lblDtFim.AutoSize = true;
            this.lblDtFim.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtFim.Location = new System.Drawing.Point(14, 98);
            this.lblDtFim.Name = "lblDtFim";
            this.lblDtFim.Size = new System.Drawing.Size(46, 24);
            this.lblDtFim.TabIndex = 2;
            this.lblDtFim.Text = "Fim:";
            // 
            // lblDtInicio
            // 
            this.lblDtInicio.AutoSize = true;
            this.lblDtInicio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtInicio.Location = new System.Drawing.Point(14, 27);
            this.lblDtInicio.Name = "lblDtInicio";
            this.lblDtInicio.Size = new System.Drawing.Size(61, 24);
            this.lblDtInicio.TabIndex = 2;
            this.lblDtInicio.Text = "Início:";
            // 
            // grbDesc
            // 
            this.grbDesc.Controls.Add(this.txtDesc);
            this.grbDesc.Controls.Add(this.lblImagem);
            this.grbDesc.Controls.Add(this.lblDesc);
            this.grbDesc.Controls.Add(this.btnSelecImg);
            this.grbDesc.Controls.Add(this.pcbImagem);
            this.grbDesc.Location = new System.Drawing.Point(15, 189);
            this.grbDesc.Name = "grbDesc";
            this.grbDesc.Size = new System.Drawing.Size(421, 265);
            this.grbDesc.TabIndex = 4;
            this.grbDesc.TabStop = false;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(199, 64);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(207, 177);
            this.txtDesc.TabIndex = 9;
            this.txtDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesc_KeyPress);
            // 
            // lblImagem
            // 
            this.lblImagem.AutoSize = true;
            this.lblImagem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagem.Location = new System.Drawing.Point(54, 29);
            this.lblImagem.Name = "lblImagem";
            this.lblImagem.Size = new System.Drawing.Size(82, 24);
            this.lblImagem.TabIndex = 8;
            this.lblImagem.Text = "Imagem:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(255, 29);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(96, 24);
            this.lblDesc.TabIndex = 8;
            this.lblDesc.Text = "Descrição:";
            // 
            // btnSelecImg
            // 
            this.btnSelecImg.Location = new System.Drawing.Point(15, 201);
            this.btnSelecImg.Name = "btnSelecImg";
            this.btnSelecImg.Size = new System.Drawing.Size(161, 40);
            this.btnSelecImg.TabIndex = 6;
            this.btnSelecImg.Text = "Selecionar Imagem";
            this.btnSelecImg.UseVisualStyleBackColor = true;
            // 
            // pcbImagem
            // 
            this.pcbImagem.Image = global::Restaurante.Properties.Resources._48px_Crystal_Clear_app_korganizer;
            this.pcbImagem.Location = new System.Drawing.Point(15, 64);
            this.pcbImagem.Name = "pcbImagem";
            this.pcbImagem.Size = new System.Drawing.Size(161, 131);
            this.pcbImagem.TabIndex = 5;
            this.pcbImagem.TabStop = false;
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Items.AddRange(new object[] {
            "Alimentos",
            "Pratos",
            "Sobremesas",
            "Bebidas"});
            this.cmbGrupo.Location = new System.Drawing.Point(626, 75);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(157, 29);
            this.cmbGrupo.TabIndex = 3;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Location = new System.Drawing.Point(622, 40);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(69, 24);
            this.lblGrupo.TabIndex = 2;
            this.lblGrupo.Text = "Grupo:";
            // 
            // lblNomeForn
            // 
            this.lblNomeForn.AutoSize = true;
            this.lblNomeForn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeForn.Location = new System.Drawing.Point(192, 114);
            this.lblNomeForn.Name = "lblNomeForn";
            this.lblNomeForn.Size = new System.Drawing.Size(166, 24);
            this.lblNomeForn.TabIndex = 2;
            this.lblNomeForn.Text = "Nome Fornecedor:";
            // 
            // lblCodForn
            // 
            this.lblCodForn.AutoSize = true;
            this.lblCodForn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodForn.Location = new System.Drawing.Point(15, 114);
            this.lblCodForn.Name = "lblCodForn";
            this.lblCodForn.Size = new System.Drawing.Size(97, 24);
            this.lblCodForn.TabIndex = 2;
            this.lblCodForn.Text = "Cod.Forn.:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(300, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(66, 24);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtNomeForn
            // 
            this.txtNomeForn.Enabled = false;
            this.txtNomeForn.Location = new System.Drawing.Point(196, 150);
            this.txtNomeForn.MaxLength = 35;
            this.txtNomeForn.Name = "txtNomeForn";
            this.txtNomeForn.Size = new System.Drawing.Size(295, 28);
            this.txtNomeForn.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(304, 75);
            this.txtNome.MaxLength = 35;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(295, 28);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtCodForn
            // 
            this.txtCodForn.Location = new System.Drawing.Point(17, 149);
            this.txtCodForn.MaxLength = 6;
            this.txtCodForn.Name = "txtCodForn";
            this.txtCodForn.Size = new System.Drawing.Size(114, 28);
            this.txtCodForn.TabIndex = 1;
            this.txtCodForn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodForn_KeyPress);
            // 
            // txtEan
            // 
            this.txtEan.Enabled = false;
            this.txtEan.Location = new System.Drawing.Point(140, 75);
            this.txtEan.MaxLength = 13;
            this.txtEan.Name = "txtEan";
            this.txtEan.Size = new System.Drawing.Size(140, 28);
            this.txtEan.TabIndex = 1;
            this.txtEan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEan_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(15, 75);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 28);
            this.txtCodigo.TabIndex = 1;
            // 
            // rbEan
            // 
            this.rbEan.AutoSize = true;
            this.rbEan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEan.Location = new System.Drawing.Point(140, 40);
            this.rbEan.Name = "rbEan";
            this.rbEan.Size = new System.Drawing.Size(72, 28);
            this.rbEan.TabIndex = 0;
            this.rbEan.Text = "EAN:";
            this.rbEan.UseVisualStyleBackColor = true;
            this.rbEan.CheckedChanged += new System.EventHandler(this.rbEan_CheckedChanged);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.Location = new System.Drawing.Point(15, 40);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(95, 28);
            this.rbCodigo.TabIndex = 0;
            this.rbCodigo.Text = "Código:";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.rbCodigo_CheckedChanged);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(471, 588);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(101, 40);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(737, 588);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(101, 40);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(602, 588);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 40);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // frmNovoProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(897, 638);
            this.Controls.Add(this.grbDetalhes);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGravar);
            this.Name = "frmNovoProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.grbDetalhes.ResumeLayout(false);
            this.grbDetalhes.PerformLayout();
            this.grbSituacao.ResumeLayout(false);
            this.grbSituacao.PerformLayout();
            this.grbValores.ResumeLayout(false);
            this.grbPreçoCusto.ResumeLayout(false);
            this.grbPreçoCusto.PerformLayout();
            this.grbPreços.ResumeLayout(false);
            this.grbPreços.PerformLayout();
            this.grbDtOfertas.ResumeLayout(false);
            this.grbDtOfertas.PerformLayout();
            this.grbDesc.ResumeLayout(false);
            this.grbDesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDetalhes;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEan;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.RadioButton rbEan;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.GroupBox grbDesc;
        private System.Windows.Forms.Button btnSelecImg;
        private System.Windows.Forms.PictureBox pcbImagem;
        private System.Windows.Forms.GroupBox grbValores;
        private System.Windows.Forms.RadioButton rbVlrVenda;
        private System.Windows.Forms.RadioButton rbVlrOferta;
        private System.Windows.Forms.GroupBox grbPreços;
        private System.Windows.Forms.GroupBox grbDtOfertas;
        private System.Windows.Forms.Label lblDtFim;
        private System.Windows.Forms.Label lblDtInicio;
        private System.Windows.Forms.GroupBox grbSituacao;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Label lblImagem;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblNomeForn;
        private System.Windows.Forms.Label lblCodForn;
        private System.Windows.Forms.TextBox txtNomeForn;
        private System.Windows.Forms.TextBox txtCodForn;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.GroupBox grbPreçoCusto;
        private System.Windows.Forms.Label lblPreçoCusto;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox mtxtPreçoCusto;
        private System.Windows.Forms.MaskedTextBox mtxtVlrOferta;
        private System.Windows.Forms.MaskedTextBox mtxtVlrVenda;
    }
}