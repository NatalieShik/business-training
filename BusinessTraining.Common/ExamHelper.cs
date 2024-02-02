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

            foreach (var answer in question.WrongAnswers)
            {
                answers.Add(answer);
            }
            answers.OrderBy(x => Guid.NewGuid());
            return answers;
        }
    }
}
