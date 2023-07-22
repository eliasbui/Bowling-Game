namespace bowlingGame.Model
{
  public class BowlingGame
  {
    private int[] rolls { get; set; } = new int[21]; // 21 is the maximum number of rolls in a game 10 frames * 2 rolls + 1 bonus roll
    private int currentRoll { get; set; } = 0; // current roll index
    public void Rolls(int noOfPins)
    {
      // increment the current roll index
      rolls[currentRoll++] = noOfPins; // add the number of pins knocked down to the current roll index
    }
    //create method isSpare, isStrike, sumOfBallsInFrame, spareBonus, strikeBonus, score
    private bool IsSpare(int rollIndex)
    {
      return rolls[rollIndex] + rolls[rollIndex + 1] == 10; // if the sum of the current roll and the next roll is 10, then it is a spare and return true
      // = 10 because the maximum number of pins in a frame is 10
    }
    private bool IsStrike(int rollIndex)
    {
      return rolls[rollIndex] == 10; // if the current roll is 10, then it is a strike and return true
    }
    private int SumOfBallsInFrame(int rollIndex)
    {
      return rolls[rollIndex] + rolls[rollIndex + 1]; // return the sum of the current roll and the next roll
    }
    private int SpareBonus(int rollIndex)
    {
      return rolls[rollIndex + 2]; // return the next roll after the spare
    }
    private int StrikeBonus(int rollIndex)
    {
      return rolls[rollIndex + 1] + rolls[rollIndex + 2]; // return the next two rolls after the strike
    }
    //create enum type for frame
    public enum Frame
    {
      strike,
      spare,
      openFrame
    }
    //method get fame type
    private Frame GetFrameType(int rollIndex)
    {
      if (rolls[rollIndex] == 10)
      {
        return Frame.strike; // = 10 is a strike frame
      }
      else if (rolls[rollIndex] + rolls[rollIndex + 1] == 10)
      {
        return Frame.spare; // if the sum of the current roll and the next roll is 10, then it is a spare frame
      }
      else
      {
        return Frame.openFrame;
      }
    }
    //method to calculate the score
    public int Score()
    {
      int score = 0; // initialize the score to 0
      int rollIndex = 0; // initialize the roll index to 0
      for (int i = 0; i < 10; i++) // i is frame
      {
        switch (GetFrameType(rollIndex))
        {
          case Frame.strike:
            score += 10 + StrikeBonus(rollIndex); // add 10 to the score and the next two rolls after the strike
            rollIndex++; // increment the roll index by 1
            break;
          case Frame.spare:
            score += 10 + SpareBonus(rollIndex); // add 10 to the score and the next roll after the spare
            rollIndex += 2; // increment the roll index by 2
            break;
          case Frame.openFrame:
          default:
            score += SumOfBallsInFrame(rollIndex); // add the sum of the current roll and the next roll to the score
            rollIndex += 2; // increment the roll index by 2
            break;
        }
      }
      return score; // return the score
    }
  }
}
