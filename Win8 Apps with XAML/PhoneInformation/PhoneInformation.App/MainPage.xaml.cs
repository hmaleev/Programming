using System;
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
using PhoneInformation.App.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PhoneInformation.App
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

        private void onNokiaTap(object sender, TappedRoutedEventArgs e)
        {
            Url.brand = "nokia";
          this.Frame.Navigate(typeof( Views.Brands.PhoneList));
        }

        private void onSamsungTap(object sender, TappedRoutedEventArgs e)
        {
            Url.brand = "samsung";
            this.Frame.Navigate(typeof(Views.Brands.PhoneList));
        }

        private void onSonyTap(object sender, TappedRoutedEventArgs e)
        {
            Url.brand = "sony";
            this.Frame.Navigate(typeof(Views.Brands.PhoneList));
        }

        private void onHTCTap(object sender, TappedRoutedEventArgs e)
        {
            Url.brand = "htc";
            this.Frame.Navigate(typeof(Views.Brands.PhoneList));
            //this.Frame.Navigate(typeof(Views.Brands.HTC));
        }

        private void onMotorolaTap(object sender, TappedRoutedEventArgs e)
        {
            Url.brand = "motorola";
           this.Frame.Navigate(typeof(Views.Brands.PhoneList));
        }

        private void onAppleTap(object sender, TappedRoutedEventArgs e)
        {
            Url.brand = "apple";
            this.Frame.Navigate(typeof(Views.Brands.PhoneList));
        }

        private void onBlackberryTap(object sender, TappedRoutedEventArgs e)
        {
            Url.brand ="blackberry";
            this.Frame.Navigate(typeof(Views.Brands.PhoneList));
        }

        private void onLGTap(object sender, TappedRoutedEventArgs e)
        {
            Url.brand = "lg";
            this.Frame.Navigate(typeof(Views.Brands.PhoneList));
        }
    }
}
