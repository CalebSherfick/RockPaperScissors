using System;

namespace RockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      System.Console.WriteLine("Lets play Rock | Paper | Scissors!");
      Random mathRandomTool = new Random();
      System.Console.WriteLine(@"WHAT DO YOU CHOOSE?
      1 = ROCK
      2 = PAPER
      3 = SCISSORS");
      string PChoice = Console.ReadLine().ToLower();
      int Random = mathRandomTool.Next(1, 4);
      int CompWins = 0;
      int PWins = 0;


      switch (Random)
      {
        case 1:
          if (PChoice == "1")
          {
            System.Console.WriteLine("You both chose ROCK");
            System.Console.WriteLine($"WINS: {PWins} LOSSES: {CompWins}");
          }
          else if (PChoice == "2")
          {
            System.Console.WriteLine("PAPER beats ROCK: You WON!");
            PWins++;
            System.Console.WriteLine($"WINS: {PWins} LOSSES: {CompWins}");
          }
          else if (PChoice == "3")
          {
            System.Console.WriteLine("ROCK beats SCISSORS: You LOST!");
            CompWins++;
            System.Console.WriteLine($"WINS: {PWins} LOSSES: {CompWins}");
          }
          break;
        case 2:
          if (PChoice == "1")
          {
            System.Console.WriteLine("PAPER beats ROCK: You LOST!");
            CompWins++;
            System.Console.WriteLine($"WINS: {PWins} LOSSES: {CompWins}");
          }
          else if (PChoice == "2")
          {
            System.Console.WriteLine("You both chose PAPER");
            System.Console.WriteLine($"WINS: {PWins} LOSSES: {CompWins}");
          }
          else if (PChoice == "3")
          {
            System.Console.WriteLine("SCISSORS beats PAPER: You WON!");
            PWins++;
            System.Console.WriteLine($"WINS: {PWins} LOSSES: {CompWins}");
          }
          break;
        case 3:
          if (PChoice == "1")
          {
            System.Console.WriteLine("ROCK beats SCISSORS: You WON! ");
            PWins++;
            System.Console.WriteLine($"WINS: {PWins} LOSSES: {CompWins}");
          }
          else if (PChoice == "2")
          {
            System.Console.WriteLine("PAPER beats ROCK: You LOST! ");
            CompWins++;
            System.Console.WriteLine($"WINS: {PWins} LOSSES: {CompWins}");
          }
          else if (PChoice == "3")
          {
            System.Console.WriteLine("You both chose SCISSORS");
            System.Console.WriteLine($"WINS: {PWins} LOSSES: {CompWins}");
          }
          break;
      }




    }
  }
}
