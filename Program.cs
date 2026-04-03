/*
    Erwin Mashobane
    ST10073464
*/
using System;

namespace CybersecurityAwarenessChatbot.Classes

{
    class Program
    {
        static void Main(string[] args)
        {
            ChatBot bot = new ChatBot();
            bot.Start();

            Console.ReadKey();
        }
    }
}