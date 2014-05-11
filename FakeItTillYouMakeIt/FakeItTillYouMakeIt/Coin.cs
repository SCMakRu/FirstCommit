﻿using FakeItTillYouMakeIt.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeItTillYouMakeIt
{
    public class Coin
    {
        public Image coinImg { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int alive { get; set; }
        public static Rectangle Bounds;

        public Coin(int x, int y)
        {
            coinImg = Resources.coin;
            X = x;
            Y = y;
            alive = 0;
        }

        public void DrawImage(Graphics g, int width, int height)
        {
            if (X <= width - coinImg.Width-122 && Y <= height - coinImg.Height-30)
            {
                coinImg = Resources.coin;
                g.DrawImage(coinImg, X, Y);
            }
        }
    }
}
