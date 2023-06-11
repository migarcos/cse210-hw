using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareAnswer = SquareNumber(userNumber);
        Console.WriteLine($"The square to {userNumber} is {squareAnswer}");
    }

    static void DisplayWelcomeMessage()
    {
            Console.WriteLine("Welcome to C# ");
    }

    static string PromptUserName()
    {
            Console.Write("Write your name: ");
            string name = Console.ReadLine();

            return name;
    }

    static int PromptUserNumber()
    {
            Console.Write("Enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }
}