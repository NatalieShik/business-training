using System;
using System.Collections.Generic;
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
                var filePath = Properties.Settings.Default.FilePath;
                AppState.Questions = FileHelper.LoadFromFileOrCreateNew(filePath);
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
                TestForm.ShowTestResults(this);
                return;
            }

            this.Hide();
            using (TestForm test = new TestForm())
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
            SettingsHelper.SaveSettingAtempt(true);
            try
            {
                FileHelper.SaveToFile(Properties.Settings.Default.FilePath, AppState.Questions);
            }
            catch
            {
                MessageBox.Show(this, "Файл не был сохранен. Вероятно, вы переименовали его или удалили.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
