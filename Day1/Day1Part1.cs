using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AOC_D1
{
    class Part1
    {
        
        public void PartOne()
        {
            Logic logic = new Logic() ;
            var input = File.ReadAllLines(@"./input.txt").Select(int.Parse).ToList();
            var numberOfTimesDepthIncreases = logic.CalculateDepthIncreases(input);

            Console.WriteLine(numberOfTimesDepthIncreases);


        }


    }
}
