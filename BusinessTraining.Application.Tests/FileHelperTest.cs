using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BusinessTraining.Application.Tests
{
    [TestClass]
    public class FileHelperTest
    {
        private List<QuestionsAndAnswers> CreateTestData()
        {
            List<QuestionsAndAnswers> questions = new List<QuestionsAndAnswers>();
            List<string> wrongAnswers = new List<string>
            {
                "привет",
                "привет-привет"
            };
            QuestionsAndAnswers question = new QuestionsAndAnswers("Привет?", "привет!", wrongAnswers, "1", "2");
            questions.Add(question);
            List<string> wrongAnswersEng = new List<string>
            {
                "hello",
                "hello-hello"
            };
            question = new QuestionsAndAnswers("Hello?", "hello!", wrongAnswersEng, "3", "4");
            questions.Add(question);
            return questions;
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
        public void LoadFromFile_And_SaveToFile_Training_Test()
        {
            List<QuestionsAndAnswers> questions = CreateTestData();

            FileHelper.SaveToFile("example.training", questions);
            List<QuestionsAndAnswers> result = FileHelper.LoadFromFile("example.training");

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

        [TestMethod]
        public void LoadFromFile_And_SaveToFile_Docx_Test()
        {
            List<QuestionsAndAnswers> questions = CreateTestData();

            FileHelper.SaveToFile("example.docx", questions);
            List<QuestionsAndAnswers> result = FileHelper.LoadFromFile("example.docx");

            CheckResults(questions, result);
        }

        private void CheckResults(List<QuestionsAndAnswers> expected, List<QuestionsAndAnswers> result)
        {
            Assert.AreEqual(expected.Count, result.Count);
            Assert.AreEqual(expected[0].Question, result[0].Question);
            Assert.AreEqual(expected[0].Answer, result[0].Answer);

            Assert.AreEqual(expected[0].WrongAnswers.Count, result[0].WrongAnswers.Count);
            Assert.AreEqual(expected[0].WrongAnswers[0].ToString(), result[0].WrongAnswers[0].ToString());

            Assert.AreEqual(expected[0].Direction, result[0].Direction);
            Assert.AreEqual(expected[0].Section, result[0].Section);
        }
    }
}
