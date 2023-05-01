using System.Collections.Generic;

namespace Sphinx.Models
{
  public class Riddle
  {
    private string _easterEgg1 = "IDK I'm not Kyle";
    private string _easterEgg2 = "Who is Kyle?";
    public string Question1 { get; } = "what is Kyle's middle name?";
    public bool CheckQuestion1(string input)
    {
      string answer = "joseph";
      if (input == answer || input == _easterEgg1 || input == _easterEgg2)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public string Question2 { get; } = "What year was Kyle born?";
    public bool CheckQuestion2(string input)
    {
      string answer = "1924";
      if (input == answer || input == _easterEgg1 || input == _easterEgg2)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public string Question3 { get; } = "What instrument does Kyle play?";
    public bool CheckQuestion3(string input)
    {
      string answer = "nose flute";
      if (input == answer || input == _easterEgg1 || input == _easterEgg2)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public string Question4 { get; } = "What is Kyle's favorite hobby?";
    public bool CheckQuestion4(string input)
    {
      string answer = "singing";
      if (input == answer || input == _easterEgg1 || input == _easterEgg2)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public string Question5 { get; } = "What is Kyle's favorite TV show?";
    public bool CheckQuestion5(string input)
    {
      string answer = "jeopardy";
      if (input == answer || input == _easterEgg1 || input == _easterEgg2)
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