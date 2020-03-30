namespace Homework7
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtLeng = new System.Windows.Forms.TextBox();
            this.txtPer1 = new System.Windows.Forms.TextBox();
            this.txtPer2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PaintPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(158, 10);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 25);
            this.txtN.TabIndex = 1;
            this.txtN.TextChanged += new System.EventHandler(this.N_TXTChanged);
            // 
            // txtLeng
            // 
            this.txtLeng.Location = new System.Drawing.Point(158, 49);
            this.txtLeng.Name = "txtLeng";
            this.txtLeng.Size = new System.Drawing.Size(100, 25);
            this.txtLeng.TabIndex = 2;
            this.txtLeng.TextChanged += new System.EventHandler(this.leng_TXTChanged);
            // 
            // txtPer1
            // 
            this.txtPer1.Location = new System.Drawing.Point(158, 104);
            this.txtPer1.Name = "txtPer1";
            this.txtPer1.Size = new System.Drawing.Size(100, 25);
            this.txtPer1.TabIndex = 3;
            this.txtPer1.TextChanged += new System.EventHandler(this.per1_TXTChanged);
            // 
            // txtPer2
            // 
            this.txtPer2.Location = new System.Drawing.Point(158, 145);
            this.txtPer2.Name = "txtPer2";
            this.txtPer2.Size = new System.Drawing.Size(100, 25);
            this.txtPer2.TabIndex = 4;
            this.txtPer2.TextChanged += new System.EventHandler(this.per2_TXTChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "递归深度(n)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPen);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtLeng);
            this.panel1.Controls.Add(this.txtPer2);
            this.panel1.Controls.Add(this.txtPer1);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 260);
            this.panel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "画笔颜色(pen)";
            // 
            // txtPen
            // 
            this.txtPen.Location = new System.Drawing.Point(158, 197);
            this.txtPen.Name = "txtPen";
            this.txtPen.Size = new System.Drawing.Size(100, 25);
            this.txtPen.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "左分支长度(per2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "右分支长度(per1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "主干长度（leng)";
            // 
            // PaintPanel
            // 
            this.PaintPanel.Location = new System.Drawing.Point(403, 44);
            this.PaintPanel.Name = "PaintPanel";
            this.PaintPanel.Size = new System.Drawing.Size(377, 431);
            this.PaintPanel.TabIndex = 7;
            this.PaintPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.paint_panel);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "修改绘画参数";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 539);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PaintPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Cayley Tree";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtLeng;
        private System.Windows.Forms.TextBox txtPer1;
        private System.Windows.Forms.TextBox txtPer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PaintPanel;
        private System.Windows.Forms.Label label6;
    }
}

