using System;

namespace BusinessTraining
{
    public static class SettingsHelper
    {
        public static void SaveSettingAtempt(bool atempt)
        {
            Properties.Settings.Default.Attempt = atempt;
            Properties.Settings.Default.Save();
        }

        public static void SaveSettingIsManager(bool isManager)
        {
            Properties.Settings.Default.IsManager = isManager;
            Properties.Settings.Default.Save();
        }

        public static bool GetSettingIsManager()
        {
            return Properties.Settings.Default.IsManager;
        }

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
    }
}
