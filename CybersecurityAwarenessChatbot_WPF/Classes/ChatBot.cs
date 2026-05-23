
/*
    Erwin Mashobane
    ST10073464
*/
/*using System;
using System.Collections;
using System.Data;

namespace CybersecurityAwarenessChatbot.Classes

{
    
    class ChatBot
    {
        List<(string message, DateTime time)> conversationHistory = new List<(string, DateTime)>();
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
                    Console.Write("\nBot: Would you like to see your conversation before exiting? (yes/no): ");
                    string choice = Console.ReadLine().ToLower().Trim();

                    while (choice != "yes" && choice != "no")
                    {
                        Console.Write("Please type 'yes' or 'no': ");
                        choice = Console.ReadLine().ToLower().Trim();
                    }

                    if (choice == "yes")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n===== Conversation History =====\n");

                        for (int i = 0; i < conversationHistory.Count; i++)
                        {
                            var entry = conversationHistory[i];

                            string time = entry.time.ToString("HH:mm:ss");

                            // Alternate colors for user & bot
                            if (i % 2 == 0)
                                Console.ForegroundColor = ConsoleColor.White;   // User
                            else
                                Console.ForegroundColor = ConsoleColor.Green;   // Bot

                            Console.WriteLine($"[{time}] {entry.message}");
                        }

                        Console.WriteLine("\n================================");
                        conversationHistory.Clear(); // clear history after displaying
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nBot: Goodbye {UserName}! Stay safe online and keep winning");
                    break;
                }

                // Get response from Responses class and display it     
                Console.ForegroundColor = ConsoleColor.Green;
                string botReply = responses.GetResponse(input);

                conversationHistory.Add(("You: " + input, DateTime.Now));
                conversationHistory.Add(("Bot: " + botReply, DateTime.Now));

                Console.WriteLine("Bot: " + botReply);
            }
        }
    }
}*/

using CybersecurityAwarenessChatbot.Classes;
using System;
using System.Collections.Generic;

namespace CybersecurityAwarenessChatbot_V1.Services
{
    // Main chatbot engine.
    // Controls memory, sentiment, keyword recognition, and conversation flow.
    public class ChatBot
    {
        private readonly KeywordResponder keywordResponder;
        private readonly SentimentDetector sentimentDetector;
        private readonly MemoryStore memoryStore;

        private readonly Random random;

        private bool awaitingName = true;

        private readonly List<string> fallbackResponses;

        private string LastMatchedKeyword = "";

        // Constructor

        public ChatBot()
        {
            keywordResponder = new KeywordResponder();
            sentimentDetector = new SentimentDetector();
            memoryStore = new MemoryStore();

            random = new Random();

            fallbackResponses = new List<string>
            {
                "I'm not sure I understand yet. Try asking about passwords, scams, or privacy.",
                "Could you rephrase that? I can help with cybersecurity topics.",
                "Ask me about phishing, malware, passwords, or online safety."
            };
        }

        // Initial greeting message.
        public string GetGreeting()
        {
            return "👋 Welcome to SecureWin!\n\nWhat is your name?";
        }

        // Main chatbot processing logic.
        public string ProcessInput(string input)
        {
            input = input.ToLower();

            // Capture user name
            if (awaitingName)
            {
                memoryStore.UserName = input;

                awaitingName = false;

                return $"😊 Nice to meet you, {memoryStore.UserName}!\n\n" +
                       $"You can ask me about:\n" +
                       $"🔒 Passwords\n" +
                       $"🎣 Phishing\n" +
                       $"🛡️ Privacy\n" +
                       $"💻 Malware\n" +
                       $"⚠️ Scams";
            }

            // Follow-up conversations
            if (
                input.Contains("tell me more") ||
                input.Contains("another tip") ||
                input.Contains("explain more") ||
                input.Contains("continue")
                )
            {
                return keywordResponder.GetFollowUpResponse();
            }

            // Store favourite topic
            if (input.Contains("interested in"))
            {
                foreach (string keyword in keywordResponder.GetAllKeywords())
                {
                    if (input.Contains(keyword))
                    {
                        memoryStore.FavouriteTopic = keyword;

                        return $"Great! I'll remember that you're interested in {keyword}.";
                    }
                }
            }

            // Sentiment detection
            Sentiment sentiment = sentimentDetector.Detect(input);

            // Keyword responce
            string keywordResponse = keywordResponder.GetResponse(input);

            if (!string.IsNullOrEmpty(keywordResponse))
            {
                LastMatchedKeyword = keywordResponder.LastMatchedKeyword;

                return sentiment + "\n\n" + keywordResponse;
            }

            // Special questions
            if (input.Contains("how are you"))
            {
                return "😊 I'm functioning perfectly and ready to keep you safe online!";
            }

            if (input.Contains("purpose"))
            {
                return "🎯 My purpose is to educate users about cybersecurity awareness.";
            }

            if (input.Contains("what can you do"))
            {
                return "💡 I can help with passwords, phishing, malware, scams, privacy, ransomware, VPNs, and much more!";
            }

            // Fallback response
            return fallbackResponses[random.Next(fallbackResponses.Count)];
        }
    }
}


