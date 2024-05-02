using Telegram.Bot;

namespace BusinessTraining
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

        public void SendMessage(string message)
        {
            Bot.SendTextMessageAsync(ChatId, message);
        }
    }
}
