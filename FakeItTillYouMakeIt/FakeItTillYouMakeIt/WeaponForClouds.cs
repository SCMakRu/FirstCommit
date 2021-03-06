﻿using FakeItTillYouMakeIt.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeItTillYouMakeIt
{
    public class WeaponForClouds
    {
        public Image weaponForCloudImg { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int imgWeaponWidth { get; set; }
        public int imgWeaponHeight { get; set; }

        public WeaponForClouds(int x, int y)
        {
            X = x;
            Y = y;
            weaponForCloudImg = Resources.PSWEAPONNN;
            imgWeaponWidth = weaponForCloudImg.Width;
            imgWeaponHeight = weaponForCloudImg.Height;
        }

        public void DrawWeapon(Graphics g)
        {
            weaponForCloudImg = Resources.PSWEAPONNN;
            g.DrawImage(weaponForCloudImg, X, Y);            
        }

        public void Move()
        {
           Y -= 1;
        }
    }
}
