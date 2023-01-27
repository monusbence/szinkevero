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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sliPiros_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte red, green, blue;
            red = Convert.ToByte(sliPiros.Value);
            green = Convert.ToByte(sliZold.Value);
            blue = Convert.ToByte(sliKek.Value);
            rctColor.Fill = new SolidColorBrush(Color.FromRgb(red, green, blue));
        }

        private void sliZold_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte red, green, blue;
            red = Convert.ToByte(sliPiros.Value);
            green = Convert.ToByte(sliZold.Value);
            blue = Convert.ToByte(sliKek.Value);
            rctColor.Fill = new SolidColorBrush(Color.FromRgb(red, green, blue));
        }

        private void sliKek_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            byte red, green, blue;
            red = Convert.ToByte(sliPiros.Value);
            green = Convert.ToByte(sliZold.Value);
            blue = Convert.ToByte(sliKek.Value);
            rctColor.Fill = new SolidColorBrush(Color.FromRgb(red, green, blue));
        }
    }
}
