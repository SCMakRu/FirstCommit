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
    public partial class HowToPlay : Form
    {
        SoundPlayer sound1;
      //  SoundPlayer sound;
        public HowToPlay()
        {
            InitializeComponent();
           // sound = new SoundPlayer(Properties.Resources.А__Бородин___quot_Улетай_на_крыльях_ветра_quot_);
           // sound.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sound1 = new SoundPlayer(Properties.Resources.PrepareThyself);
            sound1.Play();
            Close();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //richTextBox1.Text = "Hello there! Welcome";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
