namespace AdventOfCode2021
{
  public class Day1
  {
    public int CountNumberOfIncreases(int[] measurements)
    {
      var numberOfIncreases = 0;

      for (int i = 0; i < measurements.Length - 1; i++)
      {
        if (measurements[i] < measurements[i + 1])
        {
          numberOfIncreases++;
        }
      }

      return numberOfIncreases;
    }

    public int CountNumberOfIncreasesWithWindowOfSize3(int[] lines)
    {
      var numberOfIncreases = 0;

      if (lines.Length < 3) return 0;

      for (int i = 1; i < lines.Length - 2; i++)
      {
        var sumOfSlidingWindowA = lines[i - 1] + lines[i] + lines[i + 1];
        var sumOfSlidingWindowB = lines[i] + lines[i + 1] + lines[i + 2];

        if (sumOfSlidingWindowA < sumOfSlidingWindowB)
        {
          numberOfIncreases++;
        }
      }

      //123456
      //1|2|3000
      //02|3|400
      //003|4|50
      //0004|5|6
      //pick the 2nd to the 2nd-last index as the anchor as the domain
      //then an i in domain has the property i-1 and i+1 are also elements in the domain
      //that is i-1 and i+1 are valid indexes in the bounds of the array
      //assume there are at least 3 lines
      //then the 2nd element in the domain is the one where i=1 (zero-indexing)
      //the last element is the 1st last element, that is the element at lines.Length-1 (zero-indexing).
      //thus the 2nd last element is the element at lines.Length-2
      //when there are exactly 3 lines then domain has lines[1] as the 2nd element
      //and the 2nd last element is lines[lines.Length-2 = 3-2 = 1].

      //for a window I need to anchor on an element j in the domain
      //create a counter of value 0
      //compute lines[j-1]+lines[j]+lines[j+1]
      //put this value into memory

      //I must set k = j + 1 for every valid window

      //for a window I need to anchor on an element k in the domain
      //create a counter of value 0
      //compute lines[k-1]+lines[k]+lines[k+1]
      //put this value into memory

      //what does valid window mean? same as before - the window must be defined
      //this means that if j runs from lines[1] to lines[lines.Length-2]
      //k runs from lines[2] to lines lines[lines.Length-3]
      //I only need the values I can compare between j and k
      //so I can drop the value of j that has no k to compare with
      //so my comparison needs only evaluate pairs (l, l + 1) where each is a valid anchor
      //at the lowest bound that means pairs of indexes (1, 1 + 1)
      //since lines[1 - 1] + lines[1] + lines[1 + 1] can be computed
      //and lines[1 + 1 - 1] + lines[1 + 1] + lines[1 + 1 + 1] can be computed
      //and at the highest bound that means pairs of indexes (lines.Length - 3, lines.Length - 2)
      //since lines[lines.Length - 3 - 1] + lines[lines.Length - 3] + lines[lines.Length - 3 + 1] can be computed
      //and lines[lines.Length - 2 - 1] + lines[lines.Length - 2] + lines[lines.Length - 2 + 1] can be computed
      return numberOfIncreases;
    }
  }
}