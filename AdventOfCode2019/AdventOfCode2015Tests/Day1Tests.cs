using AdventOfCode2015;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2015Tests
{
    [TestClass]
    public class Day1Tests
    {
        [TestMethod]
        public void Test1()
        {
            string input = "(())";
            Assert.AreEqual(0, Day1.GetFloors(input));

            input = "()()";
            Assert.AreEqual(0, Day1.GetFloors(input));

            input = "(((";
            Assert.AreEqual(3, Day1.GetFloors(input));
            
            input = "(()(()(";
            Assert.AreEqual(3, Day1.GetFloors(input));

            input = "))(((((";
            Assert.AreEqual(3, Day1.GetFloors(input));

            input = "())";
            Assert.AreEqual(-1, Day1.GetFloors(input));

            input = "))(";
            Assert.AreEqual(-1, Day1.GetFloors(input));

            input = ")())())";
            Assert.AreEqual(-3, Day1.GetFloors(input));
        }
    }
}
