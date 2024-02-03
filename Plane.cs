using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritance_Hongfei
{
    public class Plane : Air
    {
        int _numberofJets;
        public Plane(string color, int numberofJets) : base(color)
        {
            _numberofJets = numberofJets;
        }

        public int NumberofJets { get => _numberofJets; set => _numberofJets=value; }

        public override string ToString()
        {
            return base.ToString() + $" - Number of Jets {_numberofJets}";
        }

    }
}
