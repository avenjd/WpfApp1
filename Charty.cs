﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Charty
    {
        Random random = new Random();
        private int randomNum;

        public Charty()
        {
            this.randomNum = random.Next(1,100);
        }
    }
}
