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

namespace WpfApp17
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public class ColorRGB
        {
            public byte red { get; set; }
            public byte green { get; set; }
            public byte blue { get; set; }
        }

        public ColorRGB color { get; set; }
        public Color clr { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            color = new ColorRGB();
            color.red = 0;
            color.green = 0;
            color.blue = 0;
            this.rgb.Fill = new SolidColorBrush(Color.FromRgb(color.red, color.green, color.blue));
        }

        private void sld_Color_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            string crlName = slider.Name;
            double value = slider.Value;
            
            if (crlName.Equals("sliderRed"))
            {
                color.red = Convert.ToByte(value);
            }
            if (crlName.Equals("sliderGreen"))
            {
                color.green = Convert.ToByte(value);
            }
            if (crlName.Equals("sliderBlue"))
            {
                color.blue = Convert.ToByte(value);
            }
            
            clr = Color.FromRgb(color.red, color.green, color.blue);
            
            this.rgb.Fill = new SolidColorBrush(Color.FromRgb(color.red, color.green, color.blue));
        }



    }
}
