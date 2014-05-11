﻿using FakeItTillYouMakeIt.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeItTillYouMakeIt
{
    public class Kometa
    {
        public Image kometaImg { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Kometa(int x, int y)
        {
            X = x;
            Y = y;
            kometaImg = Resources.kometa;
            
        }

        public void DrawKometa(Graphics g)
        {
            kometaImg = Resources.kometa;
            g.DrawImage(kometaImg, X, Y);            
        }

        public void kometaMove()
        {
            X += 2;
          //  Y += 1;
        }
    }
}
