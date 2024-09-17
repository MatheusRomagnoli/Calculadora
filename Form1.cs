using System.Security.Cryptography;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timerBarra_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 10;
            if (progressBar1.Value == 100)
            {
                timerBarra.Enabled = false;
                frmCalculadora frmcalc = new frmCalculadora();
                frmcalc.ShowDialog();
                
            }
        }
    }
}
