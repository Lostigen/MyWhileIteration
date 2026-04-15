using System;

namespace MyWhileIteration;

class Program
{
    static void Main(string[] args)
    {
            MainMenu();
    }

    private static bool MainMenu()
    {
        Console.WriteLine("Choose an option.");
        Console.WriteLine("Option 1.");
        Console.WriteLine("Option 2.");
        Console.WriteLine("Option 3.");
        Console.WriteLine("Option 4.");
        Console.WriteLine("Option 5.");
        Console.WriteLine("Option 6.");
        string selection = Console.ReadLine() ?? "";

        switch (selection)
        {
            case "1":
                DoSomething();
                return true;
            case "2":
                DoSomethingElse();
                return true;
            case "3":
                return true;
            case "4":
                return true;
            case "5":
                return true;
            case "6":
                return true;
            default:
                return false;
        }
    }

    private static void DoSomething()
    {
        Console.WriteLine("Doing something.");
    }

    private static void DoSomethingElse()
    {
        Console.WriteLine("Doing something else.");
    }
}
