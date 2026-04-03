namespace CybersecurityAwarenessChatbot.Classes

{
    class Responses
    {
        public string GetResponse(string input)
        {
            
            // Greeting
            if (input.Contains("how are you"))
            {
                return "I'm fully operational and ready to help you stay safe online!";
            }

            // Purpose
            else if (input.Contains("purpose") || input.Contains("what do you do"))
            {
                return "My purpose is to educate you about cybersecurity and help you avoid online threats.";
            }

            // Password Safety
            else if (input.Contains("password"))
            {
                return "A strong password should be at least 8–12 characters long and include uppercase letters, lowercase letters, numbers, and symbols. Avoid using personal information.";
            }

            // Password Tips Advanced
            else if (input.Contains("strong password") || input.Contains("create password"))
            {
                return "Try using a passphrase like 'BlueSky#2026!' — it's easier to remember and harder to crack.";
            }

            // Phishing
            else if (input.Contains("phishing"))
            {
                return "Phishing is when scammers trick you into giving personal information through fake emails or websites. Always check the sender and avoid clicking suspicious links.";
            }

            // Phishing Scenario
            else if (input.Contains("suspicious email") || input.Contains("fake email"))
            {
                return "If an email asks for urgent action or personal info, verify it directly with the company. Never click unknown links.";
            }

            // Safe Browsing
            else if (input.Contains("safe browsing") || input.Contains("browser safety"))
            {
                return "Always check for HTTPS in the URL, avoid downloading from unknown sites, and keep your browser updated.";
            }

            // Links
            else if (input.Contains("link") || input.Contains("url"))
            {
                return "Hover over links before clicking to see the real URL. If it looks suspicious, don’t click it.";
            }

            // Malware
            else if (input.Contains("malware") || input.Contains("virus"))
            {
                return "Malware is harmful software that can damage your system or steal data. Install antivirus software and avoid suspicious downloads.";
            }

            // Social Engineering
            else if (input.Contains("social engineering"))
            {
                return "Social engineering is when attackers manipulate people into revealing confidential information. Always verify requests before sharing sensitive data.";
            }

            // Personal Data
            else if (input.Contains("personal information") || input.Contains("data protection"))
            {
                return "Never share sensitive information like passwords, ID numbers, or banking details online unless you're sure the site is secure.";
            }

            // WiFi Safety
            else if (input.Contains("wifi") || input.Contains("public wifi"))
            {
                return "Avoid logging into sensitive accounts on public WiFi. Use a VPN if possible to protect your data.";
            }


            // Two-Factor Authentication
            else if (input.Contains("2fa") || input.Contains("two factor"))
            {
                return "Two-Factor Authentication adds an extra layer of security by requiring a second verification step. Always enable it where possible.";
            }

            // What can I ask
            else if (input.Contains("what can i ask"))
            {
                return "You can ask me about passwords, phishing, malware, safe browsing, and protecting your personal data.";
            }

            // Default response
            else
            {
                return "Hmm I’m not sure about that yet. Try asking about passwords, phishing, or safe browsing!";
            }

            
        }
    }
}