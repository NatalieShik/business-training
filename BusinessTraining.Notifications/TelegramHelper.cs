using System.Threading.Tasks;
using Telegram.Bot;

namespace BusinessTraining.Notifications
{
    public class TelegramHelper
    {
        private readonly TelegramBotClient Bot;
        private readonly string ChatId;

        public TelegramHelper(string botToken, string chatId)
        {
            Bot = new TelegramBotClient(botToken);
            ChatId = chatId;
        }

        public async Task SendMessageAsync(string message)
        {
            await Bot.SendTextMessageAsync(ChatId, message);
        }
    }
}
