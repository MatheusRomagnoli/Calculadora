namespace Calculadora
{
    partial class frmConverteCelsiusFahrenheit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCelsius = new TextBox();
            label1 = new Label();
            btnConverter = new Button();
            label2 = new Label();
            txtResultado = new TextBox();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(12, 32);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(205, 23);
            txtCelsius.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(192, 21);
            label1.TabIndex = 1;
            label1.Text = "Temperatura em Celsius";
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(223, 32);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(75, 23);
            btnConverter.TabIndex = 2;
            btnConverter.Text = "converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(221, 21);
            label2.TabIndex = 3;
            label2.Text = "Temperatura em Fahrenheit";
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.Window;
            txtResultado.Location = new Point(12, 93);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(221, 68);
            txtResultado.TabIndex = 5;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(12, 167);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // frmConverteCelsiusFahrenheit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 202);
            Controls.Add(btnLimpar);
            Controls.Add(txtResultado);
            Controls.Add(label2);
            Controls.Add(btnConverter);
            Controls.Add(label1);
            Controls.Add(txtCelsius);
            Name = "frmConverteCelsiusFahrenheit";
            Text = "frmConverteCelsiusFahrenheit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCelsius;
        private Label label1;
        private Button btnConverter;
        private Label label2;
        private TextBox txtResultado;
        private Button btnLimpar;
    }
}