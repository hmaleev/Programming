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

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace PhoneInformation.App.Views.Comparison
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Comparison : PhoneInformation.App.Common.LayoutAwarePage
    {
        public Comparison()
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

        private void onPhonesTap(object sender, TappedRoutedEventArgs e)
        {
            if (FirstPhoneInfo.Visibility == Visibility.Visible)
            {
                FirstPhoneInfo.Visibility = Visibility.Collapsed;
                SecondPhoneInfo.Visibility = Visibility.Collapsed;

            }
            else
            {
                FirstPhoneInfo.Visibility = Visibility.Visible;
                SecondPhoneInfo.Visibility = Visibility.Visible;
            }
        }
        private void onGeneralTap(object sender, TappedRoutedEventArgs e)
        {
            if (GeneralInfo.Visibility == Visibility.Visible)
            {
                GeneralInfo.Visibility = Visibility.Collapsed;
                GeneralInfoS.Visibility = Visibility.Collapsed;

            }
            else
            {
                GeneralInfo.Visibility = Visibility.Visible;
                GeneralInfoS.Visibility = Visibility.Visible;
            }
        }
        private void onBodyTap(object sender, TappedRoutedEventArgs e)
        {
            if (BodyInfo.Visibility == Visibility.Visible)
            {
                BodyInfo.Visibility = Visibility.Collapsed;
                BodyInfo2.Visibility = Visibility.Collapsed;

            }
            else
            {
                BodyInfo.Visibility = Visibility.Visible;
                BodyInfo2.Visibility = Visibility.Visible;
            }
        }
        private void onDisplayTap(object sender, TappedRoutedEventArgs e)
        {
            if (DisplayInfo.Visibility == Visibility.Visible)
            {
                DisplayInfo.Visibility = Visibility.Collapsed;
                DisplayInfo2.Visibility = Visibility.Collapsed;

            }
            else
            {
                DisplayInfo.Visibility = Visibility.Visible;
                DisplayInfo2.Visibility = Visibility.Visible;
            }
        }
        private void onSoundTap(object sender, TappedRoutedEventArgs e)
        {
            if (SoundInfo.Visibility == Visibility.Visible)
            {
                SoundInfo.Visibility = Visibility.Collapsed;
                SoundInfo2.Visibility = Visibility.Collapsed;

            }
            else
            {
                SoundInfo.Visibility = Visibility.Visible;
                SoundInfo2.Visibility = Visibility.Visible;
            }
        }
        private void onMemoryTap(object sender, TappedRoutedEventArgs e)
        {
            if (MemoryInfo.Visibility == Visibility.Visible)
            {
                MemoryInfo.Visibility = Visibility.Collapsed;
                MemoryInfo2.Visibility = Visibility.Collapsed;

            }
            else
            {
                MemoryInfo.Visibility = Visibility.Visible;
                MemoryInfo2.Visibility = Visibility.Visible;
            }
        }
        private void onDataTap(object sender, TappedRoutedEventArgs e)
        {
            if (DataInfo.Visibility == Visibility.Visible)
            {
                DataInfo.Visibility = Visibility.Collapsed;
                DataInfo2.Visibility = Visibility.Collapsed;

            }
            else
            {
                DataInfo.Visibility = Visibility.Visible;
                DataInfo2.Visibility = Visibility.Visible;
            }
        }
        private void onCameraTap(object sender, TappedRoutedEventArgs e)
        {
            if (CameraInfo.Visibility == Visibility.Visible)
            {
                CameraInfo.Visibility = Visibility.Collapsed;
                CameraInfo2.Visibility = Visibility.Collapsed;

            }
            else
            {
                CameraInfo.Visibility = Visibility.Visible;
                CameraInfo2.Visibility = Visibility.Visible;
            }
        }
        private void onFeaturesTap(object sender, TappedRoutedEventArgs e)
        {
            if (FeaturesInfo.Visibility == Visibility.Visible)
            {
                FeaturesInfo.Visibility = Visibility.Collapsed;
                FeaturesInfo2.Visibility = Visibility.Collapsed;

            }
            else
            {
                FeaturesInfo.Visibility = Visibility.Visible;
                FeaturesInfo2.Visibility = Visibility.Visible;
            }
        }
        private void onBatteryTap(object sender, TappedRoutedEventArgs e)
        {
            if (BatteryInfo.Visibility == Visibility.Visible)
            {
                BatteryInfo.Visibility = Visibility.Collapsed;
                BatteryInfo2.Visibility = Visibility.Collapsed;

            }
            else
            {
                BatteryInfo.Visibility = Visibility.Visible;
                BatteryInfo2.Visibility = Visibility.Visible;
            }
        }

    }
}
