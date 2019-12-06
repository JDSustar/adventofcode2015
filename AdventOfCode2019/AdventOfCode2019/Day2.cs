using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2015
{
    public static class Day2
    {
        public static void StarOne(string fileName = "PuzzleInputs/Day2.txt")
        {
            string[] lines = File.ReadAllLines(fileName);

            List<Tuple<int,int,int>> packages = new List<Tuple<int, int, int>>();

            foreach (var line in lines)
            {
                int[] dimensions = line.Split('x').Select(int.Parse).ToArray();
                packages.Add(new Tuple<int, int, int>(dimensions[0], dimensions[1], dimensions[2]));
            }

            int wrappingPaperRequired = 0;

            packages.ForEach(x => wrappingPaperRequired += GetWrappingPaperRequired(x));

            Console.WriteLine("2a: " + wrappingPaperRequired);
        }

        public static void StarTwo(string fileName = "PuzzleInputs/Day2.txt")
        {
            string[] lines = File.ReadAllLines(fileName);

            List<Tuple<int, int, int>> packages = new List<Tuple<int, int, int>>();

            foreach (var line in lines)
            {
                int[] dimensions = line.Split('x').Select(int.Parse).ToArray();
                packages.Add(new Tuple<int, int, int>(dimensions[0], dimensions[1], dimensions[2]));
            }

            int wrappingPaperRequired = 0;

            packages.ForEach(x => wrappingPaperRequired += GetRibbenLength(x));

            Console.WriteLine("2b: " + wrappingPaperRequired);
        }

        public static int GetWrappingPaperRequired(Tuple<int, int, int> package)
        {
            int areaSide1 = package.Item1 * package.Item2;
            int areaSide2 = package.Item1 * package.Item3;
            int areaSide3 = package.Item2 * package.Item3;

            int result = areaSide1 * 2 + areaSide2 * 2 + areaSide3 * 2 + Math.Min(areaSide1, Math.Min(areaSide2, areaSide3));

            return result;
        }

        public static int GetRibbenLength(Tuple<int, int, int> package)
        {
            var dimensions = new List<int>() { package.Item1, package.Item2, package.Item3 };
            dimensions.Sort();

            var side1 = dimensions[0];
            var side2 = dimensions[1];

            int result = side1 * 2 + side2 * 2 + package.Item1 * package.Item2 * package.Item3;

            return result;
        }
    }
}
