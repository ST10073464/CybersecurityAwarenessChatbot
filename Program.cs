using System;

namespace CybersecurityAwarenessChatbot.Bot
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