using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CastleHabitant> habitants = new List<CastleHabitant>()
            {
                new Defender(), new Defender(),new Crossbowman(),new Crossbowman()
            };
            
            List<Defender> defenders = new List<Defender>()
            {
                new Defender(), new Defender()
            };


            List<Crossbowman> crossbowmen = new List<Crossbowman>()
            {
                new Crossbowman(), new Crossbowman(),
            };
 
            foreach (CastleHabitant hab in habitants)
            {
                Console.WriteLine(hab.ToString());
                Console.WriteLine(hab.Eat());
            }

            foreach (Defender def in defenders) Console.WriteLine(def.ReadyToFight());
            foreach (Crossbowman cro in crossbowmen) Console.WriteLine(cro.ReadyToFight());

            Console.ReadLine();
        }
    }
}
