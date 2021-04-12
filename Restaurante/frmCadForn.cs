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
    public partial class frmCadForn : Form
    {
        public frmCadForn()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmNovoForn NovoForn = new frmNovoForn();
            NovoForn.Show();

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmNovoForn NovoDtlForn = new frmNovoForn();
            NovoDtlForn.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        //PROPRIEDADES CODIGO
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //PROPRIEDADES NOME
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
