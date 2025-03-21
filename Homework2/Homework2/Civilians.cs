using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Civilians : CastleHabitant
    {
        public override int Eat()
        {
            return 1;
        }

        public override string ToString()
        {
            return "This is Civilian";
        }
    }
}
