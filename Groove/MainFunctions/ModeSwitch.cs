using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

using Groove;

namespace Groove.MainFunctions
{
    public class ModeSwitch
    {
        private static bool Dark = false;

        public void Switch(bool IsDark)
        {
            Dark = IsDark;
            MainWindow mW = new MainWindow();
            mW.Mode(Dark);

        }

    }
}
