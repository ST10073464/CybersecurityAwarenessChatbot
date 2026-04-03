/*
    Erwin Mashobane
    ST10073464
*/
using System.Threading;

public class ConsoleUI
{
    public static void TypeText(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(30); // typing effect
        }
        Console.WriteLine();
    }
}