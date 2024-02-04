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

            //answers.Select(x => (Item:x, OrderNum: Guid.NewGuid())).OrderBy(x => x.OrderNum).Select(x => x.Item).ToList();

            return answers.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
