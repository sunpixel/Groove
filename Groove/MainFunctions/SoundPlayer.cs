using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Groove.MainFunctions
{
    class SoundPlayer
    {
        private bool _playing = false;
        private static double speed = 1.0;
        private int Song_ID = 0;
        private List<Uri> songList = new List<Uri>();

        MediaPlayer mediaPlayer = new MediaPlayer();

        public SoundPlayer() { }

        public void PlayPauseSound(Uri song = null)
        {
            if (song == null)
            {
                if (_playing)
                {
                    _playing = false;
                    mediaPlayer.Pause();
                }
                else
                {
                    _playing = true;
                    mediaPlayer.Open(songList[Song_ID]);
                    mediaPlayer.Play();
                }
            }
            else
            {
                mediaPlayer.Close();
                if (_playing) 
                {
                    mediaPlayer.Stop();
                    mediaPlayer.Open(song);
                    mediaPlayer.Play();
                }
                else
                {
                    _playing = true;
                    mediaPlayer.Open(song);
                    mediaPlayer.Play();
                }
            }
        }

        public void Speedup()
        {
            speed += 0.5;
            mediaPlayer.SpeedRatio = speed;
        }

        public void SlowDown() 
        {
            speed -= 0.5;
            mediaPlayer.SpeedRatio = speed;
        }

        public void SkipForward()
        {
            mediaPlayer.Stop();
            Song_ID++;
            mediaPlayer.Close();
        }

        public void SkipBackward() 
        {
            mediaPlayer.Stop();
            Song_ID--;
            mediaPlayer.Close();
        }

    }
}
