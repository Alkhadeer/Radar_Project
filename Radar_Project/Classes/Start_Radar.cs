using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radar_Project.Classes
{
    class Start_Radar
    {
        static bool Radar_State;
        /// <summary>
        ///   this is a function to Start On  the radar 
        ///   And return Radar State 
        /// </summary>
        /// <returns></returns>
        public static bool ON_Radar()
        {
            Radar_State = true;
            return Radar_State;
        }

        /// <summary>
        /// this is a function to Start On  the radar 
        ///   And return Radar State 
        /// </summary>
        /// <returns></returns>
        public static bool OFF_Radar()
        {
            Radar_State = false;
            return Radar_State;
        }


        /// <summary>
        /// this is a function to determain Radar state
        /// return true if Radar ON or false if Radar OFF.
        /// </summary>
        /// <returns></returns>
        public static bool Send_Radar_State()
        {
            return Radar_State;
        }

        public static string Message_For_User()
        {
            if (Radar_State)
            {
                return " The Radar is  ON .";
            }
            else
                return " The Radar is  OFF .";
        }


    }
}
