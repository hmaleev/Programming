using System;
using System.Collections.Generic;
using System.Linq;
using PhoneInformation.App.Models;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
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

                if (ApplicationView.Value != ApplicationViewState.Snapped)
                {
                    var selectedItem = itemGridView.SelectedItem as PhoneModel;
                    Parameters.location = selectedItem.Link;
                    this.Frame.Navigate(typeof(Views.DetailedInformation.DetailInformation));
                }
                else
                {
                    var selectedItem = itemListView.SelectedItem as PhoneModel;
                    Parameters.location = selectedItem.Link;
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
                if (ApplicationView.Value != ApplicationViewState.Snapped)
                {
                    var selectedItems = itemGridView.SelectedItems;
                    if (itemGridView.SelectedItems.Count == 0)
                    {
                        selectedItems = itemGridViewZoomedOut.SelectedItems;
                    }
                    if (selectedItems.Count == 2)
                    {
                        var firstPhone = selectedItems[0] as PhoneModel;
                        var secondPhone = selectedItems[1] as PhoneModel;
                        string[] splitedString = firstPhone.Link.Split('-', '.');
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

                else
                {

                    var selectedItems = itemListView.SelectedItems;

                    if (selectedItems.Count == 2)
                    {
                        var firstPhone = selectedItems[0] as PhoneModel;
                        var secondPhone = selectedItems[1] as PhoneModel;
                        string[] splitedString = firstPhone.Link.Split('-', '.');
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
            }
            catch (Exception)
            {
            }
        }

        private void itemGridViewZoomedOut_ItemClick(object sender, Windows.UI.Xaml.Controls.ItemClickEventArgs e)
        {
            var x = sender as PhoneModel;
        }


        private void StackPanel_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            try
            {
                var selectedItem = itemGridViewZoomedOut.SelectedItem as PhoneModel;
                Parameters.location = selectedItem.Link;
                this.Frame.Navigate(typeof(Views.DetailedInformation.DetailInformation));
            }
            catch (Exception)
            {
            }
        }
    }

}