namespace Principal
{
    partial class frmCtrlReservas
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
            this.lblData = new System.Windows.Forms.Label();
            this.grbDadosBusc = new System.Windows.Forms.GroupBox();
            this.dtpDataA = new System.Windows.Forms.DateTimePicker();
            this.dtpDataDe = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblDataA = new System.Windows.Forms.Label();
            this.lstvReservas = new System.Windows.Forms.ListView();
            this.clhData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhNroReserv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh2L = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh4L = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhMesasDisp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh2LDisp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clh4LDisp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbParam = new System.Windows.Forms.GroupBox();
            this.grbPeriodo = new System.Windows.Forms.GroupBox();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.dtpDataIn = new System.Windows.Forms.DateTimePicker();
            this.dtpDataAp = new System.Windows.Forms.DateTimePicker();
            this.rdDataInFim = new System.Windows.Forms.RadioButton();
            this.rbDataAp = new System.Windows.Forms.RadioButton();
            this.grbMesasDisp = new System.Windows.Forms.GroupBox();
            this.cmbMesa4L = new System.Windows.Forms.ComboBox();
            this.cmbQtdMesas = new System.Windows.Forms.ComboBox();
            this.cmbMesa2L = new System.Windows.Forms.ComboBox();
            this.lblMesa4L = new System.Windows.Forms.Label();
            this.lblQtdMesas = new System.Windows.Forms.Label();
            this.lblMesa2L = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.grbDadosBusc.SuspendLayout();
            this.grbParam.SuspendLayout();
            this.grbPeriodo.SuspendLayout();
            this.grbMesasDisp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(35, 29);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(56, 24);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data:";
            // 
            // grbDadosBusc
            // 
            this.grbDadosBusc.Controls.Add(this.dtpDataA);
            this.grbDadosBusc.Controls.Add(this.dtpDataDe);
            this.grbDadosBusc.Controls.Add(this.btnBuscar);
            this.grbDadosBusc.Controls.Add(this.lblDataA);
            this.grbDadosBusc.Controls.Add(this.lblData);
            this.grbDadosBusc.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDadosBusc.Location = new System.Drawing.Point(36, 4);
            this.grbDadosBusc.Name = "grbDadosBusc";
            this.grbDadosBusc.Size = new System.Drawing.Size(663, 86);
            this.grbDadosBusc.TabIndex = 1;
            this.grbDadosBusc.TabStop = false;
            this.grbDadosBusc.Text = "Pesquisa";
            // 
            // dtpDataA
            // 
            this.dtpDataA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataA.Location = new System.Drawing.Point(286, 30);
            this.dtpDataA.Name = "dtpDataA";
            this.dtpDataA.Size = new System.Drawing.Size(137, 28);
            this.dtpDataA.TabIndex = 4;
            // 
            // dtpDataDe
            // 
            this.dtpDataDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDe.Location = new System.Drawing.Point(94, 29);
            this.dtpDataDe.Name = "dtpDataDe";
            this.dtpDataDe.Size = new System.Drawing.Size(137, 28);
            this.dtpDataDe.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(534, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 35);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblDataA
            // 
            this.lblDataA.AutoSize = true;
            this.lblDataA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataA.Location = new System.Drawing.Point(245, 30);
            this.lblDataA.Name = "lblDataA";
            this.lblDataA.Size = new System.Drawing.Size(22, 24);
            this.lblDataA.TabIndex = 2;
            this.lblDataA.Text = "A";
            // 
            // lstvReservas
            // 
            this.lstvReservas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhData,
            this.clhNroReserv,
            this.clh2L,
            this.clh4L,
            this.clhMesasDisp,
            this.clh2LDisp,
            this.clh4LDisp});
            this.lstvReservas.FullRowSelect = true;
            this.lstvReservas.GridLines = true;
            this.lstvReservas.Location = new System.Drawing.Point(36, 108);
            this.lstvReservas.Name = "lstvReservas";
            this.lstvReservas.Size = new System.Drawing.Size(663, 236);
            this.lstvReservas.TabIndex = 2;
            this.lstvReservas.UseCompatibleStateImageBehavior = false;
            this.lstvReservas.View = System.Windows.Forms.View.Details;
            this.lstvReservas.SelectedIndexChanged += new System.EventHandler(this.lstvReservas_SelectedIndexChanged);
            // 
            // clhData
            // 
            this.clhData.Text = "Data";
            this.clhData.Width = 90;
            // 
            // clhNroReserv
            // 
            this.clhNroReserv.Text = "Nro. de Reservas";
            this.clhNroReserv.Width = 120;
            // 
            // clh2L
            // 
            this.clh2L.Text = "Mesa 2L Reserv.";
            this.clh2L.Width = 127;
            // 
            // clh4L
            // 
            this.clh4L.Text = "Mesa 4L Reserv.";
            this.clh4L.Width = 125;
            // 
            // clhMesasDisp
            // 
            this.clhMesasDisp.Text = "Mesas Disponíveis";
            this.clhMesasDisp.Width = 141;
            // 
            // clh2LDisp
            // 
            this.clh2LDisp.Text = "2L Disponivel";
            // 
            // clh4LDisp
            // 
            this.clh4LDisp.Text = "4L Disponivel";
            // 
            // grbParam
            // 
            this.grbParam.Controls.Add(this.grbPeriodo);
            this.grbParam.Controls.Add(this.grbMesasDisp);
            this.grbParam.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbParam.Location = new System.Drawing.Point(36, 352);
            this.grbParam.Name = "grbParam";
            this.grbParam.Size = new System.Drawing.Size(663, 204);
            this.grbParam.TabIndex = 3;
            this.grbParam.TabStop = false;
            this.grbParam.Text = "Parâmetros";
            // 
            // grbPeriodo
            // 
            this.grbPeriodo.Controls.Add(this.dtpDataFim);
            this.grbPeriodo.Controls.Add(this.dtpDataIn);
            this.grbPeriodo.Controls.Add(this.dtpDataAp);
            this.grbPeriodo.Controls.Add(this.rdDataInFim);
            this.grbPeriodo.Controls.Add(this.rbDataAp);
            this.grbPeriodo.Location = new System.Drawing.Point(267, 24);
            this.grbPeriodo.Name = "grbPeriodo";
            this.grbPeriodo.Size = new System.Drawing.Size(376, 163);
            this.grbPeriodo.TabIndex = 1;
            this.grbPeriodo.TabStop = false;
            this.grbPeriodo.Text = "Período";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Enabled = false;
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFim.Location = new System.Drawing.Point(200, 96);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(137, 28);
            this.dtpDataFim.TabIndex = 4;
            // 
            // dtpDataIn
            // 
            this.dtpDataIn.Enabled = false;
            this.dtpDataIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataIn.Location = new System.Drawing.Point(200, 53);
            this.dtpDataIn.Name = "dtpDataIn";
            this.dtpDataIn.Size = new System.Drawing.Size(137, 28);
            this.dtpDataIn.TabIndex = 4;
            // 
            // dtpDataAp
            // 
            this.dtpDataAp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAp.Location = new System.Drawing.Point(35, 53);
            this.dtpDataAp.Name = "dtpDataAp";
            this.dtpDataAp.Size = new System.Drawing.Size(137, 28);
            this.dtpDataAp.TabIndex = 4;
            // 
            // rdDataInFim
            // 
            this.rdDataInFim.AutoSize = true;
            this.rdDataInFim.Location = new System.Drawing.Point(16, 100);
            this.rdDataInFim.Name = "rdDataInFim";
            this.rdDataInFim.Size = new System.Drawing.Size(166, 25);
            this.rdDataInFim.TabIndex = 0;
            this.rdDataInFim.TabStop = true;
            this.rdDataInFim.Text = "Data de Início/Fim:";
            this.rdDataInFim.UseVisualStyleBackColor = true;
            this.rdDataInFim.CheckedChanged += new System.EventHandler(this.rdDataInFim_CheckedChanged);
            // 
            // rbDataAp
            // 
            this.rbDataAp.AutoSize = true;
            this.rbDataAp.Location = new System.Drawing.Point(16, 22);
            this.rbDataAp.Name = "rbDataAp";
            this.rbDataAp.Size = new System.Drawing.Size(146, 25);
            this.rbDataAp.TabIndex = 0;
            this.rbDataAp.TabStop = true;
            this.rbDataAp.Text = "Data a partir de:";
            this.rbDataAp.UseVisualStyleBackColor = true;
            this.rbDataAp.CheckedChanged += new System.EventHandler(this.rbDataAp_CheckedChanged);
            // 
            // grbMesasDisp
            // 
            this.grbMesasDisp.Controls.Add(this.cmbMesa4L);
            this.grbMesasDisp.Controls.Add(this.cmbQtdMesas);
            this.grbMesasDisp.Controls.Add(this.cmbMesa2L);
            this.grbMesasDisp.Controls.Add(this.lblMesa4L);
            this.grbMesasDisp.Controls.Add(this.lblQtdMesas);
            this.grbMesasDisp.Controls.Add(this.lblMesa2L);
            this.grbMesasDisp.Location = new System.Drawing.Point(15, 24);
            this.grbMesasDisp.Name = "grbMesasDisp";
            this.grbMesasDisp.Size = new System.Drawing.Size(216, 163);
            this.grbMesasDisp.TabIndex = 0;
            this.grbMesasDisp.TabStop = false;
            this.grbMesasDisp.Text = "Mesas Disponíveis";
            // 
            // cmbMesa4L
            // 
            this.cmbMesa4L.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMesa4L.FormattingEnabled = true;
            this.cmbMesa4L.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbMesa4L.Location = new System.Drawing.Point(106, 120);
            this.cmbMesa4L.Name = "cmbMesa4L";
            this.cmbMesa4L.Size = new System.Drawing.Size(77, 29);
            this.cmbMesa4L.TabIndex = 1;
            // 
            // cmbQtdMesas
            // 
            this.cmbQtdMesas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQtdMesas.FormattingEnabled = true;
            this.cmbQtdMesas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbQtdMesas.Location = new System.Drawing.Point(106, 30);
            this.cmbQtdMesas.Name = "cmbQtdMesas";
            this.cmbQtdMesas.Size = new System.Drawing.Size(77, 29);
            this.cmbQtdMesas.TabIndex = 1;
            // 
            // cmbMesa2L
            // 
            this.cmbMesa2L.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMesa2L.FormattingEnabled = true;
            this.cmbMesa2L.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbMesa2L.Location = new System.Drawing.Point(106, 76);
            this.cmbMesa2L.Name = "cmbMesa2L";
            this.cmbMesa2L.Size = new System.Drawing.Size(77, 29);
            this.cmbMesa2L.TabIndex = 1;
            // 
            // lblMesa4L
            // 
            this.lblMesa4L.AutoSize = true;
            this.lblMesa4L.Location = new System.Drawing.Point(8, 120);
            this.lblMesa4L.Name = "lblMesa4L";
            this.lblMesa4L.Size = new System.Drawing.Size(82, 21);
            this.lblMesa4L.TabIndex = 0;
            this.lblMesa4L.Text = "4 Lugares:";
            // 
            // lblQtdMesas
            // 
            this.lblQtdMesas.AutoSize = true;
            this.lblQtdMesas.Location = new System.Drawing.Point(8, 30);
            this.lblQtdMesas.Name = "lblQtdMesas";
            this.lblQtdMesas.Size = new System.Drawing.Size(97, 21);
            this.lblQtdMesas.TabIndex = 0;
            this.lblQtdMesas.Text = "Qtd. Mesas:";
            // 
            // lblMesa2L
            // 
            this.lblMesa2L.AutoSize = true;
            this.lblMesa2L.Location = new System.Drawing.Point(8, 79);
            this.lblMesa2L.Name = "lblMesa2L";
            this.lblMesa2L.Size = new System.Drawing.Size(82, 21);
            this.lblMesa2L.TabIndex = 0;
            this.lblMesa2L.Text = "2 Lugares:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(592, 563);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 40);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(454, 563);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(91, 40);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // frmCtrlReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(742, 613);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.grbParam);
            this.Controls.Add(this.lstvReservas);
            this.Controls.Add(this.grbDadosBusc);
            this.Name = "frmCtrlReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Reservas";
            this.grbDadosBusc.ResumeLayout(false);
            this.grbDadosBusc.PerformLayout();
            this.grbParam.ResumeLayout(false);
            this.grbPeriodo.ResumeLayout(false);
            this.grbPeriodo.PerformLayout();
            this.grbMesasDisp.ResumeLayout(false);
            this.grbMesasDisp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.GroupBox grbDadosBusc;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblDataA;
        private System.Windows.Forms.ListView lstvReservas;
        private System.Windows.Forms.ColumnHeader clhData;
        private System.Windows.Forms.ColumnHeader clhNroReserv;
        private System.Windows.Forms.ColumnHeader clh2L;
        private System.Windows.Forms.ColumnHeader clhMesasDisp;
        private System.Windows.Forms.ColumnHeader clh4L;
        private System.Windows.Forms.GroupBox grbParam;
        private System.Windows.Forms.GroupBox grbMesasDisp;
        private System.Windows.Forms.ComboBox cmbMesa4L;
        private System.Windows.Forms.ComboBox cmbMesa2L;
        private System.Windows.Forms.Label lblMesa4L;
        private System.Windows.Forms.Label lblMesa2L;
        private System.Windows.Forms.GroupBox grbPeriodo;
        private System.Windows.Forms.RadioButton rdDataInFim;
        private System.Windows.Forms.RadioButton rbDataAp;
        private System.Windows.Forms.ComboBox cmbQtdMesas;
        private System.Windows.Forms.Label lblQtdMesas;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.DateTimePicker dtpDataA;
        private System.Windows.Forms.DateTimePicker dtpDataDe;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.DateTimePicker dtpDataIn;
        private System.Windows.Forms.DateTimePicker dtpDataAp;
        private System.Windows.Forms.ColumnHeader clh2LDisp;
        private System.Windows.Forms.ColumnHeader clh4LDisp;
    }
}

