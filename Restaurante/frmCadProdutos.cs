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
    public partial class frmCadProdutos : Form
    {
        public frmCadProdutos()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmNovoProd NovoProd = new frmNovoProd();
            NovoProd.Show();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmNovoProd frmDtlProd = new frmNovoProd();
            frmDtlProd.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            for (int i = lstvProdutos.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem li = lstvProdutos.SelectedItems[i];
                lstvProdutos.Items.Remove(li);

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      
    }
}
