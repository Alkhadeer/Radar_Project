using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace Radar_Project.Classes
{
    class Plane : Location_Plane
    {
        public static SoundPlayer plains = new SoundPlayer("PlainS.wav");


        /// <summary>
        ///  this is a function to play sound of plain
        /// </summary>

        public static void PlainSound()
        {

            plains.Play();
        }

    }
}
