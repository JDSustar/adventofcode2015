using System;
using System.Collections.Generic;
using System.Text;
using AdventOfCode2015;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2015Tests
{
    [TestClass]
    public class Day2Tests
    {
        [TestMethod]
        public void Test1()
        {
            var testPackage = new Tuple<int, int, int>(2, 3, 4);

            Assert.AreEqual(58, Day2.GetWrappingPaperRequired(testPackage));
        }
    }
}
