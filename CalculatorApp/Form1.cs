using System.Globalization;

namespace CalculatorApp;

public partial class Form1 : Form
{
    private string _first = "";
    private string _second = "";
    private string _function = "";
    private double _result;
    private string _userInput = "";
    
    public Form1()
    {
        InitializeComponent();
    }

    private void button0_Click(object sender, EventArgs e)
    {
        ProcessInput("0");
    }
    private void button1_Click(object sender, EventArgs e)
    {
        ProcessInput("1");
    }
    private void button2_Click(object sender, EventArgs e)
    {
        ProcessInput("2");
    }
    private void button3_Click(object sender, EventArgs e)
    {
        ProcessInput("3");
    }
    private void button4_Click(object sender, EventArgs e)
    {
        ProcessInput("4");
    }
    private void button5_Click(object sender, EventArgs e)
    {
        ProcessInput("5");
    }
    private void button6_Click(object sender, EventArgs e)
    {
        ProcessInput("6");
    }
    private void button7_Click(object sender, EventArgs e)
    {
        ProcessInput("7");
    }

    private void button8_Click(object sender, EventArgs e)
    {
        ProcessInput("8");
    }
    private void button9_Click(object sender, EventArgs e)
    {
        ProcessInput("9");
    }
    private void buttonEquals_Click(object sender, EventArgs e)
    {
        _second = _userInput;
        var firstNum = Convert.ToDouble(_first);
        var secondNum = Convert.ToDouble(_second);
        switch (_function)
        {
            // add
            case "+":
                _result = firstNum + secondNum;
                calculatorDisplay.Text = _result.ToString(CultureInfo.CurrentCulture);
                break;
            // minus
            case "-":
                _result = firstNum - secondNum;
                calculatorDisplay.Text = _result.ToString(CultureInfo.CurrentCulture);
                break;
            // divide
            case "/" when secondNum == 0d:
                calculatorDisplay.Text = "Invalid num";
                break;
            case "/":
                _result = firstNum / secondNum;
                calculatorDisplay.Text = _result.ToString(CultureInfo.CurrentCulture);
                break;
            // multiply
            case "*":
                _result = firstNum * secondNum;
                calculatorDisplay.Text = _result.ToString(CultureInfo.CurrentCulture);
                break;
        }
    }
    private void buttonClear_Click(object sender, EventArgs e)
    {
        _first = "";
        _second = "";
        _userInput = "";
        _result = 0.00;
        calculatorDisplay.Text = " 0 ";
    }
    private void buttonAdd_Click(object sender, EventArgs e)
    {
        calculatorDisplay.Text += " + ";
        _function = "+";
        _first = _userInput;
        _userInput = "";
    }
    private void buttonSubtract_Click(object sender, EventArgs e)
    {
        calculatorDisplay.Text += " - ";
        _function = "-";
        _first = _userInput;
        _userInput = "";
    }
    private void buttonMultiply_Click(object sender, EventArgs e)
    {
        calculatorDisplay.Text += " * ";
        _function = "*";
        _first = _userInput;
        _userInput = "";
    }
    private void buttonDivide_Click(object sender, EventArgs e)
    {
        calculatorDisplay.Text += " / ";
        _function = "/";
        _first = _userInput;
        _userInput = "";
    }
    private void buttonDecimal_Click(object sender, EventArgs e)
    {
        ProcessInput(".");
    }
    
    private void ProcessInput(string input)
    {
        if (_first == "") calculatorDisplay.Text = "0";
        _userInput += input;
        calculatorDisplay.Text = _function.Length < 1 ? _first + _userInput : $"{_first} {_function} {_userInput}";
    }
}