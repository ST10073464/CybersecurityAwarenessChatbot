
/*
    Erwin Mashobane
    ST10073464
*/
using System;
using System.Collections;


namespace CybersecurityAwarenessChatbot.Classes

{
    class ChatBot
    {
        public string UserName { get; set; }

        UIHelper ui = new UIHelper();

        VoicePlayer voice = new VoicePlayer();

        Responses responses = new Responses();

        public void Start()
        {
            // Show ASCII Logo
            ui.ShowLogo();

            // Play welcome audio
            voice.PlayGreeting();

            AskUserName();

            // Small pause for effect
            Thread.Sleep(500);

            //  welcome message
            Console.WriteLine($"\nHey {UserName}! Welcome to SecureWin");

            Console.WriteLine("\nYou can chat with me about staying safe online, including:");
            Console.WriteLine("     Creating strong passwords");
            Console.WriteLine("     Spotting phishing scams");
            Console.WriteLine("     Safe and smart browsing");

            Console.WriteLine("\nGo ahead and ask me anything related to online safety!\n");
            Console.WriteLine("Type 'exit' anytime to quit.\n");

            ChatLoop();
        }

        void AskUserName()
        {
            Console.Write("Please enter your name: ");
            UserName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(UserName))
            {
                // warning message when user enters empty name
                Console.WriteLine("Name cannot be empty. Please try again.");
                UserName = Console.ReadLine();
            }

            // Trim spaces and capitalize first letter
            UserName = UserName.Trim();
            UserName = char.ToUpper(UserName[0]) + UserName.Substring(1).ToLower();
        }

        void ChatLoop()
        {
            string input = "";

            while (true)
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nYou: ");

                input = Console.ReadLine().ToLower();
                //  Case-InsensitiveComparer handling
                input = input.ToLower().Trim();

                if (string.IsNullOrWhiteSpace(input))
                {
                    // Check for empty input and prompt user to enter a valid question
                    Console.WriteLine("Bot: Please enter a valid question.");
                    continue;
                }

                // Exit condition
                if (input == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nBot: Goodbye {UserName}! Stay safe online and keep winning");
                    break;
                }


                // Get response from Responses class and display it     
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bot: " + responses.GetResponse(input));
            }
        }
    }
}


