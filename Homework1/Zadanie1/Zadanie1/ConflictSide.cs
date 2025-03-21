using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class ConflictSide
    {
        protected int numberOfPeople { get; private set; }
        private int numberOfArtileryBatteries { get; set; }
        public ConflictSide() { }
        public ConflictSide(int _numberOfPeople, int _numberOfArtileryBatteries)
        {
            this.numberOfPeople = _numberOfPeople;
            this.numberOfArtileryBatteries = _numberOfArtileryBatteries;
        }

        public void FactionStatistic()
        {
            Console.WriteLine("There are " + numberOfPeople + " people in this faction and they have " + numberOfArtileryBatteries + " artilery batteries");
        }
    }
}
