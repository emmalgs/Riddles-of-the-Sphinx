using System.Collections.Generic;

namespace Sphinx.Models
{
  public class Riddle
  {
    public string Question1 { get; } = "what is Kyle's middle name?";
    public bool CheckQuestion1(string input)
    {
      string answer = "joseph";
      if (input == answer)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}