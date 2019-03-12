﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mo_lab2
{
    public partial class OneDimensionalSearchForm : Form
    {
        double x3, x2, x, c, a0, b0, e, d, s;

        private void btnStart_Click(object sender, EventArgs e)
        {
            dichotomy();
            golden_ratio();

            draw();
        }

        public OneDimensionalSearchForm()
        {
            InitializeComponent();
        }

            double func(double x3, double x2, double x, double c, double i) //Вычисление значения функции в точке i
        {
            return ((x3 * i * i * i) + (x2 * i * i) + (x * i) + c);
        }

        void draw() //Рисование графика заданной функции
        {
            x3 = Convert.ToDouble(textBox1.Text);
            x2 = Convert.ToDouble(textBox2.Text);
            x = Convert.ToDouble(textBox3.Text);
            c = Convert.ToDouble(textBox4.Text);

            a0 = Convert.ToDouble(textBox5.Text);
            b0 = Convert.ToDouble(textBox6.Text);

            chart1.Series[0].Points.Clear();
            for (double i = a0; i <= b0; i += 0.1) //Рисуем график от начальной до конечной точки
            {
                chart1.Series[0].Points.AddXY(i, func(x3, x2, x, c, i));
            }
        }

        void dichotomy()
        {
            int k = 0; //Количество итераций
            int r = 0; //Количество вычислений

            double a1, b1;
            double f1, f2;
            double x_1 = 0, x_2 = 0;


            x3 = Convert.ToDouble(textBox1.Text);
            x2 = Convert.ToDouble(textBox2.Text);
            x = Convert.ToDouble(textBox3.Text);
            c = Convert.ToDouble(textBox4.Text);

            a0 = Convert.ToDouble(textBox5.Text);
            b0 = Convert.ToDouble(textBox6.Text);
            e = Convert.ToDouble(textBox7.Text);
            d = Convert.ToDouble(textBox8.Text);

            a1 = a0; b1 = b0;

            while (k < 1000)
            {
                k++;

                if (Math.Abs(b1 - a1) < e) //Если решение было найдено, прерываем цикл
                {
                    break;
                }

                x_1 = ((a1 + b1) - d) / 2;
                x_2 = ((a1 + b1) + d) / 2;

                f1 = func(x3, x2, x, c, x_1);
                f2 = func(x3, x2, x, c, x_2);

                r += 4;

                if (f1 < f2)
                {
                    b1 = x_2;
                }
                else
                {
                    a1 = x_1;
                }
            }

            tbOutDichotomy.Text = "";
            tbOutDichotomy.AppendText("Количество итераций: " + k + "\n");
            tbOutDichotomy.AppendText("Количество вычислений: " + r + "\n\n");
            tbOutDichotomy.AppendText("Конечные значения:\n");
            tbOutDichotomy.AppendText("an = " + Convert.ToString(a1) + "\n");
            tbOutDichotomy.AppendText("bn = " + Convert.ToString(b1) + "\n");
            tbOutDichotomy.AppendText("x = " + Convert.ToString((a1 + b1) / 2) + "\n");
            tbOutDichotomy.AppendText("y = " + Convert.ToString(func(x3, x2, x, c, ((a1 + b1) / 2))) + "\n");
        }

        void golden_ratio()
        {
            int k = 0; //Количество итераций
            int r = 0; //Количество вычислений

            double a, b, a1, b1;
            double f1 = 0, f2 = 0;
            double x_1 = 0, x_2 = 0, y_1 = 0, y_2 = 0;
            double f = (1 + Math.Sqrt(5)) / 2;

            x3 = Convert.ToDouble(textBox1.Text);
            x2 = Convert.ToDouble(textBox2.Text);
            x = Convert.ToDouble(textBox3.Text);
            c = Convert.ToDouble(textBox4.Text);

            a = Convert.ToDouble(textBox5.Text);
            b = Convert.ToDouble(textBox6.Text);
            e = Convert.ToDouble(textBox7.Text);
            d = Convert.ToDouble(textBox8.Text);

            while (k < 1000)
            {
                k += 1;

                if (Math.Abs(b - a) < e) //Если решение было найдено, прерываем цикл
                {
                    break;
                }
                else
                {
                    x_1 = b - ((b - a) / f);
                    x_2 = a + ((b - a) / f);

                    y_1 = func(x3, x2, x, c, x_1);
                    y_2 = func(x3, x2, x, c, x_2);

                    r += 2;

                    if (y_1 > y_2)
                    {
                        a = x_1;
                    }
                    else
                    {
                        b = x_2;
                    }
                }
            }

            tbOutGolden.Text = "";
            tbOutGolden.AppendText("Количество итераций: " + k + "\n");
            tbOutGolden.AppendText("Количество вычислений: " + r + "\n");
            tbOutGolden.AppendText("Конечные значения:\n");
            tbOutGolden.AppendText("an = " + Convert.ToString(a) + "\n");
            tbOutGolden.AppendText("bn = " + Convert.ToString(b) + "\n");
            tbOutGolden.AppendText("x = " + Convert.ToString((a + b) / 2) + "\n");
            tbOutGolden.AppendText("y = " + Convert.ToString(func(x3, x2, x, c, ((a + b) / 2))) + "\n");
        }

        private void btnShowChart_Click(object sender, EventArgs e)
        {
            draw();
        }
    }
}
