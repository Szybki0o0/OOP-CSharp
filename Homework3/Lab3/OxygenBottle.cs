﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class OxygenBottle : IVisitPort
    {
        public double MaxCapacity { get; set; }
        protected double volume, weight;
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = MaxCapacity;
                weight = value * 7.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 7.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }

        public OxygenBottle(double maxCapacity)
        {
            this.MaxCapacity = maxCapacity;
        }

        public double GetMaxCapacity() { return this.MaxCapacity; }
        public double VisitPort()
        {
            double oxygenToFill = MaxCapacity - Volume;
            return oxygenToFill * 10;
        }
    }
}
