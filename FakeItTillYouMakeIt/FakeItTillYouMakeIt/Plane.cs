﻿using FakeItTillYouMakeIt.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeItTillYouMakeIt
{
   public class Plane
    {
     
        public Image planeImg {get;set;}
        public static Rectangle boundPlane;
       
        public int X { get; set; }
        public int Y { get; set; }

        public int Velocity { get; set; }
        public float Angle { get; set; }

        private int velocityX;
        private int velocityY;


        public Plane(int x, int y, int velocity, float angle)
        {
            X = x;
            Y = y;
            Velocity = velocity;
            Angle = angle;
            velocityX = 60;
            velocityY = 0;
    //      velocityX =(int)Math.Cos(Angle) * Velocity;
    //        velocityY = (int)Math.Sin(Angle) * Velocity;
            planeImg = Resources.avion;
        }


        public void DrawPlane(Graphics g)
        {
            planeImg = Resources.avion;
            g.DrawImage(planeImg, X, Y);
        }

        public void MovePlane()
        {
       /*     int nextX = X + velocityX;
            int nextY = Y + velocityY;
            if (nextX - 5 <= boundPlane.Left || (nextX + 5 >= boundPlane.Right))
            {
                velocityX = -velocityX;
            }
            if (nextY - 1 <= boundPlane.Top || (nextY + 1 >= boundPlane.Bottom))
            {
                velocityY = -velocityY;
            }
            X += velocityX;
            Y += velocityY;
           */

          //  float nextX = X + velocityX;
           // float nextY = Y + velocityY;


            X = (int)(X + velocityX);
         //   Y = (int)(Y + velocityY);
        }

    }
}
