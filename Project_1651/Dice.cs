using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1
{
    internal class Dice
    {

        public int Side { get; set; }

        public Dice() { }

        public int Roll()
        {
            Random rd = new Random();
            return rd.Next(1, Side + 1);
        }
    }
}
