using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    public class Day1
    {
      public int CountNumberOfIncreases(string[] lines)
      {
        var numberOfIncreases = 0;

        for (int i = 0; i < lines.Length - 1; i++)
        {
          if (int.Parse(lines[i]) < int.Parse(lines[i + 1]))
          {
            numberOfIncreases++;
          }
        }

        return numberOfIncreases;
      }
    }
}
