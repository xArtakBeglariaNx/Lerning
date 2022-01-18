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

namespace OOP_step_146_WPF_WPFStyles
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lstBoxStyles.Items.Add("BasicCantrolStyle");
            lstBoxStyles.Items.Add("BigGreenButton");
            lstBoxStyles.Items.Add("TiltButton");
            lstBoxStyles.Items.Add("GrowingButtonStyle");
        }

        private void comboStyles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currStyle = (Style)TryFindResource(lstBoxStyles.SelectedValue);
            if (currStyle == null) return;
            this.lstBoxStyles.Style = currStyle;
        }
    }
}
