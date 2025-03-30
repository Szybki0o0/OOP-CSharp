using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Waste : IVisitPort
    {
        protected double volume, weight;
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = 0;
                weight = value * 2.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 2.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public double VisitPort()
        {
            return 0;
        }
    }
}
