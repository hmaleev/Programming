using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace XAMLCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string input =string.Empty;
        string currentNumber = string.Empty;
        decimal result = 0;
        bool signIsMinus;
        bool isDigit =false;

        public MainWindow()
        {
            InitializeComponent();
        }

        public int CreateNumber(string input) 
        {
            return int.Parse(input);
        }

        private void onDigitClick(object sender, RoutedEventArgs e)
        {
            Button digit = (Button)sender;
            
            currentNumber += digit.Content.ToString();
            input += digit.Content.ToString();
            calculatorResult.FontSize = 12;
            calculatorResult.Text = input;
            signIsMinus = false;
            isDigit = true;
        }

        private void onSignClick(object sender, RoutedEventArgs e)
        {
            Button sign = (Button)sender;
            currentNumber = string.Empty;
            if (isDigit)
            {
                input += " " + sign.Content.ToString() + " ";
                isDigit = false;
            }
            else
            {
                input += sign.Content.ToString();
                isDigit = false;
            }
            calculatorResult.Text = input;

            calculatorResult.VerticalAlignment = VerticalAlignment.Top;
        }

        private void onEqualsClick(object sender, RoutedEventArgs e)
        {
            result = 0;
            decimal tempResult = 0;
            string[] parsedInput = input.Split(' ');
            for (int i = 0; i < parsedInput.Length; i++)
            {
                switch (parsedInput[i])
                {
                    default: 
                        {
                            break;
                        }
                    case "+": 
                        {
                            if (tempResult!=0)
                            {
                                result = tempResult + decimal.Parse(parsedInput[i + 1]);
                                //calculatorResult.Text = result.ToString();
                            }
                            else
                            {
                                result = decimal.Parse(parsedInput[i - 1]) + decimal.Parse(parsedInput[i + 1]);
                                //calculatorResult.Text = result.ToString();
                            }
                            
                            tempResult = result;
                            break;
                        }
                    case "-":
                        {
                            if (tempResult != 0)
                            {
                                result = tempResult - decimal.Parse(parsedInput[i + 1]);
                            }
                            else
                            {
                                result = decimal.Parse(parsedInput[i - 1]) - decimal.Parse(parsedInput[i + 1]);
                            }

                            tempResult = result;
                            break;
                        }
                    case "*":
                        {
                            if (tempResult != 0)
                            {
                                result = tempResult * decimal.Parse(parsedInput[i + 1]);
                            }
                            else
                            {
                                result = decimal.Parse(parsedInput[i - 1]) * decimal.Parse(parsedInput[i + 1]);
                            }

                            tempResult = result;
                            break;
                        }
                    case "/":
                        {
                            if (tempResult != 0)
                            {
                                result = tempResult / decimal.Parse(parsedInput[i + 1]);
                            }
                            else
                            {
                                result = decimal.Parse(parsedInput[i - 1]) / decimal.Parse(parsedInput[i + 1]);
                            }
                            tempResult = result;
                            break;
                        }
                }
            }
            calculatorResult.Text = result.ToString();
            calculatorResult.FontSize = 24;
            calculatorResult.VerticalAlignment = VerticalAlignment.Center;
            input = string.Empty;
        }

        private void onDecimalSeparator(object sender, RoutedEventArgs e)
        {
            Button digit = (Button)sender;
            input += digit.Content.ToString();
            calculatorResult.FontSize = 12;
            calculatorResult.Text = input;
        }

        private void onPlusMinusClick(object sender, RoutedEventArgs e)
        {
          
            if (!signIsMinus)
            {
                string negatedNumber = currentNumber.Insert(0, "-");
                input = input.Replace(currentNumber, negatedNumber);

                signIsMinus = true;
            }
            else
            {
                string notNegatedNUmber = currentNumber;

                calculatorResult.Text =input.Replace(currentNumber, notNegatedNUmber);
                signIsMinus = false;
            }
           
        }

        private void onClearClick(object sender, RoutedEventArgs e)
        {

            input = string.Empty;
            calculatorResult.Text = string.Empty;
        }

        private void onSquareRootClick(object sender, RoutedEventArgs e)
        {
            calculatorResult.Text = Math.Sqrt(double.Parse(input)).ToString();
            calculatorResult.FontSize = 24;
            calculatorResult.VerticalAlignment = VerticalAlignment.Center;
            input = string.Empty;
        }
    }
}