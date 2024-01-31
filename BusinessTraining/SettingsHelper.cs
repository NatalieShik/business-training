namespace BusinessTraining
{
    internal static class SettingsHelper
    {
        public static void SaveSettingAtempt(bool atempt)
        {
            Properties.Settings.Default.Attempt = atempt;
            Properties.Settings.Default.Save();
        }

        public static void SaveSettingFile(string fileName)
        {
            Properties.Settings.Default.FilePath = fileName;
            Properties.Settings.Default.Save();
        }
    }
}
