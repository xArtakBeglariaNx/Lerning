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
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_step_145_WPF_SpinningButtonAnimationApp
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

        private bool _isSpinning = false;

        private void btnSpinner_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!_isSpinning)
            {
                _isSpinning = true;
                var dblAnim = new DoubleAnimation();
                dblAnim.Completed += (o, s) => { _isSpinning = false; };
                dblAnim.Duration = new Duration(TimeSpan.FromSeconds(4.0));
                dblAnim.From = 0;
                dblAnim.To = 360;

                var rt = new RotateTransform();
                btnSpinner.RenderTransform = rt;

                rt.BeginAnimation(RotateTransform.AngleProperty, dblAnim);
            }
        }

        private void btnSpinner_OnClick(object sender, RoutedEventArgs e)
        {
            var dblAnim = new DoubleAnimation()
            {
                Duration = new Duration(TimeSpan.FromSeconds(2.0)),
                From = 1.0,
                To = 0.0
            };
            dblAnim.AutoReverse = true;
            //dblAnim.RepeatBehavior = RepeatBehavior.Forever;
            //dblAnim.RepeatBehavior = new RepeatBehavior(3);
            //dblAnim.RepeatBehavior = new RepeatBehavior(TimeSpan.FromSeconds(30));
            btnSpinner.BeginAnimation(Button.OpacityProperty, dblAnim);
        }
    }
}
