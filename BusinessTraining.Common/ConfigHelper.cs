using System.Configuration;
using System.Xml;

namespace BusinessTraining
{
    public static class ConfigHelper
    {
        public static void SetSettingValue(this Configuration config, string settingName, string settingValue)
        {
            ((ClientSettingsSection)config.SectionGroups["applicationSettings"].Sections[0])
                .Settings.Get(settingName).Value = CreateSettingValueElement(settingValue);
        }

        private static SettingValueElement CreateSettingValueElement(string settingValue) 
        {
            SettingValueElement setting = new SettingValueElement();
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("value");
            XmlText textNode = doc.CreateTextNode(settingValue);
            root.AppendChild(textNode);
            doc.AppendChild(root);
            setting.ValueXml = doc.DocumentElement;
            return setting;
        }
    }
}
