/*
 * Created by: Allison Cook
 * Created on: 1 May, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - New Walking Man
 * This program when start is clicked dynamically creates picture boxes
 * When a picture box is clicked the man walks
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewWalkingManAllisonC
{
    public partial class WalkingManForm : Form
    {
        public WalkingManForm()
        {
            InitializeComponent();
            //hiding the label
            this.lblClick.Hide();
        }

        private void CreatePicBoxes()
        {
            //generate each of the picture boxes
            CreatePic(61, 78);
            CreatePic(464, 78);
            CreatePic(61, 358);
            CreatePic(464, 358);
        }

        private void CreatePic(int x, int y)
        {
            //create the picture boxes at thye set location
            PictureBox tmpPicMan = new PictureBox();

            //getting a point
            Point pntPic = new System.Drawing.Point(x, y);

            //setting the picture box to the point
            tmpPicMan.Location = pntPic;

            //asssign the image to the picture box
            tmpPicMan.Image = Properties.Resources.wa

            //make the image fit the picture box height and width
            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            //make the picture box size
            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            //add the event listener
            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);

            //add the picture box to the form
            this.Controls.Add(tmpPicMan);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //show the label
            this.lblClick.Show();

            //call the create picture boxes function
            CreatePicBoxes();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            //cast the oject to a picture box
            PictureBox tmpPicMan = (PictureBox)sender;

            //Write a message checking which picture box was clicked
            Console.WriteLine("Picture box (" + tmpPicMan.Location.X + ", " + tmpPicMan.Location.Y + ") was clicked.");

            //declare the local variables and constants
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            //continue to loop through the pictures while the frame hasn't reached the max number
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    tmpPicMan.Image = Properties
                }
            }
        }

    }
}
