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
    public partial class frmCadFunc : Form
    {
        public frmCadFunc()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
      
            frmNovoFunc NovoFunc = new frmNovoFunc();
            NovoFunc.Show();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != (char)8) 
            {  
            e.Handled = true; 
            }

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            frmNovoFunc frmVisualizar = new frmNovoFunc();
            frmVisualizar.Show();
        }

        private void frmCadFunc_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            for (int i = lstvFunc.SelectedItems.Count - 1; i >= 0; i--)
            {
                ListViewItem li = lstvFunc.SelectedItems[i];
                lstvFunc.Items.Remove(li);

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }  



    

   
        }
    }


