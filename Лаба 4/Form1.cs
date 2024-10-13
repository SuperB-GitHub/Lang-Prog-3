using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            one();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            one();
        }
        public void one()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            Pen oces = new Pen(Color.Black, 1);
            Font drawFont = new Font("Arial", 12);
            Font signFont = new Font("Arial", 7);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            int width = Form1.ActiveForm.Width;
            int height = Form1.ActiveForm.Height;
            Point center = new Point((int)((width / 2) - 8), (int)((height / 2) - 19));

            g.DrawLine(oces, 10, center.Y, center.X, center.Y);
            g.DrawLine(oces, center.X, center.Y, 2 * center.X - 10, center.Y);
            g.DrawLine(oces, center.X, 10, center.X, center.Y);
            g.DrawLine(oces, center.X, center.Y, center.X, 2 * center.Y - 10);
            g.DrawString("X", drawFont, drawBrush, new PointF(2 * center.X - 5, center.Y + 10), drawFormat);
            g.DrawString("Y", drawFont, drawBrush, new PointF(center.X + 30, 25), drawFormat);
            g.DrawString("0", drawFont, drawBrush, center, drawFormat);
            g.DrawLine(oces, center.X, 10, center.X + 5, 20);
            g.DrawLine(oces, center.X, 10, center.X - 5, 20);
            g.DrawLine(oces, 2 * center.X - 10, center.Y, 2 * center.X - 20, center.Y + 5);
            g.DrawLine(oces, 2 * center.X - 10, center.Y, 2 * center.X - 20, center.Y - 5);

            int stepbyoces = 25;
            int shtrih = 3;
            int maxValue = 10;
            float oneDel = (float)maxValue / ((int)center.X / (float)stepbyoces);

            for (int i = center.X, j = center.X, k = 1; i < 2 * center.X - 30; j -= stepbyoces, i += stepbyoces, k++)
            {
                g.DrawLine(oces, i, center.Y - shtrih, i, center.Y + shtrih);
                g.DrawLine(oces, j, center.Y - shtrih, j, center.Y + shtrih);
                if (i < 2 * center.X - 55)
                {
                    g.DrawString((k * oneDel).ToString("0.0"), signFont, drawBrush, new PointF(i + stepbyoces + 9, center.Y + 6), drawFormat);
                    g.DrawString(((k * oneDel).ToString("0.0").ToString() + "-"), signFont, drawBrush, new PointF(j - stepbyoces + 9, center.Y + 6), drawFormat);
                }
            }
            for (int i2 = center.Y, j2 = center.Y, k2 = 1; i2 < 2 * center.Y - 30; j2 -= stepbyoces, i2 += stepbyoces, k2++)
            {
                g.DrawLine(oces, center.X - shtrih, i2, center.X + shtrih, i2);
                g.DrawLine(oces, center.X - shtrih, j2, center.X + shtrih, j2);
                if (i2 < 2 * center.Y - 55)
                {
                    g.DrawString((k2 * oneDel).ToString("0.0"), signFont, drawBrush, new PointF(center.X - 6, j2 - stepbyoces - 6 ), drawFormat);
                    g.DrawString(((k2 * oneDel).ToString("0.0").ToString() + "-"), signFont, drawBrush, new PointF(center.X - 6, i2 + stepbyoces - 6), drawFormat);
                }

            }

            Pen graph1 = new Pen(Color.Red, 2);
            Pen graph2 = new Pen(Color.Green, 2);
            Pen graph3 = new Pen(Color.Blue, 2);
            do_graf(100, maxValue, oneDel, 1, graph1, center, stepbyoces, g);
            do_graf(100, maxValue, oneDel, 2, graph2, center, stepbyoces, g);
            do_graf(100, maxValue, oneDel, 3, graph3, center, stepbyoces, g);
        }

        public void do_graf(int numOfPoints, double maxValue, float oneDel, int form, Pen penGraph, Point center, int stepbyoces, Graphics g)
        {
            double[] pointsX = new double[numOfPoints];
            double[] pointsY = new double[numOfPoints];
            Point[] drawPoints = new Point[numOfPoints];
            float tempX = 1 / oneDel * stepbyoces;
            float tempY = 1 / oneDel * stepbyoces;
            for (int counter = 0; counter < numOfPoints; counter++)
            {
                pointsX[counter] = (double)(maxValue * 2) / (double)numOfPoints * (counter + 1) - (double)(maxValue);
            }
            for (int counter = 0; counter < numOfPoints; counter++)
            {
                if (form == 1)
                {
                    pointsY[counter] = -Math.Cos(pointsX[counter]);
                }
                else if (form == 2)
                {
                    pointsY[counter] = -Math.Cos(pointsX[counter] + Math.PI / 2);
                }
                else if (form == 3)
                {
                    pointsY[counter] = -Math.Sin(pointsX[counter] - Math.PI / 2);
                }

            }
            for (int counter = 0; counter < numOfPoints; counter++)
            {
                drawPoints[counter].X = center.X + (int)(pointsX[counter] * tempX);
                drawPoints[counter].Y = center.Y + (int)(pointsY[counter] * tempY);
            }
            g.DrawCurve(penGraph, drawPoints);
        }

        private void ToForm2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void ToForm3_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
