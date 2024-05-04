namespace BusinessTraining.Configuration
{
    internal static class ConfigSettingsHelper
    {
        public static void SaveSettingFirstLaunch(bool value)
        {
            Properties.Settings.Default.FirstLaunch = value;
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
