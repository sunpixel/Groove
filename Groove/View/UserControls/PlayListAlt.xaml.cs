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
    /// Interaction logic for PlayListAlt.xaml
    /// </summary>
    public partial class PlayListAlt : UserControl
    {
        public PlayListAlt()
        {
            InitializeComponent();
        }

        private string imageSource;

        public string ImageSource
        {
            get { return imageSource; }
            set
            {
                imageSource = value;
                imgDisplay.Source = new BitmapImage(new Uri(value, UriKind.Relative));
            }
        }

        private string songName;

        public string SongName
        {
            get { return songName; }
            set {
                songName = value;
                tbSongName.Text = songName;
            }
        }


        private void PlaySound_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
