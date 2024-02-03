using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritance_Hongfei
{
    public class Helicopter : Air
    {
        int _numberOfPropellers;
        public Helicopter(string color, int numberOfPropellers) : base(color)
        {
            _numberOfPropellers = numberOfPropellers;
        }

        public int NumberOfPropellers { get => _numberOfPropellers; set => _numberOfPropellers=value; }

        public override string ToString()
        {
            return base.ToString() + $" - Number of Properllers {_numberOfPropellers}";
        }
    }
}
