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
    public partial class Form2 : Form
    {
        SoundPlayer sound1;
        SoundPlayer sound2;
        SoundPlayer sound3;
        SoundPlayer sound4;

        SoundPlayer sound5;

        public int level;
        public BegginingPictures begPic;
        public Form3 f3;
        public int slika;
        Bitmap doubleBuffer;
        Graphics graphics;
        public bool wasChecked;
        public bool active;
        public Form2()
        {
            InitializeComponent();            
            wasChecked = false;
            slika = 0;
            begPic = new BegginingPictures(0,0);
            active = false;
            doubleBuffer = new Bitmap(Width, Height);
            graphics = CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbLevel1.Checked)
            {
               // timerBeginning.Start();

               // if (active)
             //   {
                    Form4 form = new Form4();
                    // form.ShowDialog();
                    // form.Visible = true;
                    form.ShowDialog();
                    level = 1;
                    wasChecked = true;
           //     }
            }
            wasChecked = true;

            if (wasChecked)
            {
                rbLevel2.Enabled = true;
                if (rbLevel2.Checked)
                {
                    if (wasChecked)
                    {
                        level = 2;
                   //     this.Visible = false;
                        Form3 form3 = new Form3();
                     
                       // form3.Visible = true;
                        form3.ShowDialog();
                    }
                }
            }

            if (!rbLevel1.Checked && !rbLevel2.Checked)
            {
                MessageBox.Show("Choose your level",
                    "Level", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            sound1 = new SoundPlayer(Properties.Resources.sound11);
            sound2 = new SoundPlayer(Properties.Resources.Dammit);
            sound3 = new SoundPlayer(Properties.Resources.FinallyAPresentSurprise);
            sound4 = new SoundPlayer(Properties.Resources.OhYouTraitor);
            sound1.Play();

            if (MessageBox.Show("Are you sure about this?! Oh no!",
                  "Oh no!", MessageBoxButtons.YesNo, MessageBoxIcon.None) == System.Windows.Forms.DialogResult.Yes)
            {
                sound4.Play();
                if (MessageBox.Show("Have a good one though!",
                  "Come back soon!", MessageBoxButtons.OK, MessageBoxIcon.None) == System.Windows.Forms.DialogResult.OK)
                {
                    Close();
                }
            }
            else
            {
                sound3.Play();
            }
        }

        private void timerBeginning_Tick(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(doubleBuffer);
            if (slika == 1)
            {
                begPic.DrawImage(g,1);
            }
            else if (slika == 2)
            {
                begPic.DrawImage(g,2);
            }
            else if (slika ==3)
            {
                begPic.DrawImage(g,3);
            }
            else if (slika == 4)
            {
                begPic.DrawImage(g,4);
                timerBeginning.Stop();
                active = true;
            }
            slika++;
            graphics.DrawImageUnscaled(doubleBuffer, 0, 0);

        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HowToPlay htp = new HowToPlay();
            htp.ShowDialog();
            sound5 = new SoundPlayer(Properties.Resources.HelloBrother);
            //sound5.Play();
        }
    }
}
