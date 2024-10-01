namespace Calculadora
{
    partial class frmConverteCM
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
            label1 = new Label();
            label2 = new Label();
            txtCentimetros = new TextBox();
            txtPolegada = new TextBox();
            btnConverteCM = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 0;
            label1.Text = "Centímetros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 1;
            label2.Text = "Polegadas";
            label2.Click += label2_Click;
            // 
            // txtCentimetros
            // 
            txtCentimetros.Location = new Point(12, 42);
            txtCentimetros.Name = "txtCentimetros";
            txtCentimetros.Size = new Size(237, 23);
            txtCentimetros.TabIndex = 2;
            // 
            // txtPolegada
            // 
            txtPolegada.Location = new Point(12, 115);
            txtPolegada.Multiline = true;
            txtPolegada.Name = "txtPolegada";
            txtPolegada.ReadOnly = true;
            txtPolegada.Size = new Size(237, 93);
            txtPolegada.TabIndex = 3;
            // 
            // btnConverteCM
            // 
            btnConverteCM.Location = new Point(272, 42);
            btnConverteCM.Name = "btnConverteCM";
            btnConverteCM.Size = new Size(75, 23);
            btnConverteCM.TabIndex = 4;
            btnConverteCM.Text = "Converter";
            btnConverteCM.UseVisualStyleBackColor = true;
            btnConverteCM.Click += btnConverteCM_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(12, 225);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // frmConverteCM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 266);
            Controls.Add(btnLimpar);
            Controls.Add(btnConverteCM);
            Controls.Add(txtPolegada);
            Controls.Add(txtCentimetros);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmConverteCM";
            Text = "frmConverteCM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCentimetros;
        private TextBox txtPolegada;
        private Button btnConverteCM;
        private Button btnLimpar;
    }
}