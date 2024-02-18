using System;
using System.IO;
using System.Windows.Forms;

namespace BusinessTraining
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                var filePathforQuestions = Path.Combine(Application.LocalUserAppDataPath, Properties.Settings.Default.QuestionsFile);
                AppState.Questions = FileHelper.LoadFromFileOrCreateNew(filePathforQuestions);
                CheckIfNoQuestions();
            }
            catch
            {
                MessageBox.Show(this, "Ошибка, файл не был найден. Загрузите другой файл.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CheckIfNoQuestions()
        {
            if (AppState.Questions.Count == 0)
            {
                buttonOpenPrepearing.Enabled = false;
                buttonOpenTest.Enabled = false;
            }
            else
            {
                buttonOpenPrepearing.Enabled = true;
                buttonOpenTest.Enabled = true;
            }
        }

        private void ButtonOpenTable_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (TableForm table = new TableForm())
            {
                table.ShowDialog();
            } 
            this.Show();
            CheckIfNoQuestions();
        }

        private void ButtonOpenTest_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.Attempt)
            {
                ExamForm.ShowTestResults(this);
                return;
            }

            this.Hide();
            using (ExamForm test = new ExamForm())
            {
                test.ShowDialog();
            }
            this.Show();
        }

        private void ButtonOpenPrepearing_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (AskingUserForm ask = new AskingUserForm())
            {
                ask.ShowDialog();
            } 
            this.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var filePath = Path.Combine(Application.LocalUserAppDataPath, Properties.Settings.Default.QuestionsFile);
            SettingsHelper.SaveSettingAtempt(true);

            FileAttributes attributes = File.GetAttributes(filePath);
            if (attributes.HasFlag(FileAttributes.Hidden))
            {
                attributes = FileAttributes.Normal;
                File.SetAttributes(filePath, attributes);
            }

            FileHelper.SaveToFile(filePath, AppState.Questions);
            File.SetAttributes(filePath, FileAttributes.Hidden);
        }
    }
}
