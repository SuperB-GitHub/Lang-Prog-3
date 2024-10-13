using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба_4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Graphics prims = PictureBox.CreateGraphics();

                SolidBrush Brush1 = new SolidBrush(Color.DarkSalmon);
                Point[] trianglePoints = new Point[]
                {
                new Point(200, 300),
                new Point(70, 270),
                new Point(300, 400)
                };
                prims.FillPolygon(Brush1, trianglePoints);

                Pen Pen1 = new Pen(Color.LawnGreen, 6);
                prims.DrawEllipse(Pen1, 300, 160, 170, 90);

                SolidBrush Brush2 = new SolidBrush(Color.Firebrick);
                prims.FillEllipse(Brush2, 600, 300, 150, 150);

                Pen Pen2 = new Pen(Color.Yellow, 10);
                prims.DrawRectangle(Pen2, 100, 50, 50, 100);

                SolidBrush Brush3 = new SolidBrush(Color.Blue);
                Point[] arrowPoints = new Point[]
                {
                new Point(640, 150),
                new Point(600, 100),
                new Point(630, 100),
                new Point(630, 40),
                new Point(650, 40),
                new Point(650, 100),
                new Point(680, 100),
                new Point(640, 150)
                };
                prims.FillPolygon(Brush3, arrowPoints);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PictureBox.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            PictureBox.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ImageFormat img = ImageFormat.Jpeg;
            saveFileDialog1.ShowDialog();
            Rectangle bounds = this.Bounds;
            Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            bitmap.Save(saveFileDialog1.FileName, img);
            PictureBox.Show();
        }
    }
}
