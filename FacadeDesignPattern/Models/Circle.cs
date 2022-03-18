using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern.Models
{
    public class Circle
    {
        public double Radius { get; set; }

        internal double Draw()
        {
            return (Radius * 2 * 3.14);
        }
    }
}
