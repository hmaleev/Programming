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

namespace checkedItems
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

        private void onChecked(object sender, RoutedEventArgs e)
        {
            CheckBox item = sender as CheckBox;
            //TextBoxContent.AppendText(" " + item.Content + " ");
            TextBoxContent.Text +=(" " + item.Content + " ");
        }

        private void onUnchecked(object sender, RoutedEventArgs e)
        {

            CheckBox item = sender as CheckBox;
            string text = TextBoxContent.Text;
            text = text.Replace(item.Content.ToString(), string.Empty);
            Console.WriteLine(text);
            TextBoxContent.Text = text;
        }
    }
}
