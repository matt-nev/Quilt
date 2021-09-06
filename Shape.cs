using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltConsoleApp
{


    public abstract class Shape
    {
        public string Color;
        public string Name;
        public string GetArea()
        {
            return ($"{Color } {Name } with an area of {GetArea()}");
        }
    }  
}
