
using System;
using System.Media;

namespace CybersecurityAwarenessChatbot.Bot
{
    class VoicePlayer
    {
        public void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer(@"C:\Users\Student\Desktop\Prog6221\CybersecurityAwarenessChatbot\PART_1\CybersecurityAwarenessChatbot\hello.wav");

                player.Load();
                player.PlaySync();
            }
            catch (Exception)
            {
                Console.WriteLine("Audio file could not be played.");
            }
        }
    }
}