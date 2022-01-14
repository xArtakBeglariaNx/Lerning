using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace OOP_step_142_WPF_RenderingWithVisuals
{
    public class CustomVisualFrameworkElement : FrameworkElement
    {
        VisualCollection theVisuals;
        public CustomVisualFrameworkElement()
        {
            theVisuals = new VisualCollection(this) { AddRect(), AddCircle() };
            this.MouseDown += CustomVisualFrameworkElement_MouseDown;
        }

        private void CustomVisualFrameworkElement_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Point pt = e.GetPosition((UIElement)sender);

            VisualTreeHelper.HitTest(this, null, new HitTestResultCallback(myCallback), new PointHitTestParameters(pt));
        }

        private HitTestResultBehavior myCallback(HitTestResult result)
        {
            if (result.VisualHit.GetType() == typeof(DrawingVisual))
            {
                if (((DrawingVisual)result.VisualHit).Transform == null)
                {
                    ((DrawingVisual)result.VisualHit).Transform = new SkewTransform(7, 7);
                }
                else
                {
                    ((DrawingVisual)result.VisualHit).Transform = null;
                }
            }

            return HitTestResultBehavior.Stop;
        }

        private Visual AddCircle()
        {
            DrawingVisual drawingVisual = new DrawingVisual();
            using (DrawingContext drawingContext = drawingVisual.RenderOpen())
            {
                Rect rect = new Rect(new Point(160, 100), new Size(320, 80));
                drawingContext.DrawEllipse(Brushes.DarkBlue, null, new Point(70, 90), 40, 50);
            }
            return drawingVisual;
        }

        private Visual AddRect()
        {
            DrawingVisual drawingVisual = new DrawingVisual();
            using (DrawingContext drawingContext = drawingVisual.RenderOpen())
            {
                Rect rect = new Rect(new Point(160, 100), new Size(320, 80));
                drawingContext.DrawRectangle(Brushes.Tomato, null, rect);
            }
            return drawingVisual;
        }

        protected override int VisualChildrenCount => theVisuals.Count;
        protected override Visual GetVisualChild(int index)
        {
            if (index < 0 || index >= theVisuals.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            return theVisuals[index];
        }
    }
}
