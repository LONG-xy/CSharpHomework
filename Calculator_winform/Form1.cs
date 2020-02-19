using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator_winform
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Cal_load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
        }
       //自定义的异常
      //除零异常
        public class CustomException_2 : ApplicationException
        {
            public CustomException_2(string message) : base(message) { }
        }
        //点击按钮进行计算
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                string op = comboBox1.Text;
                double sum = 0;
             
                if(textBox2.Text.Equals("0")&&op.Equals("/"))
                { throw (new CustomException_2("除数为零")); }
                else
                {
                    switch (op)
                    {
                        case "+":
                            sum= num1 + num2;
                            break;
                        case "-":
                            sum = num1- num2;
                            break;
                        case "*":
                            sum = num1 * num2;
                            break;
                        case "/":
                            sum = num1 / num2;
                            break;
                    }
                }
                textBox3.Text = sum.ToString();
            }
            catch (CustomException_2)
            { MessageBox.Show("除数不能为零", "运算提示"); }

            catch (Exception ex) { MessageBox.Show("输入不能为空", "运算提示"); }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
