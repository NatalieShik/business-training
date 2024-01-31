using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BusinessTraining.Tests
{
    [TestClass]
    public class FileHelperTest
    {
        private List<QuestionsAndAnswers> CreateTestData()
        {
            List<QuestionsAndAnswers> questions = new List<QuestionsAndAnswers>();
            QuestionsAndAnswers question = new QuestionsAndAnswers("Привет?", "привет!", "1", "2");
            questions.Add(question);
            question = new QuestionsAndAnswers("Hello?", "hello!", "3", "4");
            questions.Add(question);
            return questions;
        }

        [TestMethod]
        public void LoadFromFile_And_SaveToFile_Binary_Test()
        {
            List<QuestionsAndAnswers> questions = CreateTestData();

            FileHelper.SaveToFile("example.bin", questions);
            List<QuestionsAndAnswers> result = FileHelper.LoadFromFile("example.bin");

            CheckResults(questions, result);
        }

        [TestMethod]
        public void LoadFromFile_And_SaveToFile_Xml_Test()
        {
            List<QuestionsAndAnswers> questions = CreateTestData();

            FileHelper.SaveToFile("example.xml", questions);
            List<QuestionsAndAnswers> result = FileHelper.LoadFromFile("example.xml");

            CheckResults(questions, result);
        }

        [TestMethod]
        public void LoadFromFile_And_SaveToFile_Json_Test()
        {
            List<QuestionsAndAnswers> questions = CreateTestData();

            FileHelper.SaveToFile("example.json", questions);
            List<QuestionsAndAnswers> result = FileHelper.LoadFromFile("example.json");

            CheckResults(questions, result);
        }

        [TestMethod]
        public void LoadFromFile_And_SaveToFile_Txt_Test()
        {
            List<QuestionsAndAnswers> questions = CreateTestData();

            FileHelper.SaveToFile("example.txt", questions);
            List<QuestionsAndAnswers> result = FileHelper.LoadFromFile("example.txt");

            CheckResults(questions, result);
        }

        private void CheckResults(List<QuestionsAndAnswers> expected, List<QuestionsAndAnswers> result)
        {
            Assert.AreEqual(expected.Count, result.Count);
            Assert.AreEqual(expected[0].Question, result[0].Question);
            Assert.AreEqual(expected[0].Section, result[0].Section);
            Assert.AreEqual(expected[0].Direction, result[0].Direction);
            Assert.AreEqual(expected[0].Answer, result[0].Answer);
        }
    }
}
