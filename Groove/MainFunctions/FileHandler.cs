using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Groove.MainFunctions
{
   class FileHandler
    {

        private string _fileName;

        public FileHandler() { }
        MediaPlayer player = new MediaPlayer();
        
        public void FileOpen()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "mp3 files (*.mp3) |*.mp3|All files (*.*) |*.*";
            _fileName = openFileDialog.FileName;
        }

        void FilePlay()
        {
            player.Open(new Uri(_fileName));
            player.Play();
        }

    }
}
