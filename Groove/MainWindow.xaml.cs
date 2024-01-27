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

// Imported
using Groove.MainFunctions;
using Groove.View.Pages;

namespace Groove
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            window.Content = new Main();

        }

        public void Mode(bool Dark)
        {
            var bc = new BrushConverter();

            if (Dark)
            {
                Grids.Background = (Brush)bc.ConvertFrom("#293133");
                window.BorderBrush = Brushes.White;
            }
            else 
            { 
                Grids.Background = Brushes.White;
                window.BorderBrush = (Brush)bc.ConvertFrom("#293133");
            }
        }

    }
}
