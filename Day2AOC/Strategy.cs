using System;
namespace Day2AOC
{
	public class Strategy
	{
		public static int Guide()
		{
			
			Console.Write("Enter a path for puzzle input: ");
			var path = Console.ReadLine();

			var PuzzleInput = File.ReadAllLines(path);

			var  len = PuzzleInput.GetLength(0);

            int Opponent = 0;
            int myScore = 0;
            int scissors = 3;
            int paper = 2;
            int rock = 1;
            int draw = 3;
            int won = 6;

            // Rock = A (1), Paper = B (2), Scissors = C (3);
            // Rock = X (1), Paper = Y (2), Scissors = Z (3);

            //Loss = 0, Draw = 3, win = 6

  

			foreach (var line in PuzzleInput)
			{
				if (line == "A X")
				{
                    myScore += rock;
                    Opponent += rock;
					myScore += draw;
					Opponent += draw;
				}
				else if (line == "A Y")
				{
                    Opponent += rock;
                    myScore += paper;
                    myScore += won;
				}
                else if (line == "A Z")
                {
                    myScore += scissors;
                    Opponent += rock;
                    Opponent += won;
                }
                else if (line == "B X")
                {
                    Opponent += paper;
                    myScore += rock;
                    Opponent += won;
                }
                else if (line == "B Y")
                {
                    Opponent += paper;
                    myScore += paper;
                    myScore += draw;
					Opponent += draw;
                }
                else if (line == "B Z")
                {
                    Opponent += paper;
                    myScore += scissors;
                    myScore += won;
                }
                else if (line == "C X")
                {
                    Opponent += scissors;
                    myScore += rock;
                    myScore += won;
                }
                else if (line == "C Y")
                {
                    Opponent += scissors;
                    Opponent += won;
                    myScore += paper;
                }
                else if (line == "C Z")
                {
                    myScore += draw;
                    myScore += scissors;
					Opponent += draw;
                    Opponent += scissors;

                }

            }	       
			
			return myScore;
			
		}
	}
}

