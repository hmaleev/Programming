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
        decimal result = 0;
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
            input += digit.Content.ToString();
            calculatorResult.FontSize = 12;
            calculatorResult.Text = input;
        }

        private void onSignClick(object sender, RoutedEventArgs e)
        {
            Button digit = (Button)sender;
            input += " " + digit.Content.ToString() +" " ;
            calculatorResult.Text = input;
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
            input = string.Empty;
        }

        private void onDecimalSeparator(object sender, RoutedEventArgs e)
        {
            Button digit = (Button)sender;
            input += digit.Content.ToString();
            calculatorResult.FontSize = 12;
            calculatorResult.Text = input;
        }
    }
}
