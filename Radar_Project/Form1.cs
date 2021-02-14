using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Radar_Project.Classes;
namespace Radar_Project
{
    public partial class Form1 : Form
    {
        public static Form1 frm;
        int t = 1300;
        public int c = 600;

        public Form1()
        {
            InitializeComponent();

            frm = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Plane.Location = new Point(1300, 30);
            this.Plane.Visible = true;
            this.timer1.Enabled = true;
        }
        /// <summary>
        /// this is a event function to for run Radar 
        /// when the user click in the ON Radar button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ON_Radar_Click(object sender, EventArgs e)
        {
            Start_Radar.ON_Radar();
            MessageBox.Show(Start_Radar.Message_For_User());
            this.OFF_Radar.BackColor = Color.Empty;
            this.ON_Radar.BackColor = Color.Green;
        }

        /// <summary>
        ///  this is a event function to for OFF Radar 
        /// when the user click in the OFF Radar button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OFF_Radar_Click(object sender, EventArgs e)
        {
            Start_Radar.OFF_Radar();
            MessageBox.Show(Start_Radar.Message_For_User());
            this.OFF_Radar.BackColor = Color.Red;
            this.ON_Radar.BackColor = Color.Empty;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t -= 3;

              Controller.Get_Location_Plane();

            this.Plane.Location = new Point(t, 30);
            if (Plane.Location.X <= 800)

                this.button1.BackColor = Color.Blue;


            if (Form1.frm.Plane.Location.X <= 0)
                timer1.Stop();
        }
    }
}
