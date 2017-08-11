using System;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
      public RepeatCounter()
      {

      }

      public int CountRepeats(string userInput, string find)
      {
          string[] searchFor = new string[] {find.ToLower()};
          string[] resultString = userInput.ToLower().Split(searchFor, StringSplitOptions.None);

          return resultString.Length - 1;
      }
  }
}