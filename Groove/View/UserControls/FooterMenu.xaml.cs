using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for FooterMenu.xaml
    /// </summary>
    public partial class FooterMenu : UserControl
    {
        public FooterMenu()
        {
            InitializeComponent();
        }


        private bool SliderVisible = false;

        private bool _isPlaying = false;

        private double playTime;

        public double PlayTime
        {
            get { return playTime; }
            set 
            { 
                playTime = value; 
                
            }
        }

        // funcs




        private void btn_SkipBack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_SlowDown_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Play_Pause_Click(object sender, RoutedEventArgs e)
        {
            if(_isPlaying)
            {
                _isPlaying = false;
                imgPause.Visibility = Visibility.Visible;
                imgPlay.Visibility = Visibility.Hidden;

                // Stopping play

            }
            else
            {
                _isPlaying = true;
                imgPause.Visibility = Visibility.Hidden;
                imgPlay.Visibility = Visibility.Visible;

                // Selecting a random song from Library to play


            }
        }

        private void btn_SpeedUp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_SkipForward_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_Volume_Click(object sender, RoutedEventArgs e)
        {
            if(SliderVisible) 
            {
                SliderVisible = false;
                VolumeSlider.Visibility = Visibility.Collapsed;
            }
            else
            {
                SliderVisible= true;
                VolumeSlider.Visibility = Visibility.Visible;
            }
        }
    }
}
