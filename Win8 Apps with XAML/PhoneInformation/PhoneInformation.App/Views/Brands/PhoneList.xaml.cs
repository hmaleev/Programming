using System;
using System.Collections.Generic;
using System.Linq;
using PhoneInformation.App.Models;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace PhoneInformation.App.Views.Brands
{

    public sealed partial class PhoneList : PhoneInformation.App.Common.LayoutAwarePage
    {
        public PhoneList()
        {
            this.InitializeComponent();
        }

        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        private void StackPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                if (itemGridView.SelectedItem!=null)
                {
                    var x = itemGridView.SelectedItem as PhoneModel;
                    Parameters.location = x.Link;
                    this.Frame.Navigate(typeof(Views.DetailedInformation.DetailInformation));
                }
            }
            catch (Exception)
            {
                
                
            }
        }

        private void CompareClick(object sender, RoutedEventArgs e)
        {
            try
            {
               var selectedItems = itemGridView.SelectedItems;
               if (selectedItems.Count == 2)
                    {
                        var firstPhone = selectedItems[0] as PhoneModel;
                        var secondPhone = selectedItems[1] as PhoneModel;
                        string[] splitedString = firstPhone.Link.Split('-','.');
                        Parameters.firstPhoneId = splitedString[1];
                        splitedString = secondPhone.Link.Split('-', '.');
                        Parameters.secondPhoneId = splitedString[1];
                        this.Frame.Navigate(typeof(Views.Comparison.Comparison));
                    }
                else
                    {
                        var message = new MessageDialog("You can compare only 2 phones");
                        message.ShowAsync();
                    }
            }
            catch (Exception)
            {
            }
        }
    }
}