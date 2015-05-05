using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgLogic
{
    public class Dice
    {
        private Random random = new Random();

        public Dice()
        {
            
        }

        public Dice(int v)
        {
            if (v > 0 && v < 7)
                _value = v;
            else _value = 1;
        }

        public void Roll()
        {
            _value = random.Next(1, 7);
        }

        private int _value;
        public int Value { get { return _value; } }
    }
}
