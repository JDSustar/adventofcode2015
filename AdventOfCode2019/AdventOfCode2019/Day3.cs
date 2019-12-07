using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2015
{
    public static class Day3
    {
        public static void StarOne(string fileLocation = "PuzzleInputs/Day3.txt")
        {
            string input = File.ReadAllText(fileLocation);

            var chars = input.ToCharArray().ToList();

            var sm = new SantaMap();

            chars.ForEach(c => sm.AddHouse(c));

            Console.WriteLine("3A: Houses Visited: " + sm.visitedHouses.Count);
        }

        public static void StarTwo(string fileLocation = "PuzzleInputs/Day3.txt")
        {
            string input = File.ReadAllText(fileLocation);

            var chars = input.ToCharArray().ToList();

            var sm = new SantaMap();
            var sm2 = new SantaMap();


            for (int i = 0; i < chars.Count; i += 2 )
            {
                sm.AddHouse(chars[i]);
                sm2.AddHouse(chars[i+1]);
            }

            var housesVisited = sm.visitedHouses.Union(sm2.visitedHouses).ToList();

            Console.WriteLine("3B: Houses Visited: " + housesVisited.Count);
        }
    }

    public class SantaMap
    {
        public List<Tuple<int, int>> visitedHouses = new List<Tuple<int, int>>();

        private Tuple<int, int> LastPoint;

        public SantaMap()
        {
            visitedHouses.Add(new Tuple<int, int>(0,0));
            LastPoint = visitedHouses.FirstOrDefault();
        }

        public void AddHouse(char direction)
        {
            int x = LastPoint.Item1;
            int y = LastPoint.Item2;

            switch (direction)
            {
                case '^':
                    y += 1;
                    break;
                case '<':
                    x -= 1;
                    break;
                case '>':
                    x += 1;
                    break;
                case 'v':
                    y -= 1;
                    break;
            }

            var pointToAdd = new Tuple<int, int>(x, y);

            if (!visitedHouses.Contains(pointToAdd))
            {
                visitedHouses.Add(pointToAdd);
            }

            LastPoint = pointToAdd;
        }
    }
}
