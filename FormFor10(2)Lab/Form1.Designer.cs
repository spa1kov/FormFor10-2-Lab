
using System;
using System.Windows.Forms;

namespace FormFor10_2_Lab
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 15F);
            label1.Location = new Point(360, 74);
            label1.Name = "label1";
            label1.Size = new Size(77, 24);
            label1.TabIndex = 0;
            label1.Text = "Решение:";
            // 
            // button1
            // 
            button1.Location = new Point(514, 257);
            button1.Name = "button1";
            button1.Size = new Size(206, 76);
            button1.TabIndex = 1;
            button1.Text = "Суммированием в цикле (n + 1)(2p + n)/2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(70, 257);
            button2.Name = "button2";
            button2.Size = new Size(206, 76);
            button2.TabIndex = 2;
            button2.Text = "Формулы суммы p + (p + 1) + (p + 2) + ⋯ + (p + n) ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(332, 285);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Script MT Bold", 15F);
            label2.Location = new Point(360, 175);
            label2.Name = "label2";
            label2.Size = new Size(0, 24);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Script MT Bold", 15F);
            label3.Location = new Point(360, 137);
            label3.Name = "label3";
            label3.Size = new Size(0, 24);
            label3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Script MT Bold", 15F);
            label4.Location = new Point(300, 285);
            label4.Name = "label4";
            label4.Size = new Size(26, 24);
            label4.TabIndex = 4;
            label4.Text = "Р:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Script MT Bold", 15F);
            label5.Location = new Point(300, 329);
            label5.Name = "label5";
            label5.Size = new Size(34, 24);
            label5.TabIndex = 5;
            label5.Text = "N:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(332, 329);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(EventArgs e, object sender)
        {

        }

        private void button2_Click(EventArgs e, object sender)
        {
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
    }
}