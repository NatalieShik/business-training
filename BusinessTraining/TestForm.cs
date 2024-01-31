using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BusinessTraining
{
    public partial class TestForm : Form
    {
        private List<QuestionsAndAnswers> LocaleTestQuestions = new List<QuestionsAndAnswers>(AppState.Questions);
        private int index; //индекс текущего вопроса
        private int[] previousIndexes; //использованные индексы
        private int i; //индекс для массива
        private Random random = new Random();
        private int questions;  //количество вопросов

        private List<QuestionsAndAnswers> LocaleTestAnswers = new List<QuestionsAndAnswers>();
        private short right;

        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            previousIndexes = new int[LocaleTestQuestions.Count];
            for (int ind = 0; ind < LocaleTestQuestions.Count; ind++)
                previousIndexes[ind] = -1;

            questions = LocaleTestQuestions.Count;
            NewQuestion();
        }

        private QuestionsAndAnswers NewQuestion()
        {
            labelQuestionsLeftNum.Text = questions.ToString();
            
            QuestionsAndAnswers temp = RandomQuestion();
            if (temp == null)
                return null;

            textBoxForQuestions.Text = temp.Question;
            RandomAnswers(temp);

            return temp;
        }

        private QuestionsAndAnswers RandomQuestion()
        {
            if (LocaleTestQuestions.Count == 1)
                return LocaleTestQuestions[0];

            do
                index = random.Next(LocaleTestQuestions.Count);
            while (previousIndexes.Any(prevIndex => prevIndex == index));

            previousIndexes[i] = index; i++;

            return LocaleTestQuestions[index];
        }

        private void RandomAnswers(QuestionsAndAnswers question)
        {
            List<string> answers = SelectRandomAnswers(question);
            PopulateComboBoxAnswers(answers);
        }

        private void PopulateComboBoxAnswers(List<string> answers)
        {
            comboBoxAnswer.Items.Clear();
            foreach (var answer in answers)
            {
                comboBoxAnswer.Items.Add(answer);
            }
        }

        private List<string> SelectRandomAnswers(QuestionsAndAnswers question)
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

        //private void RandomAnswers(QuestionsAndAnswers temp)
        //{
        //    int[] previousIndexesOfAnswers = new int[5];
        //    for (int ind = 0; ind < 5; ind++)
        //        previousIndexesOfAnswers[ind] = -1;

        //    for (int ind = 0; ind < 5; ind++)
        //    {
        //        int randomNumber;
        //        do
        //            randomNumber = random.Next(LocaleTestQuestions.Count);
        //        while (previousIndexesOfAnswers.Any(prevIndex => prevIndex == randomNumber));

        //        comboBoxAnswer.Items.Add(LocaleTestQuestions[randomNumber].Answer);
        //        previousIndexesOfAnswers[ind] = randomNumber;
        //    }
        //    if (!comboBoxAnswer.Items.Contains(temp.Answer))
        //    {
        //        comboBoxAnswer.Items.RemoveAt(4);
        //        comboBoxAnswer.Items.Add(temp.Answer);
        //    }

        //    int n = comboBoxAnswer.Items.Count;
        //    while (n > 1)
        //    {
        //        n--;
        //        int k = random.Next(n + 1);
        //        object value = comboBoxAnswer.Items[k];
        //        comboBoxAnswer.Items[k] = comboBoxAnswer.Items[n];
        //        comboBoxAnswer.Items[n] = value;
        //    }
        //}

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            QuestionsAndAnswers RightQuestion = AppState.Questions.FirstOrDefault(q => q.Question == textBoxForQuestions.Text);
            if (RightQuestion == null)
                return;

            // TODO: избавиться от этого конструктора
            QuestionsAndAnswers temp = new QuestionsAndAnswers(textBoxForQuestions.Text, comboBoxAnswer.Text, RightQuestion.Direction, RightQuestion.Section);
            LocaleTestAnswers.Add(temp);
            if (temp.Answer == RightQuestion.Answer)
                right++;

            questions--;
            if (questions > 0)
                NewQuestion();
            else
            {
                if (questions == 0) 
                    labelQuestionsLeftNum.Text = questions.ToString();
                AppState.LastTestResult = $"По итогам теста, вы ответили верно на следующее количество вопросов: {right}, " +
                    $"что составляет {Math.Round((double)right / LocaleTestAnswers.Count * 100, 2)}% от всех вопросов.";
                ShowTestResults(this);

                SettingsHelper.SaveSettingAtempt(false);
                this.Close();
            }
        }

        public static void ShowTestResults(IWin32Window owner)
        {
            MessageBox.Show(owner, AppState.LastTestResult, "Вы прошли тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
