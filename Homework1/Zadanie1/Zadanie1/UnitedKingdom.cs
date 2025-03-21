using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class UnitedKingdom : AlliedPowers
    {
        private int numberOfTanks { get; set; }
        public UnitedKingdom() { }
        public UnitedKingdom(int _numberOfPeople, int _numberOfArtileryBatteries, bool _hasFleatOnAtlantic, int _numberOfTanks) : base(_numberOfPeople, _numberOfArtileryBatteries, _hasFleatOnAtlantic)
        {
            this.numberOfTanks = _numberOfTanks;
        }

        public void UnitedKingdomStatistics()
        {
            if (hasFleatOnAtlantic)
            {
                Console.WriteLine("There are " + numberOfPeople + " people in United Kingdom and they have " + numberOfTanks + "taxies and they have fleat on the Atlantic but I can't tell how many artilery batteries they have");
            }
            else
            {
                Console.WriteLine("There are " + numberOfPeople + " people in United Kingdom and they have " + numberOfTanks + " taxies and they don't have fleat on the Atlantic and I can't tell how many artilery batteries they have");
            }
        }
    }
}
