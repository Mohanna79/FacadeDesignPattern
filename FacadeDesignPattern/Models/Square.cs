using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.Models
{
    public class Square
    {
        public double Diameter { get; set; }    
        public double Side { get; set; }

        internal double Draw()
        {
           return (Side * 4);
        }
    }
}
