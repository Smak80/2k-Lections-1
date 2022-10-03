using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2k_2022_09_12
{
    public class TrigComplex : Complex
    {
        private double r, phi;
        public TrigComplex(double r, double phi) : 
            base(r * Math.Cos(phi),
                r * Math.Sin(phi)) 
        {
            this.r = r;
            this.phi = phi;
        }
    }
}
