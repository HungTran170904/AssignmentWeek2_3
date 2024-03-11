using System.Data;

namespace AssignmentWeek2
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel = new TableLayoutPanel();
            button_seven = new Button();
            button_eight = new Button();
            button_nine = new Button();
            button_div = new Button();
            button_ce = new Button();
            button_four = new Button();
            button_five = new Button();
            button_six = new Button();
            button_mul = new Button();
            button_c = new Button();
            button_one = new Button();
            button_two = new Button();
            button_three = new Button();
            button_sub = new Button();
            button_dot = new Button();
            button_add = new Button();
            button_zero = new Button();
            button_eq = new Button();
            textBox = new TextBox();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 5;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel.Controls.Add(button_seven, 0, 1);
            tableLayoutPanel.Controls.Add(button_eight, 1, 1);
            tableLayoutPanel.Controls.Add(button_nine, 2, 1);
            tableLayoutPanel.Controls.Add(button_div, 3, 1);
            tableLayoutPanel.Controls.Add(button_ce, 4, 1);
            tableLayoutPanel.Controls.Add(button_four, 0, 2);
            tableLayoutPanel.Controls.Add(button_five, 1, 2);
            tableLayoutPanel.Controls.Add(button_six, 2, 2);
            tableLayoutPanel.Controls.Add(button_mul, 3, 2);
            tableLayoutPanel.Controls.Add(button_c, 4, 2);
            tableLayoutPanel.Controls.Add(button_one, 0, 3);
            tableLayoutPanel.Controls.Add(button_two, 1, 3);
            tableLayoutPanel.Controls.Add(button_three, 2, 3);
            tableLayoutPanel.Controls.Add(button_sub, 3, 3);
            tableLayoutPanel.Controls.Add(button_dot, 2, 4);
            tableLayoutPanel.Controls.Add(button_add, 3, 4);
            tableLayoutPanel.Controls.Add(button_zero, 0, 4);
            tableLayoutPanel.Controls.Add(button_eq, 4, 3);
            tableLayoutPanel.Controls.Add(textBox, 0, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 5;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3377762F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.665554F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6655579F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.665554F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.665554F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(529, 534);
            tableLayoutPanel.TabIndex = 0;
            // 
            // button_seven
            // 
            button_seven.AutoSize = true;
            button_seven.Dock = DockStyle.Fill;
            button_seven.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_seven.Location = new Point(3, 181);
            button_seven.Name = "button_seven";
            button_seven.Size = new Size(99, 82);
            button_seven.TabIndex = 1;
            button_seven.Text = "7";
            button_seven.UseVisualStyleBackColor = true;
            // 
            // button_eight
            // 
            button_eight.AutoSize = true;
            button_eight.Dock = DockStyle.Fill;
            button_eight.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_eight.Location = new Point(108, 181);
            button_eight.Name = "button_eight";
            button_eight.Size = new Size(99, 82);
            button_eight.TabIndex = 2;
            button_eight.Text = "8";
            button_eight.UseVisualStyleBackColor = true;
            // 
            // button_nine
            // 
            button_nine.AutoSize = true;
            button_nine.Dock = DockStyle.Fill;
            button_nine.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_nine.Location = new Point(213, 181);
            button_nine.Name = "button_nine";
            button_nine.Size = new Size(99, 82);
            button_nine.TabIndex = 3;
            button_nine.Text = "9";
            button_nine.UseVisualStyleBackColor = true;
            // 
            // button_div
            // 
            button_div.AutoSize = true;
            button_div.Dock = DockStyle.Fill;
            button_div.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_div.Location = new Point(318, 181);
            button_div.Name = "button_div";
            button_div.Size = new Size(99, 82);
            button_div.TabIndex = 4;
            button_div.Text = "/";
            button_div.UseVisualStyleBackColor = true;
            // 
            // button_ce
            // 
            button_ce.AutoSize = true;
            button_ce.Dock = DockStyle.Fill;
            button_ce.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_ce.Location = new Point(423, 181);
            button_ce.Name = "button_ce";
            button_ce.Size = new Size(103, 82);
            button_ce.TabIndex = 5;
            button_ce.Text = "CE";
            button_ce.UseVisualStyleBackColor = true;
            // 
            // button_four
            // 
            button_four.AutoSize = true;
            button_four.Dock = DockStyle.Fill;
            button_four.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_four.Location = new Point(3, 269);
            button_four.Name = "button_four";
            button_four.Size = new Size(99, 82);
            button_four.TabIndex = 6;
            button_four.Text = "4";
            button_four.UseVisualStyleBackColor = true;
            // 
            // button_five
            // 
            button_five.AutoSize = true;
            button_five.Dock = DockStyle.Fill;
            button_five.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_five.Location = new Point(108, 269);
            button_five.Name = "button_five";
            button_five.Size = new Size(99, 82);
            button_five.TabIndex = 7;
            button_five.Text = "5";
            button_five.UseVisualStyleBackColor = true;
            // 
            // button_six
            // 
            button_six.AutoSize = true;
            button_six.Dock = DockStyle.Fill;
            button_six.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_six.Location = new Point(213, 269);
            button_six.Name = "button_six";
            button_six.Size = new Size(99, 82);
            button_six.TabIndex = 8;
            button_six.Text = "6";
            button_six.UseVisualStyleBackColor = true;
            // 
            // button_mul
            // 
            button_mul.AutoSize = true;
            button_mul.Dock = DockStyle.Fill;
            button_mul.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_mul.Location = new Point(318, 269);
            button_mul.Name = "button_mul";
            button_mul.Size = new Size(99, 82);
            button_mul.TabIndex = 9;
            button_mul.Text = "*";
            button_mul.UseVisualStyleBackColor = true;
            // 
            // button_c
            // 
            button_c.AutoSize = true;
            button_c.Dock = DockStyle.Fill;
            button_c.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_c.Location = new Point(423, 269);
            button_c.Name = "button_c";
            button_c.Size = new Size(103, 82);
            button_c.TabIndex = 10;
            button_c.Text = "C";
            button_c.UseVisualStyleBackColor = true;
            // 
            // button_one
            // 
            button_one.AutoSize = true;
            button_one.Dock = DockStyle.Fill;
            button_one.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_one.Location = new Point(3, 357);
            button_one.Name = "button_one";
            button_one.Size = new Size(99, 82);
            button_one.TabIndex = 11;
            button_one.Text = "1";
            button_one.UseVisualStyleBackColor = true;
            // 
            // button_two
            // 
            button_two.AutoSize = true;
            button_two.Dock = DockStyle.Fill;
            button_two.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_two.Location = new Point(108, 357);
            button_two.Name = "button_two";
            button_two.Size = new Size(99, 82);
            button_two.TabIndex = 12;
            button_two.Text = "2";
            button_two.UseVisualStyleBackColor = true;
            // 
            // button_three
            // 
            button_three.AutoSize = true;
            button_three.Dock = DockStyle.Fill;
            button_three.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_three.Location = new Point(213, 357);
            button_three.Name = "button_three";
            button_three.Size = new Size(99, 82);
            button_three.TabIndex = 13;
            button_three.Text = "3";
            button_three.UseVisualStyleBackColor = true;
            // 
            // button_sub
            // 
            button_sub.AutoSize = true;
            button_sub.Dock = DockStyle.Fill;
            button_sub.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_sub.Location = new Point(318, 357);
            button_sub.Name = "button_sub";
            button_sub.Size = new Size(99, 82);
            button_sub.TabIndex = 14;
            button_sub.Text = "-";
            button_sub.UseVisualStyleBackColor = true;
            // 
            // button_dot
            // 
            button_dot.AutoSize = true;
            button_dot.Dock = DockStyle.Fill;
            button_dot.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_dot.Location = new Point(213, 445);
            button_dot.Name = "button_dot";
            button_dot.Size = new Size(99, 86);
            button_dot.TabIndex = 15;
            button_dot.Text = ".";
            button_dot.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            button_add.AutoSize = true;
            button_add.Dock = DockStyle.Fill;
            button_add.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_add.Location = new Point(318, 445);
            button_add.Name = "button_add";
            button_add.Size = new Size(99, 86);
            button_add.TabIndex = 16;
            button_add.Text = "+";
            button_add.UseVisualStyleBackColor = true;
            // 
            // button_zero
            // 
            button_zero.AutoSize = true;
            tableLayoutPanel.SetColumnSpan(button_zero, 2);
            button_zero.Dock = DockStyle.Fill;
            button_zero.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_zero.Location = new Point(3, 445);
            button_zero.Name = "button_zero";
            button_zero.Size = new Size(204, 86);
            button_zero.TabIndex = 17;
            button_zero.Text = "0";
            button_zero.UseVisualStyleBackColor = true;
            // 
            // button_eq
            // 
            button_eq.AutoSize = true;
            button_eq.Dock = DockStyle.Fill;
            button_eq.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button_eq.Location = new Point(423, 357);
            button_eq.Name = "button_eq";
            tableLayoutPanel.SetRowSpan(button_eq, 2);
            button_eq.Size = new Size(103, 174);
            button_eq.TabIndex = 18;
            button_eq.Text = "=";
            button_eq.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            textBox.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanel.SetColumnSpan(textBox, 5);
            textBox.Dock = DockStyle.Fill;
            textBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBox.Location = new Point(10, 30);
            textBox.Margin = new Padding(10, 30, 10, 30);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ReadOnly = true;
            textBox.Size = new Size(509, 118);
            textBox.TabIndex = 19;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 534);
            Controls.Add(tableLayoutPanel);
            Name = "CalculatorForm";
            Text = "Calculator";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Button button_seven;
        private Button button_eight;
        private Button button_nine;
        private Button button_div;
        private Button button_ce;
        private Button button_four;
        private Button button_five;
        private Button button_six;
        private Button button_mul;
        private Button button_c;
        private Button button_one;
        private Button button_two;
        private Button button_three;
        private Button button_sub;
        private Button button_dot;
        private Button button_add;
        private Button button_zero;
        private Button button_eq;
        private TextBox textBox;
    }
}
