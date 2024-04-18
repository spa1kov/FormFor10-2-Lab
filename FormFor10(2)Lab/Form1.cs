using System;
using System.Windows.Forms;

namespace FormFor10_2_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int CalculateLeftSum(int p, int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += p + i;
            }
            return sum;
        }

        private int CalculateRightSum(int p, int n)
        {
            return (n + 1) * (2 * p + n) / 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int p = Convert.ToInt32(textBox1.Text);
                int n = Convert.ToInt32(textBox2.Text);
                int result = CalculateLeftSum(p, n);
                MessageBox.Show("Сумма чисел по функции до " + p + " с шагом " + n + " равна " + result);
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный формат ввода. Пожалуйста, введите целое число.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int p = Convert.ToInt32(textBox1.Text);
                int n = Convert.ToInt32(textBox2.Text);
                int result = CalculateRightSum(p, n);
                MessageBox.Show("Сумма чисел по правой формуле до " + p + " с шагом " + n + " равна " + result);
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный формат ввода. Пожалуйста, введите целое число.");
            }
        }
    }
}