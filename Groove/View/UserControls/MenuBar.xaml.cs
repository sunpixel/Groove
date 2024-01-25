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

namespace Groove.View.UserControls
{
    /// <summary>
    /// Interaction logic for MenuBar.xaml
    /// </summary>
    public partial class MenuBar : UserControl
    {
        public MenuBar()
        {
            InitializeComponent();
        }

/*        private bool _isDark = false;*/


        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(GetHashCode());
        }

        private void btn_Mode_Click(object sender, RoutedEventArgs e)
        {
            bool Dark = false;
            if (Dark)
            {
                Mode_img.Source = new BitmapImage(new Uri(value, UriKind.Relative));
            }
        }

/*
        private void ThemeChange_Click(object sender, RoutedEventArgs e)
        {
            ImageSourceConverter iSC= new ImageSourceConverter();
            if (_isDark)
            {
                _isDark = false;
                ThemeImageMoon.Visibility = Visibility.Hidden;
                ThemeImageSun.Visibility = Visibility.Visible;
            }
            else
            {
                _isDark = true;
                ThemeImageSun.Visibility = Visibility.Hidden;
                ThemeImageMoon.Visibility= Visibility.Visible;
            }
        }
*/
    }
}
