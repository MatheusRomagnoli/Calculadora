using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnNumero1_Click(object sender, EventArgs e)
        {
            txtCaixa.Text = txtCaixa.Text + "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {
            txtCaixa.Text = txtCaixa.Text + "2";
        }

        private void btnNumero3_Click(object sender, EventArgs e)
        {
            txtCaixa.Text = txtCaixa.Text + "3";
        }

        private void btnNumero4_Click(object sender, EventArgs e)
        {
            txtCaixa.Text = txtCaixa.Text + "4";
        }

        private void btnNumero5_Click(object sender, EventArgs e)
        {
            txtCaixa.Text = txtCaixa.Text + "5";
        }

        private void btnNumero6_Click(object sender, EventArgs e)
        {
            txtCaixa.Text = txtCaixa.Text + "6";
        }

        private void btnNumero7_Click(object sender, EventArgs e)
        {
            txtCaixa.Text = txtCaixa.Text + "7";
        }

        private void btnNumero8_Click(object sender, EventArgs e)
        {
            txtCaixa.Text = txtCaixa.Text + "8";
        }

        private void btnNumero9_Click(object sender, EventArgs e)
        {
            txtCaixa.Text = txtCaixa.Text + "9";
        }

        private void btnNumero0_Click(object sender, EventArgs e)
        {
            txtCaixa.Text = txtCaixa.Text + "0";
        }
    }
}
