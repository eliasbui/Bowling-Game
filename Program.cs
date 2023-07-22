namespace bowlingGame
{
  using Model;
  class Program
  {
    static void Main(string[] args)
    {
      var game = new BowlingGame();
      Console.WriteLine("Enter the number of pins knocked down in each frame: ");
      string? frame = Console.ReadLine();
      if (frame == null)
      {
        Console.WriteLine("Please enter a valid input");
        return;
      }
      int frameTryParse = int.Parse(frame.Split(" ")[0]);
      if (frameTryParse > 10 || frameTryParse < 0)
      {
        Console.WriteLine("Please enter a valid input");
        return;
      }
      for (int i = 0; i < frameTryParse; i++)
      {
        Console.WriteLine($"Frame {i + 1}: ");
        for (int j = 0; j < 2; j++)
        {
          Console.WriteLine("Enter the number of pins knocked down: ");
          Console.WriteLine("Roll " + (j + 1));
          string? pins = Console.ReadLine();
          //if pin = 10 roll 2 = 0
          if (j == 0 && pins == "10")
          {
            game.Rolls(10);
            break;
          }
          if (pins == null)
          {
            Console.WriteLine("Please enter a valid input");
            break;
          }
          int pinsTryParse = int.Parse(pins.Split(" ")[0]);
          if (pinsTryParse > 10 || pinsTryParse < 0)
          {
            Console.WriteLine("Please enter a valid input");
            break;
          }
          game.Rolls(pinsTryParse);
        }
      }
      int score = game.Score();
      Console.WriteLine($"Score: {score}");
    }
  }
}
