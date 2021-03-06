﻿using FakeItTillYouMakeIt.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeItTillYouMakeIt
{
   public class MovingBackground
    {
       public Image bgImg { get; set; }
       public int speed { get; set; }
       public int X { get; set; }
       public int Y { get; set; }
       

       public MovingBackground(int x)
       {
           bgImg = Resources.bg2;
           X = x;
           Y = 0;
           speed = 2;    
       }

       public void BGMove()
       {
           if (X >= 0)
               X = -1080;
           else
               X+= speed;
       }

       public void Draw(Graphics g)
       {
           bgImg = Resources.bg2;
           g.DrawImage(bgImg,X,Y);
       }
    }
}
