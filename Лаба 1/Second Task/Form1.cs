namespace Second_Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(0, this.Height / 2), new Point(this.Width / 2, 0), new Point(this.Width, this.Height / 2), new Point(this.Width / 2, this.Height), });
            Region myRegion = new Region(myPath);
            this.Region = myRegion;

        }
    }
}
