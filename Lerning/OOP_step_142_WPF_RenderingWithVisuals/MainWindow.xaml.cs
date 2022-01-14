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

namespace OOP_step_142_WPF_RenderingWithVisuals
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

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            const int TextFontSize = 30;

            //Create obj System.Windows.Media.FormattedText            
            FormattedText text = new FormattedText("Hello visual Layer",
                new System.Globalization.CultureInfo("en-us"),
                FlowDirection.LeftToRight,
                new Typeface(this.FontFamily, FontStyles.Italic, FontWeights.DemiBold, FontStretches.UltraExpanded),
                TextFontSize,
                Brushes.Green,
                null,
                VisualTreeHelper.GetDpi(this).PixelsPerDip);

            //Create DrawingVisual and Get DrawingContext
            DrawingVisual drawingVisual = new DrawingVisual();
            using (DrawingContext drawingContext = drawingVisual.RenderOpen())
            {
                //Call anything methods from DrawingContext to visual data
                drawingContext.DrawRoundedRectangle(Brushes.Yellow,
                    new Pen(Brushes.Black, 5),
                    new Rect(5, 5, 450, 100), 20, 20);
                drawingContext.DrawText(text, new Point(20, 20));

                //Create byte image is dinamyc using data in obj  DrawingVisual
                RenderTargetBitmap bmp = new RenderTargetBitmap(500, 100, 100, 90, PixelFormats.Pbgra32);
                bmp.Render(drawingVisual);

                myImage.Source = bmp;
            }
        }
    }
}
