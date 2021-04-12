namespace Principal
{
    partial class frmClienteFidel
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
            this.grbDtConsulta = new System.Windows.Forms.GroupBox();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblAte = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.lstvClienteFidel = new System.Windows.Forms.ListView();
            this.clhCpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNroReservas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.grbDtConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDtConsulta
            // 
            this.grbDtConsulta.Controls.Add(this.dtpAte);
            this.grbDtConsulta.Controls.Add(this.dtpDe);
            this.grbDtConsulta.Controls.Add(this.btnPesquisar);
            this.grbDtConsulta.Controls.Add(this.lblAte);
            this.grbDtConsulta.Controls.Add(this.lblDe);
            this.grbDtConsulta.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDtConsulta.Location = new System.Drawing.Point(12, 28);
            this.grbDtConsulta.Name = "grbDtConsulta";
            this.grbDtConsulta.Size = new System.Drawing.Size(662, 110);
            this.grbDtConsulta.TabIndex = 0;
            this.grbDtConsulta.TabStop = false;
            this.grbDtConsulta.Text = "Data da Consulta";
            // 
            // dtpAte
            // 
            this.dtpAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAte.Location = new System.Drawing.Point(242, 42);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(131, 28);
            this.dtpAte.TabIndex = 2;
            // 
            // dtpDe
            // 
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(50, 42);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(131, 28);
            this.dtpDe.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(445, 42);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(106, 37);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Location = new System.Drawing.Point(200, 45);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(39, 21);
            this.lblAte.TabIndex = 0;
            this.lblAte.Text = "Até:";
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(16, 44);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(35, 21);
            this.lblDe.TabIndex = 0;
            this.lblDe.Text = "De:";
            // 
            // lstvClienteFidel
            // 
            this.lstvClienteFidel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhCpf,
            this.clhNome,
            this.clhNroReservas,
            this.clhTel,
            this.clhEmail});
            this.lstvClienteFidel.FullRowSelect = true;
            this.lstvClienteFidel.GridLines = true;
            this.lstvClienteFidel.Location = new System.Drawing.Point(12, 159);
            this.lstvClienteFidel.Name = "lstvClienteFidel";
            this.lstvClienteFidel.Size = new System.Drawing.Size(827, 240);
            this.lstvClienteFidel.TabIndex = 2;
            this.lstvClienteFidel.UseCompatibleStateImageBehavior = false;
            this.lstvClienteFidel.View = System.Windows.Forms.View.Details;
            // 
            // clhCpf
            // 
            this.clhCpf.Text = "CPF";
            this.clhCpf.Width = 123;
            // 
            // clhNome
            // 
            this.clhNome.Text = "Nome";
            this.clhNome.Width = 232;
            // 
            // clhNroReservas
            // 
            this.clhNroReservas.Text = "Nro.Reservas";
            this.clhNroReservas.Width = 101;
            // 
            // clhTel
            // 
            this.clhTel.Text = "Telefone";
            this.clhTel.Width = 111;
            // 
            // clhEmail
            // 
            this.clhEmail.Text = "Email";
            this.clhEmail.Width = 247;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(682, 438);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(106, 41);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(534, 438);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(106, 41);
            this.btnVisualizar.TabIndex = 1;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(391, 438);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(106, 41);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // frmClienteFidel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(855, 491);
            this.Controls.Add(this.lstvClienteFidel);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.grbDtConsulta);
            this.Name = "frmClienteFidel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente Fidelidade";
            this.grbDtConsulta.ResumeLayout(false);
            this.grbDtConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDtConsulta;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ListView lstvClienteFidel;
        private System.Windows.Forms.ColumnHeader clhCpf;
        private System.Windows.Forms.ColumnHeader clhNome;
        private System.Windows.Forms.ColumnHeader clhNroReservas;
        private System.Windows.Forms.ColumnHeader clhTel;
        private System.Windows.Forms.ColumnHeader clhEmail;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.Button btnImprimir;
    }
}