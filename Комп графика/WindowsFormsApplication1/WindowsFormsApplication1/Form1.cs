using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        Graphics Graph;
        Pen MyPen;
        int x, y;
        public MainForm()
        {

            Graph = CreateGraphics();
            MyPen = new Pen(Color.Black);
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyPen.Dispose();
            Graph.Dispose();

        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            int x0 = 150;
            int y0 = 150;
            int x1, y1, x2, y2;
            double x, y;
            const double xMin = -300;
            const double xMax = 300;
            const double step = 0.01;
            const double k = 20;
            //фактические координаты в начальной точке заданного диапазона
            x = xMin;
            y = 1 + 2 * Math.Cos(2 * x);
            x1 = (int)(x0 + x * k);
            y1 = (int)(y0 - y * k);
            while (x < xMax)
            {
                //определение фактических координат графика в следующей точке
                x = x + step;
                y = 1 + 2 * (Math.Cos(2 * x));
                //соответствующие им экранные координаты
                x2 = (int)(x0 + x * k);
                y2 = (int)(y0 - y * k);
                //вывод отрезка графика на экран
                Graph.DrawLine(MyPen, x0, 0, x0, 300);
                Graph.DrawLine(MyPen, 0, y0, 300, y0);
                Graph.DrawLine(MyPen, x0, 0, x0 - 10, 0 + 10);
                Graph.DrawLine(MyPen, x0, 0, x0 + 10, 0 + 10);

                Graph.DrawLine(MyPen, 20 - 10, 10 - y0, 300, y0);
                Graph.DrawLine(MyPen, 280 + 0, 10 + y0, 300, y0);

                //Graph.DrawLine(MyPen, this.ClientSize.Width / 2, 0, 10, 10);
                Graph.DrawLine(MyPen, x1, y1, x2, y2);
                //запоминаем текущие координаты
                x1 = x2;
                y1 = y2;
            }
            Graph.DrawLine(MyPen, this.ClientSize.Width / 2, 0, this.ClientSize.Width / 2, this.ClientSize.Height); // ось у
            Graph.DrawLine(MyPen, 0, this.ClientSize.Height / 2, this.ClientSize.Width, this.ClientSize.Height / 2); // ось х
            for (double i = 0; i < 50; i = i + 3.14 / 2) //здесь заебашить деления и все
            {

            }
        }
    }
}