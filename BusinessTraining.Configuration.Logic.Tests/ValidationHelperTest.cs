using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessTraining.Configuration.Logic.Tests
{
    [TestClass]
    public class ValidationHelperTest
    {
        [TestMethod]
        public void CheckPassword_WrongSymbols_Test()
        {
            string password = "abcabc";
            string pseudoPassword = "*******";

            CheckStatus cs = ValidationHelper.CheckPassword(password, pseudoPassword);

            Assert.AreEqual(cs, CheckStatus.SymbolsProblem);
        }

        [TestMethod]
        public void CheckPassword_WrongLength_Test()
        {
            string password = "abc";
            string pseudoPassword = "*******";

            CheckStatus cs = ValidationHelper.CheckPassword(password, pseudoPassword);

            Assert.AreEqual(cs, CheckStatus.WrongLength);
        }

        [TestMethod]
        public void CheckPassword_Success_Test()
        {
            string password = "Abc1aB";
            string pseudoPassword = "*******";

            CheckStatus cs = ValidationHelper.CheckPassword(password, pseudoPassword);

            Assert.AreEqual(cs, CheckStatus.Success);
        }

        [TestMethod]
        public void CheckPassword_PseudoPassword_is_Password_Test()
        {
            string password = "*******";
            string pseudoPassword = "*******";

            CheckStatus cs = ValidationHelper.CheckPassword(password, pseudoPassword);

            Assert.AreEqual(cs, CheckStatus.None);
        }
    }
}
