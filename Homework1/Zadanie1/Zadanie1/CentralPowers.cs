using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class CentralPowers : ConflictSide
    {
        protected string emperorName { get; private set; }

        public CentralPowers() { }
        public CentralPowers(int _numberOfPeople, int _numberOfArtileryBatteries, string _emperorName) : base(_numberOfPeople, _numberOfArtileryBatteries)
        {
            this.emperorName = _emperorName;
        }

        public void CenterPowersStatistics()
        {
            Console.WriteLine("There are " + numberOfPeople + " people in Central Powers and the Emperor's name is " + emperorName + " but I can't tell how many artilery batteries they have");
        }
    }
}
