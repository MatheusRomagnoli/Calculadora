namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            textoCarregando = new Label();
            progressBar1 = new ProgressBar();
            timerBarra = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.macaco_gif;
            pictureBox1.Location = new Point(-11, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(819, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textoCarregando
            // 
            textoCarregando.AutoSize = true;
            textoCarregando.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            textoCarregando.Location = new Point(12, 9);
            textoCarregando.Name = "textoCarregando";
            textoCarregando.Size = new Size(401, 72);
            textoCarregando.TabIndex = 1;
            textoCarregando.Text = "CARREGANDO";
            textoCarregando.Click += label1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 84);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(761, 65);
            progressBar1.TabIndex = 2;
            // 
            // timerBarra
            // 
            timerBarra.Enabled = true;
            timerBarra.Interval = 900;
            timerBarra.Tick += timerBarra_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(textoCarregando);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label textoCarregando;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timerBarra;
    }
}
