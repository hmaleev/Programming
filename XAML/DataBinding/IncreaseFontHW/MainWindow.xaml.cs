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

namespace IncreaseFontHW
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

        private void onValueChange(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider fontSize = sender as Slider;

            txt.FontSize = fontSize.Value;

        }

        private void onSetLargeClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Slider.Value = 36;
        }

        private void onSetMediumClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Slider.Value = 24;
        }

        private void onSetDefaultClick(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Slider.Value = 12;
        }
    }
}
