using System;
using System.Windows;
using CalculatorLibrary;

namespace ScientificCalculator;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly Calculator _calculator;
    private string _input = "";
    private string _operator = "";
    private double _firstNumber;
    private bool _isOperatorClicked = false;

    public MainWindow()
    {
        InitializeComponent();
        _calculator = new Calculator();
    }

    private void Number_Click(object sender, RoutedEventArgs e)
    {
        if (_isOperatorClicked)
        {
            Display.Clear();
            _isOperatorClicked = false;
        }

        _input += (string)((System.Windows.Controls.Button)e.OriginalSource).Content;
        Display.Text = _input;
    }

    private void Operator_Click(object sender, RoutedEventArgs e)
    {
        if (!string.IsNullOrEmpty(_input))
        {
            _firstNumber = double.Parse(_input);
            _operator = (string)((System.Windows.Controls.Button)e.OriginalSource).Content;
            _isOperatorClicked = true;
            _input = "";
        }
    }

    private void Equals_Click(object sender, RoutedEventArgs e)
    {
        if (!string.IsNullOrEmpty(_input))
        {
            double secondNumber = double.Parse(_input);
            double result = 0;

            switch (_operator)
            {
                case "+":
                    result = _calculator.Add(_firstNumber, secondNumber);
                    break;
                case "-":
                    result = _calculator.Subtract(_firstNumber, secondNumber);
                    break;
                case "*":
                    result = _calculator.Multiply(_firstNumber, secondNumber);
                    break;
                case "/":
                    result = _calculator.Divide(_firstNumber, secondNumber);
                    break;
                case "^":
                    result = _calculator.Power(_firstNumber, secondNumber);
                    break;
            }

            Display.Text = result.ToString();
            HistoryLog.Items.Insert(0, $"{_firstNumber} {_operator} {secondNumber} = {result}");
            _input = result.ToString();
        }
    }

    private void Clear_Click(object sender, RoutedEventArgs e)
    {
        _input = "";
        Display.Clear();
    }

    private void Decimal_Click(object sender, RoutedEventArgs e)
    {
        if (!_input.Contains("."))
        {
            _input += ".";
            Display.Text = _input;
        }
    }

    private void ScientificFunction_Click(object sender, RoutedEventArgs e)
    {
        if (!string.IsNullOrEmpty(_input))
        {
            double number = double.Parse(_input);
            string operation = (string)((System.Windows.Controls.Button)e.OriginalSource).Content;
            double result = 0;

            switch (operation)
            {
                case "sin":
                    result = _calculator.Sin(number);
                    break;
                case "cos":
                    result = _calculator.Cos(number);
                    break;
                case "tan":
                    result = _calculator.Tan(number);
                    break;
                case "log":
                    result = _calculator.Log(number);
                    break;
                case "sqrt":
                    result = _calculator.Sqrt(number);
                    break;
            }

            Display.Text = result.ToString();
            HistoryLog.Items.Insert(0, $"{operation}({number}) = {result}");
            _input = result.ToString();
        }
    }
}