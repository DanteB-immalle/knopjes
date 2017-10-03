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

namespace tekenen_in_WPF
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

        private void Knop1_Click(object sender, RoutedEventArgs e)
        {
            double top = 0;
            double left = 0;

            top = mijnRechthoek.Margin.Top;
            left = mijnRechthoek.Margin.Left;

            left++;

            mijnRechthoek.Stroke = Brushes.Beige;
            mijnRechthoek.Margin = new Thickness(left, top, 0, 0);
        }

            private void Knop2_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Hallo wereld!", "Hallo", MessageBoxButton.YesNo, MessageBoxImage.Asterisk);
        }

        private void Knop3_Click(object sender, RoutedEventArgs e)
        {
            Line lijn = new Line();

            lijn.X1 = 10;
            lijn.Y1 = 10;
            lijn.X2 = 190;
            lijn.Y2 = 190;
            lijn.Stroke = new SolidColorBrush(Colors.DarkSalmon);

            mijnCanvas.Children.Add(lijn);


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            mijnCanvas.Background = Brushes.DarkTurquoise;
        }
    }
}
