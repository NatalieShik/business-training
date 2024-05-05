using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BusinessTraining
{
    public partial class PreparationForm : Form
    {
        private List<QuestionsAndAnswers> LocalePreparationQuestions;
        private QuestionsAndAnswers currentQuestion;
        private Random random = new Random();
        private int index;
        private int previousIndex = -1;
        private bool answerShown = false;

        public PreparationForm(string direction, List<string> sections)
        {
            InitializeComponent();
            LocalePreparationQuestions = new List<QuestionsAndAnswers>(AppState.Questions.Where(x => x.Direction == direction && sections.Any(y => x.Section.Contains(y))));
            currentQuestion = NewQuestion();
            textBoxTrainingTitle.Text = $"Вы проходите курс: {AppState.TrainingTitle}";
        }

        private void ButtonWrong_Click(object sender, EventArgs e)
        {
            currentQuestion = NewQuestion();
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            LocalePreparationQuestions.Remove(currentQuestion);
            currentQuestion = NewQuestion();
        }

        private void ButtonShowOrHideAnswer_Click(object sender, EventArgs e)
        {
            if (answerShown)
            {
                this.Height = 340;
                answerShown = false;
                buttonShowOrHideAnswer.Text = "Показать ответ";
            }
            else
            {
                this.Height = 574;
                answerShown = true;
                buttonShowOrHideAnswer.Text = "Скрыть ответ";
            }
        }

        private QuestionsAndAnswers RandomQuestion()
        {
            labelCounter.Text = LocalePreparationQuestions.Count.ToString();
            if (LocalePreparationQuestions.Count == 0)
            {
                MessageBox.Show(this, "Вы успешно прошли обучение! Если вы готовы, пройдите экзаменационное тестирование.", "Поздравляем", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }  
                        
            if (LocalePreparationQuestions.Count == 1)
                return LocalePreparationQuestions[0];

            do
                index = random.Next(LocalePreparationQuestions.Count);
            while (index == previousIndex);

            previousIndex = index;

            return LocalePreparationQuestions[index];
        }

        private QuestionsAndAnswers NewQuestion()
        {
            this.Height = 340;
            answerShown = false;
            QuestionsAndAnswers temp = RandomQuestion();
            if (temp == null)
                return null;
            textBoxForQuestions.Text = temp.Question;
            textBoxForAnswers.Text = temp.Answer;
            return temp;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
