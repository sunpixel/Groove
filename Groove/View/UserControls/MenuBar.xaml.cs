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

using Groove.MainFunctions;

namespace Groove.View.UserControls
{
    /// <summary>
    /// Interaction logic for MenuBar.xaml
    /// </summary>
    public partial class MenuBar : UserControl
    {
        bool Dark = false;


        
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
            ModeSwitch mS = new ModeSwitch();

            if (!Dark)
            {
                Mode_img.Source = new BitmapImage(new Uri("/Assets/sun.png", UriKind.Relative));
                Dark = true;
                Mode_Dark();
            }
            else
            {
                Mode_img.Source = new BitmapImage(new Uri("/Assets/Month.png", UriKind.Relative));
                Dark = false;
                Mode_Light();
            }

            mS.Switch(Dark);
        }

        private void Mode_Dark()
        {
            Grid.Background = Brushes.Black;
            M_Add.Foreground = Brushes.White;
            Add_song.Foreground = Brushes.Black;
            Add_songs.Foreground = Brushes.Black;
            Exit.Foreground = Brushes.Black;
        }

        private void Mode_Light()
        {
            Grid.Background = Brushes.White;
            M_Add.Foreground = Brushes.Black;
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
