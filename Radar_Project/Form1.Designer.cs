namespace Radar_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OFF_Radar = new System.Windows.Forms.Button();
            this.ON_Radar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Plane = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Plane)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1357, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 53);
            this.button1.TabIndex = 5;
            this.button1.Text = "Get Plane";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OFF_Radar
            // 
            this.OFF_Radar.BackColor = System.Drawing.Color.Red;
            this.OFF_Radar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OFF_Radar.Location = new System.Drawing.Point(869, 499);
            this.OFF_Radar.Name = "OFF_Radar";
            this.OFF_Radar.Size = new System.Drawing.Size(166, 53);
            this.OFF_Radar.TabIndex = 9;
            this.OFF_Radar.Text = "OFF Radar";
            this.OFF_Radar.UseVisualStyleBackColor = false;
            this.OFF_Radar.Click += new System.EventHandler(this.OFF_Radar_Click);
            // 
            // ON_Radar
            // 
            this.ON_Radar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ON_Radar.Location = new System.Drawing.Point(1109, 499);
            this.ON_Radar.Name = "ON_Radar";
            this.ON_Radar.Size = new System.Drawing.Size(166, 53);
            this.ON_Radar.TabIndex = 8;
            this.ON_Radar.Text = "ON Radar";
            this.ON_Radar.UseVisualStyleBackColor = true;
            this.ON_Radar.Click += new System.EventHandler(this.ON_Radar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(566, 613);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 58);
            this.label1.TabIndex = 7;
            this.label1.Text = "\r\n\r\n";
            this.label1.Visible = false;
            // 
            // Plane
            // 
            this.Plane.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Plane.Image = ((System.Drawing.Image)(resources.GetObject("Plane.Image")));
            this.Plane.Location = new System.Drawing.Point(1175, 50);
            this.Plane.Name = "Plane";
            this.Plane.Size = new System.Drawing.Size(100, 50);
            this.Plane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Plane.TabIndex = 6;
            this.Plane.TabStop = false;
            this.Plane.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1505, 709);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OFF_Radar);
            this.Controls.Add(this.ON_Radar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Plane);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Plane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button OFF_Radar;
        private System.Windows.Forms.Button ON_Radar;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox Plane;
    }
}

