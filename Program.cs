using System;
using System.Diagnostics;

namespace MyWhileIteration;

class Program
{
    static void Main(string[] args)
    {
            bool menu = true;
            while (menu == true)
            {
                menu = MainMenu();
            }
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
        Console.WriteLine("7, exit");
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
                DoCaseThree();
                return true;
            case "4":
                DoCaseFour();
                return true;
            case "5":
                DoCaseFive();
                return true;
            case "6":
                DoCaseSix();
                return true;
            case "7":
                return false;
            default:
                return false;
        }
    }

    private static void DoSomething()
    {
        // Starta ett av spelen du redan gjort här
        Console.WriteLine("Kör FizzBuzz här kanske?");
        Console.ReadLine();
    }

    private static void DoSomethingElse()
    {
        // Starta ett av spelen du redan gjort här
        Console.WriteLine("Kör Tärningsspelet här kanske?");
        Console.ReadLine();
    }
    
    private static void DoCaseThree()
    {
        // Starta ett av spelen du redan gjort här
        Console.WriteLine("Något annat spel här...");
        Console.ReadLine();
    }
    
    private static void DoCaseFour()
    {
        // Starta ett av spelen du redan gjort här
        Console.WriteLine("Något annat spel här...");
        Console.ReadLine();
    }
    
    private static void DoCaseFive()
    {
        // Starta ett av spelen du redan gjort här
        Console.WriteLine("Något annat spel här...");
        Console.ReadLine();
    }
    
    private static void DoCaseSix()
    {
        // Starta ett av spelen du redan gjort här
        Console.WriteLine("Något annat spel här...");
        Console.ReadLine();
    }    
}
