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
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button0 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(24, 24, 24);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 323);
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
            textBox.Location = new Point(12, 52);
            textBox.Margin = new Padding(0);
            textBox.Multiline = false;
            textBox.Name = "textBox";
            textBox.RightToLeft = RightToLeft.Yes;
            textBox.Size = new Size(309, 77);
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
            button2.Location = new Point(88, 323);
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
            button3.Location = new Point(164, 323);
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
            button6.Location = new Point(164, 267);
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
            button5.Location = new Point(88, 267);
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
            button4.Location = new Point(12, 267);
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
            button9.Location = new Point(164, 211);
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
            button8.Location = new Point(88, 211);
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
            button7.Location = new Point(12, 211);
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
            button_equal.BackColor = Color.FromArgb(24, 24, 24);
            button_equal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button_equal.ForeColor = Color.White;
            button_equal.Location = new Point(251, 379);
            button_equal.Name = "button_equal";
            button_equal.Size = new Size(70, 50);
            button_equal.TabIndex = 11;
            button_equal.Text = "=";
            button_equal.UseVisualStyleBackColor = false;
            button_equal.Click += button_equal_Click;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button10.BackColor = Color.FromArgb(24, 24, 24);
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button10.ForeColor = Color.White;
            button10.Location = new Point(251, 211);
            button10.Name = "button10";
            button10.Size = new Size(70, 50);
            button10.TabIndex = 12;
            button10.Text = "C";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button11.BackColor = Color.FromArgb(24, 24, 24);
            button11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button11.ForeColor = Color.White;
            button11.Location = new Point(251, 267);
            button11.Name = "button11";
            button11.Size = new Size(70, 50);
            button11.TabIndex = 13;
            button11.Text = "+";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button12.BackColor = Color.FromArgb(24, 24, 24);
            button12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button12.ForeColor = Color.White;
            button12.Location = new Point(251, 323);
            button12.Name = "button12";
            button12.Size = new Size(70, 50);
            button12.TabIndex = 14;
            button12.Text = "-";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button0
            // 
            button0.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button0.BackColor = Color.FromArgb(24, 24, 24);
            button0.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button0.ForeColor = Color.White;
            button0.Location = new Point(12, 379);
            button0.Name = "button0";
            button0.Size = new Size(222, 50);
            button0.TabIndex = 15;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 24);
            ClientSize = new Size(333, 441);
            Controls.Add(button0);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
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
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button0;
    }
}
