using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Inheritance_Hongfei
{
    public class Sea : Vehicle
    {
        public enum Type {submarine, boat}
        Type _type;

        public Type Type1 { get => _type; set => _type=value; }

        public Sea(string color,Type type) : base(color)
        {
            _type = type;
        }


        public override string ToString()
        {
            return base.ToString() + $" - It is a {_type}";
        }
    }
}
