using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PhoneInformation.App.Views.Printing;
using Windows.Data.Xml.Dom;
using Windows.Graphics.Printing;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Notifications;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Printing;

namespace PhoneInformation.App.Views.DetailedInformation
{
    public sealed partial class DetailInformation : PhoneInformation.App.Common.LayoutAwarePage
    {
        public DetailInformation()
        {
            this.InitializeComponent();
        }

        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }

        private void OnTap(object sender, TappedRoutedEventArgs e)
        {
            var obj = sender as TextBlock;
            string text = obj.Text;
            ShowPhoneDetails(text);
        }

        private void ShowPhoneDetails(string text)
        {
            switch (text)
            {
                default:
                    break;
                case "Phone":
                    {
                        if (FirstPhoneInfo.Visibility == Visibility.Visible)
                        {
                            FirstPhoneInfo.Visibility = Visibility.Collapsed;

                        }
                        else
                        {
                            FirstPhoneInfo.Visibility = Visibility.Visible;
                        }
                        break;
                    }
                case "General":
                    {
                        if (GeneralInfo.Visibility == Visibility.Visible || GeneralInfoSnapped.Visibility == Visibility.Visible)
                        {
                            GeneralInfo.Visibility = Visibility.Collapsed;
                            GeneralInfoSnapped.Visibility = Visibility.Collapsed;
                        }
                        else
                        {
                            GeneralInfo.Visibility = Visibility.Visible;
                            GeneralInfoSnapped.Visibility = Visibility.Visible;

                        }
                        break;
                    }
                case "Body":
                    {
                        if (BodyInfo.Visibility == Visibility.Visible || BodyInfoSnapped.Visibility == Visibility.Visible)
                        {
                            BodyInfo.Visibility = Visibility.Collapsed;
                            BodyInfoSnapped.Visibility = Visibility.Collapsed;
                        }
                        else
                        {
                            BodyInfo.Visibility = Visibility.Visible;
                            BodyInfoSnapped.Visibility = Visibility.Visible;
                        }
                        break;
                    }
                case "Display":
                    {
                        if (DisplayInfo.Visibility == Visibility.Visible || DisplayInfoSnaped.Visibility == Visibility.Visible)
                        {
                            DisplayInfo.Visibility = Visibility.Collapsed;
                            DisplayInfoSnaped.Visibility = Visibility.Collapsed;

                        }
                        else
                        {
                            DisplayInfo.Visibility = Visibility.Visible;
                            DisplayInfoSnaped.Visibility = Visibility.Visible;
                        }
                        break;
                    }
                case "Sound":
                    {
                        if (SoundInfo.Visibility == Visibility.Visible || SoundInfoSnapped.Visibility == Visibility.Visible)
                        {
                            SoundInfo.Visibility = Visibility.Collapsed;
                            SoundInfoSnapped.Visibility = Visibility.Collapsed;

                        }
                        else
                        {
                            SoundInfo.Visibility = Visibility.Visible;
                            SoundInfoSnapped.Visibility = Visibility.Visible;
                        }
                        break;
                    }
                case "Memory":
                    {
                        if (MemoryInfo.Visibility == Visibility.Visible || MemoryInfoSnapped.Visibility == Visibility.Visible)
                        {
                            MemoryInfo.Visibility = Visibility.Collapsed;
                            MemoryInfoSnapped.Visibility = Visibility.Collapsed;

                        }
                        else
                        {
                            MemoryInfo.Visibility = Visibility.Visible;
                            MemoryInfoSnapped.Visibility = Visibility.Visible;
                        }
                        break;
                    }
                case "Data":
                    {
                        if (DataInfo.Visibility == Visibility.Visible || DataInfoSnapped.Visibility == Visibility.Visible)
                        {
                            DataInfo.Visibility = Visibility.Collapsed;
                            DataInfoSnapped.Visibility = Visibility.Collapsed;

                        }
                        else
                        {
                            DataInfo.Visibility = Visibility.Visible;
                            DataInfoSnapped.Visibility = Visibility.Visible;
                        }
                        break;
                    }
                case "Camera":
                    {
                        if (CameraInfo.Visibility == Visibility.Visible || CameraInfoSnapped.Visibility == Visibility.Visible)
                        {
                            CameraInfo.Visibility = Visibility.Collapsed;
                            CameraInfoSnapped.Visibility = Visibility.Collapsed;

                        }
                        else
                        {
                            CameraInfo.Visibility = Visibility.Visible;
                            CameraInfoSnapped.Visibility = Visibility.Visible;
                        }
                        break;
                    }
                case "Features":
                    {
                        if (FeaturesInfo.Visibility == Visibility.Visible || FeaturesInfoSnapped.Visibility == Visibility.Visible)
                        {
                            FeaturesInfo.Visibility = Visibility.Collapsed;
                            FeaturesInfoSnapped.Visibility = Visibility.Collapsed;
                        }
                        else
                        {
                            FeaturesInfo.Visibility = Visibility.Visible;
                            FeaturesInfoSnapped.Visibility = Visibility.Visible;
                        }
                        break;
                    }
                case "Battery":
                    {
                        if (BatteryInfo.Visibility == Visibility.Visible || BatteryInfoSnapped.Visibility == Visibility.Visible)
                        {
                            BatteryInfo.Visibility = Visibility.Collapsed;
                            BatteryInfoSnapped.Visibility = Visibility.Collapsed;

                        }
                        else
                        {
                            BatteryInfo.Visibility = Visibility.Visible;
                            BatteryInfoSnapped.Visibility = Visibility.Visible;
                        }
                        break;
                    }
            }
        }

