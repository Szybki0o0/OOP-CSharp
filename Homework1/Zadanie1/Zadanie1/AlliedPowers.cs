using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class AlliedPowers : ConflictSide
    {
        protected bool hasFleatOnAtlantic { get; private set; }
        public AlliedPowers() { }
        public AlliedPowers(int _numberOfPeople, int _numberOfArtileryBatteries, bool _hasFleatOnAtlantic) : base(_numberOfPeople, _numberOfArtileryBatteries)
        {
            this.hasFleatOnAtlantic = _hasFleatOnAtlantic;
        }

        public void AlliesStatistics()
        {
            if (hasFleatOnAtlantic)
            {
                Console.WriteLine("There are " + numberOfPeople + " people in Allied powers and they have fleat on the Atlantic but I can't tell how many artilery batteries they have");
            }
            else
            {
                Console.WriteLine("There are " + numberOfPeople + " people in Allied powers and they don't have fleat on the Atlantic and I can't tell how many artilery batteries they have");
            }
        }
    }
}
