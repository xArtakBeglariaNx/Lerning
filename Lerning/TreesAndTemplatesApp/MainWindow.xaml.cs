using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using System.Xaml;
using System.Xml;

namespace OOP_step_147_WPF_TreesAndTemplatesApp
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

        private string _dataShow = string.Empty;
        private Control _ctrlToExamine = null;  

        private void showLogicalTree_Click(object sender, RoutedEventArgs e)
        {
            _dataShow = "";
            BuildLogicalTree(0, this);
            txtDisplayArea.Text = _dataShow;
        }

        void BuildLogicalTree(int depph, object obj)
        {
            _dataShow += new string(' ', depph) + obj.GetType().Name + "\n";
            if (!(obj is DependencyObject))
            {
                return;
            }

            foreach (var child in LogicalTreeHelper.GetChildren((DependencyObject)obj))
            {
                BuildLogicalTree(depph + 5, child);
            }
        }

        private void showVisualTree_Click(object sender, RoutedEventArgs e)
        {
            _dataShow = "";
            BuildVisualTree(0, this);
            txtDisplayArea.Text = _dataShow;
        }

        void BuildVisualTree(int depth, DependencyObject obj)
        {
            _dataShow += new string(' ', depth) + obj.GetType().Name + "\n";

            for(int i = 0; i < VisualTreeHelper.GetChildrenCount(obj); i++)
            {
                BuildVisualTree(depth + 1, VisualTreeHelper.GetChild(obj, i));
            }
        }

        private void btnTemplate_Click(object sender, RoutedEventArgs e)
        {
            _dataShow = "";
            ShowTemplate();
            txtDisplayArea.Text = _dataShow;
        }

        private void ShowTemplate()
        {
            if (_ctrlToExamine != null)
            {
                stackTemplatePanel.Children.Remove(_ctrlToExamine);
            }

            try
            {
                Assembly asm = Assembly.Load("PresentationFramework, Version=4.0.0.0," +
                                             "Culture=neutral, PublicKeyToken=31bf3856ad364e35");
                _ctrlToExamine = (Control)asm.CreateInstance(txtFullName.Text);
                _ctrlToExamine.Height = 200;
                _ctrlToExamine.Width = 200;
                _ctrlToExamine.Margin = new Thickness(5);
                stackTemplatePanel.Children.Add(_ctrlToExamine);

                var xmlSettings = new XmlWriterSettings { Indent = true };
                var strBuilder = new StringBuilder();
                var xWriter = XmlWriter.Create(strBuilder, xmlSettings);
                XamlWriter.Save(_ctrlToExamine.Template, xWriter);
                _dataShow = strBuilder.ToString();
            }
            catch (Exception ex)
            {
                _dataShow = ex.Message;
            }
        }
    }
}
