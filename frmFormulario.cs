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

        string operador;
        int variavel1;
        int variavel2;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnNumero1_Click(object sender, EventArgs e)
        {
            txtCaixa.Text = txtCaixa.Text + "1";
        }

        private void btnOperaçãoMulti_Click(object sender, EventArgs e)
        {
            this.operador = "*";
            this.variavel1 = Convert.ToInt32(txtCaixa.Text);
            txtCaixa.Text = "";
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

        private void btnOperaçãoMais_Click(object sender, EventArgs e)
        {
            this.operador = "+";
            this.variavel1 = Convert.ToInt32(txtCaixa.Text);
            txtCaixa.Text = "";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            this.variavel2 = Convert.ToInt32(txtCaixa.Text);
            if (this.operador == "+")
            {
                string resultado = (variavel1 + variavel2).ToString();
                txtCaixa.Text = resultado;
            }
            if (this.operador == "-")
            {
                string resultado = (variavel1 - variavel2).ToString();
                txtCaixa.Text = resultado;
            }
            if (this.operador == "*")
            {
                string resultado = (variavel1 * variavel2).ToString();
                txtCaixa.Text = resultado;
            }
            if (this.operador == "/")
            {
                string resultado = (variavel1 / variavel2).ToString();
                txtCaixa.Text = resultado;
            }
        }

        private void btnOperaçãoMenos_Click(object sender, EventArgs e)
        {
            this.operador = "-";
            this.variavel1 = Convert.ToInt32(txtCaixa.Text);
            txtCaixa.Text = "";
        }

        private void btnOperaçãoDividir_Click(object sender, EventArgs e)
        {
            this.operador = "/";
            this.variavel1 = Convert.ToInt32(txtCaixa.Text);
            txtCaixa.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCaixa.Text = "";
        }

        private void frmCalculadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void brnConversor_Click(object sender, EventArgs e)
        {
            frmConverteCelsiusFahrenheit formularioConverte = new frmConverteCelsiusFahrenheit();
            formularioConverte.ShowDialog();
        }

        private void btnConverteCM_Click(object sender, EventArgs e)
        {
            frmConverteCM formularioConverteCM = new frmConverteCM();
            formularioConverteCM.ShowDialog();
        }
    }
}
