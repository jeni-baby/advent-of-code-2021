using AdventOfCode2021;

namespace AdventOfCode.Tests
{
  public class Day1Tests
  {
    string[] _lines = File.ReadAllLines(@"C:\dev\AdventOfCode2021\AdventOfCode2021\day1-inputs.txt");
    string[] _example = File.ReadAllLines(@"C:\dev\AdventOfCode2021\AdventOfCode2021\day1-example-data.txt");

    [Test]
    public void actual_WhenComputingListWithWindowOfLength1_ThenAverageIsCorrect()
    {
      var day1 = new Day1();
      var numberOfIncreases = day1.CountNumberOfIncreases(_lines);
      Assert.That(numberOfIncreases, Is.EqualTo(1564));
    }

    [Test]
    public void actual_WhenComputingListWithWindowOfLength3_ThenAverageIsCorrect()
    {
      var day1 = new Day1();
      var numberOfIncreases = day1.CountNumberOfIncreasesWithWindowOfSize3(_lines);
      Assert.That(numberOfIncreases, Is.EqualTo(1611));
    }

    [Test]
    public void example_WhenComputingListWithWindowOfLength1_ThenAverageIsCorrect()
    {
      var day1 = new Day1();
      var numberOfIncreases = day1.CountNumberOfIncreases(_example);
      Assert.That(numberOfIncreases, Is.EqualTo(7));
    }

    [Test]
    public void example_WhenComputingListWithWindowOfLength3_ThenAverageIsCorrect()
    {
      var day1 = new Day1();
      var numberOfIncreases = day1.CountNumberOfIncreasesWithWindowOfSize3(_example);
      Assert.That(numberOfIncreases, Is.EqualTo(5));
    }
  }
}