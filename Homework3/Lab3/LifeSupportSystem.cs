using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class LifeSupportSystem
    {
        private List<OxygenBottle> oxygenBottles;
        private FoodContainer foodContainer;
        private Waste waste;
        private List<Human> crew;

        public LifeSupportSystem(List<OxygenBottle> bottles, FoodContainer container, Waste waste,List<Human> crew) 
        {
            this.oxygenBottles = bottles;
            this.foodContainer = container;
            this.waste = waste;
            this.crew = crew;
        }
        public bool CheckSuppliesBeforeTravel(double timeTravel) {
            double usedValue = timeTravel * crew.Count;
            foreach (OxygenBottle bottle in oxygenBottles) {
                if (bottle.Weight - usedValue <= 0) return false;
            }
            if ((foodContainer.Weight - usedValue) <= 0) return false;
            return true;
        }
        public void Run(double timeTravel) 
        {   
            foreach (OxygenBottle bottle in oxygenBottles) { bottle.Weight -= crew.Count * timeTravel; }
            foodContainer.Weight -= crew.Count * timeTravel;
            waste.Weight += crew.Count * timeTravel;
        }
    }
}
