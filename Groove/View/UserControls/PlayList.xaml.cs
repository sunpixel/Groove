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
    /// Interaction logic for PlayList.xaml
    /// </summary>
    public partial class PlayList : UserControl
    {
        public PlayList()
        {
            InitializeComponent();
        }

        private string sourceString;



        public string SourceString
        {
            get { return sourceString; }
            set
            {
                sourceString = value;
                Image.Source = new BitmapImage(new Uri(value, UriKind.Relative));
            }
        }

    }
}
