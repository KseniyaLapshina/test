using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Graph = CreateGraphics();
            MyPen = new Pen(Color.Black);
            InitializeComponent();
        }
        Graphics Graph;
        Pen MyPen;
        int x, y;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int w = 270, h = 384;
            int w0 = w / 2, h0 = h / 2;
            Graph.DrawLine(MyPen, 0, 270, this.ClientSize.Width, 270); // ось х
            Graph.DrawLine(MyPen, 0, 270 * 2, this.ClientSize.Width, 270 * 2); // ось х
            Graph.DrawLine(MyPen, 0, 270 * 3, this.ClientSize.Width, 270 * 3); // ось х
            Graph.DrawLine(MyPen, 384, 0, 384, this.ClientSize.Height); // ось у
            Graph.DrawLine(MyPen, 384 * 2, 0, 384 * 2, this.ClientSize.Height); // ось у
            Graph.DrawLine(MyPen, 384 * 3, 0, 384 * 3, this.ClientSize.Height); // ось у
            Graph.DrawLine(MyPen, 384 * 4, 0, 384 * 4, this.ClientSize.Height); // ось у

            int a = 75, b = 50;
            /*for (double i = 0.01; i < 2 * 3.14; i = i + 0.01)
            {
                int x1 = (int)(a * Math.Cos(i) * (1 + Math.Cos(i))), y1 = (int)(a * Math.Sin(i) * (1 + Math.Cos(i)));
                int x2 = (int)(a * Math.Cos(i + 0.01) * (1 + Math.Cos(i + 0.01))), y2 = (int)(a * Math.Sin(i + 0.01) * (1 + Math.Cos(i + 0.01)));
                Graph.DrawLine(MyPen, x1 + w0, y1 + h0 - 60, x2 + w0, y2 + h0 - 60);
            }*/

            //часть а
            for (double i = 0.01; i < 2 * 3.14 - 0.01; i = i + 0.01)
            {
                int x1 = (int)(a * Math.Cos(i) * Math.Cos(i) + b * Math.Cos(i)), y1 = (int)(a * Math.Cos(i) * Math.Sin(i) + b * Math.Sin(i));
                int x2 = (int)(a * Math.Cos(i + 0.01) * Math.Cos(i + 0.01) + b * Math.Cos(i + 0.01)), y2 = (int)(a * Math.Cos(i + 0.01) * Math.Sin(i + 0.01) + b * Math.Sin(i + 0.01));
                Graph.DrawLine(MyPen, x1 + w0, y1 + h0 - 60, x2 + w0, y2 + h0 - 60);
            }
            a = 50;
            b = 75;
            for (double i = 0.01; i < 2 * 3.14 - 0.01; i = i + 0.01)
            {

                int x1 = (int)(a * Math.Cos(i) * Math.Cos(i) + b * Math.Cos(i)), y1 = (int)(a * Math.Cos(i) * Math.Sin(i) + b * Math.Sin(i));
                int x2 = (int)(a * Math.Cos(i + 0.01) * Math.Cos(i + 0.01) + b * Math.Cos(i + 0.01)), y2 = (int)(a * Math.Cos(i + 0.01) * Math.Sin(i + 0.01) + b * Math.Sin(i + 0.01));
                Graph.DrawLine(MyPen, x1 + w * 2, y1 + h0 - 60, x2 + w * 2, y2 + h0 - 60);
            }
            a = 30;
            b = 80;
            for (double i = 0.01; i < 2 * 3.14 - 0.01; i = i + 0.01)
            {

                int x1 = (int)(a * Math.Cos(i) * Math.Cos(i) + b * Math.Cos(i)), y1 = (int)(a * Math.Cos(i) * Math.Sin(i) + b * Math.Sin(i));
                int x2 = (int)(a * Math.Cos(i + 0.01) * Math.Cos(i + 0.01) + b * Math.Cos(i + 0.01)), y2 = (int)(a * Math.Cos(i + 0.01) * Math.Sin(i + 0.01) + b * Math.Sin(i + 0.01));
                Graph.DrawLine(MyPen, x1 + w * 3 + 120, y1 + h0 - 60, x2 + w * 3 + 120, y2 + h0 - 60);
            }
            //часть b
            a = 5;
            int l = 50;
            for (double i = -3.14/2; i < 3.14/2 - 0.01; i = i + 0.01)
            {
                int x1 = (int)(a + l * Math.Cos(i)), y1 = (int)(a * Math.Tan(i) + l * Math.Sin(i));
                int x2 = (int)(a + l * Math.Cos(i + 0.01)), y2 = (int)(a * Math.Tan(i + 0.01) + l * Math.Sin(i + 0.01));
                Graph.DrawLine(MyPen, x1 + w * 5 , y1 + h0 - 60, x2 + w * 5, y2 + h0 - 60);
            }
            for (double i = 3.14 / 2; i < 3 * 3.14 / 2 - 0.01; i = i + 0.01)
            {

                Graph.DrawLine(MyPen, x1 + w * 4 + 120, y1 + h0 - 60, x2 + w * 4 + 120, y2 + h0 - 60);
            }
            }
    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyPen.Dispose();
            Graph.Dispose();
        }
    }
}
