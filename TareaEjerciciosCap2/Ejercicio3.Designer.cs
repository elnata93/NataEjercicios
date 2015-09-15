namespace TareaEjerciciosCap2
{
    partial class Ejercicio3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gradosTextBox1 = new System.Windows.Forms.TextBox();
            this.resultTextBox4 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // gradosTextBox1
            // 
            this.gradosTextBox1.Location = new System.Drawing.Point(113, 61);
            this.gradosTextBox1.Name = "gradosTextBox1";
            this.gradosTextBox1.Size = new System.Drawing.Size(100, 20);
            this.gradosTextBox1.TabIndex = 3;
            this.gradosTextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // resultTextBox4
            // 
            this.resultTextBox4.Location = new System.Drawing.Point(113, 119);
            this.resultTextBox4.Name = "resultTextBox4";
            this.resultTextBox4.Size = new System.Drawing.Size(100, 20);
            this.resultTextBox4.TabIndex = 6;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(125, 163);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "Calcular";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.calcularButton1_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.resultTextBox4);
            this.Controls.Add(this.gradosTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio3";
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox gradosTextBox1;
        private System.Windows.Forms.TextBox resultTextBox4;
        private System.Windows.Forms.Button Button1;
    }
}