        private async void OnSaveButtonClick(object sender, RoutedEventArgs e)
        {
            if (ApplicationView.Value != ApplicationViewState.Snapped)
            {
                string output = SavePhoneInformation();

                FileSavePicker savePicker = new FileSavePicker();
                savePicker.SuggestedStartLocation = PickerLocationId.DocumentsLibrary;
                savePicker.FileTypeChoices.Add("Plain Text", new List<string>() { ".txt" });
                savePicker.SuggestedFileName = "PhoneInformation";
                StorageFile file = await savePicker.PickSaveFileAsync();

                XmlDocument toastXml = CreateToastNotification();

                if (file != null)
                {

                    await FileIO.WriteTextAsync(file, output, Windows.Storage.Streams.UnicodeEncoding.Utf8);
                    ShowToastNotification(toastXml);
                }
            }
            else
            {
                var message = new MessageDialog("This action is not supported in snapped view");
                message.ShowAsync();

            }
        }

        private static void ShowToastNotification(XmlDocument toastXml)
        {
            ToastNotification toast = new ToastNotification(toastXml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }

        private static XmlDocument CreateToastNotification()
        {
            ToastTemplateType toastNotification = ToastTemplateType.ToastText01;
            XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(toastNotification);
            XmlNodeList toastText = toastXml.GetElementsByTagName("text");
            toastText[0].AppendChild(toastXml.CreateTextNode("File saved successfully!"));
            return toastXml;
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
            sb.AppendLine(Sim.Text);
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
            sb.AppendLine(GPRS.Text);
            sb.Append("EDGE: ");
            sb.AppendLine(EDGE.Text);
            sb.Append("Speed: ");
            sb.AppendLine(Speed.Text);
            sb.Append("Wi-Fi: ");
            sb.AppendLine(WiFi.Text);
            sb.Append("NFC: ");
            sb.AppendLine(NFC.Text);
            sb.Append("USB: ");
            sb.AppendLine(USB.Text);

            sb.AppendLine("----------Camera Information----------");
            sb.Append("Primary camera: ");
            sb.AppendLine(PrimaryCamera.Text);
            sb.Append("Secondary camera: ");
            sb.AppendLine(SecondaryCamera.Text);
            sb.Append("Video: ");
            sb.AppendLine(Video.Text);
            sb.Append("Other camera features: ");
            sb.AppendLine(CameraFeatures.Text);

            sb.AppendLine("----------Features Information----------");
            sb.Append("Operating Sytem: ");
            sb.AppendLine(OS.Text);
            sb.Append("Chipset: ");
            sb.AppendLine(Chipset.Text);
            sb.Append("CPU: ");
            sb.AppendLine(CPU.Text);
            sb.Append("GPU: ");
            sb.AppendLine(GPU.Text);
            sb.Append("Sensors: ");
            sb.AppendLine(Sensors.Text);
            sb.Append("Messaging: ");
            sb.AppendLine(Messaging.Text);
            sb.Append("Browser: ");
            sb.AppendLine(Browser.Text);
            sb.Append("Radio: ");
            sb.AppendLine(Radio.Text);
            sb.Append("GPS: ");
            sb.AppendLine(GPS.Text);
            sb.Append("Java: ");
            sb.AppendLine(Java.Text);
            sb.Append("Colors: ");
            sb.AppendLine(Colors.Text);
            sb.Append("Other Features: ");
            sb.AppendLine(OtherFeatures.Text);

            sb.AppendLine("----------Battery Information----------");
            sb.Append("Battery Type: ");
            sb.AppendLine(BatteryType.Text);
            sb.Append("Standby Time: ");
            sb.AppendLine(StandbyTime.Text);
            sb.Append("Talk Time: ");
            sb.AppendLine(TalkTime.Text);
            sb.Append("Music Play Time: ");
            sb.AppendLine(MusicPlayTime.Text);

            string res = sb.ToString();
            return res;
        }

        PrintDocument document = null;
        IPrintDocumentSource source = null;
        List<UIElement> pages = null;
        FrameworkElement page1;
        protected event EventHandler PagesCreated;
        protected const double left = 0.075;
        protected const double top = 0.03;

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            if (document == null) return;

            document.Paginate -= PrintDocumentPaginate;
            document.GetPreviewPage -= PrintDocumentGetPreviewPage;
            document.AddPages -= PrintDocumentAddPages;

            // Remove the handler for printing initialization.
            PrintManager manager = PrintManager.GetForCurrentView();
            manager.PrintTaskRequested -= ManagerPrintTaskRequested;

            PrintContainer.Children.Clear();
        }

