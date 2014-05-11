﻿using FakeItTillYouMakeIt.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeItTillYouMakeIt
{
    public class Cloud
    {
        public Image cloudImg { get; set; }
        public int speed { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int number { get; set; }
        Random rand { get; set; }
        public static Rectangle Bounds;

        public Cloud(int x, int y)
        {
            X = x;
            Y = y;
            rand = new Random();
            number = rand.Next(1, 2);
            cloudImg = Resources.cloudPS1;
        }
      
        public void DrawCloudImage(Graphics g,int number, int width, int height)
        {
            if (X <= width - cloudImg.Width && Y <= height - cloudImg.Height)
            {
                if (number == 1)
                {
                    cloudImg = Resources.oblakPS2;
                }
                if (number == 2)
                {
                    cloudImg = Resources.cloudPS1;
                }

                g.DrawImage(cloudImg, X, Y);
            }
        }

        public void MoveDown()
        {
            Y += 1;          
        }

        public void MoveDownFaster()
        {
            Y += 2;
        }

    /*    public void MoveDownSlower()
        {
            Y += 1;
        }
        */
       /* public bool robotCloud(int formHeight)
        {
            if (Y + 10 <= formHeight)
            {
                Y=Y+
            }
            return false;
        }
        * */

    }
}
