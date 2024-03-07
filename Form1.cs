namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            int valor1, valor2;
            //Entrada de datos
            valor1 = int.Parse(txt_Valor1.Text);
            valor2 = int.Parse(txt_Valor2.Text);
            //Proceso
            int resultado_suma = valor1 + valor2;
            int resultado_resta = valor1 - valor2;
            int resultado_multiplicacion = valor1 * valor2;
            int resultado_division = valor1 / valor2;
            //Salida de datos
            txt_Resultado_Suma.Text = resultado_suma.ToString();
            txt_Resultado_Resta.Text = resultado_resta.ToString();
            txt_Resultado_multiplicacion.Text = resultado_multiplicacion.ToString();
            txt_Resultado_division.Text = resultado_division.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_Valor1.Clear();
            txt_Valor2.Clear();
            txt_Resultado_Suma.Clear();
            txt_Resultado_Resta.Clear();
            txt_Resultado_multiplicacion.Clear();
            txt_Resultado_division.Text = string.Empty;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void txt_Valor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}