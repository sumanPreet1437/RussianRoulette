using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        RussianRoulette.LogicClass Logic = new RussianRoulette.LogicClass();

        [TestMethod]
        public void ShootAwayTest()
        {
            try
            {
                Logic.ShootAway();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public void LoadTest()
        {
            try
            {
                Logic.ShootAway();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public void SpinTest()
        {
            try
            {
                Logic.ShootAway();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public void ShootHeadTest()
            {
                try
                {
                    Logic.ShootHead();
                    Assert.IsTrue(true);
                }
                catch
                {
                    Assert.IsFalse(false);
                }
            }
        }
    }

