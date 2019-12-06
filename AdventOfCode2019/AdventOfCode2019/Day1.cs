using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2015
{
    public static class Day1
    {

        public static void StarOne(string fileName = "PuzzleInputs/Day1.txt")
        {
            string input = File.ReadAllText(fileName);

            Console.WriteLine("1a: " + GetFloors(input));
        }

        public static void StarTwo(string fileName = "PuzzleInputs/Day1.txt")
        {
            string input = File.ReadAllText(fileName);

            Console.WriteLine("1b: " + GetBasementPosition(input));
        }

        public static int GetFloors(string input)
        {
            var dictionary = input.ToCharArray().GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            if (!dictionary.ContainsKey('('))
            {
                dictionary['('] = 0;
            }

            if (!dictionary.ContainsKey(')'))
            {
                dictionary[')'] = 0;
            }

            return dictionary['('] - dictionary[')'];
        }

        public static int GetBasementPosition(string input)
        {
            int currentFloor = 0;
            int currentPosition = 0;

            while (input.Length > 0)
            {
                currentPosition++;

                if (input[0] == '(')
                    currentFloor++;
                else if (input[0] == ')')
                    currentFloor--;

                input = input.Substring(1);

                if (currentFloor < 0)
                    return currentPosition;
            }

            throw new Exception("Input string does not cause a negative floor.");
        }
    }
}
