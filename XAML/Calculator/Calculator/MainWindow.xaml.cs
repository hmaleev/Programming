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
        int result = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;
            currentTextBox.Text = input;
        }


        public int CreateNumber(string input)
        {
            return int.Parse(input);
        }

        private void onDigitClick(object sender, RoutedEventArgs e)
        {
            Button digit = (Button)sender;
            input += digit.Content.ToString();
        }

        private void onSignClick(object sender, RoutedEventArgs e)
        {
            Button digit = (Button)sender;
            input += " " + digit.Content.ToString() +" " ;
        }

        private void onEqualsClick(object sender, RoutedEventArgs e)
        {

            result = 0;
            int tempResult = 0;
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
                                result = tempResult + int.Parse(parsedInput[i + 1]);
                            }
                            else
                            {
                                result =  int.Parse(parsedInput[i - 1]) + int.Parse(parsedInput[i + 1]);
                            }
                            
                            tempResult = result;
                            break;
                        }
                    case "-":
                        {
                            if (tempResult != 0)
                            {
                                result = tempResult - int.Parse(parsedInput[i + 1]);
                            }
                            else
                            {
                                result = int.Parse(parsedInput[i - 1]) - int.Parse(parsedInput[i + 1]);
                            }

                            tempResult = result;
                            break;
                        }
                    case "*":
                        {
                            if (tempResult != 0)
                            {
                                result = tempResult * int.Parse(parsedInput[i + 1]);
                            }
                            else
                            {
                                result = int.Parse(parsedInput[i - 1]) * int.Parse(parsedInput[i + 1]);
                            }

                            tempResult = result;
                            break;
                        }
                    case "/":
                        {
                            if (tempResult != 0)
                            {
                                result = tempResult / int.Parse(parsedInput[i + 1]);
                            }
                            else
                            {
                                result = int.Parse(parsedInput[i - 1]) / int.Parse(parsedInput[i + 1]);
                            }

                            tempResult = result;
                            break;
                        }
                }
            }
            MessageBox.Show(result.ToString());
            input = string.Empty;
            
        }


    }
}
