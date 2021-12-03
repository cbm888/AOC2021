using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC_D1
{
    class Part2
    {
        public void PartTwo()
        {
            Logic logic = new Logic();
            var input = File.ReadAllLines(@"./input.txt")
            .Select(int.Parse)
            .ToList();

            var slidingMeasurement = new List<int>();

            int iterator = 0;
            while (iterator < input.Count - 2)
            {
                var m = input.GetRange(iterator, 3).Sum();
                slidingMeasurement.Add(m);
                iterator++;
            }

            var numberOfTimesDepthIncreases = logic.CalculateDepthIncreases(slidingMeasurement);

            Console.WriteLine(numberOfTimesDepthIncreases);
        }

    }
}
