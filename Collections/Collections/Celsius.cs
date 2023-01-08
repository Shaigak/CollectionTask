using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Celsius
    {
        public double Degree { get; set; }

        public Celsius(double degree)
        {
            Degree = degree;  
        }

        public static implicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(celsius.Degree + 273.15);
        }
    }
}
