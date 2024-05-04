namespace BusinessTraining.Configuration
{
    internal static class ConfigSettingsHelper
    {
        public static void SaveSettingFirstLaunchAsFalse()
        {
            Properties.Settings.Default.FirstLaunch = false;
            Properties.Settings.Default.Save();
        }

        public static void SaveSettingConfigFilePath(string configFilePath)
        {
            Properties.Settings.Default.ConfigFilePath = configFilePath;
            Properties.Settings.Default.Save();
        }

        public static string GetSettingConfigFilePath()
        {
            return Properties.Settings.Default.ConfigFilePath;
        }

        public static bool GetSettingFirstLaunch()
        {
            return Properties.Settings.Default.FirstLaunch;
        }
    }
}
