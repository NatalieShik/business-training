using System;
using System.Collections.Generic;

namespace BusinessTraining
{
    [Serializable]
    public class QuestionsAndAnswers
    {
        public string Question { get; set; }

        public string Answer { get; set; }

        public List<string> WrongAnswers { get; } = new List<string>();

        public string Direction { get; set; }

        public string Section { get; set; }

        public QuestionsAndAnswers(string question, string answer, string direction, string section)
        {
            Question = question;
            Answer = answer;
            Direction = direction;
            Section = section;
        }

        public QuestionsAndAnswers() { }
    }
}
