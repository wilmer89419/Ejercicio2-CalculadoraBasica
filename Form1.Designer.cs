namespace WinFormsApp2
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
            txt_Valor2 = new TextBox();
            txt_Valor1 = new TextBox();
            txt_Resultado_Suma = new TextBox();
            lblPrimerValor = new Label();
            lblSegundoValor = new Label();
            lblSuma = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lblResta = new Label();
            lblMultiplicacion = new Label();
            lblDivision = new Label();
            txt_Resultado_Resta = new TextBox();
            txt_Resultado_multiplicacion = new TextBox();
            txt_Resultado_division = new TextBox();
            SuspendLayout();
            // 
            // txt_Valor2
            // 
            txt_Valor2.Location = new Point(251, 95);
            txt_Valor2.Margin = new Padding(3, 2, 3, 2);
            txt_Valor2.Name = "txt_Valor2";
            txt_Valor2.Size = new Size(110, 23);
            txt_Valor2.TabIndex = 0;
            // 
            // txt_Valor1
            // 
            txt_Valor1.Location = new Point(251, 55);
            txt_Valor1.Margin = new Padding(3, 2, 3, 2);
            txt_Valor1.Name = "txt_Valor1";
            txt_Valor1.Size = new Size(110, 23);
            txt_Valor1.TabIndex = 1;
            txt_Valor1.TextChanged += txt_Valor1_TextChanged;
            // 
            // txt_Resultado_Suma
            // 
            txt_Resultado_Suma.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Resultado_Suma.Location = new Point(27, 206);
            txt_Resultado_Suma.Margin = new Padding(3, 2, 3, 2);
            txt_Resultado_Suma.Name = "txt_Resultado_Suma";
            txt_Resultado_Suma.Size = new Size(110, 21);
            txt_Resultado_Suma.TabIndex = 2;
            txt_Resultado_Suma.TextChanged += textBox3_TextChanged;
            // 
            // lblPrimerValor
            // 
            lblPrimerValor.AutoSize = true;
            lblPrimerValor.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerValor.ForeColor = SystemColors.ControlText;
            lblPrimerValor.Location = new Point(164, 55);
            lblPrimerValor.Name = "lblPrimerValor";
            lblPrimerValor.Size = new Size(69, 22);
            lblPrimerValor.TabIndex = 3;
            lblPrimerValor.Text = "Valor1";
            lblPrimerValor.Click += label1_Click;
            // 
            // lblSegundoValor
            // 
            lblSegundoValor.AutoSize = true;
            lblSegundoValor.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoValor.ForeColor = SystemColors.ControlText;
            lblSegundoValor.Location = new Point(164, 95);
            lblSegundoValor.Name = "lblSegundoValor";
            lblSegundoValor.Size = new Size(69, 22);
            lblSegundoValor.TabIndex = 4;
            lblSegundoValor.Text = "Valor2";
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSuma.ForeColor = SystemColors.ActiveCaptionText;
            lblSuma.Location = new Point(15, 180);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(138, 18);
            lblSuma.TabIndex = 5;
            lblSuma.Text = "Resultado Suma";
            lblSuma.Click += label3_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Turquoise;
            btnCalcular.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.ForeColor = SystemColors.ActiveCaptionText;
            btnCalcular.Location = new Point(447, 38);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(89, 28);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += button1_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Turquoise;
            btnLimpiar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiar.Location = new Point(447, 81);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(89, 26);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += button2_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Turquoise;
            btnSalir.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = SystemColors.ActiveCaptionText;
            btnSalir.Location = new Point(447, 120);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(89, 25);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += button3_Click;
            // 
            // lblResta
            // 
            lblResta.AutoSize = true;
            lblResta.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblResta.ForeColor = SystemColors.ActiveCaptionText;
            lblResta.Location = new Point(180, 180);
            lblResta.Name = "lblResta";
            lblResta.Size = new Size(140, 18);
            lblResta.TabIndex = 9;
            lblResta.Text = "Resultado Resta";
            lblResta.Click += label4_Click;
            // 
            // lblMultiplicacion
            // 
            lblMultiplicacion.AutoSize = true;
            lblMultiplicacion.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMultiplicacion.ForeColor = SystemColors.ActiveCaptionText;
            lblMultiplicacion.Location = new Point(346, 180);
            lblMultiplicacion.Name = "lblMultiplicacion";
            lblMultiplicacion.Size = new Size(202, 18);
            lblMultiplicacion.TabIndex = 10;
            lblMultiplicacion.Text = "Resultado Multiplicacion";
            // 
            // lblDivision
            // 
            lblDivision.AutoSize = true;
            lblDivision.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDivision.ForeColor = SystemColors.ActiveCaptionText;
            lblDivision.Location = new Point(567, 180);
            lblDivision.Name = "lblDivision";
            lblDivision.Size = new Size(155, 18);
            lblDivision.TabIndex = 11;
            lblDivision.Text = "Resultado Division";
            lblDivision.Click += label6_Click;
            // 
            // txt_Resultado_Resta
            // 
            txt_Resultado_Resta.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Resultado_Resta.Location = new Point(192, 206);
            txt_Resultado_Resta.Margin = new Padding(3, 2, 3, 2);
            txt_Resultado_Resta.Name = "txt_Resultado_Resta";
            txt_Resultado_Resta.Size = new Size(110, 21);
            txt_Resultado_Resta.TabIndex = 12;
            // 
            // txt_Resultado_multiplicacion
            // 
            txt_Resultado_multiplicacion.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Resultado_multiplicacion.Location = new Point(389, 206);
            txt_Resultado_multiplicacion.Margin = new Padding(3, 2, 3, 2);
            txt_Resultado_multiplicacion.Name = "txt_Resultado_multiplicacion";
            txt_Resultado_multiplicacion.Size = new Size(110, 21);
            txt_Resultado_multiplicacion.TabIndex = 13;
            // 
            // txt_Resultado_division
            // 
            txt_Resultado_division.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Resultado_division.Location = new Point(585, 206);
            txt_Resultado_division.Margin = new Padding(3, 2, 3, 2);
            txt_Resultado_division.Name = "txt_Resultado_division";
            txt_Resultado_division.Size = new Size(110, 21);
            txt_Resultado_division.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(735, 334);
            Controls.Add(txt_Resultado_division);
            Controls.Add(txt_Resultado_multiplicacion);
            Controls.Add(txt_Resultado_Resta);
            Controls.Add(lblDivision);
            Controls.Add(lblMultiplicacion);
            Controls.Add(lblResta);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(lblSuma);
            Controls.Add(lblSegundoValor);
            Controls.Add(lblPrimerValor);
            Controls.Add(txt_Resultado_Suma);
            Controls.Add(txt_Valor1);
            Controls.Add(txt_Valor2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Calculadora Básica";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Valor2;
        private TextBox txt_Valor1;
        private TextBox txt_Resultado_Suma;
        private Label lblPrimerValor;
        private Label lblSegundoValor;
        private Label lblSuma;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label lblResta;
        private Label lblMultiplicacion;
        private Label lblDivision;
        private TextBox txt_Resultado_Resta;
        private TextBox txt_Resultado_multiplicacion;
        private TextBox txt_Resultado_division;
    }
}