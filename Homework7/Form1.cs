using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework7
{
    public partial class Form1 : Form
    {
        public Graphics graphics;
        public double th1 = 30 * Math.PI / 180;
        public double th2 = 20 * Math.PI / 180;
        public double per1;
        public double per2;
        public double leng;

        public Form1()
        {
            InitializeComponent();
           
        }
        void drawCayleyTree(int n, double x0, double y0, double leng, double th, double per1, double per2)
        {
            if (n == 0) return;

            else
            {
                double x1 = x0 + leng * Math.Cos(th);
                double y1 = y0 + leng * Math.Sin(th);

                drawLine(x0, y0, x1, y1);

                drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1,per1,per2);
                drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2,per1,per2);

            }
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
        }


        private void button1_Click(object sender, EventArgs e)
        {


            if (graphics == null) graphics = PaintPanel.CreateGraphics();
           
                drawCayleyTree(int.Parse(txtN.Text),200,300,double.Parse(txtLeng.Text),20,double.Parse(txtPer1.Text),double.Parse(txtPer2.Text));


        }

        private void N_TXTChanged(object sender, EventArgs e)
        {
            string n = txtN.Text.ToString();
        }

        private void leng_TXTChanged(object sender, EventArgs e)
        {
            leng = double.Parse(txtLeng.Text.ToString());
        }

        private void per1_TXTChanged(object sender, EventArgs e)
        {
            per1 = double.Parse(txtPer1.Text.ToString());
        }

        private void per2_TXTChanged(object sender, EventArgs e)
        {
            per2 = double.Parse(txtPer2.Text.ToString());
        }

        private void paint_panel(object sender, PaintEventArgs e)
        {
           

        }
    }
}
