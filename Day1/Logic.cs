using System;
using System.Collections.Generic;

namespace AOC_D1
{
    public class Logic
    {
        public int CalculateDepthIncreases(List<int> input)
        {
            int numberOfDepthIncreases = 0;
            int i = 1;
            while (i < input.Count)
            {
                if (input[i] > input[i - 1])
                {
                    numberOfDepthIncreases++;
                }
                i++;
            }

            return numberOfDepthIncreases;
        }
    }
}