using BluBotCore.Services;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace BluBotCore
{
    class Program
    {
        public static async Task Main()
        {
            DiscordClient _discord = new DiscordClient();
            await _discord.MainAsync();
        }
    }

}
