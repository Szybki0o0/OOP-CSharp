using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Engine
    {
        private FuelTank tank;
        private Waste waste;

        public Engine(FuelTank tank,Waste waste) 
        {
            this.tank = tank;
            this.waste = waste;
        }

        public double GetVelocity(double submarineWeight)
        {
            return submarineWeight/1000;         
        }
        public bool CheckFuelBeforeTravel(double travelTime) 
        {
            if ((tank.Weight - travelTime * 20 ) <= 0) return false;
            return true;
        }
        public void Travel(double travelTime)
        {
            tank.Weight -= travelTime * 20;
            waste.Weight += travelTime * 40;
        }
    }
}
