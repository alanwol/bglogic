using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BgLogic;

namespace unittestmodel
{
    [TestClass]
    public class MoveUnitTest
    {
        [TestMethod]
        public void TestMoveConstructor()
        {
            Move m = new Move(0,11,Color.Black);

            Assert.AreEqual(0, m.Start, "Start value was not set correctly");
        }
    }
}
