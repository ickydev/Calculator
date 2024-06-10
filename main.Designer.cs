namespace Calculator
{
    partial class Calculator
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
            button1 = new Button();
            textBox = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button_equal = new Button();
            button_clear = new Button();
            button_sum = new Button();
            button_sub = new Button();
            button0 = new Button();
            button_multiply = new Button();
            button_divide = new Button();
            button_divRemainder = new Button();
            button_exponent = new Button();
            button_comma = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(24, 24, 24);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(11, 323);
            button1.Name = "button1";
            button1.Size = new Size(70, 50);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox.BackColor = Color.FromArgb(24, 24, 24);
            textBox.BorderStyle = BorderStyle.None;
            textBox.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox.ForeColor = Color.White;
            textBox.Location = new Point(12, 35);
            textBox.Margin = new Padding(0);
            textBox.Multiline = false;
            textBox.Name = "textBox";
            textBox.RightToLeft = RightToLeft.Yes;
            textBox.Size = new Size(297, 70);
            textBox.TabIndex = 2;
            textBox.Text = "0";
            textBox.TextChanged += textBox_TextChanged;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(24, 24, 24);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(87, 323);
            button2.Name = "button2";
            button2.Size = new Size(70, 50);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(24, 24, 24);
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(163, 323);
            button3.Name = "button3";
            button3.Size = new Size(70, 50);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button6.BackColor = Color.FromArgb(24, 24, 24);
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button6.ForeColor = Color.White;
            button6.Location = new Point(163, 267);
            button6.Name = "button6";
            button6.Size = new Size(70, 50);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.BackColor = Color.FromArgb(24, 24, 24);
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(87, 267);
            button5.Name = "button5";
            button5.Size = new Size(70, 50);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(24, 24, 24);
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(11, 267);
            button4.Name = "button4";
            button4.Size = new Size(70, 50);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button9.BackColor = Color.FromArgb(24, 24, 24);
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button9.ForeColor = Color.White;
            button9.Location = new Point(163, 211);
            button9.Name = "button9";
            button9.Size = new Size(70, 50);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button8.BackColor = Color.FromArgb(24, 24, 24);
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button8.ForeColor = Color.White;
            button8.Location = new Point(87, 211);
            button8.Name = "button8";
            button8.Size = new Size(70, 50);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button7.BackColor = Color.FromArgb(24, 24, 24);
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button7.ForeColor = Color.White;
            button7.Location = new Point(11, 211);
            button7.Name = "button7";
            button7.Size = new Size(70, 50);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button_equal
            // 
            button_equal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_equal.BackColor = Color.FromArgb(32, 32, 32);
            button_equal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_equal.ForeColor = Color.White;
            button_equal.Location = new Point(162, 379);
            button_equal.Name = "button_equal";
            button_equal.Size = new Size(147, 50);
            button_equal.TabIndex = 11;
            button_equal.Text = "=";
            button_equal.UseVisualStyleBackColor = false;
            button_equal.Click += button_equal_Click;
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_clear.BackColor = Color.FromArgb(24, 24, 24);
            button_clear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(12, 155);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(70, 50);
            button_clear.TabIndex = 12;
            button_clear.Text = "C";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // button_sum
            // 
            button_sum.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_sum.BackColor = Color.FromArgb(24, 24, 24);
            button_sum.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_sum.ForeColor = Color.White;
            button_sum.Location = new Point(239, 323);
            button_sum.Name = "button_sum";
            button_sum.Size = new Size(70, 50);
            button_sum.TabIndex = 13;
            button_sum.Text = "+";
            button_sum.UseVisualStyleBackColor = false;
            button_sum.Click += button_sum_Click;
            // 
            // button_sub
            // 
            button_sub.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_sub.BackColor = Color.FromArgb(24, 24, 24);
            button_sub.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_sub.ForeColor = Color.White;
            button_sub.Location = new Point(239, 267);
            button_sub.Name = "button_sub";
            button_sub.Size = new Size(70, 50);
            button_sub.TabIndex = 14;
            button_sub.Text = "-";
            button_sub.UseVisualStyleBackColor = false;
            button_sub.Click += button_sub_Click;
            // 
            // button0
            // 
            button0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button0.BackColor = Color.FromArgb(24, 24, 24);
            button0.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button0.ForeColor = Color.White;
            button0.Location = new Point(88, 379);
            button0.Name = "button0";
            button0.Size = new Size(70, 50);
            button0.TabIndex = 15;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // button_multiply
            // 
            button_multiply.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_multiply.BackColor = Color.FromArgb(24, 24, 24);
            button_multiply.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_multiply.ForeColor = Color.White;
            button_multiply.Location = new Point(239, 211);
            button_multiply.Name = "button_multiply";
            button_multiply.Size = new Size(70, 50);
            button_multiply.TabIndex = 16;
            button_multiply.Text = "*";
            button_multiply.UseVisualStyleBackColor = false;
            button_multiply.Click += button_multiply_Click;
            // 
            // button_divide
            // 
            button_divide.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_divide.BackColor = Color.FromArgb(24, 24, 24);
            button_divide.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_divide.ForeColor = Color.White;
            button_divide.Location = new Point(239, 155);
            button_divide.Name = "button_divide";
            button_divide.Size = new Size(70, 50);
            button_divide.TabIndex = 17;
            button_divide.Text = "/";
            button_divide.UseVisualStyleBackColor = false;
            button_divide.Click += button_divide_Click;
            // 
            // button_divRemainder
            // 
            button_divRemainder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_divRemainder.BackColor = Color.FromArgb(24, 24, 24);
            button_divRemainder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_divRemainder.ForeColor = Color.White;
            button_divRemainder.Location = new Point(88, 155);
            button_divRemainder.Name = "button_divRemainder";
            button_divRemainder.Size = new Size(70, 50);
            button_divRemainder.TabIndex = 18;
            button_divRemainder.Text = "%";
            button_divRemainder.UseVisualStyleBackColor = false;
            button_divRemainder.Click += button_divRemainder_Click;
            // 
            // button_exponent
            // 
            button_exponent.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_exponent.BackColor = Color.FromArgb(24, 24, 24);
            button_exponent.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_exponent.ForeColor = Color.White;
            button_exponent.Location = new Point(163, 155);
            button_exponent.Name = "button_exponent";
            button_exponent.Size = new Size(70, 50);
            button_exponent.TabIndex = 19;
            button_exponent.Text = "**";
            button_exponent.UseVisualStyleBackColor = false;
            button_exponent.Click += button_exponent_Click;
            // 
            // button_comma
            // 
            button_comma.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_comma.BackColor = Color.FromArgb(24, 24, 24);
            button_comma.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_comma.ForeColor = Color.White;
            button_comma.Location = new Point(12, 379);
            button_comma.Name = "button_comma";
            button_comma.Size = new Size(70, 50);
            button_comma.TabIndex = 21;
            button_comma.Text = ",";
            button_comma.UseVisualStyleBackColor = false;
            button_comma.Click += button_comma_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 24);
            ClientSize = new Size(324, 441);
            Controls.Add(button_comma);
            Controls.Add(button_exponent);
            Controls.Add(button_divRemainder);
            Controls.Add(button_divide);
            Controls.Add(button_multiply);
            Controls.Add(button0);
            Controls.Add(button_sub);
            Controls.Add(button_sum);
            Controls.Add(button_clear);
            Controls.Add(button_equal);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox);
            Controls.Add(button1);
            MaximizeBox = false;
            MaximumSize = new Size(340, 480);
            Name = "Calculator";
            Opacity = 0.9D;
            Text = "Calculator";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private RichTextBox textBox;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button_equal;
        private Button button_clear;
        private Button button_sum;
        private Button button_sub;
        private Button button0;
        private Button button_multiply;
        private Button button_divide;
        private Button button_divRemainder;
        private Button button_exponent;
        private Button button_comma;
    }
}
