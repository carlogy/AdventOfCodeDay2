namespace Day2AOC;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Incomplete Strategy: " + Strategy.Guide());
        Console.WriteLine("Complete Strategy: " + CompletedStrategy.Guide());
        Console.ReadLine();
    }
}

