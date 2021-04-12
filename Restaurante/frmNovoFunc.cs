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
    public partial class frmNovoFunc : Form
    {
        public frmNovoFunc()
        {
            InitializeComponent();
        }

        private void txtRg_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //VALIDAR NOME
            if (txtNome.Text == "") 
            {
                //mensagem da caixa de notificação, notificação, tipo de botões, icone

                MessageBox.Show("Campo Nome Obrigatório", "Preencher Nome", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //inserir cor de fundo no campo a validar
                txtNome.BackColor = Color.Yellow;
                //focar o ponteiro no campo 
                txtNome.Focus();
                return; 
            }

            //VALIDAR DATA NASCIMENTO
            if (mTxtDtNasc.Text.Trim().Length != 10)
            {
                MessageBox.Show("Campo Data de Nascimento Obrigatório", "Preencher Data de Nascimento", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                mTxtDtNasc.BackColor = Color.Yellow;
                mTxtDtNasc.Focus();

                return;
            }

            //VALIDAR RG
            if (mTxtRg.Text.Trim().Length != 13 )
            {
                MessageBox.Show("Campo RG Obrigatório", "Preencher RG", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                mTxtRg.BackColor = Color.Yellow;
                mTxtRg.Focus();

                return;
            }

            //VALIDAR SEXO
            if (rbMasc.Checked == false && rbFem.Checked == false)
            {
                MessageBox.Show("Favor Selecionar o Sexo", "Sexo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            //VALIDAR CPF
            //TRIM = tirar os espaços da direita e da esquerda  (que contam como caractere)
            if (mTxtCpf.Text.Trim().Length != 14)
            {
                MessageBox.Show("Campo CPF Obrigatório", "Preencher CPF", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                mTxtCpf.BackColor = Color.Yellow;
                mTxtCpf.Focus();

                return;
            }

            //VALIDAR TELEFONE
            if (mTxtTel.Text.Trim().Length != 9)
            {
                MessageBox.Show("Campo Telefone Obrigatório", "Preencher Telefone", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                mTxtTel.BackColor = Color.Yellow;
                mTxtTel.Focus();

                return;

            }

            //VALIDAR CARGO

            if (cmbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Campo Cargo Obrigatório", "Preencher Cargo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cmbCargo.BackColor = Color.Yellow;
                cmbCargo.Focus();

                return;
            }

            //VALIDAR STATUS
            if (rbAtivo.Checked == false && rbInativo.Checked == false)
            {
                MessageBox.Show("Favor Selecionar o Sexo", "Sexo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

     
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

        //PROPRIEDADES DATA NASCIMENTO
        private void mTxtDtNasc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            mTxtDtNasc.BackColor = Color.White;
        }


        //PROPRIEDADES RG
        private void mTxtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            mTxtRg.BackColor = Color.White;
        }

        //PROPRIEDADES CPF
        private void mTxtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            mTxtCpf.BackColor = Color.White;
        }

        //PROPRIEDADES TELEFONE
        private void mTxtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            mTxtTel.BackColor = Color.White;
        }

        //PROPRIEDADES CARGO
        private void cmbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCargo.BackColor = Color.Empty;
        }

        private void mTxtDtNasc_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cmbUf_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {


        }

       

     

       


        

        

        

        

        

        

        


    }
}
