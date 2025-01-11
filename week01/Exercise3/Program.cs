using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,101);
        int guess = 0;
        while (guess != magicNum)
        {
            Console.Write("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());
            if (magicNum > guess)
            {
                Console.WriteLine("Higher.");
            }
            else if (magicNum < guess)
            {
                Console.WriteLine("Lower.");
            }
            else
            {
                Console.WriteLine("Correct!");
            }
        }

    }
}