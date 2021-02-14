using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Radar_Project.Classes
{
    class Location_Plane
    {

        protected static int X;
        protected static int Y;

        /// <summary>
        /// this is a property to get The Location of X axis of plane . 
        /// </summary>
        public int Get_X
        {
            get
            {
                return X;
            }
        }

        /// <summary>
        /// this is a property to get The Location of Y axis of plane . 
        /// </summary>
        public int Get_Y
        {
            get
            {
                return Y;
            }


        }
        /// <summary>
        ///  this is a function to get set location of plane from Form1
        /// </summary>
        public static void Plane_Loc()
        {

            X = Form1.frm.Plane.Location.X;
            Y = Form1.frm.Plane.Location.Y;

        }

    }
}
