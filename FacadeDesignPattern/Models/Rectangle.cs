using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.Models
{
    internal class Rectangle
    {
        public double Rule { get; set; }
        public double Height { get; set; }

        internal double Draw()
        {
            return ((Rule * Height) / 2);
        }
    }
}
