namespace Sphinx.Models
{
  public class Riddle
  {
    private static string _easterEgg1 = "idk i'm not kyle";
    private static string _easterEgg2 = "who is kyle?";
    public static string Question1 { get; } = "what is kyle's middle name?";
    public static bool CheckQuestion1(string input)
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
    public static string Question2 { get; } = "What year was Kyle born?";
    public static bool CheckQuestion2(string input)
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
    public static string Question3 { get; } = "What instrument does Kyle play?";
    public static bool CheckQuestion3(string input)
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
    public static string Question4 { get; } = "What is Kyle's favorite hobby?";
    public static bool CheckQuestion4(string input)
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
    public static string Question5 { get; } = "What is Kyle's favorite TV show?";
    public static bool CheckQuestion5(string input)
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