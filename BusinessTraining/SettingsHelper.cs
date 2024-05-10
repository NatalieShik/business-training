using System;

namespace BusinessTraining
{
    public static class SettingsHelper
    {
        public static string GetSettingCompanyBranch()
        {
            return Properties.Settings.Default.CompanyBranch;
        }

        public static bool ConfigurationIsNotFine()
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.CompanyBranch) || String.IsNullOrEmpty(Properties.Settings.Default.PasswordHash)
                || String.IsNullOrEmpty(Properties.Settings.Default.BotToken) || String.IsNullOrEmpty(Properties.Settings.Default.ChatId))
                return false;
            return true;
        }

        public static string GetSettingPasswordHash()
        {
            return Properties.Settings.Default.PasswordHash;
        }

        public static string GetSettingChatId()
        {
            return CryptoHelper.Decrypt(Properties.Settings.Default.ChatId);
        }

        public static string GetSettingBotToken()
        {
            return CryptoHelper.Decrypt(Properties.Settings.Default.BotToken);
        }
    }
}
