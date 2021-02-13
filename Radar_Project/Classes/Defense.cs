using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.Drawing;
namespace Ammar.Classes
{
    class Defense : Location_Plane
    {
        public static SoundPlayer lunch = new SoundPlayer("lunch.wav");
        public static SoundPlayer pom = new SoundPlayer("pom.wav");



        /// <summary>
        ///  this is a function to play sound of pom 
        /// </summary>
        public static void PomSound()
        {
            pom.Play();
        }

        /// <summary>
        ///  this is a function to play sound of lunch 
        /// </summary>
        public static void lunchSound()
        {

            lunch.Play();
        }
    }
}
