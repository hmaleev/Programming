using System;
using System.Linq;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;
using System.Xml;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PaintRT
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        RotateTransform rectRotation = new RotateTransform();

        TranslateTransform rectTranslation = new TranslateTransform();
        Point startPoint = new Point();
        Point endPoint = new Point();
        string currentElement;
        SolidColorBrush color;
        public MainPage()
        {
            rectRotation.Angle = 0.1;
            color = new SolidColorBrush( Colors.Red);
            this.InitializeComponent();
          
            rotatingCanvas.RenderTransform = rectRotation;
            Slider.RenderTransform = rectTranslation;
           
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
            color = new SolidColorBrush(Colors.Red);

            if (rectRotation.Angle>360)
            {
                rectRotation.Angle -= 360;
            }

            bool isRed = (rectRotation.Angle >= 0 && rectRotation.Angle <= 20) || (rectRotation.Angle >= -20 && rectRotation.Angle <= 0) || (rectRotation.Angle >= 345 && rectRotation.Angle <= 360);
            if (isRed)
            {
                color = new SolidColorBrush(Colors.Red);
            }

            bool isGreen = (rectRotation.Angle >= 65 && rectRotation.Angle <= 115);
            if (isGreen)
            {
                color = new SolidColorBrush(Colors.Green);
            }

            bool isBlue = (rectRotation.Angle >= 155 && rectRotation.Angle <= 205);
            if (isBlue)
            {
                color = new SolidColorBrush(Colors.Blue);
            }

            bool isBlack = (rectRotation.Angle >= 245 && rectRotation.Angle <= 295);
            if (isBlack)
            {
                color = new SolidColorBrush(Colors.Black);
            }
        }

        private void OnPaintFieldPointerPressed(object sender, PointerRoutedEventArgs e)
        {
            GetStartPoint(e);
        }
      
        private void OnPaintFieldPointerReleased(object sender, PointerRoutedEventArgs e)
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
                case "rectangle":
                    {
                        var rectangle = CreateRectangle();
                        paintField.Children.Add(rectangle);
                        Canvas.SetTop(rectangle, startPoint.Y);
                        Canvas.SetLeft(rectangle, startPoint.X);
                        break;
                    }
                case "circle":
                    {
                        var circle = CreateCircle();
                        paintField.Children.Add(circle);
                        Canvas.SetLeft(circle, startPoint.X);
                        Canvas.SetTop(circle, startPoint.Y);
                        break;
                    }
            }
        }

        private void GetStartPoint(PointerRoutedEventArgs e)
        {
            startPoint.X = e.GetCurrentPoint(paintField).Position.X;
            startPoint.Y = e.GetCurrentPoint(paintField).Position.Y;
        }

        private void GetEndPoint(PointerRoutedEventArgs e)
        {
            endPoint.X = e.GetCurrentPoint(paintField).Position.X;
            endPoint.Y = e.GetCurrentPoint(paintField).Position.Y;
        }

        private Line CreateLine()
        {
            Line line = new Line();
            line.Stroke = color;
            line.StrokeThickness = 2;
            line.X1 = startPoint.X;
            line.Y1 = startPoint.Y;
            line.X2 = endPoint.X;
            line.Y2 = endPoint.Y;
            return line;
        }
  
        private Rectangle CreateRectangle()
        {
            Rectangle rectangle = new Rectangle();
            Point tempPoint = new Point();
            var width = endPoint.X - startPoint.X;
            var height = endPoint.Y - startPoint.Y;

            if (width < 0 && height < 0)
            {

                 width = startPoint.X- endPoint.X ;
                 height = startPoint.Y - endPoint.Y;
                 tempPoint = startPoint;
                 startPoint = endPoint;
                 endPoint = startPoint;
            }
            else if (width > 0 && height < 0)
            {
                 height = startPoint.Y - endPoint.Y;
                 tempPoint.Y = startPoint.Y;
                 startPoint.Y = endPoint.Y;
                 endPoint.Y = startPoint.Y;
            }
            else if (width < 0 && height > 0)
            {
                width = startPoint.X - endPoint.X;
                tempPoint.X = startPoint.X;
                startPoint.X = endPoint.X;
                endPoint.X = startPoint.X;
            }

            rectangle.Width = width;
            rectangle.Height = height;
            rectangle.Stroke = color;
            rectangle.StrokeThickness = 2;
            return rectangle;
        }

        private Ellipse CreateCircle()
        {
            Ellipse circle = new Ellipse();
            Point tempPoint = new Point();
            var width = endPoint.X - startPoint.X;
            var height = endPoint.Y - startPoint.Y;

            if (width < 0 && height < 0)
            {
                width = startPoint.X - endPoint.X;
                height = startPoint.Y - endPoint.Y;
                tempPoint = startPoint;
                startPoint = endPoint;
                endPoint = startPoint;
            }
            else if (width > 0 && height < 0)
            {
                height = startPoint.Y - endPoint.Y;
                tempPoint.Y = startPoint.Y;
                startPoint.Y = endPoint.Y;
                endPoint.Y = startPoint.Y;
            }
            else if (width < 0 && height > 0)
            {
                width = startPoint.X - endPoint.X;
                tempPoint.X = startPoint.X;
                startPoint.X = endPoint.X;
                endPoint.X = startPoint.X;
            }

            circle.Height = height;
            circle.Width = width;
            circle.Stroke = color;
            circle.StrokeThickness = 2;
            return circle;
        }

        private void OnSlide(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            //var slider = sender as Canvas;
            currentElement = "rectangle";

            var xOffset = e.Delta.Translation.X;
            rectTranslation.X += xOffset;

            bool isCircle = (rectTranslation.X > 30 && rectTranslation.X < 60);
            if (isCircle)
            {
                currentElement = "circle";
            }

            bool isLine = (rectTranslation.X > 85 && rectTranslation.X < 130);
            if (isLine)
            {
                currentElement = "line";
            }
        }

        private void OnSave(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            
            foreach (var item in  paintField.Children)
            {
                if (item == item as Rectangle)
                {
                    var x = item as Rectangle;
                }
              
            }
        }
    }
}