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

        public static string GetSettingCompanyBranch()
        {
            return Properties.Settings.Default.CompanyBranch;
        }

        public static bool GetSettingIsManager()
        {
            return Properties.Settings.Default.IsManager;
        }
    }
}
