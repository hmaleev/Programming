using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CalculatePrimes
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void onCalculateClick(object sender, RoutedEventArgs e)
        {
            int start = int.Parse(StartNumber.Text);
            int end = int.Parse(FinalNumber.Text);
            StringBuilder output = new StringBuilder();
            var results = PrimesCalculator.GetPrimesInRange(start,end);
            foreach (var result in results)
            {
                output.Append(" " + result + ",");
            }
            output = output.Remove(output.Length - 1,1);
            Result.Text = output.ToString();
        }
    }
}
