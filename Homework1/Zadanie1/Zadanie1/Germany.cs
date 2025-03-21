using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Germany : CentralPowers
    {
        private int numberOfFlameThrowers { get; set; }
        public Germany(int _numberOfPeople, int _numberOfArtileryBatteries, string _emperorName, int _numberOfFlameThrowers) : base(_numberOfPeople, _numberOfArtileryBatteries, _emperorName)
        {
            this.numberOfFlameThrowers = _numberOfFlameThrowers;
        }

        public void GermanyStatistics()
        {
            Console.WriteLine("There are " + numberOfPeople + " people in Germany and they have " + numberOfFlameThrowers + " flamethrowers and the Emperor's name is " + emperorName + " but I can't tell how many artilery batteries they have");
        }
    }
}
