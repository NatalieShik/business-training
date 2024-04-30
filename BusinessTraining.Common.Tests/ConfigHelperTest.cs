using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BusinessTraining.Tests
{
    [TestClass]
    public class ConfigHelperTest
    {
        [TestMethod]
        public void UpdateSetting_Test()
        {
            // TODO: и как проводить тестирование тут??
            string settingName = "CompanyBranch";
            string settingValue = "ул. Оптиков, д. 52";

            SettingValueElement result = ConfigHelper.UpdateSetting(settingValue);

            //Assert.AreEqual
        }

    }
}
