namespace Principal
{
    partial class frmNovoFunc
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
            this.grbDadosPes = new System.Windows.Forms.GroupBox();
            this.mTxtCel = new System.Windows.Forms.MaskedTextBox();
            this.mTxtTel = new System.Windows.Forms.MaskedTextBox();
            this.mTxtRg = new System.Windows.Forms.MaskedTextBox();
            this.mTxtDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.mTxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.rbFem = new System.Windows.Forms.RadioButton();
            this.rbMasc = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grbDadosCom = new System.Windows.Forms.GroupBox();
            this.mtxtSalario = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.grbStatus = new System.Windows.Forms.GroupBox();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.lblSalario = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCargHor = new System.Windows.Forms.TextBox();
            this.lblCargHor = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grbDadosPes.SuspendLayout();
            this.grbDadosCom.SuspendLayout();
            this.grbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDadosPes
            // 
            this.grbDadosPes.Controls.Add(this.mTxtCel);
            this.grbDadosPes.Controls.Add(this.mTxtTel);
            this.grbDadosPes.Controls.Add(this.mTxtRg);
            this.grbDadosPes.Controls.Add(this.mTxtDtNasc);
            this.grbDadosPes.Controls.Add(this.mTxtCpf);
            this.grbDadosPes.Controls.Add(this.rbFem);
            this.grbDadosPes.Controls.Add(this.rbMasc);
            this.grbDadosPes.Controls.Add(this.txtNome);
            this.grbDadosPes.Controls.Add(this.lblNome);
            this.grbDadosPes.Controls.Add(this.lblCel);
            this.grbDadosPes.Controls.Add(this.lblTel);
            this.grbDadosPes.Controls.Add(this.lblCpf);
            this.grbDadosPes.Controls.Add(this.lblSexo);
            this.grbDadosPes.Controls.Add(this.lblRg);
            this.grbDadosPes.Controls.Add(this.lblDtNasc);
            this.grbDadosPes.Controls.Add(this.txtCodigo);
            this.grbDadosPes.Controls.Add(this.lblCodigo);
            this.grbDadosPes.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDadosPes.Location = new System.Drawing.Point(12, 14);
            this.grbDadosPes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDadosPes.Name = "grbDadosPes";
            this.grbDadosPes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDadosPes.Size = new System.Drawing.Size(845, 188);
            this.grbDadosPes.TabIndex = 0;
            this.grbDadosPes.TabStop = false;
            this.grbDadosPes.Text = "Dados Pessoais";
            // 
            // mTxtCel
            // 
            this.mTxtCel.Location = new System.Drawing.Point(564, 137);
            this.mTxtCel.Mask = "(00) 00000-0000";
            this.mTxtCel.Name = "mTxtCel";
            this.mTxtCel.Size = new System.Drawing.Size(149, 28);
            this.mTxtCel.TabIndex = 5;
            // 
            // mTxtTel
            // 
            this.mTxtTel.Location = new System.Drawing.Point(325, 136);
            this.mTxtTel.Mask = "(00) 0000-0000";
            this.mTxtTel.Name = "mTxtTel";
            this.mTxtTel.Size = new System.Drawing.Size(149, 28);
            this.mTxtTel.TabIndex = 5;
            this.mTxtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mTxtTel_KeyPress);
            // 
            // mTxtRg
            // 
            this.mTxtRg.Location = new System.Drawing.Point(366, 90);
            this.mTxtRg.Mask = "00,000,000-AA";
            this.mTxtRg.Name = "mTxtRg";
            this.mTxtRg.Size = new System.Drawing.Size(146, 28);
            this.mTxtRg.TabIndex = 5;
            this.mTxtRg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mTxtRg_KeyPress);
            // 
            // mTxtDtNasc
            // 
            this.mTxtDtNasc.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtDtNasc.Location = new System.Drawing.Point(195, 89);
            this.mTxtDtNasc.Mask = "00/00/0000";
            this.mTxtDtNasc.Name = "mTxtDtNasc";
            this.mTxtDtNasc.Size = new System.Drawing.Size(110, 29);
            this.mTxtDtNasc.TabIndex = 4;
            // 
            // mTxtCpf
            // 
            this.mTxtCpf.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTxtCpf.Location = new System.Drawing.Point(67, 137);
            this.mTxtCpf.Mask = "000,000,000-00";
            this.mTxtCpf.Name = "mTxtCpf";
            this.mTxtCpf.Size = new System.Drawing.Size(149, 29);
            this.mTxtCpf.TabIndex = 4;
            this.mTxtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mTxtCpf_KeyPress);
            // 
            // rbFem
            // 
            this.rbFem.AutoSize = true;
            this.rbFem.Location = new System.Drawing.Point(701, 91);
            this.rbFem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFem.Name = "rbFem";
            this.rbFem.Size = new System.Drawing.Size(97, 25);
            this.rbFem.TabIndex = 1;
            this.rbFem.Text = "Feminino";
            this.rbFem.UseVisualStyleBackColor = true;
            // 
            // rbMasc
            // 
            this.rbMasc.AutoSize = true;
            this.rbMasc.Location = new System.Drawing.Point(591, 91);
            this.rbMasc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMasc.Name = "rbMasc";
            this.rbMasc.Size = new System.Drawing.Size(103, 25);
            this.rbMasc.TabIndex = 1;
            this.rbMasc.Text = "Masculino";
            this.rbMasc.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(288, 39);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(385, 28);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(208, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(76, 23);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "* Nome:";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCel.Location = new System.Drawing.Point(488, 138);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(71, 23);
            this.lblCel.TabIndex = 0;
            this.lblCel.Text = "Celular:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(226, 138);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(96, 23);
            this.lblTel.TabIndex = 0;
            this.lblTel.Text = "* Telefone:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(7, 138);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(57, 23);
            this.lblCpf.TabIndex = 0;
            this.lblCpf.Text = "* CPF:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(525, 90);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(66, 23);
            this.lblSexo.TabIndex = 0;
            this.lblSexo.Text = "* Sexo:";
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRg.Location = new System.Drawing.Point(311, 90);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(51, 23);
            this.lblRg.TabIndex = 0;
            this.lblRg.Text = "* RG:";
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtNasc.Location = new System.Drawing.Point(7, 90);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(188, 23);
            this.lblDtNasc.TabIndex = 0;
            this.lblDtNasc.Text = "* Data de Nascimento:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(83, 39);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(105, 28);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(7, 39);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(69, 23);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // grbDadosCom
            // 
            this.grbDadosCom.Controls.Add(this.mtxtSalario);
            this.grbDadosCom.Controls.Add(this.label16);
            this.grbDadosCom.Controls.Add(this.grbStatus);
            this.grbDadosCom.Controls.Add(this.lblSalario);
            this.grbDadosCom.Controls.Add(this.cmbCargo);
            this.grbDadosCom.Controls.Add(this.lblCargo);
            this.grbDadosCom.Controls.Add(this.txtCargHor);
            this.grbDadosCom.Controls.Add(this.lblCargHor);
            this.grbDadosCom.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDadosCom.Location = new System.Drawing.Point(12, 211);
            this.grbDadosCom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDadosCom.Name = "grbDadosCom";
            this.grbDadosCom.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDadosCom.Size = new System.Drawing.Size(845, 151);
            this.grbDadosCom.TabIndex = 4;
            this.grbDadosCom.TabStop = false;
            this.grbDadosCom.Text = "Dados Comerciais";
            // 
            // mtxtSalario
            // 
            this.mtxtSalario.Enabled = false;
            this.mtxtSalario.Location = new System.Drawing.Point(93, 99);
            this.mtxtSalario.Mask = "$ 00,000.00";
            this.mtxtSalario.Name = "mtxtSalario";
            this.mtxtSalario.Size = new System.Drawing.Size(112, 28);
            this.mtxtSalario.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(386, 106);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(437, 20);
            this.label16.TabIndex = 41;
            this.label16.Text = "Campos com (*) são de preenchimento obrigatório.";
            // 
            // grbStatus
            // 
            this.grbStatus.Controls.Add(this.rbAtivo);
            this.grbStatus.Controls.Add(this.rbInativo);
            this.grbStatus.Location = new System.Drawing.Point(529, 19);
            this.grbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.grbStatus.Name = "grbStatus";
            this.grbStatus.Padding = new System.Windows.Forms.Padding(4);
            this.grbStatus.Size = new System.Drawing.Size(287, 70);
            this.grbStatus.TabIndex = 7;
            this.grbStatus.TabStop = false;
            this.grbStatus.Text = "* Status";
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Location = new System.Drawing.Point(33, 30);
            this.rbAtivo.Margin = new System.Windows.Forms.Padding(4);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(67, 25);
            this.rbAtivo.TabIndex = 6;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(135, 30);
            this.rbInativo.Margin = new System.Windows.Forms.Padding(4);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(80, 25);
            this.rbInativo.TabIndex = 6;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(19, 100);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(69, 23);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salário:";
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.DropDownWidth = 177;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.ItemHeight = 21;
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
            this.cmbCargo.Location = new System.Drawing.Point(95, 41);
            this.cmbCargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(177, 29);
            this.cmbCargo.TabIndex = 3;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(19, 42);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(73, 23);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "* Cargo:";
            // 
            // txtCargHor
            // 
            this.txtCargHor.Enabled = false;
            this.txtCargHor.Location = new System.Drawing.Point(428, 41);
            this.txtCargHor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCargHor.MaxLength = 4;
            this.txtCargHor.Name = "txtCargHor";
            this.txtCargHor.Size = new System.Drawing.Size(85, 28);
            this.txtCargHor.TabIndex = 1;
            this.txtCargHor.TextChanged += new System.EventHandler(this.txtRg_TextChanged);
            // 
            // lblCargHor
            // 
            this.lblCargHor.AutoSize = true;
            this.lblCargHor.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargHor.Location = new System.Drawing.Point(300, 42);
            this.lblCargHor.Name = "lblCargHor";
            this.lblCargHor.Size = new System.Drawing.Size(122, 23);
            this.lblCargHor.TabIndex = 0;
            this.lblCargHor.Text = "Carga Horária:";
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(451, 391);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 39);
            this.btnGravar.TabIndex = 5;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(721, 391);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(104, 39);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(585, 391);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 39);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmNovoFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(877, 444);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.grbDadosCom);
            this.Controls.Add(this.grbDadosPes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmNovoFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionário";
            this.grbDadosPes.ResumeLayout(false);
            this.grbDadosPes.PerformLayout();
            this.grbDadosCom.ResumeLayout(false);
            this.grbDadosCom.PerformLayout();
            this.grbStatus.ResumeLayout(false);
            this.grbStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDadosPes;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.RadioButton rbFem;
        private System.Windows.Forms.RadioButton rbMasc;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.GroupBox grbDadosCom;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCargHor;
        private System.Windows.Forms.Label lblCargHor;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox grbStatus;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox mTxtCpf;
        private System.Windows.Forms.MaskedTextBox mTxtRg;
        private System.Windows.Forms.MaskedTextBox mTxtCel;
        private System.Windows.Forms.MaskedTextBox mTxtTel;
        private System.Windows.Forms.MaskedTextBox mTxtDtNasc;
        private System.Windows.Forms.MaskedTextBox mtxtSalario;
    }
}