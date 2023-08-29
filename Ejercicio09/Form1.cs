namespace Ejercicio09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(text1.Text);
            int num2 = int.Parse(text2.Text);
            int num3 = int.Parse(text3.Text);
            if ((num1 > num2) && (num1 > num3))
            {
                lblresultado.Text = "El primer número es el mayor";
            }
            else if ((num2 > num1) && (num2 > num3)) 
            {
                lblresultado.Text = "El segundo número es el mayor";
            }
            else 
            {
                lblresultado.Text = "El tercer número es el mayor";
            }
        }
    }
}