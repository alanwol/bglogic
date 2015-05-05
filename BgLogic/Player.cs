using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgLogic
{
    public class Player
    {
        public Player()
        {
            _numHit = _numTakenOff = 0;
        }

        private int _numHit;
        private int _numTakenOff;
    }
}
