using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNum = -1;
        while (userNum != 0)
        {
            Console.Write("Enter a number (To quit enter 0): ");
            string useInput = Console.ReadLine();
            userNum = int.Parse(useInput);
            if (userNum !=0)
            {
                numbers.Add(userNum);
            }
        }
        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"This is the sum: {sum}.");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"This is the average: {average}.");
        int large = numbers[0];
        foreach (int number in numbers)
        {
            if (number > large)
            {
                large = number;
            }
        }
        Console.WriteLine($"This is the largest: {large}.");

    }
}