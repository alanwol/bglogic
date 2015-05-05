using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgLogic
{
    public struct Move
    {
        public Move(int start, int end, Color c)
        {
            Start = start;
            End = end;
            Color = c;
        }

        public int Start;
        public int End;
        public Color Color;
    }
}
