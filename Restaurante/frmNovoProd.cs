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
    public partial class frmNovoProd : Form
    {
        public frmNovoProd()
        {
            InitializeComponent();
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtEan.Enabled = false;
        }

        private void rbEan_CheckedChanged(object sender, EventArgs e)
        {
            txtEan.Enabled = true;
            txtCodigo.Enabled = false;
        }

        private void rbVlrOferta_CheckedChanged(object sender, EventArgs e)
        {
            mtxtVlrOferta.Enabled = true;
            mtxtVlrVenda.Enabled = false;
            dtpInicio.Enabled = true;
            dtpFim.Enabled = true;
         
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtEan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void lsbDesc_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtVlrVenda_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtVlrOferta_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void rbVlrVenda_CheckedChanged(object sender, EventArgs e)
        {
            mtxtVlrVenda.Enabled = true;
            mtxtVlrOferta.Enabled = false;
            dtpInicio.Enabled = false;
            dtpFim.Enabled = false;
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddGrupo frmGrupo = new frmAddGrupo();
            frmGrupo.Show();

            if (txtNome.TextLength >0)
            {
                cmbGrupo.Items.Add(txtNome.ToString().Trim());



            }
        }

        private void txtCodForn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void mtxtPreçoCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

     
        }
    }