        private void PrepareContent()
        {
            if (page1 == null)
            {
                page1 = new PrintPage();
                StackPanel header = (StackPanel)page1.FindName("header");
                header.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }

            PrintContainer.Children.Add(page1);
            PrintContainer.InvalidateMeasure();
            PrintContainer.UpdateLayout();
        }

        void ManagerPrintTaskRequested(PrintManager sender, PrintTaskRequestedEventArgs args)
        {
            PrintTask task = null;
            task = args.Request.CreatePrintTask("Phone Information - Details", sourceRequested =>
            {
                sourceRequested.SetSource(source);
            });
        }

        void PrintDocumentAddPages(object sender, AddPagesEventArgs e)
        {
            for (int i = 0; i < pages.Count; i++)
            {
                document.AddPage(pages[i]);
            }

            PrintDocument printDoc = (PrintDocument)sender;
            printDoc.AddPagesComplete();
        }

        void PrintDocumentGetPreviewPage(object sender, GetPreviewPageEventArgs e)
        {
            PrintDocument printDoc = (PrintDocument)sender;

            printDoc.SetPreviewPage(e.PageNumber, pages[e.PageNumber - 1]);
        }

        void PrintDocumentPaginate(object sender, PaginateEventArgs e)
        {
            pages.Clear();
            PrintContainer.Children.Clear();

            RichTextBlockOverflow lastRtboOnPage;
            PrintTaskOptions printingOptions = ((PrintTaskOptions)e.PrintTaskOptions);
            PrintPageDescription pageDescription = printingOptions.GetPageDescription(0);

            lastRtboOnPage = AddOnePrintPreviewPage(null, pageDescription);

            while (lastRtboOnPage.HasOverflowContent && lastRtboOnPage.Visibility == Windows.UI.Xaml.Visibility.Visible)
            {
                lastRtboOnPage = AddOnePrintPreviewPage(lastRtboOnPage, pageDescription);
            }

            if (PagesCreated != null)
            {
                PagesCreated.Invoke(pages, null);
            }

            PrintDocument printDoc = (PrintDocument)sender;

            printDoc.SetPreviewPageCount(pages.Count, PreviewPageCountType.Intermediate);
        }

        private RichTextBlockOverflow AddOnePrintPreviewPage(RichTextBlockOverflow lastRtboAdded, PrintPageDescription printPageDescription)
        {
            FrameworkElement page;
            RichTextBlockOverflow link;

            if (lastRtboAdded == null)
            {
                page = page1;
                StackPanel footer = (StackPanel)page.FindName("footer");
                footer.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
            else
            {
                page = new ContinuationPage(lastRtboAdded);
            }

            page.Width = printPageDescription.PageSize.Width;
            page.Height = printPageDescription.PageSize.Height;

            Grid printableArea = (Grid)page.FindName("printableArea");

            double marginWidth = Math.Max(printPageDescription.PageSize.Width - printPageDescription.ImageableRect.Width, printPageDescription.PageSize.Width * left * 2);
            double marginHeight = Math.Max(printPageDescription.PageSize.Height - printPageDescription.ImageableRect.Height, printPageDescription.PageSize.Height * top * 2);

            printableArea.Width = page1.Width - marginWidth;
            printableArea.Height = page1.Height - marginHeight;

            PrintContainer.Children.Add(page);
            PrintContainer.InvalidateMeasure();
            PrintContainer.UpdateLayout();

            // Find the last text container and see if the content is overflowing
            link = (RichTextBlockOverflow)page.FindName("continuationPageLinkedContainer");

            // Check if this is the last page
            if (!link.HasOverflowContent && link.Visibility == Windows.UI.Xaml.Visibility.Visible)
            {
                StackPanel footer = (StackPanel)page.FindName("footer");
                footer.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }

            // Add the page to the page preview collection
            pages.Add(page);

            return link;
        }

        private async void OnPrintButtonClick(object sender, RoutedEventArgs e)
        {
            if (ApplicationView.Value != ApplicationViewState.Snapped)
            {
                document = new PrintDocument();
                source = document.DocumentSource;

                document.Paginate += PrintDocumentPaginate;
                document.GetPreviewPage += PrintDocumentGetPreviewPage;
                document.AddPages += PrintDocumentAddPages;

                PrintManager manager = PrintManager.GetForCurrentView();
                manager.PrintTaskRequested += ManagerPrintTaskRequested;

                pages = new List<UIElement>();

                PrepareContent();
                await Windows.Graphics.Printing.PrintManager.ShowPrintUIAsync();
            }
            else
            {
                var message = new MessageDialog("This action is not supported in snapped view");
                message.ShowAsync();

            }
        }

    }
}