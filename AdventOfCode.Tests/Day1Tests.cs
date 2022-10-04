using AdventOfCode2021;

namespace AdventOfCode.Tests
{
  public class Day1Tests
  {
    string[] _lines = File.ReadAllLines(@"C:\dev\AdventOfCode2021\AdventOfCode2021\day1-inputs.txt");

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void _WhenComputingListWihWindowOfLength1_ThenAverageIsCorrect()
    {
      var day1 = new Day1();
      var numberOfIncreases = day1.CountNumberOfIncreases(_lines);
      Assert.That(numberOfIncreases,Is.EqualTo(1564));
    }
  }
}