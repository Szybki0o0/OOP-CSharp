using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class UnitedStates : AlliedPowers
    {
        private int numberOfShotguns {  get; set; }
        public UnitedStates() { }
        public UnitedStates(int _numberOfPeople, int _numberOfArtileryBatteries, bool _hasFleatOnAtlantic,int _numberOfShotguns) : base(_numberOfPeople, _numberOfArtileryBatteries, _hasFleatOnAtlantic)
        {
            this.numberOfShotguns = _numberOfShotguns;
        }

        public void UnitedStatesStatistics()
        {
            if (hasFleatOnAtlantic)
            {
                Console.WriteLine("There are " + numberOfPeople + " people in United States and they have " + numberOfShotguns + "taxies and they have fleat on the Atlantic but I can't tell how many artilery batteries they have");
            }
            else
            {
                Console.WriteLine("There are " + numberOfPeople + " people in United States and they have " + numberOfShotguns + " taxies and they don't have fleat on the Atlantic and I can't tell how many artilery batteries they have");
            }
        }
    }
}
