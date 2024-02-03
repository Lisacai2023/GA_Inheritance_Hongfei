﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritance_Hongfei
{
    public class Land : Vehicle
    {
        int _wheels;

        public Land(string color, int wheels) : base(color)
        {
            _wheels = wheels;
        }

        public int Wheels { get => _wheels; set => _wheels=value; }

        public override string ToString()
        {
            return base.ToString() + $" - Number of wheels {_wheels}";
                 
        }
    }
}
