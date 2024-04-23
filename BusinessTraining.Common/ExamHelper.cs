using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessTraining
{
    public static class ExamHelper
    {
        public static List<string> SelectRandomAnswers(QuestionsAndAnswers question)
        {
            var answers = new List<string>
            {
                question.Answer
            };
            answers.AddRange(question.WrongAnswers);

            return answers.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
