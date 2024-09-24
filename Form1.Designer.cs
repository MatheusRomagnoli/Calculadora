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
            PBbarra = new ProgressBar();
            tmrTempo = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.macaco_gif;
            pictureBox1.Location = new Point(-14, 210);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1024, 360);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textoCarregando
            // 
            textoCarregando.AutoSize = true;
            textoCarregando.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            textoCarregando.Location = new Point(15, 11);
            textoCarregando.Margin = new Padding(4, 0, 4, 0);
            textoCarregando.Name = "textoCarregando";
            textoCarregando.Size = new Size(478, 86);
            textoCarregando.TabIndex = 1;
            textoCarregando.Text = "CARREGANDO";
            textoCarregando.Click += label1_Click;
            // 
            // PBbarra
            // 
            PBbarra.Location = new Point(15, 105);
            PBbarra.Margin = new Padding(4);
            PBbarra.Name = "PBbarra";
            PBbarra.Size = new Size(951, 81);
            PBbarra.TabIndex = 2;
            PBbarra.Click += progressBar1_Click;
            // 
            // tmrTempo
            // 
            tmrTempo.Enabled = true;
            tmrTempo.Interval = 1000;
            tmrTempo.Tick += tmrTempo_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(PBbarra);
            Controls.Add(textoCarregando);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
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
        private ProgressBar PBbarra;
        private System.Windows.Forms.Timer tmrTempo;
    }
}
