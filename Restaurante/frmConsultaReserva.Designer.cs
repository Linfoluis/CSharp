namespace Principal
{
    partial class frmConsultaReserva
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblNroMesa4L = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCodReserva = new System.Windows.Forms.Label();
            this.txtCodReserva = new System.Windows.Forms.TextBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDtReserva = new System.Windows.Forms.Label();
            this.txtNroPessoas = new System.Windows.Forms.TextBox();
            this.lblNroPessoas = new System.Windows.Forms.Label();
            this.grbDadosMesa = new System.Windows.Forms.GroupBox();
            this.mtxtHorario = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDtReserva = new System.Windows.Forms.MaskedTextBox();
            this.lblNroMesa2L = new System.Windows.Forms.Label();
            this.txtNroMesa2L = new System.Windows.Forms.TextBox();
            this.txtNroMesa4L = new System.Windows.Forms.TextBox();
            this.grbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.grbDadosMesa.SuspendLayout();
            this.grbDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(401, 375);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(92, 41);
            this.btnImprimir.TabIndex = 8;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // lblNroMesa4L
            // 
            this.lblNroMesa4L.AutoSize = true;
            this.lblNroMesa4L.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroMesa4L.Location = new System.Drawing.Point(224, 131);
            this.lblNroMesa4L.Name = "lblNroMesa4L";
            this.lblNroMesa4L.Size = new System.Drawing.Size(125, 24);
            this.lblNroMesa4L.TabIndex = 7;
            this.lblNroMesa4L.Text = "Nro. Mesa 4L:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(555, 375);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(92, 41);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblCodReserva
            // 
            this.lblCodReserva.AutoSize = true;
            this.lblCodReserva.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodReserva.Location = new System.Drawing.Point(6, 34);
            this.lblCodReserva.Name = "lblCodReserva";
            this.lblCodReserva.Size = new System.Drawing.Size(124, 24);
            this.lblCodReserva.TabIndex = 9;
            this.lblCodReserva.Text = "Cod. Reserva:";
            // 
            // txtCodReserva
            // 
            this.txtCodReserva.Enabled = false;
            this.txtCodReserva.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodReserva.Location = new System.Drawing.Point(135, 35);
            this.txtCodReserva.MaxLength = 8;
            this.txtCodReserva.Name = "txtCodReserva";
            this.txtCodReserva.Size = new System.Drawing.Size(112, 28);
            this.txtCodReserva.TabIndex = 8;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(292, 80);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(80, 24);
            this.lblHorario.TabIndex = 7;
            this.lblHorario.Text = "Horário:";
            // 
            // lblDtReserva
            // 
            this.lblDtReserva.AutoSize = true;
            this.lblDtReserva.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtReserva.Location = new System.Drawing.Point(6, 80);
            this.lblDtReserva.Name = "lblDtReserva";
            this.lblDtReserva.Size = new System.Drawing.Size(152, 24);
            this.lblDtReserva.TabIndex = 7;
            this.lblDtReserva.Text = "Data da Reserva:";
            // 
            // txtNroPessoas
            // 
            this.txtNroPessoas.Enabled = false;
            this.txtNroPessoas.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroPessoas.Location = new System.Drawing.Point(136, 132);
            this.txtNroPessoas.MaxLength = 2;
            this.txtNroPessoas.Name = "txtNroPessoas";
            this.txtNroPessoas.Size = new System.Drawing.Size(68, 28);
            this.txtNroPessoas.TabIndex = 6;
            // 
            // lblNroPessoas
            // 
            this.lblNroPessoas.AutoSize = true;
            this.lblNroPessoas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroPessoas.Location = new System.Drawing.Point(7, 131);
            this.lblNroPessoas.Name = "lblNroPessoas";
            this.lblNroPessoas.Size = new System.Drawing.Size(123, 24);
            this.lblNroPessoas.TabIndex = 9;
            this.lblNroPessoas.Text = "Nro. Pessoas:";
            // 
            // grbDadosMesa
            // 
            this.grbDadosMesa.Controls.Add(this.mtxtHorario);
            this.grbDadosMesa.Controls.Add(this.mtxtDtReserva);
            this.grbDadosMesa.Controls.Add(this.lblNroMesa2L);
            this.grbDadosMesa.Controls.Add(this.lblNroMesa4L);
            this.grbDadosMesa.Controls.Add(this.lblCodReserva);
            this.grbDadosMesa.Controls.Add(this.txtCodReserva);
            this.grbDadosMesa.Controls.Add(this.lblHorario);
            this.grbDadosMesa.Controls.Add(this.txtNroMesa2L);
            this.grbDadosMesa.Controls.Add(this.lblDtReserva);
            this.grbDadosMesa.Controls.Add(this.txtNroMesa4L);
            this.grbDadosMesa.Controls.Add(this.txtNroPessoas);
            this.grbDadosMesa.Controls.Add(this.lblNroPessoas);
            this.grbDadosMesa.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDadosMesa.Location = new System.Drawing.Point(12, 171);
            this.grbDadosMesa.Name = "grbDadosMesa";
            this.grbDadosMesa.Size = new System.Drawing.Size(679, 174);
            this.grbDadosMesa.TabIndex = 6;
            this.grbDadosMesa.TabStop = false;
            this.grbDadosMesa.Text = "Dados da Mesa";
            // 
            // mtxtHorario
            // 
            this.mtxtHorario.Enabled = false;
            this.mtxtHorario.Location = new System.Drawing.Point(372, 81);
            this.mtxtHorario.Mask = "00:00";
            this.mtxtHorario.Name = "mtxtHorario";
            this.mtxtHorario.Size = new System.Drawing.Size(76, 28);
            this.mtxtHorario.TabIndex = 10;
            // 
            // mtxtDtReserva
            // 
            this.mtxtDtReserva.Enabled = false;
            this.mtxtDtReserva.Location = new System.Drawing.Point(160, 81);
            this.mtxtDtReserva.Mask = "00/00/0000";
            this.mtxtDtReserva.Name = "mtxtDtReserva";
            this.mtxtDtReserva.Size = new System.Drawing.Size(117, 28);
            this.mtxtDtReserva.TabIndex = 10;
            // 
            // lblNroMesa2L
            // 
            this.lblNroMesa2L.AutoSize = true;
            this.lblNroMesa2L.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroMesa2L.Location = new System.Drawing.Point(438, 131);
            this.lblNroMesa2L.Name = "lblNroMesa2L";
            this.lblNroMesa2L.Size = new System.Drawing.Size(125, 24);
            this.lblNroMesa2L.TabIndex = 7;
            this.lblNroMesa2L.Text = "Nro. Mesa 2L:";
            // 
            // txtNroMesa2L
            // 
            this.txtNroMesa2L.Enabled = false;
            this.txtNroMesa2L.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroMesa2L.Location = new System.Drawing.Point(569, 132);
            this.txtNroMesa2L.MaxLength = 2;
            this.txtNroMesa2L.Name = "txtNroMesa2L";
            this.txtNroMesa2L.Size = new System.Drawing.Size(68, 28);
            this.txtNroMesa2L.TabIndex = 6;
            // 
            // txtNroMesa4L
            // 
            this.txtNroMesa4L.Enabled = false;
            this.txtNroMesa4L.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroMesa4L.Location = new System.Drawing.Point(355, 132);
            this.txtNroMesa4L.MaxLength = 2;
            this.txtNroMesa4L.Name = "txtNroMesa4L";
            this.txtNroMesa4L.Size = new System.Drawing.Size(68, 28);
            this.txtNroMesa4L.TabIndex = 6;
            // 
            // grbDadosPessoais
            // 
            this.grbDadosPessoais.Controls.Add(this.txtNome);
            this.grbDadosPessoais.Controls.Add(this.lblCelular);
            this.grbDadosPessoais.Controls.Add(this.mtxtCelular);
            this.grbDadosPessoais.Controls.Add(this.lblNome);
            this.grbDadosPessoais.Controls.Add(this.mtxtCpf);
            this.grbDadosPessoais.Controls.Add(this.lblCpf);
            this.grbDadosPessoais.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDadosPessoais.Location = new System.Drawing.Point(12, 23);
            this.grbDadosPessoais.Name = "grbDadosPessoais";
            this.grbDadosPessoais.Size = new System.Drawing.Size(624, 134);
            this.grbDadosPessoais.TabIndex = 9;
            this.grbDadosPessoais.TabStop = false;
            this.grbDadosPessoais.Text = "Dados Pessoais";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(88, 34);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(352, 28);
            this.txtNome.TabIndex = 4;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(245, 85);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(75, 24);
            this.lblCelular.TabIndex = 5;
            this.lblCelular.Text = "Celular:";
            // 
            // mtxtCelular
            // 
            this.mtxtCelular.Enabled = false;
            this.mtxtCelular.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCelular.Location = new System.Drawing.Point(325, 85);
            this.mtxtCelular.Mask = "(00) 00000-0000";
            this.mtxtCelular.Name = "mtxtCelular";
            this.mtxtCelular.Size = new System.Drawing.Size(147, 28);
            this.mtxtCelular.TabIndex = 8;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(16, 34);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(66, 24);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome:";
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.Enabled = false;
            this.mtxtCpf.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCpf.Location = new System.Drawing.Point(69, 81);
            this.mtxtCpf.Mask = "000,000,000-00";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(152, 28);
            this.mtxtCpf.TabIndex = 9;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(16, 83);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(47, 24);
            this.lblCpf.TabIndex = 7;
            this.lblCpf.Text = "CPF:";
            // 
            // frmConsultaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 428);
            this.Controls.Add(this.grbDadosPessoais);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.grbDadosMesa);
            this.Name = "frmConsultaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Reservas";
            this.grbDadosMesa.ResumeLayout(false);
            this.grbDadosMesa.PerformLayout();
            this.grbDadosPessoais.ResumeLayout(false);
            this.grbDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblNroMesa4L;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCodReserva;
        private System.Windows.Forms.TextBox txtCodReserva;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDtReserva;
        private System.Windows.Forms.TextBox txtNroPessoas;
        private System.Windows.Forms.Label lblNroPessoas;
        private System.Windows.Forms.GroupBox grbDadosMesa;
        private System.Windows.Forms.MaskedTextBox mtxtHorario;
        private System.Windows.Forms.MaskedTextBox mtxtDtReserva;
        private System.Windows.Forms.Label lblNroMesa2L;
        private System.Windows.Forms.TextBox txtNroMesa2L;
        private System.Windows.Forms.TextBox txtNroMesa4L;
        private System.Windows.Forms.GroupBox grbDadosPessoais;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.MaskedTextBox mtxtCelular;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MaskedTextBox mtxtCpf;
        private System.Windows.Forms.Label lblCpf;
    }
}