using System;
using System.Windows.Forms;

namespace DigitExtractorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        unsafe int f(int* m1, int* m0, int N)
        {
            *m1 = N / 10;  // Первая цифра (десятки)
            *m0 = N % 10;  // Последняя цифра (единицы)
            return 0;
        }

        private unsafe void buttonExtract_Click(object sender, EventArgs e)
        {
            try
            {
                int N = int.Parse(textBoxInput.Text);
                if (N < 10 || N > 99)
                {
                    MessageBox.Show("Введите строго двузначное число (от 10 до 99)");
                    return;
                }

                int first = 0, last = 0;

                f(&first, &last, N);

                labelFirst.Text = "Первая цифра: " + first.ToString();
                labelLast.Text = "Последняя цифра: " + last.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message);
            }
        }
    }
}
