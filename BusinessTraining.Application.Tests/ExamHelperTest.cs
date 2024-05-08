using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace BusinessTraining.Application.Tests
{
    [TestClass]
    public class ExamHelperTest
    {
        private QuestionsAndAnswers CreateTestData()
        {
            List<string> wrongAnswers = new List<string>
        {
            "ответ",
            "answer",
            "wrong answer"
        };
            QuestionsAndAnswers question = new QuestionsAndAnswers("Вопрос?", "правильный ответ", wrongAnswers, "1", "2");
            return question;
        }

        [TestMethod]
        public void SelectRandomAnswers_Test()
        {
            QuestionsAndAnswers question = CreateTestData();

            var answers = ExamHelper.SelectRandomAnswers(question);

            Assert.IsNotNull(answers);
            Assert.AreEqual(question.WrongAnswers.Count + 1, answers.Count);

            var expectedAnswers = question.WrongAnswers.ToList();
            expectedAnswers.Add(question.Answer);

            CollectionAssert.AreEquivalent(expectedAnswers, answers);
        }
    }
}
