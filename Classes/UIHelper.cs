using System;

namespace CybersecurityAwarenessChatbot.Classes

{
    class UIHelper
    {
        public void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("=========================================");
            Console.WriteLine("     CYBERSECURITY AWARENESS BOT");
            Console.WriteLine("=========================================");
            Console.WriteLine("          _________");
            Console.WriteLine("         /         \\");
            Console.WriteLine("        /  LOCKED   \\");
            Console.WriteLine("       |   CYBER     |");
            Console.WriteLine("       |  SECURITY   |");
            Console.WriteLine("        \\___________/");
            Console.WriteLine("           ||   ||");
            Console.WriteLine("           ||   ||");
            Console.WriteLine("=========================================\n");

            Console.ResetColor();
        }
    }
}