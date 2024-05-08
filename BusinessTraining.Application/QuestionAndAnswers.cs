using System.Collections.Generic;

namespace BusinessTraining
{
    public class QuestionAndAnswers
    {
        public string Question { get; set; }

        public string Answer { get; set; }

        public List<string> WrongAnswers { get; set; } = new List<string>();

        public string Direction { get; set; }

        public string Section { get; set; }

        public QuestionAndAnswers(string question, string answer, List<string> wrongAnswers, string direction, string section)
        {
            Question = question;
            Answer = answer;
            WrongAnswers = wrongAnswers;
            Direction = direction;
            Section = section;
        }

        public QuestionAndAnswers() { }
    }
}
