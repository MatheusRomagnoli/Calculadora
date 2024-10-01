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

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void tmrTempo_Tick(object sender, EventArgs e)
        {
            PBbarra.Value += 50;
            if (PBbarra.Value == 100)
            {
                tmrTempo.Enabled = false;
                new frmCalculadora().ShowDialog();
                this.Hide();
            }
        }
    }
}
