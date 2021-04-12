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
    public partial class frmAddGrupo : Form
    {
        public frmAddGrupo()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //VALIDAÇÃO NOME
            if (txtNome.Text == "")
            {
                MessageBox.Show("Campo Nome Obrigatório", "Preencher Nome", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.BackColor = Color.Yellow;
                txtNome.Focus();
                return;
            }

            string[] mItems = new string[] 
            { 
                txtNome.Text,
            };

            ListViewItem lvi = new ListViewItem(mItems);
            lstvGrupo.Items.Add(lvi);

            txtNome.Clear();

            }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            {
                txtNome.Text = lstvGrupo.FocusedItem.SubItems[0].Text;
                
            }

      

          
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //PROPRIEDADES NOME
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            txtNome.BackColor = Color.White;
        }

    











    }
}
