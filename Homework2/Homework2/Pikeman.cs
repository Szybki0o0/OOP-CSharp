﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Pikeman : Defender
    {
        public string ReadyToFight() 
        {
            return "Pikeman is ready to fight";
        }

        public override string ToString()
        {
            return "This is Pikeman";
        }
    }
}
