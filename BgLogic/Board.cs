using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BgLogic
{
    public enum Color
    {
        Black = -1,
        None = 0,
        White = 1
    }

    public class BgBoard
    {
        public BgBoard()
        {
            _board[0] = -2;
            _board[23] = 2;
        }

        public void ApplyMove(Move m)
        {
            _board[m.Start] -= (int)m.Color;
            _board[m.End] += (int)m.Color;
        }

        public bool PositionBlocked(int pos, Color c)
        {
            Debug.Assert(pos >= 0 && pos < 24);

            Color bc = GetColor(pos);

            if (bc == c || bc == Color.None)
                return true;
            else if (Math.Abs(Board[pos]) < 2)
                return true;

            return false;
        }

        private Color GetColor(int pos)
        {
            if (Board[pos] == 0)
                return Color.None;

            return Board[pos] > 0 ? Color.White : Color.Black;
        }

        public int[] Board { get { return _board; } }

        readonly int [] _board = new int [24];
    }
}
