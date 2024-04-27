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
            buttonOpenPrepearing.Enabled = false;
            buttonOpenTest.Enabled = false;
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

        private void ButtonChooseFile_Click(object sender, EventArgs e)
        {
            string fileName;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.DefaultExt = "docx";
                openFileDialog.Filter = "Зашифрованные файлы|*.training";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                fileName = openFileDialog.FileName;
                AppState.TrainingTitle = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
            }
            try
            {
                AppState.Questions = FileHelper.LoadFromFile(fileName);
                CheckIfNoQuestions();
            }
            catch
            {
                MessageBox.Show(this, "Данный файл не соответствует параметрам, выберите другой.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
