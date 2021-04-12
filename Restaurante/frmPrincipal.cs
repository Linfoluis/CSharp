using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
          
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (frmPrincipal.ActiveForm.MdiChildren.Length > 0)
            {
                frmPrincipal.ActiveForm.ActiveMdiChild.Close();
            }
        }

        private void tstpCadFunc_Click(object sender, EventArgs e)
        {
            frmCadFunc frmFunc = new frmCadFunc();
            frmFunc.MdiParent = this;
            frmFunc.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadForn frmForn = new frmCadForn();
            frmForn.MdiParent = this;
            frmForn.Show();
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadProdutos frmProdutos = new frmCadProdutos();
            frmProdutos.MdiParent = this;
            frmProdutos.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
        }

        private void produtosMaisVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdMaisVend ProdMaisVend = new frmProdMaisVend();
            ProdMaisVend.MdiParent = this;
            ProdMaisVend.Show();
        }

        private void clienteFidelidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteFidel ClienteFidel = new frmClienteFidel();
            ClienteFidel.MdiParent = this;
            ClienteFidel.Show();
        }

        private void controleDeReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCtrlReservas CtrlReservas = new frmCtrlReservas();
            CtrlReservas.MdiParent = this;
            CtrlReservas.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = false;
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompras compras = new frmCompras();
            compras.MdiParent = this;
            compras.Show();
            
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendas Vendas = new frmVendas();
            Vendas.MdiParent = this;
            Vendas.Show(); 
        }

        private void fecharGuiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (frmPrincipal.ActiveForm.MdiChildren.Length > 0)
            {
                frmPrincipal.ActiveForm.ActiveMdiChild.Close();
            }

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            frmReservar reservar = new frmReservar();
            reservar.MdiParent = this;
            reservar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVendas Vendas = new frmVendas();
            Vendas.MdiParent = this;
            Vendas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCompras compras = new frmCompras();
            compras.MdiParent = this;
            compras.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCadForn frmForn = new frmCadForn();
            frmForn.MdiParent = this;
            frmForn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmCadProdutos frmProdutos = new frmCadProdutos();
            frmProdutos.MdiParent = this;
            frmProdutos.Show();
        }

        private void reservarMesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservar reservar = new frmReservar();
            reservar.MdiParent = this;
            reservar.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHora.Text = DateTime.Now.ToLongTimeString(); 
        }
        

    }
}

