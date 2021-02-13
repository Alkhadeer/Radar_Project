using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radar_Project.Classes
{
    class Sense_Plane 
    {
        static bool Is_plane = false;
        static bool Radar_State;


        /// <summary>
        /// this is a function to Get Radar State 
        /// </summary>
        public static void Get_Radar_State()
        {
           // Radar_State = Start_Radar.Send_Radar_State();
        }

        /// <summary>
        /// this is a function to sense Plane and return the result .
        /// </summary>
        /// <returns></returns>
        public static bool Sense()
        {
            Get_Radar_State();

            if (Form1.frm.Plane.Location.X == 1300)
             //   Plane.PlainSound();

            if (Radar_State)
             //   if (X <= 1454 || Y <= 784)
                {
                    Is_plane = true;
                }
            return Is_plane;
        }
    }
}
