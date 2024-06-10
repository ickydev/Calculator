using System.Linq;

namespace Calculator
{
    public partial class Calculator : Form
    {

        protected bool selectedValue;
        protected Int16 selectedType;

        protected double value0;
        protected double value1;

        public Calculator(){
            // Begin the application
            InitializeComponent();
            ResetValue();
        }

        static double Add(double v1, double v2){
            return v1 + v2; // Return the addiction of v1 and v2
        }

        static double Subtract(double v1, double v2){
            return v1 - v2; // Return the subtraction of v1 and v2
        }

        static double Multiply(double v1, double v2){
            return v1 * v2; // Return the multiplication of v1 and v2
        }

        static double Divide(double v1, double v2){
            return v1 / v2; // Return the division of v1 and v2
        }

        static double DivRemainder(double v1, double v2){
            return v1 % v2; // Return the remainder of v1 and v2 division
        }

        static double Exponent(double v1, double v2){
            return Math.Pow(v1, v2); // Return the exponent of v1 and v2
        }

        private void button0_Click(object sender, EventArgs e){
            AddValue("0");
        }

        private void button1_Click(object sender, EventArgs e){
            AddValue("1");
        }

        private void button2_Click(object sender, EventArgs e){
            AddValue("2");
        }

        private void button3_Click(object sender, EventArgs e){
            AddValue("3");
        }

        private void button4_Click(object sender, EventArgs e){
            AddValue("4");
        }

        private void button5_Click(object sender, EventArgs e){
            AddValue("5");
        }

        private void button6_Click(object sender, EventArgs e){
            AddValue("6");
        }

        private void button7_Click(object sender, EventArgs e){
            AddValue("7");
        }

        private void button8_Click(object sender, EventArgs e){
            AddValue("8");
        }

        private void button9_Click(object sender, EventArgs e){
            AddValue("9");
        }

        private void button_comma_Click(object sender, EventArgs e){
            AddValue(",");
        }

        private void button_equal_Click(object sender, EventArgs e){

            ParseValues();

            switch (selectedType)
            {
                case 1:
                    textBox.Text = Add(value0, value1).ToString();
                    break;
                case 2:
                    textBox.Text = Subtract(value0, value1).ToString();
                    break;
                case 3:
                    textBox.Text = Multiply(value0, value1).ToString();
                    break;
                case 4:
                    textBox.Text = Divide(value0, value1).ToString();
                    break;
                case 5:
                    textBox.Text = DivRemainder(value0, value1).ToString();
                    break;
                case 6:
                    textBox.Text = Exponent(value0, value1).ToString();
                    break;
                default:
                    textBox.Text = "Incorrect method!";
                    break;
            }
        }

        private void button_clear_Click(object sender, EventArgs e){
            selectedType = 0;
            selectedValue = false;
            ResetValue();
        }

        private void button_sum_Click(object sender, EventArgs e){
            ParseValues();
            selectedType = 1;
            selectedValue = true;
            ResetValue();
        }

        private void button_sub_Click(object sender, EventArgs e){
            ParseValues();
            selectedType = 2;
            selectedValue = true;
            ResetValue();
        }

        private void button_multiply_Click(object sender, EventArgs e){
            ParseValues();
            selectedType = 3;
            selectedValue = true;
            ResetValue();
        }

        private void button_divide_Click(object sender, EventArgs e){
            ParseValues();
            selectedType = 4;
            selectedValue = true;
            ResetValue();
        }

        private void button_divRemainder_Click(object sender, EventArgs e){
            ParseValues();
            selectedType = 5;
            selectedValue = true;
            ResetValue();
        }

        private void button_exponent_Click(object sender, EventArgs e){
            ParseValues();
            selectedType = 6;
            selectedValue = true;
            ResetValue();
        }

        private void AddValue(string value){
            textBox.Text += value;
        }

        private void ResetValue(){
            textBox.Text = "";
        }

        private void ParseValues(){
            if (!selectedValue)
            {
                // Try to convert string to value0 integer 
                try{
                    value0 = Double.Parse(textBox.Text);
                    Console.WriteLine(value0);
                }
                catch (FormatException e){
                    Console.WriteLine(e.Message);
                    ResetValue();
                }
            }

            else
            {   // Try to convert string to value1 integer 
                try{
                    value1 = Double.Parse(textBox.Text);
                    Console.WriteLine(value1);
                }
                catch (FormatException e){
                    Console.WriteLine(e.Message);
                    ResetValue();
                }
            }

        }

        private void textBox_TextChanged(object sender, EventArgs e){
            // Unused
        }
    }
}
