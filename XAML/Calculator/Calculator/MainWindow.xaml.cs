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
        string number;
     
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox result = (TextBox)sender;
            result.Text = number;
        }

        //private void onDigitClick(object sender, RoutedEventArgs e)
        //{
        //    Button digit = (Button)sender;
        //    number += digit.Content.ToString();

        //}
        public int CreateNumber(string input)
        {
            return int.Parse(input);
        }

        //private void onSignClick(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
