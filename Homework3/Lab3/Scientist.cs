using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Scientist : Human
    {
        private Equipment equipment;

        public Scientist(Equipment equipment)
        {
            this.equipment = equipment;
        }

        public void Work(double time) 
        {
            if (time >= 24) { equipment.Weight--; }
        }
    }
}
