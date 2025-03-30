using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class FuelTank : IVisitPort
    {
        public double MaxCapacity { get; set; }
        private Fuel fuel;

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
        
        public FuelTank(double _maxCapacity, Fuel _fuel)
        { 
            MaxCapacity = _maxCapacity;
            this.fuel = _fuel;
        }

        public string GetFuelType()
        {
            return fuel.GetType();
        }

        public double VisitPort()
        {
            double fuelToFill = MaxCapacity - fuel.Volume;
            if(GetFuelType() == "nuclear") return fuelToFill * 90;
            else return fuelToFill * 40;
        }
    }
}
