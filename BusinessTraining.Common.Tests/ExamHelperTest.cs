using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTraining.Tests
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

            // сделать так, чтобы проверялось, что встречается один ответ один раз
            List<string> uniqueAnswers = new List<string>();
            foreach (var answer in answers)
            {
                Assert.IsFalse(uniqueAnswers.Contains(answer));
                uniqueAnswers.Add(answer);
            }
        }
    }
}
