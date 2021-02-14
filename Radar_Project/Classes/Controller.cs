using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace Radar_Project.Classes
{
    class Controller : Location_Plane
    {

        public static void Get_Location_Plane()
        {
            if (Sense_Plane.Sense())
            {


                if (Form1.frm.Plane.Location.X <= 610)
                {
                    Classes.Defense.Lunch_Rocket();
                }

                if (Form1.frm.Plane.Location.X <= 500)
                {
                    Form1.frm.Plane.Visible = false;
                    Form1.frm.label1.Visible = false;


                }
            }


        }
    }
}
