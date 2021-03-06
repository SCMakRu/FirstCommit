﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeItTillYouMakeIt
{
    public class CoinsDoc
    {
        public List<Coin> coins;
        public int Hits { get; set; }
        public int count { get; set; }
        Random r;
        

        public CoinsDoc()
        {
            coins = new List<Coin>();
            r = new Random();
            count = 0;
            Hits = 0;
        }

        public void Draw(Graphics g, int w, int h)
        {
            foreach (Coin c in coins)
            {
                c.DrawImage(g, w, h);
            }
        }

        public void AddCoin(int x, int y)
        {
            Coin c = new Coin(x, y);
            coins.Add(c);
        }

        public void DestroyCoin()
        {
            for (int i = coins.Count; i >= 0; i--)
            {
                coins.RemoveAt(i);
                Hits++;
            }
        }

        public void CoinsAlive()
        {
            for (int i = 0; i < coins.Count; i++)
            {
                coins[i].alive++;
            }
        }
    }
}
