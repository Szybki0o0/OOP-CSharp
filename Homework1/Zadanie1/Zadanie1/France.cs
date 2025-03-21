using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class France : AlliedPowers
    {
        private int numberOfTaxies { get; set; }
        public France() { } 
        public France(int _numberOfPeople, int _numberOfArtileryBatteries, bool _hasFleatOnAtlantic, int _numberOfTaxies) : base(_numberOfPeople, _numberOfArtileryBatteries, _hasFleatOnAtlantic)
        {
            this.numberOfTaxies = _numberOfTaxies;
        }

        public void FranceStatistics()
        {
            if (hasFleatOnAtlantic)
            {
                Console.WriteLine("There are " + numberOfPeople + " people in France and they have " + numberOfTaxies + " taxies and they have fleat on the Atlantic but I can't tell how many artilery batteries they have");
            }
            else
            {
                Console.WriteLine("There are " + numberOfPeople + " people in France and they have " + numberOfTaxies + " taxies and they don't have fleat on the Atlantic and I can't tell how many artilery batteries they have");
            }
        }
    }
}
