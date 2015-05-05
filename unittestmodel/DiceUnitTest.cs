using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BgLogic;

namespace unittestmodel
{
    [TestClass]
    public class DiceUnitTest
    {
        [TestMethod]
        public void TestDiceRolls()
        {
            Dice d = new Dice();

            for (int i=0;i<100;++i)
            {
                d.Roll();

                Assert.IsTrue(d.Value > 0 && d.Value < 7, "Value is not correct {0}" , d.Value);
            }
        }
    }
}
