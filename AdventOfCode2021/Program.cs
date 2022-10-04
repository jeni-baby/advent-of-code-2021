string[] lines = System.IO.File.ReadAllLines(@"C:\dev\AdventOfCode2021\AdventOfCode2021\day1-inputs.txt");
var numberOfIncreases = CountNumberOfIncreases(lines);
Console.WriteLine("How many measurements are larger than the previous measurement?");
Console.Write($"{numberOfIncreases} measurements are larger than their previous measurement.");

static int CountNumberOfIncreases(string[] lines)
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