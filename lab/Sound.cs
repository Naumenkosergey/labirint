using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace lab
{
    static class Sound
    {
        static bool play = true;
        static SoundPlayer click = new SoundPlayer(Properties.Resources.click);

        public static void SoundOff()
        {
            play = false;
        }
        public static void SoundON()
        {
            play = true;
        }
        public static void PlayCkick()
        {
            if (play)
                click.Play();
        }
    }
}
