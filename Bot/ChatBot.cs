
using System;

namespace CybersecurityAwarenessChatbot.Bot
{
    class ChatBot
    {
        public string UserName { get; set; }

        VoicePlayer voice = new VoicePlayer();
        UIHelper ui = new UIHelper();
        Responses responses = new Responses();

        public void Start()
        {
            ui.ShowLogo();

            voice.PlayGreeting();

            AskUserName();

            Console.WriteLine($"\nWelcome {UserName}! I am your Cybersecurity Awareness Assistant.");
            Console.WriteLine("Ask me about password safety, phishing, or safe browsing.");
            Console.WriteLine("Type 'exit' to quit.\n");

            ChatLoop();
        }

        void AskUserName()
        {
            Console.Write("Please enter your name: ");
            UserName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(UserName))
            {
                Console.WriteLine("Name cannot be empty. Please try again.");
                UserName = Console.ReadLine();
            }
        }

        void ChatLoop()
        {
            string input = "";

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nYou: ");

                input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Bot: Please enter a valid question.");
                    continue;
                }

                // FIX: Check exit BEFORE responding
                if (input == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bot: Goodbye! Stay safe online.");
                    break;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bot: " + responses.GetResponse(input));
            }
        }
    }
}
