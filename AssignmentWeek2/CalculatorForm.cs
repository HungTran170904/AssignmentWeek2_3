using System.CodeDom;
using System.Data;

namespace AssignmentWeek2
{
    public partial class CalculatorForm : Form
    {
        private DataTable dt=new DataTable();
        private string mathExpression = "";
        private string result = "";
        public CalculatorForm()
        {
            InitializeComponent();
            button_seven.Click+=button_Click;
            button_eight.Click += button_Click;
            button_nine.Click += button_Click;
            button_div.Click += button_Click;
            button_ce.Click += button_Click;
            button_four.Click += button_Click;
            button_five.Click += button_Click;
            button_six.Click += button_Click;
            button_mul.Click += button_Click;
            button_c.Click += button_Click;
            button_one.Click += button_Click;
            button_two.Click += button_Click;
            button_three.Click += button_Click;
            button_sub.Click += button_Click;
            button_dot.Click += button_Click;
            button_add.Click += button_Click;
            button_zero.Click += button_Click;
            button_eq.Click += button_Click;

    }
        private void button_Click(object sender, EventArgs e)
        {
            Button button= sender as Button;
            string text = button.Text;
            if (text.Equals("C")) mathExpression = "";
            else if (text.Equals("CE") && textBox.Text.Length > 0)
                mathExpression = mathExpression.Substring(0, mathExpression.Length - 1);
            else if (text.Equals("="))
            {
                try
                {
                    result = dt.Compute(textBox.Text, null).ToString();
                }
                catch (EvaluateException)
                {
                    result = "Divide by zero is invalid";
                }
                catch (SyntaxErrorException)
                {
                    result= "There is error with syntax of math expression you entered";
                }
                catch (InvalidCastException)
                {
                    result = "Cannot read a specific number! Please correct it";
                }
                catch (FormatException)
                {
                    result = "The format of the math expression is invalid";
                }
                catch (Exception)
                {
                    result = "There is an error";
                }
                textBox.Lines = [mathExpression, result];
                return;
            }
            else mathExpression += text;
            textBox.Text = mathExpression;
        }
    }
}
