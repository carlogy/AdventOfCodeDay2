using System;
namespace Day2AOC
{
	public class CompletedStrategy
	{
		public static int Guide()
		{
            Console.Write("Enter a path for puzzle input: ");
            var path = Console.ReadLine();

            var PuzzleInput = File.ReadAllLines(path);

            int myScore = 0;
            int scissors = 3;
            int paper = 2;
            int rock = 1;
            int draw = 3;
            int won = 6;

            //x = lose, Y = draw, Z = Win
            foreach (var line in PuzzleInput)
            {
                if (line == "A X")
                {
                    myScore += scissors;
                    
                }
                else if (line == "A Y")
                {
                    myScore += rock;
                    myScore += draw;
                }
                else if (line == "A Z")
                {
                    myScore += paper;
                    myScore += won;
                }
                else if (line == "B X")
                {
                    myScore += rock;
                    
                }
                else if (line == "B Y")
                {
                    myScore += draw;
                    myScore += paper;
                }
                else if (line == "B Z")
                {
                    myScore += won;
                    myScore += scissors;
                }
                else if (line == "C X")
                {
                    myScore += paper; 
                }
                else if (line == "C Y")
                {
                    myScore += draw;
                    myScore += scissors;
                }
                else if (line == "C Z")
                {
                    myScore += won;
                    myScore += rock;
                    
                }

            }

            return myScore;
        }
	}
}

