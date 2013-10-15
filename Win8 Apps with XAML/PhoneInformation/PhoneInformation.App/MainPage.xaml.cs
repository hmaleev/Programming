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
    public sealed partial class MainPage : PhoneInformation.App.Common.LayoutAwarePage
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

        private void onTap(object sender, TappedRoutedEventArgs e)
        {
            int index ;
            if (itemGridView.SelectedIndex!=-1)
            {
                index = itemGridView.SelectedIndex;
            }
            else if(itemListView.SelectedIndex!=-1)
            {
                index = itemListView.SelectedIndex;
            }
            else
            {
                index = -1;
            }
            SelectBrand(index);
        }
  
        private void SelectBrand(int index)
        {
            switch (index)
            {
                default:
                    break;
                case 0:
                    {
                        Parameters.brand = "nokia";
                        this.Frame.Navigate(typeof( Views.Brands.PhoneList));
                        break;
                    }
                    case 1:
                    {
                        Parameters.brand = "samsung";
                        this.Frame.Navigate(typeof( Views.Brands.PhoneList));
                        break;
                    }
                    case 2:
                    {
                        Parameters.brand = "blackberry";
                        this.Frame.Navigate(typeof( Views.Brands.PhoneList));
                        break;
                    }
                    case 3:
                    {
                        Parameters.brand = "lg";
                        this.Frame.Navigate(typeof( Views.Brands.PhoneList));
                        break;
                    }
                    case 4:
                    {
                        Parameters.brand = "apple";
                        this.Frame.Navigate(typeof( Views.Brands.PhoneList));
                        break;
                    }
                    case 5:
                    {
                        Parameters.brand = "motorola";
                        this.Frame.Navigate(typeof( Views.Brands.PhoneList));
                        break;
                    }
                    case 6:
                    {
                        Parameters.brand = "sony";
                        this.Frame.Navigate(typeof( Views.Brands.PhoneList));
                        break;
                    }
                    case 7:
                    {
                        Parameters.brand = "htc";
                        this.Frame.Navigate(typeof( Views.Brands.PhoneList));
                        break;
                    }
            }
        }
    }
}
