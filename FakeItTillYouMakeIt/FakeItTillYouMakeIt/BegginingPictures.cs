﻿using FakeItTillYouMakeIt.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeItTillYouMakeIt
{
    public class BegginingPictures
    { 
        public Image beg;
       
        public int X;
        public int Y;
      //  public int number;

        public BegginingPictures(int x, int y)
        {
            X = 0;
            Y = 0;
        //    number = num;
            beg = Resources.beg1;

        }
        public void DrawImage(Graphics g, int number)
        {
            beg = Resources.beg1;

            if (number == 1)
            {
                beg = Resources.beg1;
                g.DrawImage(beg, X, Y);
            }
            else if (number == 2)
            {
                beg = Resources.beg2;
                g.DrawImage(beg, X, Y);
            }
            else if (number == 3)
            {
                beg = Resources.beg4;
                g.DrawImage(beg, X, Y);
            }
            else if (number == 4)
            {
                beg = Resources.beg5;
                g.DrawImage(beg, X, Y);
            }
        }
    }
}
