using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_step_139_WPF_RenderingWithShapes
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private enum SelectedShape
        { Circle, Rectangle, Line }

        private SelectedShape _currentShape;

        private void circleOption_Click(object sender, RoutedEventArgs e)
        {
            _currentShape = SelectedShape.Circle;
        }

        private void rectOption_Click(object sender, RoutedEventArgs e)
        {
            _currentShape = SelectedShape.Rectangle;
        }

        private void lineOption_Click(object sender, RoutedEventArgs e)
        {
            _currentShape = SelectedShape.Line;
        }

        private void canvasDrawingArea_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Shape shapeToTender = null;
            switch (_currentShape)
            {
                case SelectedShape.Circle:
                    shapeToTender = new Ellipse() { Height = 35, Width = 35 };
                    RadialGradientBrush brush = new RadialGradientBrush();
                    brush.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FF103DAB"), 0));
                    brush.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FF040C03"), 0.607));
                    brush.GradientStops.Add(new GradientStop((Color)ColorConverter.ConvertFromString("#FF4DEC37"), 1));
                    shapeToTender.Fill = brush;
                    break;
                case SelectedShape.Rectangle:
                    shapeToTender = new Rectangle() { Fill = Brushes.Red, Height = 35, Width = 35, RadiusX = 10, RadiusY = 10 };
                    break;
                case SelectedShape.Line:
                    shapeToTender = new Line()
                    {
                        Stroke = Brushes.Blue, StrokeThickness = 10,
                        X1 = 10, X2 = 50, Y1 = 10, Y2 = 50,
                        StrokeStartLineCap = PenLineCap.Triangle,
                        StrokeEndLineCap = PenLineCap.Round
                    };
                    break;
                default:
                    return;
            }

            if (flipCanvas.IsChecked == true)
            {
                RotateTransform rotate = new RotateTransform(-180);
                canvasDrawingArea.LayoutTransform = rotate;
            }

            Canvas.SetLeft(shapeToTender, e.GetPosition(canvasDrawingArea).X);
            Canvas.SetTop(shapeToTender, e.GetPosition(canvasDrawingArea).Y);

            canvasDrawingArea.Children.Add(shapeToTender);
        }

        private void canvasDrawingArea_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point pt = e.GetPosition((Canvas)sender);

            HitTestResult result = VisualTreeHelper.HitTest(canvasDrawingArea, pt);

            if (result != null)
            {
                canvasDrawingArea.Children.Remove(result.VisualHit as Shape);
            }
        }

        private void flipCanvas_Click(object sender, RoutedEventArgs e)
        {
            if (flipCanvas.IsChecked == true)
            {
                RotateTransform rotate = new RotateTransform(-180);
                canvasDrawingArea.LayoutTransform = rotate;
            }
            else
            {
                canvasDrawingArea.LayoutTransform = null;
            }
        }
    }
}
