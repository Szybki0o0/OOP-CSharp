using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Defender : CastleHabitant, IStatus
    {
        public override int Eat()
        {
            return 2;
        }
        public string ReadyToFight()
        {
            return "Defender is ready to fight";
        }

        public override string ToString()
        {
            return "This is Defender";
        }
    }
}
