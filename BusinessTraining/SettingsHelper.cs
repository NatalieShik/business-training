namespace BusinessTraining
{
    internal static class SettingsHelper
    {
        public static void SaveSettingAtempt(bool atempt)
        {
            Properties.Settings.Default.Attempt = atempt;
            Properties.Settings.Default.Save();
        }

        public static bool GetFirstLaunchSetting() // TODO: Configuration
        {
            return Properties.Settings.Default.FirstLaunch;
        }

        public static void SaveFirstLaunchSetting() // TODO: Configuration
        {
            Properties.Settings.Default.FirstLaunch = false;
            Properties.Settings.Default.Save();
        }

        public static string GetLaunchFileSetting()
        {
            return Properties.Settings.Default.LaunchFile;
        }
    }
}
