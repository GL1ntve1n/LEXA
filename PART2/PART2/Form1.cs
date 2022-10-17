using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PART2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1_answer.Location = new Point(363, 206);
            TextBox_byte.TabIndex = 1;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            label1_location.Text = label1_answer.Location.X.ToString();
            string sign = TextBox_Operand.Text;
            char[] MyChar = { '2', '3' };
            if (sign.Equals("COMBINATION1"))
            {
                string num1 = Convert.ToString(TextBox_byte.Text);
                int num2 = Convert.ToInt32(TextBox_double.Text);
                char[] MyCharDop;
                MyCharDop = num1.ToCharArray(num2/10, num2%10);
                label1_answer.Text = String.Join("", MyCharDop);
            }
            else if (sign.Equals("+"))
            {
                byte num1 = Convert.ToByte(TextBox_byte.Text);
                double num2 = Convert.ToDouble(TextBox_double.Text);
                double sum = num1 + num2;
                string str = Convert.ToString(sum);
                str = str.TrimEnd(MyChar).TrimStart(MyChar);
                label1_answer.Text = str;
            }
            else if (sign.Equals("-"))
            {
                byte num1 = Convert.ToByte(TextBox_byte.Text);
                double num2 = Convert.ToDouble(TextBox_double.Text);
                double sum = num1 - num2;
                string str = Convert.ToString(sum);
                str = str.TrimEnd(MyChar).TrimStart(MyChar);
                label1_answer.Text = str;
            }
            else if (sign.Equals("*"))
            {
                byte num1 = Convert.ToByte(TextBox_byte.Text);
                double num2 = Convert.ToDouble(TextBox_double.Text);
                double sum = num1 * num2;
                string str = Convert.ToString(sum);
                str = str.TrimEnd(MyChar).TrimStart(MyChar);
                label1_answer.Text = str;
            }
            else if (sign.Equals("^"))
            {
                byte num1 = Convert.ToByte(TextBox_byte.Text);
                double num2 = Convert.ToDouble(TextBox_double.Text);
                double sum = num1 + num2;
                sum = Math.Sqrt(sum);
                string str = Convert.ToString(sum);
                str = str.TrimEnd(MyChar).TrimStart(MyChar);
                label1_answer.Text = str;
            }
            Form2 newForm = new Form2();
            newForm.Show();
            newForm.label1_copy.Text=label1_answer.Text;







        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_location_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_AddOperation_Click(object sender, EventArgs e)
        {

        }

        private void label1_answer_Click(object sender, EventArgs e)
        {

        }
    }
}
