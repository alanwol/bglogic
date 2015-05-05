using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BgLogic;

namespace unittestmodel
{
    [TestClass]
    public class BoardUnitTest
    {
        private BgBoard Board { get; set; }

        [TestInitialize]
        public void BeforeEachTest()
        {
            Board = new BgBoard();
        }

        [TestMethod]
        public void TestBoardApplyMoveBlack()
        {
            Assert.IsTrue(Board.Board[0] == -2, "Board not initialized OK.");
            Assert.IsTrue(Board.Board[2] == 0, "Board not initialized OK.");

            Move m = new Move(0,2,Color.Black);

            Board.ApplyMove(m);

            Assert.IsTrue(Board.Board[0] == -1, "Move failed.");
            Assert.IsTrue(Board.Board[m.End] == -1, "Move failed.");
        }

        [TestMethod]
        public void TestBoardApplyMoveWhite()
        {
            Assert.IsTrue(Board.Board[23] == 2, "Board not initialized OK.");
            Assert.IsTrue(Board.Board[21] == 0, "Board not initialized OK.");

            Move m = new Move(23, 21, Color.White);

            Board.ApplyMove(m);

            Assert.IsTrue(Board.Board[m.Start] == 1, "Move failed.");
            Assert.IsTrue(Board.Board[m.End] == 1, "Move failed.");
        }

        [TestMethod]
        public void TestBoardValidLocationForMove()
        {
        }
    }
}
