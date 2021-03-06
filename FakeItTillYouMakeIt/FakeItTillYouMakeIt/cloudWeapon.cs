﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeItTillYouMakeIt
{
    public class cloudWeapon
    {
        public List<Point> ShootingPoints { get; set; }
        public int shootingX { get; set; } //X koordinata na linijata
        public int shootingY { get; set; } //Y koordinata na tocka od linijata
        public Pen shootingPen = new Pen(Color.Black, 3);
        public Pen shootingPen1 = new Pen(Color.Gray, 1);

      
        Point[] trianglePoints;



        public cloudWeapon()
        {
            ShootingPoints = new List<Point>();            
        }

      
        public void addNewPoint()
        {          
            ShootingPoints.Add(new Point(shootingX, shootingY));
            trianglePoints = new Point[3];
        }

        public void Draw(Graphics g)
        {
            if (ShootingPoints.Count > 0)
            {
                try
                {
                    g.DrawCurve(shootingPen, ShootingPoints.ToArray());
                    g.TranslateTransform(1, 0);
                    g.DrawCurve(shootingPen1, ShootingPoints.ToArray());
                    g.ResetTransform();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Shot.cs-Draw-EXCEPTION :  {0}", e.Message);
                }
                //STRELKA
                Point lastOne = (Point)ShootingPoints[ShootingPoints.Count-1];
                trianglePoints = new Point[3];
                trianglePoints[0] = new Point(lastOne.X - 2, lastOne.Y - 10);
                trianglePoints[1] = new Point(lastOne.X - 8, lastOne.Y + 2);
                trianglePoints[2] = new Point(lastOne.X + 4, lastOne.Y + 2);
                g.FillPolygon(new SolidBrush(Color.Black), trianglePoints);
                trianglePoints = new Point[3];
            }
        }

    }
}
