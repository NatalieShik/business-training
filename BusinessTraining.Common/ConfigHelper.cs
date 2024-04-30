using System.Configuration;
using System.Xml;

namespace BusinessTraining
{
    public static class ConfigHelper
    {
        public static SettingValueElement UpdateSetting(string settingValue) 
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
