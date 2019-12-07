using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventOfCode2015;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2015Tests
{
    [TestClass]
    public class Day3Tests
    {
        [TestMethod]
        public void Test1()
        {
            string input = ">";

            SantaMap sm = new SantaMap();

            input.ToCharArray().ToList().ForEach(c => sm.AddHouse(c));

            Assert.AreEqual(2, sm.visitedHouses.Count);
        }

        [TestMethod]
        public void Test2()
        {
            string input = "^>v<";

            SantaMap sm = new SantaMap();

            input.ToCharArray().ToList().ForEach(c => sm.AddHouse(c));

            Assert.AreEqual(4, sm.visitedHouses.Count);
        }

        [TestMethod]
        public void Test3()
        {
            string input = "^v^v^v^v^v";

            SantaMap sm = new SantaMap();

            input.ToCharArray().ToList().ForEach(c => sm.AddHouse(c));

            Assert.AreEqual(2, sm.visitedHouses.Count);
        }
    }
}
