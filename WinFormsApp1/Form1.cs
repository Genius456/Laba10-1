namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                double a, b, angle;
                if (double.TryParse(txtSideA.Text, out a) &&
                    double.TryParse(txtSideB.Text, out b) &&
                    double.TryParse(txtAngle.Text, out angle))
                {
                    double area = a * b * Math.Sin(angle * Math.PI / 180);
                    lblResult.Text = "Площадь параллелограмма: " + area;
                }
                else
                {
                    MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
                }
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

