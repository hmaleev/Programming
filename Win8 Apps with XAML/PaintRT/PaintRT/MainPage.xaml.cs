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
using Windows.UI.Xaml.Shapes;
using Windows.UI;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PaintRT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        RotateTransform rectRotation = new RotateTransform();

        Point startPoint = new Point();
        Point endPoint = new Point();
        string currentElement;

        public MainPage()
        {
            this.InitializeComponent();
            rotatingCanvas.RenderTransform = rectRotation;
           
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void RotatingCanvas(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            var rect = sender as Canvas;
            rectRotation.CenterX = rect.Width / 2;
            rectRotation.CenterY = rect.Height / 2;
            rectRotation.Angle += e.Delta.Rotation;
        }

        private void onTappedLine(object sender, TappedRoutedEventArgs e)
        {
            currentElement = "line";
        }

        private void onPaintFieldPointerPressed(object sender, PointerRoutedEventArgs e)
        {
            GetStartPoint(e);
        }

        private void GetStartPoint(PointerRoutedEventArgs e)
        {
            startPoint.X = e.GetCurrentPoint(paintField).Position.X;
            startPoint.Y = e.GetCurrentPoint(paintField).Position.Y;
        }

        private void onPaintFieldPointerReleased(object sender, PointerRoutedEventArgs e)
        {
            GetEndPoint(e);
          
            switch (currentElement)
            {
                default:
                    break;
                case "line":
                    {
                        paintField.Children.Add(CreateLine());
                        break;
                    }
            }
        }

        private void GetEndPoint(PointerRoutedEventArgs e)
        {
            endPoint.X = e.GetCurrentPoint(paintField).Position.X;
            endPoint.Y = e.GetCurrentPoint(paintField).Position.Y;
        }

        private Line CreateLine()
        {
            Line line = new Line();
            line.Stroke = new SolidColorBrush(Colors.Black);
            line.StrokeThickness = 2;
            line.X1 = startPoint.X;
            line.Y1 = startPoint.Y;
            line.X2 = endPoint.X;
            line.Y2 = endPoint.Y;
            return line;
        }
    }
}
