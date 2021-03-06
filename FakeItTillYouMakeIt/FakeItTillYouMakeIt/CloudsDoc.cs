﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeItTillYouMakeIt
{
    [Serializable]
    public class CloudsDoc
    {
        public List<Cloud> clouds;
        Random r { get; set; }
        public int number { get; set; }
        public CloudsDoc()
        {
            clouds = new List<Cloud>();
            r = new Random();
            number = r.Next(1, 2);            
        }

        public void DrawClouds(Graphics g, int width, int height)
        {
            number = r.Next(1, 2);
            foreach(Cloud c in clouds)
            {
                c.DrawCloudImage(g, number, width, height);
            }
        }

        public void MoveClouds()
        {
            foreach (Cloud c in clouds)
            {
                c.MoveDown();
            }
        }


        public void MoveCloudsFaster()
        {
            foreach (Cloud c in clouds)
            {
                c.MoveDownFaster();
            }
        }

 /*       public void MoveCloudsSlower()
        {
            foreach (Cloud c in clouds)
            {
                c.MoveDownSlower();
            }
        }
  * */
        public void AddCloud(int x, int y, int cloudNumber)
        {
            Cloud c = new Cloud(x, y);
            clouds.Add(c);
        }
    }
}
