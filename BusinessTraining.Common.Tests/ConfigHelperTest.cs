using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;

namespace BusinessTraining.Tests
{
    [TestClass]
    public class ConfigHelperTest
    {
        [TestMethod]
        public void SettingValue_Test()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(@"C:\Users\shikn\Documents\BusinessTraining\BusinessTraining.exe");
            Assert.IsNotNull(config, "Не получилось прочесть конфигурацию.");
            string settingName = "ChatId";
            string settingValue = "TestValue";

            ConfigHelper.SetSettingValue(config, settingName, settingValue);
            string newValue = ConfigHelper.GetSettingValue(config, settingName);

            Assert.AreEqual(settingValue, newValue);
        }
    }
}
