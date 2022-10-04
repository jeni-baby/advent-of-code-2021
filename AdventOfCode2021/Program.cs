using AdventOfCode2021;

string[] strings = File.ReadAllLines(@"C:\dev\AdventOfCode2021\AdventOfCode2021\day1-inputs.txt"); 
int[] measurements = Array.ConvertAll(strings, int.Parse);
var day1 = new Day1();

var numberOfIncreases = day1.CountNumberOfIncreases(measurements);
Console.WriteLine("How many measurements are larger than the previous measurement?");
Console.Write($"{numberOfIncreases} measurements are larger than their previous measurement.");