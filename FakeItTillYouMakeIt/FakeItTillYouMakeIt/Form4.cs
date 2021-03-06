﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeItTillYouMakeIt
{
    public partial class Form4 : Form
    {
        public Rectangle bound1;
        public Rectangle boundPlane;
        public Rectangle boundCloud;
        public Rectangle boundWeapon;
        public cloudWeapon cloudWeapon;
        public WeaponForClouds weaponForClouds;
        public int brojac1;
        public int brojac2;
        public int brojac3;
        SolidBrush groundColor;
        Graphics graphics;
        public CloudsDoc cd;
        public BegginingPictures begPic;
        public StarDoc sd;
        public Robot robot;
        public Kometa kometa;
        //public Cloud cloud;
        public Plane plane;
        Bitmap doubleBuffer;
        public int X, Y, starX, starY;
        public int wX, wY;
        int starX2, starY2;
        int cloudType;
        int starType;
        int T;
        float fuelLeft;
        public int lifes;
        Random r;
        Random randomStar;
        public int ispukani;
        SoundPlayer sound1;

        public Form4()
        {
            InitializeComponent();
            graphics = CreateGraphics();
            brojac1 = 232;
            brojac2 = 232;
            brojac3 = 255;
            ispukani = 0;
            cd = new CloudsDoc();
            sd = new StarDoc();
            begPic = new BegginingPictures(0, 0);
            robot = new Robot(240, 170);
            kometa = new Kometa(50, 50);
            cloudWeapon = new cloudWeapon();
            wX = robot.X - 50;
            wY = robot.Y + 100;
            weaponForClouds = new WeaponForClouds(wX, wY);
            //   cloud = new Cloud(X, Y, cloudType);
            plane = new Plane(-150, Height / 2 - 100, 20, (float)(Math.PI / 4));
            T = 150;
            fuelLeft = 593.7F;
            bound1 = new Rectangle(25, 0, Width - 25, Height);
            boundPlane = new Rectangle(0, Height / 2 - 100, Width - 10, 60);
            boundCloud = new Rectangle(0, 0, Width - 100, Height - 52);
            boundWeapon = new Rectangle(cloudWeapon.shootingX, cloudWeapon.shootingY, 50, Height);
            Plane.boundPlane = boundPlane;
            pbTemperature.Maximum = T;
            pbTemperature.Value = T;
            X = 0;
            Y = 0;
            starX = 0;
            starY = 0;
            starX2 = 0;
            starY2 = 0;
            cloudType = 0;
            starType = 0;
            lifes = 5;
            r = new Random();
            randomStar = new Random();
            timerBeginning.Start();
            timerAddCloud.Start();
            RobotCloudCollision();
            RobotPlaneCollision();
            doubleBuffer = new Bitmap(Width, Height);
            DoubleBuffered = true;
            sound1 = new SoundPlayer(Properties.Resources.PrepareThyself);
            
        }

        private void Draw(Graphics g)
        {
            g.Clear(Color.White);
            changeGroundColor(g);
        }

        public Boolean pocni = false;
        public void changeGroundColor(Graphics g)
        {
            groundColor = new SolidBrush(Color.FromArgb(brojac1, brojac2, brojac3));

            g.FillRectangle(groundColor, 0, 0, this.Bounds.Width, this.Bounds.Height);
            if (brojac1 == 0)
            {
                if (brojac2 >= 0)
                {
                    brojac2 -= 4;
                    brojac1 = 0;
                    brojac3 -= 5;
                }
                if (brojac3 != 0)
                {
                    brojac3 -= 5;
                    brojac2 = 0;
                    brojac1 = 0;
                }
                if (brojac3 <= 250)
                {
                    timerAddCloud.Stop();
                }
                if (brojac3 <= 160)
                {
                    starX = randomStar.Next(Width - 5);
                    starY = randomStar.Next(Height - 5);
                    starType = randomStar.Next(1, 3);
                    sd.AddStar(starX, starY, starType);
                    //  sd.DrawStars(graphics);

                    if (brojac3 % 2 == 0)
                    {
                        starX2 = randomStar.Next(Width - 10) + 3;
                        starY2 = randomStar.Next(Height - 10) - 5;
                        sd.AddStar(starX, starY, 2);
                    }

                    else if (brojac3 % 2 != 0)
                    {
                        starX2 = r.Next(Width - 10) - 2;
                        starY2 = r.Next(Height - 10) + 7;
                        sd.AddStar(starX, starY, 1);
                    }
                    if (brojac3 == 30)
                    {
                        pocni = true;
                       
                    }
                }
            }

            if (brojac1 > 0)
                brojac1 -= 4;

            if (brojac2 > 0)
                brojac2 -= 4;

            if (brojac3 == 0)
            {
                timer_Background.Stop();
                timer.Stop();
              //  timerKometa.Stop();
                if (MessageBox.Show("Hey there! Well done! You have passed the first level and you are in the space now. Click on the second level to see what is waiting for you there!",
                   "Well done!", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    Close();
                }
                else
                {
                    Close();
                }
            }
        }


        /*
         *  "however there is still some work to do here. You either quit now or you fight till your last breath."+
                        "You must fight against your enemies out there! They will come your way, but you have the power to destroy them.",
                        */

        public void RobotCloudCollision()
        {
            for (int i = 0; i < cd.clouds.Count; i++)
            {
                Pen pen = new Pen(Color.Green);
                Rectangle cloudRec = new Rectangle(cd.clouds[i].X, cd.clouds[i].Y, cd.clouds[i].cloudImg.Width, cd.clouds[i].cloudImg.Height);
         //       graphics.DrawRectangle(pen, cloudRec);
                Rectangle robotRec = new Rectangle(robot.X, robot.Y, 70, 100);//moze 105 za celosno od nozete
         //       graphics.DrawRectangle(pen, robotRec);

                if (cloudRec.IntersectsWith(robotRec))
                {
                    cd.clouds.Remove(cd.clouds[i]);
                    lifes--;
                    lblLifes.Text = String.Format("{0}", lifes);
                    if (lifes == 0)
                    {
                        timer_Background.Stop();
                        timer.Stop();
                        if (MessageBox.Show("Hey, You are NOT careful at all! You've lost all your lifes and you are still on the same planet. Let's play again so you can go into the space.",
                           "More attention is required!", MessageBoxButtons.OKCancel,
                                MessageBoxIcon.None) == System.Windows.Forms.DialogResult.OK)
                        {
                            Close();
                        }
                        else
                        {
                            Close();
                        }
                    }
                }
            }
        }


        public void RobotPlaneCollision()
        {
            Pen pen = new Pen(Color.Green);
            Rectangle planeRec = new Rectangle(plane.X, plane.Y, plane.planeImg.Width, plane.planeImg.Height);
   //       graphics.DrawRectangle(pen, planeRec);
            Rectangle robotRec = new Rectangle(robot.X, robot.Y, 70, 100);//moze 105 za celosno od nozete
    //        graphics.DrawRectangle(pen, robotRec);

            if (planeRec.IntersectsWith(robotRec))
            {
                lifes--;
                lblLifes.Text = String.Format("{0}", lifes);
                if (lifes == 0)
                {
                    timer_Background.Stop();
                    timer.Stop();
                    if (MessageBox.Show("Hey, You are NOT careful at all! You've lost all your lifes and you are still on the same planet. Let's play again so you can go into the space.",
                       "More attention is required!", MessageBoxButtons.OKCancel,
                            MessageBoxIcon.None) == System.Windows.Forms.DialogResult.OK)
                    {
                        Close();
                    }
                    else
                    {
                        Close();
                    }
                }
            }
        }


        int timeElapsed = 0;


        int countTick = 0;
        private void timerAddCloud_Tick(object sender, EventArgs e)
        {
            //  Random r = new Random();
            X = r.Next(Width);
            Y = 0;
            cloudType = r.Next(1, 3);
          /*  if (countTick % 2 == 2 || countTick == 1 || countTick == 3 || countTick == 5 || countTick == 7)
            {
                Cloud.Bounds = new Rectangle(0, 0, Width - 100, Height);
                cd.AddCloud(X, Y, cloudType);

            }*/
            if (countTick == 0)
            {
                //do nothing
            }
            else
            {
                Cloud.Bounds = new Rectangle(0, 0, Width - 100, Height);
                cd.AddCloud(X, Y, cloudType);
            }
            countTick++;
        }
        int countTime = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            //za oblaci
       //     Graphics g = Graphics.FromImage(doubleBuffer);

            cloudType = r.Next(1, 3);

            Cloud.Bounds = new Rectangle(0, 0, Width - 150, Height);

            cd.MoveClouds();
          //  graphics.Clear(groundColor.Color);
            cd.DrawClouds(graphics, Width, Height);
            RobotCloudCollision();

            if (countTime == 50)
                timerPlaneBeg.Start();

            countTime++;
 //           graphics.DrawImageUnscaled(doubleBuffer, 0, 0);
        }
        int timerPlaneTick = 0;
        private void timerPlaneBeg_Tick(object sender, EventArgs e)
        {
    //        Graphics g = Graphics.FromImage(doubleBuffer);

            //za avion
            if (timerPlaneTick <= 100)
            {
               // plane.DrawPlane(graphics);
           //     graphics.Clear(groundColor.Color);
                plane.MovePlane();
            }
            else
            {
                timerPlaneBeg.Stop();
            }

            timerPlaneTick++;
            //    Invalidate(true);
 //           graphics.DrawImageUnscaled(doubleBuffer, 0, 0);
        }

        public bool visible = false;
        public int timeVisible = 0;
        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                robot.ChangeDirection(Robot.DIRECTION.RIGHT);
                robot.MoveRobot(Width, Height);
                wX = robot.X - 50;
                wY = robot.Y - 100;
                weaponForClouds = new WeaponForClouds(wX, wY);
            }

            if (e.KeyCode == Keys.Left)
            {
                robot.ChangeDirection(Robot.DIRECTION.LEFT);
                robot.MoveRobot(Width, Height);
                wX = robot.X - 50;
                wY = robot.Y - 100;
                weaponForClouds = new WeaponForClouds(wX, wY);
            }

            if (e.KeyCode == Keys.Up)
            {
                robot.ChangeDirection(Robot.DIRECTION.UP);
                robot.MoveRobot(Width, Height);
                wX = robot.X - 50;
                wY = robot.Y - 100;
                weaponForClouds = new WeaponForClouds(wX, wY);
            }

            if (e.KeyCode == Keys.Down)
            {
                robot.ChangeDirection(Robot.DIRECTION.DOWN);
                robot.MoveRobot(Width, Height);
                wX = robot.X - 50;
                wY = robot.Y - 100;
                weaponForClouds = new WeaponForClouds(wX, wY);
            }

            if (e.KeyCode == Keys.Space)
            {               
                weaponForClouds.Move();
             // graphics.Clear(groundColor.Color);
                weaponForClouds.DrawWeapon(graphics);
            //    visible = true;
                weaponCloudCollision();

                //timerKometa.Start();
            }

            if (e.KeyCode == Keys.X)
            {
                cd.MoveCloudsFaster();
            }
         }

        public int cloudsRemoved = 0;
          public void weaponCloudCollision()
           {
                for (int i = 0; i < cd.clouds.Count; i++)
               {
                   Rectangle cloudRec = new Rectangle(cd.clouds[i].X, cd.clouds[i].Y, cd.clouds[i].cloudImg.Width, cd.clouds[i].cloudImg.Height);
                   Rectangle weaponRec = new Rectangle(weaponForClouds.X,weaponForClouds.Y, weaponForClouds.weaponForCloudImg.Width, weaponForClouds.weaponForCloudImg.Height);
                   if (weaponRec.IntersectsWith(cloudRec))
                   {
                       if (ispukani <= 4)
                       {
                           cd.clouds.RemoveAt(i);
                           cloudsRemoved++;
                           ispukani++;
                       }
                       else
                       {
                           
                           tsslCloudsDestroyed.Text = String.Format("No of clouds destroyed: {0}. You are not able to shoot again", cloudsRemoved);
                       }
                   }
               }            
          }
          
        private void timer_Background_Tick(object sender, EventArgs e)
        {
        //    Graphics g = Graphics.FromImage(doubleBuffer);
        //    graphics.Clear(Color.White);
            changeGroundColor(graphics);
            // cd.DrawClouds(g);
            // cd.MoveClouds();
            sd.DrawStars(graphics);
            tsslRobotCoordinates.Text = String.Format("Robot: X={0} Y={1}", robot.X, robot.Y);
            tsslCloudsDestroyed.Text = String.Format("No of clouds destroyed: {0}", cloudsRemoved);
            pbTemperature.Value = T - timeElapsed;
            tsslTime2.Text = String.Format("{0} seconds", timeElapsed);
            tsslFuel.Text = String.Format("{0:0.0}", fuelLeft);
            toolStripStatusLabel3.Text = String.Format("   W: {0} H: {1} ", Width, Height);
            timeElapsed++;
            fuelLeft -= 1.6F;
            lblLifes.Text = String.Format("{0}", lifes);
            robot.DrawRobot(graphics);
        
          
            plane.DrawPlane(graphics);           
        }

        int slika = 1;
        private void timerBeginning_Tick(object sender, EventArgs e)
        {
     //       Graphics g = Graphics.FromImage(doubleBuffer);
            if (slika == 1)
            {
                sound1.Play();
                begPic.DrawImage(graphics, 1);
            }
            else if (slika == 2)
            {
                begPic.DrawImage(graphics, 2);
            }
            else if (slika == 3)
            {
                begPic.DrawImage(graphics, 3);
            }
            else if (slika == 4)
            {
                begPic.DrawImage(graphics, 4);
            }
            else if (slika == 5)
            {
                timerBeginning.Stop();

                timer_Background.Start();
                timer.Start();
            }

            slika++;
  //          graphics.DrawImageUnscaled(doubleBuffer, 0, 0);
        }

        private void timerKometa_Tick(object sender, EventArgs e)
        {      
            weaponCloudCollision();
            timeVisible++;
            if (timeVisible >= 5)
            {
                timerKometa.Stop();
                visible = false;
            }
        }

        private void Form4_MouseClick(object sender, MouseEventArgs e)
        {
          /*
            Point p1 = new Point(e.X, e.Y);
            Point p2 = new Point(robot.X, robot.Y);
            Pen pn = new Pen(Color.Blue, 5);
            pn.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            graphics.DrawLine(pn, p1, p2);

            Rectangle pnRec = new Rectangle(p2.X, p2.Y, p1.X - p2.X, p1.Y - p2.Y);
            for (int i = 0; i < cd.clouds.Count; i++)
            {
                if (((e.X >= cd.clouds[i].X) && (e.X <= cd.clouds[i].cloudImg.Width)) &&
                   ((e.Y >= cd.clouds[i].Y) && (e.Y <= cd.clouds[i].cloudImg.Height)))
                {
                    // Rectangle cloudRec = new Rectangle(cd.clouds[i].X, cd.clouds[i].Y, cd.clouds[i].cloudImg.Width, cd.clouds[i].cloudImg.Height);
                    // if (pnRec.IntersectsWith(cloudRec))
                    // {
                    cd.clouds.RemoveAt(i);
                    //}
                }
            }
           * */
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
     
        }
    }
}
