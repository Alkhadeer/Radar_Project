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
    class Alarm : Location_Plane
    {
        public static void Lunch_Sound()
        {
            SoundPlayer alrm = new SoundPlayer("lunch.wav");
            alrm.Play();

        }

        public static void Message_for_User()
        {
            MessageBox.Show(" There is a plane in sky ", "Alarm ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
