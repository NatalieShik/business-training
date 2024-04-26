using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BusinessTraining
{
    public partial class ExamForm : Form
    {
        private List<QuestionsAndAnswers> LocaleTestQuestions = new List<QuestionsAndAnswers>(AppState.Questions);
        private int index; //индекс текущего вопроса
        private int[] previousIndexes; //использованные индексы
        private int i; //индекс для массива
        private Random random = new Random();
        private int questions;  //количество вопросов

        private List<QuestionsAndAnswers> LocaleTestAnswers = new List<QuestionsAndAnswers>();
        private short right;

        public ExamForm()
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
            List<string> answers = ExamHelper.SelectRandomAnswers(question);
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

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            QuestionsAndAnswers RightQuestion = AppState.Questions.FirstOrDefault(q => q.Question == textBoxForQuestions.Text);
            if (RightQuestion == null)
                return;

            QuestionsAndAnswers temp = new QuestionsAndAnswers();
            temp.Answer = comboBoxAnswer.Text;
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
                AppState.LastTestResult = $"Пользователь {AppState.UserName} прошел тестирование по \"{AppState.TrainingTitle}\", набрав {right} баллов " +
                    $"из {AppState.Questions.Count} возможных, что составляет {Math.Round((double)right / LocaleTestAnswers.Count * 100, 2)}% от всех вопросов.";
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
