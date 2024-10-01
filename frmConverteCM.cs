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
    public partial class frmConverteCM : Form
    {
        public frmConverteCM()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConverteCM_Click(object sender, EventArgs e)
        {
            double cm = Convert.ToDouble(txtCentimetros.Text);
            double resultado = cm / 2.54;
            txtPolegada.Text = resultado.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCentimetros.Text = "";
            txtPolegada.Text = "";
        }
    }
}
