using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace PhoneInformation.App.Views.DetailedInformation
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class DetailInformation : PhoneInformation.App.Common.LayoutAwarePage
    {
        public DetailInformation()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            //var res = navigationParameter as PhoneInformation.App.Models.PhoneModel;
            //string x = res.Link;
            //r = x;
            //Link.Text = r;
           
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {

        }
        private void OnPhonesTap(object sender, TappedRoutedEventArgs e)
        {
            if (FirstPhoneInfo.Visibility == Visibility.Visible)
            {
                FirstPhoneInfo.Visibility = Visibility.Collapsed;

            }
            else
            {
                FirstPhoneInfo.Visibility = Visibility.Visible;
            }
        }
        private void OnGeneralTap(object sender, TappedRoutedEventArgs e)
        {
            if (GeneralInfo.Visibility==Visibility.Visible)
            {
                GeneralInfo.Visibility = Visibility.Collapsed;

            }
            else
            {
                GeneralInfo.Visibility = Visibility.Visible;
            }
        }
        private void OnBodyTap(object sender, TappedRoutedEventArgs e)
        {
            if (BodyInfo.Visibility == Visibility.Visible)
            {
                BodyInfo.Visibility = Visibility.Collapsed;

            }
            else
            {
                BodyInfo.Visibility = Visibility.Visible;
            }
        }
        private void OnDisplayTap(object sender, TappedRoutedEventArgs e)
        {
            if (DisplayInfo.Visibility == Visibility.Visible)
            {
                DisplayInfo.Visibility = Visibility.Collapsed;

            }
            else
            {
                DisplayInfo.Visibility = Visibility.Visible;
            }
        }
        private void OnSoundTap(object sender, TappedRoutedEventArgs e)
        {
            if (SoundInfo.Visibility == Visibility.Visible)
            {
                SoundInfo.Visibility = Visibility.Collapsed;

            }
            else
            {
                SoundInfo.Visibility = Visibility.Visible;
            }
        }
        private void OnMemoryTap(object sender, TappedRoutedEventArgs e)
        {
            if (MemoryInfo.Visibility == Visibility.Visible)
            {
                MemoryInfo.Visibility = Visibility.Collapsed;

            }
            else
            {
                MemoryInfo.Visibility = Visibility.Visible;
            }
        }
        private void OnDataTap(object sender, TappedRoutedEventArgs e)
        {
            if (DataInfo.Visibility == Visibility.Visible)
            {
                DataInfo.Visibility = Visibility.Collapsed;

            }
            else
            {
                DataInfo.Visibility = Visibility.Visible;
            }
        }
        private void OnCameraTap(object sender, TappedRoutedEventArgs e)
        {
            if (CameraInfo.Visibility == Visibility.Visible)
            {
                CameraInfo.Visibility = Visibility.Collapsed;

            }
            else
            {
                CameraInfo.Visibility = Visibility.Visible;
            }
        }
        private void OnFeaturesTap(object sender, TappedRoutedEventArgs e)
        {
            if (FeaturesInfo.Visibility == Visibility.Visible)
            {
                FeaturesInfo.Visibility = Visibility.Collapsed;

            }
            else
            {
                FeaturesInfo.Visibility = Visibility.Visible;
            }
        }
        private void OnBatteryTap(object sender, TappedRoutedEventArgs e)
        {
            if (BatteryInfo.Visibility == Visibility.Visible)
            {
                BatteryInfo.Visibility = Visibility.Collapsed;

            }
            else
            {
                BatteryInfo.Visibility = Visibility.Visible;
            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string res = SavePhoneInformation();
            
            FileSavePicker savePicker = new FileSavePicker();
            savePicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
            savePicker.FileTypeChoices.Add("Plain Text", new List<string>() { ".txt" });
            savePicker.SuggestedFileName = "PhoneInformation";
            StorageFile file = await savePicker.PickSaveFileAsync();
            if (file!=null)
            {
                  await FileIO.WriteTextAsync(file, res,Windows.Storage.Streams.UnicodeEncoding.Utf8);
            }
        }
  
        private string SavePhoneInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Phone Model: ");
            sb.AppendLine(PhoneName.Text);
            sb.AppendLine("----------General Information----------");
            sb.Append("2G Network: ");
            sb.AppendLine(SecondGenNetwork.Text);
            sb.Append("3G Network: ");
            sb.AppendLine(ThirdGenNetwork.Text);
            sb.Append("4G Network: ");
            sb.AppendLine(FourthGenNetwork.Text);
            sb.Append("Sim card size: ");
            sb.AppendLine( Sim.Text);
            sb.Append("Announced: ");
            sb.AppendLine(Announced.Text);
            sb.Append("Status: ");
            sb.AppendLine(Status.Text);

            sb.AppendLine("----------Body Information----------");
            sb.Append("Dimensions: ");
            sb.AppendLine(Dimensions.Text);
            sb.Append("Weight: ");
            sb.AppendLine(Weight.Text);

            sb.AppendLine("----------Screen Information----------");
            sb.Append("Display Type: ");
            sb.AppendLine(DisplayType.Text);
            sb.Append("Size: ");
            sb.AppendLine(Size.Text);
            sb.Append("Multitouch: ");
            sb.AppendLine(Multitouch.Text);
            sb.Append("Screen Protection: ");
            sb.AppendLine(Protection.Text);

            sb.AppendLine("----------Sound Information----------");
            sb.Append("Alert Types: ");
            sb.AppendLine(AlertTypes.Text);
            sb.Append("Loudspeaker: ");
            sb.AppendLine(Loudspeaker.Text);
            sb.Append("3.5mm Audio Jack: ");
            sb.AppendLine(AudioJack.Text);
            sb.Append("Other Sound Features: ");
            sb.AppendLine(OtherSoundFeatures.Text);

            sb.AppendLine("----------Memory Information----------");
            sb.Append("Card Slot: ");
            sb.AppendLine(CardSlot.Text);
            sb.Append("Internal Memory: ");
            sb.AppendLine(Internal.Text);

            sb.AppendLine("----------Data Information----------");
            sb.Append("GPRS: ");
            sb.AppendLine("Nokia");
            sb.Append("EDGE: ");
            sb.AppendLine("Nokia");
            sb.Append("Speed: ");
            sb.AppendLine("Nokia");
            sb.Append("Wi-Fi: ");
            sb.AppendLine("Nokia");
            sb.Append("NFC: ");
            sb.AppendLine("Nokia");
            sb.Append("USB: ");
            sb.AppendLine("Nokia");

            sb.AppendLine("----------Camera Information----------");
            sb.Append("Primary camera: ");
            sb.AppendLine("Nokia");
            sb.Append("Secondary camera: ");
            sb.AppendLine("Nokia");
            sb.Append("Video: ");
            sb.AppendLine("Nokia");
            sb.Append("Other camera features: ");
            sb.AppendLine("Nokia");

            sb.AppendLine("----------Features Information----------");
            sb.Append("Operating Sytem: ");
            sb.AppendLine("Nokia");
            sb.Append("Chipset: ");
            sb.AppendLine("Nokia");
            sb.Append("CPU: ");
            sb.AppendLine("Nokia");
            sb.Append("GPU: ");
            sb.AppendLine("Nokia");
            sb.Append("Sensors: ");
            sb.AppendLine("Nokia");
            sb.Append("Messaging: ");
            sb.AppendLine("Nokia");
            sb.Append("Browser: ");
            sb.AppendLine("Nokia");
            sb.Append("Radio: ");
            sb.AppendLine("Nokia");
            sb.Append("GPS: ");
            sb.AppendLine("Nokia");
            sb.Append("Java: ");
            sb.AppendLine("Nokia");
            sb.Append("Colors: ");
            sb.AppendLine("Nokia");
            sb.Append("Other Features: ");
            sb.AppendLine("Nokia");

            sb.AppendLine("----------Battery Information----------");
            sb.Append("Battery Type: ");
            sb.AppendLine("Nokia");
            sb.Append("Standby Time: ");
            sb.AppendLine("Nokia");
            sb.Append("Talk Time: ");
            sb.AppendLine("Nokia");
            sb.Append("Music Play Time");
            sb.AppendLine("Nokia");

            string res = sb.ToString();
            return res;
        }

    }
}
