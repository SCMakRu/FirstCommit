﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeItTillYouMakeIt
{
    public class CoinsGroup
    {
        public int NumCoins { get; set; }
        public CoinsGroup(int n = 0)
        {
            if (n >= 0)
                NumCoins = n;
        }
        public void AddOne()
        {
            NumCoins++;
        }
        
    }
}
