﻿using FakeItTillYouMakeIt.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeItTillYouMakeIt
{
    public class Star
    {
        public Image star1;
        public Image star2;
        public Image star3;
        public int X;
        public int Y;
        public int number;
        public Random rand;
        public Star(int x, int y, int num)
        {
            X = x;
            Y = y;
            rand = new Random();
            number = rand.Next(1, 3);
        }
        public void DrawStarImage(Graphics g)
        {
             star1 = Resources.PSStarv1;
             star2 = Resources.PSStarV2;
             star3 = Resources.PSSTARV3;
             number = rand.Next(1, 3);

            if(number == 1)
                g.DrawImage(star1,X,Y);
            if (number == 2)
                g.DrawImage(star2, X, Y);
            if (number == 3)
                g.DrawImage(star3, X, Y);
        }
    }
}
