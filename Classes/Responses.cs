namespace CybersecurityAwarenessChatbot.Classes

{
    class Responses
    {
        public string GetResponse(string input)
        {
            if (input.Contains("how are you"))
            {
                return "I'm functioning perfectly and ready to help you stay safe online.";
            }

            else if (input.Contains("purpose"))
            {
                return "My purpose is to educate people about cybersecurity threats.";
            }

            else if (input.Contains("password"))
            {
                return "Use strong passwords with uppercase, lowercase, numbers and symbols.";
            }

            else if (input.Contains("phishing"))
            {
                return "Phishing is when attackers trick you into revealing personal information through fake emails or websites.";
            }

            else if (input.Contains("safe browsing"))
            {
                return "Avoid suspicious websites, check URLs carefully, and keep your browser updated.";
            }

            else if (input.Contains("what can i ask"))
            {
                return "You can ask about phishing, passwords, or safe browsing.";
            }

            else
            {
                return "I didn’t quite understand that. Could you rephrase?";
            }
        }
    }
}