using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        private double memory = 0;
        private string sign = "";
        private double result = 0;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void расширенныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(800, 489);
            //this.Panel.Show();
        }

        private void обычныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(319, 489);
            //this.Panel.Hide();
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            this.TB_In.Text += Convert.ToString(memory);
        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(this.TB_In.Text);
        }

        private void buttonMplus_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(this.TB_In.Text) + memory;
        }

        private void buttonMminus_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(this.TB_In.Text) - memory;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.TB_In.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.TB_In.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.TB_In.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.TB_In.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.TB_In.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.TB_In.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.TB_In.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.TB_In.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.TB_In.Text += "3";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            this.TB_In.Text += "0";
        }

        private void buttonCom_Click(object sender, EventArgs e)
        {
            if (TB_In.Text == "")
            {
                this.TB_In.Text += "0,";
            }
            else
            {
                this.TB_In.Text += ",";
            }
        }

        private void buttonBS_Click(object sender, EventArgs e)
        {
            if (this.TB_In.Text != "")
            {
                this.TB_In.Text = this.TB_In.Text.Substring(0, this.TB_In.Text.Length - 1);
            }
            
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            this.TB_In.Clear();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            this.TB_In.Clear();
            this.TB_Out.Clear();
            result = 0;
        }

        private void answer(double result)
        {
            this.TB_Out.Text += this.TB_In.Text + " = ";
            this.TB_In.Text = Convert.ToString(result);
        }

        private void buttonEqal_Click(object sender, EventArgs e)
        {
            if (this.TB_Out.Text != "" && !this.TB_Out.Text.Contains("=") && this.TB_In.Text != "")
            {
                if (sign == " + ")
                {
                    result += Convert.ToDouble(this.TB_In.Text);
                    answer(result);
                }
                if (sign == " - ")
                {
                    result -= Convert.ToDouble(this.TB_In.Text);
                    answer(result);
                }
                if (sign == " × ")
                {
                    result *= Convert.ToDouble(this.TB_In.Text);
                    answer(result);
                }
                if (sign == " / ")
                {
                    result /= Convert.ToDouble(this.TB_In.Text);
                    answer(result);
                }
            }
        }

        private void buttonPius_Click(object sender, EventArgs e)
        {
            if (this.TB_In.Text != "" || this.TB_Out.Text.Contains("="))
            {
                sign = " + ";
                if (this.TB_Out.Text == "" || this.TB_Out.Text.Contains("="))
                {
                    result = Convert.ToDouble(this.TB_In.Text);
                }
                else
                {
                    result += Convert.ToDouble(this.TB_In.Text);
                }
                this.TB_Out.Text = Convert.ToString(result) + sign;
                this.TB_In.Clear();
               
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (this.TB_In.Text != "")
            {
                sign = " - ";
                if (this.TB_Out.Text == "" || this.TB_Out.Text.Contains("="))
                {
                    result = Convert.ToDouble(this.TB_In.Text);
                }
                else
                {
                    result -= Convert.ToDouble(this.TB_In.Text);
                }
                this.TB_Out.Text = Convert.ToString(result) + sign;
                this.TB_In.Clear();

            }
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            if (this.TB_In.Text != "")
            {
                sign = " × ";
                if (this.TB_Out.Text == "" || this.TB_Out.Text.Contains("="))
                {
                    result = Convert.ToDouble(this.TB_In.Text);
                }
                else
                {
                    result *= Convert.ToDouble(this.TB_In.Text);
                }
                this.TB_Out.Text = Convert.ToString(result) + sign;
                this.TB_In.Clear();

            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            if (this.TB_In.Text != "")
            {
                sign = " / ";
                if (this.TB_Out.Text == "" || this.TB_Out.Text.Contains("="))
                {
                    result = Convert.ToDouble(this.TB_In.Text);
                }
                else
                {
                    result /= Convert.ToDouble(this.TB_In.Text);
                }
                this.TB_Out.Text = Convert.ToString(result) + sign;
                this.TB_In.Clear();

            }
        }

        private void buttonPM_Click(object sender, EventArgs e)
        {
            if (this.TB_In.Text != "" && Convert.ToDouble(this.TB_In.Text) != 0)
            {
                this.TB_In.Text = Convert.ToString(Convert.ToDouble(this.TB_In.Text) * -1);
            }
        }

        private void buttonSQRT_Click(object sender, EventArgs e)
        {
            if (this.TB_In.Text != "")
            {
                this.TB_Out.Text = "√" + Convert.ToString(this.TB_In.Text);
                result = Math.Sqrt(Math.Abs(Convert.ToDouble(this.TB_In.Text)));
                this.TB_In.Text = Convert.ToString(result);

            }
        }

        private void buttonOneDiv_Click(object sender, EventArgs e)
        {
            if (this.TB_In.Text != "")
            {
                this.TB_Out.Text = "1/" + Convert.ToString(this.TB_In.Text);
                result = 1/(Convert.ToDouble(this.TB_In.Text));
                this.TB_In.Text = Convert.ToString(result);

            }
        }

        private void CBP_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CBP_Type.SelectedItem.ToString() == "Время")
            {
                this.CBP_Out.Items.Clear();
                this.CBP_In.Items.Clear();
                this.CBP_Out.Items.AddRange(new string[] { "Года", "Минуты" });
                this.CBP_Out.SelectedItem = this.CBP_Out.Items[0];
                this.CBP_In.Items.AddRange(new string[] { "Минуты", "Года" });
                this.CBP_In.SelectedItem = this.CBP_In.Items[0];
            }
            else if (this.CBP_Type.SelectedItem.ToString() == "Скорость")
            {
                this.CBP_Out.Items.Clear();
                this.CBP_In.Items.Clear();
                this.CBP_Out.Items.AddRange(new string[] { "КМ/Ч", "М/С" });
                this.CBP_Out.SelectedItem = this.CBP_Out.Items[0];
                this.CBP_In.Items.AddRange(new string[] { "М/С", "КМ/Ч" });
                this.CBP_In.SelectedItem = this.CBP_In.Items[0];
            }
            else if (this.CBP_Type.SelectedItem.ToString() == "Ничего")
            {
                this.CBP_Out.Items.Clear();
                this.CBP_In.Items.Clear();
                this.CBP_Out.Items.AddRange(new string[] { "Ничего" });
                this.CBP_Out.SelectedItem = this.CBP_Out.Items[0];
                this.CBP_In.Items.AddRange(new string[] { "Ничего" });
                this.CBP_In.SelectedItem = this.CBP_In.Items[0];
            }
            else
            {
                this.CBP_In.Items.Clear();
                this.CBP_In.Text = string.Empty;
                this.CBP_Out.Items.Clear();
                this.CBP_Out.Text = string.Empty;
            }
        }

        private void TBP_Out_TextChanged(object sender, EventArgs e)
        {
            if (this.TBP_Out.Text == string.Empty)
            {
                this.TBP_In.Clear();
            } 
            else if (this.CBP_Out.Text == "Года" && this.CBP_In.Text == "Минуты")
            {
                this.TBP_In.Text = Convert.ToString(Convert.ToDouble(this.TBP_Out.Text)*525960);
            }
            else if (this.CBP_Out.Text == "Минуты" && this.CBP_In.Text == "Года")
            {
                this.TBP_In.Text = Convert.ToString(Convert.ToDouble(this.TBP_Out.Text) * 0.000002);
            }
        }
    }
}