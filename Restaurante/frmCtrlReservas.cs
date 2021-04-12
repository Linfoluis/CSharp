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
    public partial class frmCtrlReservas : Form
    {
        public frmCtrlReservas()
        {
            InitializeComponent();
        }

        private void rbDataAp_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataAp.Enabled = true;
            dtpDataIn.Enabled = false;
            dtpDataFim.Enabled = false;
        }

        private void rdDataInFim_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataAp.Enabled = false;
            dtpDataIn.Enabled = true;
            dtpDataFim.Enabled = true;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string[] mItems = new string[] 
            { 

            dtpDataAp.Value.ToString(),
            dtpDataIn.Value.ToString(),
            dtpDataFim.Value.ToString(),
            cmbQtdMesas.SelectedItem.ToString(),
            cmbMesa2L.SelectedItem.ToString(),
            cmbMesa4L.SelectedItem.ToString()
           
            };

            ListViewItem lvi = new ListViewItem(mItems);
            lstvReservas.Items.Add(lvi);

            
        }

        private void lstvReservas_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpDataAp.Text = lstvReservas.FocusedItem.SubItems[0].Text;
            dtpDataIn.Text = lstvReservas.FocusedItem.SubItems[0].Text;
            dtpDataFim.Text = lstvReservas.FocusedItem.SubItems[0].Text;
            cmbQtdMesas.Text = lstvReservas.FocusedItem.SubItems[4].Text;
            cmbMesa2L.Text = lstvReservas.FocusedItem.SubItems[5].Text;
            cmbMesa4L.Text = lstvReservas.FocusedItem.SubItems[6].Text;
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
