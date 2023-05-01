using System;
using Sphinx.UserInterfaceModels;
using Sphinx.Models;

class Program
{
  static void Main()
  {
    Console.WriteLine($"{WelcomeBanner.Welcome}");
    Console.WriteLine("To enter the Sphinxer, you must answer these questions three");
    Console.WriteLine($"{Riddle.Question1}");
    string input1 = Console.ReadLine();
    if (Riddle.CheckQuestion1(input1.ToLower()) == true)
    {
      if (Riddle.CheckQuestion2(PrintNextQuestion(Riddle.Question2)) == true)
      {
        if (Riddle.CheckQuestion3(PrintNextQuestion(Riddle.Question3)) == true)
        {
          if (Riddle.CheckQuestion4(PrintNextQuestion(Riddle.Question4)) == true)
          {
            if (Riddle.CheckQuestion5(PrintNextQuestion(Riddle.Question5)) == true)
            {
              Console.WriteLine("Congratulations, dummy");
              Console.WriteLine("Welcome to the Sphinxer");
              Console.WriteLine($"{SphinxBanner.Success}");
            }
            else
            {
              Console.WriteLine($"{IncorrectBanner.Incorrect}");
            }
          }
          else
          {
            Console.WriteLine($"{IncorrectBanner.Incorrect}");
          }
        }
        else
        {
          Console.WriteLine($"{IncorrectBanner.Incorrect}");
        }
      }
      else
      {
        Console.WriteLine($"{IncorrectBanner.Incorrect}");
      }
    }
    else
    {
      Console.WriteLine($"{IncorrectBanner.Incorrect}");
    }
  }
  static string PrintNextQuestion(string question)
  {
    Console.WriteLine($"{CorrectBanner.Correct}");
    Console.WriteLine("Next question, idiot....");
    Console.WriteLine($"{question}");
    string input = Console.ReadLine();
    return input.ToLower();
  }
}