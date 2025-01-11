using System;

class Program
{
    static void Main(string[] args)
    {
        static void Welcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string UserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int UseNum()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int NumSquare(int number)
        {
            int square = number * number;
            return square;
        }
        static void PrintOut(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

        Welcome();
        string username = UserName();
        int useNumber = UseNum();
        int squareNum = NumSquare(useNumber);
        PrintOut(username, squareNum);
    }
}