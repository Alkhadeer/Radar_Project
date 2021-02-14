using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.Drawing;
namespace Radar_Project.Classes
{
    class Defense : Location_Plane
    {
        public static SoundPlayer lunch = new SoundPlayer("lunch.wav");
        public static SoundPlayer pom = new SoundPlayer("pom.wav");



        public static void Lunch_Rocket()
        {
            if (Form1.frm.Plane.Location.X == 700)
                lunchSound();
            Form1.frm.c -= 15;
            Form1.frm.label1.Visible = true;
            Form1.frm.label1.Location = new Point(500, Form1.frm.c);

            if (Form1.frm.Plane.Location.X == 520)
                PomSound();
        }


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
