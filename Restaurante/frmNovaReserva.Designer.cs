namespace Principal
{
    partial class frmNovaReserva
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
            this.grbDadosMesa = new System.Windows.Forms.GroupBox();
            this.grbDisponib = new System.Windows.Forms.GroupBox();
            this.cmbNroMesas2L = new System.Windows.Forms.ComboBox();
            this.cmbNroMesa4L = new System.Windows.Forms.ComboBox();
            this.lblNroMesas2L = new System.Windows.Forms.Label();
            this.lblNroMesas4L = new System.Windows.Forms.Label();
            this.lblMesasDisp = new System.Windows.Forms.Label();
            this.txtMesasDisp = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtpHorario = new System.Windows.Forms.DateTimePicker();
            this.dtpDtReserva = new System.Windows.Forms.DateTimePicker();
            this.lblCodReserva = new System.Windows.Forms.Label();
            this.txtCodReserva = new System.Windows.Forms.TextBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblDtReserva = new System.Windows.Forms.Label();
            this.txtNroPessoas = new System.Windows.Forms.TextBox();
            this.lblNroPessoas = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.grbDadosMesa.SuspendLayout();
            this.grbDisponib.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDadosMesa
            // 
            this.grbDadosMesa.Controls.Add(this.grbDisponib);
            this.grbDadosMesa.Controls.Add(this.btnConsultar);
            this.grbDadosMesa.Controls.Add(this.dtpHorario);
            this.grbDadosMesa.Controls.Add(this.dtpDtReserva);
            this.grbDadosMesa.Controls.Add(this.lblCodReserva);
            this.grbDadosMesa.Controls.Add(this.txtCodReserva);
            this.grbDadosMesa.Controls.Add(this.lblHorario);
            this.grbDadosMesa.Controls.Add(this.lblDtReserva);
            this.grbDadosMesa.Controls.Add(this.txtNroPessoas);
            this.grbDadosMesa.Controls.Add(this.lblNroPessoas);
            this.grbDadosMesa.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDadosMesa.Location = new System.Drawing.Point(12, 6);
            this.grbDadosMesa.Name = "grbDadosMesa";
            this.grbDadosMesa.Size = new System.Drawing.Size(747, 263);
            this.grbDadosMesa.TabIndex = 1;
            this.grbDadosMesa.TabStop = false;
            this.grbDadosMesa.Text = "Dados da Mesa";
            // 
            // grbDisponib
            // 
            this.grbDisponib.Controls.Add(this.cmbNroMesas2L);
            this.grbDisponib.Controls.Add(this.cmbNroMesa4L);
            this.grbDisponib.Controls.Add(this.lblNroMesas2L);
            this.grbDisponib.Controls.Add(this.lblNroMesas4L);
            this.grbDisponib.Controls.Add(this.lblMesasDisp);
            this.grbDisponib.Controls.Add(this.txtMesasDisp);
            this.grbDisponib.Location = new System.Drawing.Point(401, 70);
            this.grbDisponib.Name = "grbDisponib";
            this.grbDisponib.Size = new System.Drawing.Size(325, 169);
            this.grbDisponib.TabIndex = 8;
            this.grbDisponib.TabStop = false;
            this.grbDisponib.Text = "Disponibilidade";
            // 
            // cmbNroMesas2L
            // 
            this.cmbNroMesas2L.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNroMesas2L.FormattingEnabled = true;
            this.cmbNroMesas2L.Location = new System.Drawing.Point(140, 124);
            this.cmbNroMesas2L.Name = "cmbNroMesas2L";
            this.cmbNroMesas2L.Size = new System.Drawing.Size(80, 29);
            this.cmbNroMesas2L.TabIndex = 8;
            // 
            // cmbNroMesa4L
            // 
            this.cmbNroMesa4L.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNroMesa4L.FormattingEnabled = true;
            this.cmbNroMesa4L.Location = new System.Drawing.Point(140, 80);
            this.cmbNroMesa4L.Name = "cmbNroMesa4L";
            this.cmbNroMesa4L.Size = new System.Drawing.Size(80, 29);
            this.cmbNroMesa4L.TabIndex = 8;
            // 
            // lblNroMesas2L
            // 
            this.lblNroMesas2L.AutoSize = true;
            this.lblNroMesas2L.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroMesas2L.Location = new System.Drawing.Point(12, 125);
            this.lblNroMesas2L.Name = "lblNroMesas2L";
            this.lblNroMesas2L.Size = new System.Drawing.Size(125, 24);
            this.lblNroMesas2L.TabIndex = 7;
            this.lblNroMesas2L.Text = "Nro. Mesa 2L:";
            // 
            // lblNroMesas4L
            // 
            this.lblNroMesas4L.AutoSize = true;
            this.lblNroMesas4L.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroMesas4L.Location = new System.Drawing.Point(12, 81);
            this.lblNroMesas4L.Name = "lblNroMesas4L";
            this.lblNroMesas4L.Size = new System.Drawing.Size(125, 24);
            this.lblNroMesas4L.TabIndex = 7;
            this.lblNroMesas4L.Text = "Nro. Mesa 4L:";
            // 
            // lblMesasDisp
            // 
            this.lblMesasDisp.AutoSize = true;
            this.lblMesasDisp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesasDisp.Location = new System.Drawing.Point(12, 35);
            this.lblMesasDisp.Name = "lblMesasDisp";
            this.lblMesasDisp.Size = new System.Drawing.Size(170, 24);
            this.lblMesasDisp.TabIndex = 7;
            this.lblMesasDisp.Text = "Mesas Disponíveis:";
            // 
            // txtMesasDisp
            // 
            this.txtMesasDisp.Enabled = false;
            this.txtMesasDisp.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesasDisp.Location = new System.Drawing.Point(185, 35);
            this.txtMesasDisp.MaxLength = 2;
            this.txtMesasDisp.Name = "txtMesasDisp";
            this.txtMesasDisp.Size = new System.Drawing.Size(72, 28);
            this.txtMesasDisp.TabIndex = 6;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(47, 211);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(92, 41);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpHorario
            // 
            this.dtpHorario.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHorario.Location = new System.Drawing.Point(98, 112);
            this.dtpHorario.Name = "dtpHorario";
            this.dtpHorario.ShowUpDown = true;
            this.dtpHorario.Size = new System.Drawing.Size(102, 28);
            this.dtpHorario.TabIndex = 0;
            this.dtpHorario.Value = new System.DateTime(2015, 11, 1, 20, 16, 0, 0);
            // 
            // dtpDtReserva
            // 
            this.dtpDtReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtReserva.Location = new System.Drawing.Point(170, 70);
            this.dtpDtReserva.Name = "dtpDtReserva";
            this.dtpDtReserva.Size = new System.Drawing.Size(134, 28);
            this.dtpDtReserva.TabIndex = 0;
            // 
            // lblCodReserva
            // 
            this.lblCodReserva.AutoSize = true;
            this.lblCodReserva.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodReserva.Location = new System.Drawing.Point(484, 27);
            this.lblCodReserva.Name = "lblCodReserva";
            this.lblCodReserva.Size = new System.Drawing.Size(124, 24);
            this.lblCodReserva.TabIndex = 9;
            this.lblCodReserva.Text = "Cod. Reserva:";
            // 
            // txtCodReserva
            // 
            this.txtCodReserva.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodReserva.Location = new System.Drawing.Point(613, 28);
            this.txtCodReserva.MaxLength = 8;
            this.txtCodReserva.Name = "txtCodReserva";
            this.txtCodReserva.Size = new System.Drawing.Size(112, 28);
            this.txtCodReserva.TabIndex = 8;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(16, 113);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(80, 24);
            this.lblHorario.TabIndex = 7;
            this.lblHorario.Text = "Horário:";
            // 
            // lblDtReserva
            // 
            this.lblDtReserva.AutoSize = true;
            this.lblDtReserva.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtReserva.Location = new System.Drawing.Point(16, 70);
            this.lblDtReserva.Name = "lblDtReserva";
            this.lblDtReserva.Size = new System.Drawing.Size(152, 24);
            this.lblDtReserva.TabIndex = 7;
            this.lblDtReserva.Text = "Data da Reserva:";
            // 
            // txtNroPessoas
            // 
            this.txtNroPessoas.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroPessoas.Location = new System.Drawing.Point(145, 159);
            this.txtNroPessoas.MaxLength = 2;
            this.txtNroPessoas.Name = "txtNroPessoas";
            this.txtNroPessoas.Size = new System.Drawing.Size(68, 28);
            this.txtNroPessoas.TabIndex = 6;
            this.txtNroPessoas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroPessoas_KeyPress);
            // 
            // lblNroPessoas
            // 
            this.lblNroPessoas.AutoSize = true;
            this.lblNroPessoas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroPessoas.Location = new System.Drawing.Point(16, 158);
            this.lblNroPessoas.Name = "lblNroPessoas";
            this.lblNroPessoas.Size = new System.Drawing.Size(123, 24);
            this.lblNroPessoas.TabIndex = 9;
            this.lblNroPessoas.Text = "Nro. Pessoas:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(622, 303);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 41);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(322, 303);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(135, 41);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // frmNovaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 356);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbDadosMesa);
            this.Name = "frmNovaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservar Nova Mesa";
            this.grbDadosMesa.ResumeLayout(false);
            this.grbDadosMesa.PerformLayout();
            this.grbDisponib.ResumeLayout(false);
            this.grbDisponib.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDadosMesa;
        private System.Windows.Forms.DateTimePicker dtpHorario;
        private System.Windows.Forms.DateTimePicker dtpDtReserva;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblDtReserva;
        private System.Windows.Forms.GroupBox grbDisponib;
        private System.Windows.Forms.ComboBox cmbNroMesas2L;
        private System.Windows.Forms.ComboBox cmbNroMesa4L;
        private System.Windows.Forms.Label lblNroMesas2L;
        private System.Windows.Forms.Label lblNroMesas4L;
        private System.Windows.Forms.Label lblMesasDisp;
        private System.Windows.Forms.TextBox txtMesasDisp;
        private System.Windows.Forms.TextBox txtNroPessoas;
        private System.Windows.Forms.Label lblNroPessoas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtCodReserva;
        private System.Windows.Forms.Label lblCodReserva;
        private System.Windows.Forms.Button btnConsultar;
    }
}