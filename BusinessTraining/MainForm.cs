using System;
using System.IO;
using System.Windows.Forms;

namespace BusinessTraining
{
    public partial class MainForm : Form
    {
        private bool passwordEntered = false;

        public MainForm()
        {
            InitializeComponent();
            buttonOpenPrepearing.Enabled = false;
            buttonOpenTest.Enabled = false;
            textBoxWelcome.Text += $", {AppState.UserName}";
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
            if (!AppState.Attempt)
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
            if (!passwordEntered && AppState.SendMessageProblems)
            {
                e.Cancel = true;
                GetPasswordForm passwordForm = new GetPasswordForm();
                if (passwordForm.ShowDialog() == DialogResult.OK)
                {
                    passwordEntered = true;
                }
            }
        }

        private void TextBoxWelcome_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Блокировать ввод с клавиатуры
        }

        private void TextBoxWelcome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true; // Предотвращение удаления текста
            }
        }
    }
}
