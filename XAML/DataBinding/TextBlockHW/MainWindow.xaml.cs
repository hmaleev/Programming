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

namespace TextBlockHW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void onTextChange(object sender, TextChangedEventArgs e)
        {
            TextBox input = sender as TextBox;
            TxtBlock.Text = input.Text;
        }

        private void onSelectedForegroundComboBox(object sender, RoutedEventArgs e)
        {
            ComboBoxItem color = sender as ComboBoxItem;
            string foregroundColor = color.Content.ToString();
            if (foregroundColor =="Green")
	        {
                TxtBlock.Foreground = Brushes.Green;
	        }
            else  if (foregroundColor =="Blue")
            {
                TxtBlock.Foreground = Brushes.Blue;
            }
            else if (foregroundColor == "Red")
            {
                TxtBlock.Foreground = Brushes.Red;
            }

        }

        private void onSelectedBackgroundComboBox(object sender, RoutedEventArgs e)
        {
            ComboBoxItem color = sender as ComboBoxItem;
            string colors = color.Content.ToString();
            if (colors == "Green")
            {
                TxtBlock.Background = Brushes.Green;
            }
            else if (colors == "Blue")
            {
                TxtBlock.Background = Brushes.Blue;
            }
            else if (colors == "Red")
            {
                TxtBlock.Background = Brushes.Red;
            }
        }
    }
}
