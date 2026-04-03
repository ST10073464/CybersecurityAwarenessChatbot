
using System;
using System.Media;
using System.Threading;

namespace CybersecurityAwarenessChatbot.Classes
{
    class VoicePlayer
    {
        public void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.hello);

                player.PlaySync();

                // Small pause for effect
                Thread.Sleep(500);
            }
            catch (Exception)
            {
                Console.WriteLine("Audio file could not be played.");

                // Small pause for effect
                Thread.Sleep(500);
            }
        }
    }
}