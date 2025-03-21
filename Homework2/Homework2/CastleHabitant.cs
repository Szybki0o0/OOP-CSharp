using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal abstract class CastleHabitant
    {
        public virtual int Eat()
        {
            return 0;
        }

        public abstract override string ToString();
    }
}
