using System;
using System.Windows.Forms;

namespace Pseudorandom_number_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int N = 20, a = 0, x; //N - Число младших разрядов, 
            //a - левая граница принимаемых значений переменной x 
            double deg = Math.Pow(2, N); //Степень двойки
            double b = deg - 1, y; //b - Правая граница 
            //принимаемых значений аргумента, y - функция
            chart1.Series[0].Points.Clear(); //Очищение экрана
            x = a;

            while (x <= b)
            {
                y = 5 * x + 1; //Значение T-функции для каждого аргумента 
                chart1.Series[0].Points.AddXY(x / deg, y % deg / deg);
                //Нанесение точек на единичный квадрат
                x++;
            }
        }
    }
}