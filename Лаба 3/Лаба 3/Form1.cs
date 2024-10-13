using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Лаба_3
{
    public partial class Form1 : Form
    {
        private double size = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void doingMassive(double size) 
        {
            DataGridViewColumn column;
            for (int i = 0; i < size; i++)
            {
                column = new DataGridViewTextBoxColumn();
                column.DataPropertyName = "Column" + i.ToString();
                column.Name = i.ToString();
                Massive.Columns.Add(column);
            }

            for (int i = 0; i < size; i++)
            {
                Massive.Rows.Add();
                Massive.Rows[i].HeaderCell.Value = "row" + i.ToString();
                Massive.AllowUserToAddRows = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doingMassive(size);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Massive.Columns.Clear();
            doingMassive(size);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    this.Massive.Rows[i].Cells[j].Value = random.Next(1,101);
                }
            }
        }
    }
}
