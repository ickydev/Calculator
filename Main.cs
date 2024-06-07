using System.Linq;

namespace Calculator
{
    public partial class Calculator : Form
    {

        protected bool selectedValue;
        protected Int16 selectedType;

        protected float value0;
        protected float value1;

        public Calculator()
        {
            InitializeComponent();
            textBox.Text = "";
        }

        static float Add(float v1, float v2)
        {
            return v1 + v2;
        }

        static float Subtract(float v1, float v2)
        {
            return v1 - v2;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            ParseValues();
            switch (selectedType)
            {
                case 1:
                    textBox.Text = Add(value0, value1).ToString();
                    break;
                case 2:
                    textBox.Text = Subtract(value0, value1).ToString();
                    break;
                default:
                    textBox.Text = "Incorrect method!";
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            selectedType = 0;
            selectedValue = false;
            textBox.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ParseValues();
            selectedType = 1;
            selectedValue = true;
            textBox.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ParseValues();
            selectedType = 2;
            selectedValue = true;
            textBox.Text = "";
        }

        private void ParseValues()
        {
            if (!selectedValue)
            {
                try
                {
                    value0 = Int32.Parse(textBox.Text);
                    Console.WriteLine(value0);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            else
            {
                try
                {
                    value1 = Int32.Parse(textBox.Text);
                    Console.WriteLine(value1);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
