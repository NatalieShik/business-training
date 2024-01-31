using System;
using System.Windows.Forms;

namespace BusinessTraining
{
    public partial class TableForm : Form
    {
        int rowIndex = -1;
        public TableForm()
        {
            InitializeComponent();          
            UpdateData();
        }

        private void UpdateData()
        {
            int i = 0;
            try
            {
                dataGridViewForQandA.RowCount = AppState.Questions.Count;
                foreach (var question in AppState.Questions)
                {
                    dataGridViewForQandA.Rows[i].Cells[0].Value = question.Question;
                    dataGridViewForQandA.Rows[i].Cells[1].Value = question.Answer;
                    dataGridViewForQandA.Rows[i].Cells[2].Value = question.Direction;
                    dataGridViewForQandA.Rows[i].Cells[3].Value = question.Section;
                    i++;
                }
            }
            catch { }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViewForQandA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridViewForQandA.Rows[e.RowIndex];
            textBoxQuestion.Text = row.Cells[0].Value.ToString();
            textBoxAnswer.Text = row.Cells[1].Value.ToString();
            textBoxDirection.Text = row.Cells[2].Value.ToString();
            textBoxSection.Text = row.Cells[3].Value.ToString();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string question = textBoxQuestion.Text.Trim();
            string answer = textBoxAnswer.Text.Trim();
            string direction = textBoxDirection.Text.Trim();
            string section = textBoxSection.Text.Trim();
            if (String.IsNullOrEmpty(question) || String.IsNullOrEmpty(answer) || String.IsNullOrEmpty(direction) || String.IsNullOrEmpty(section))
            {
                MessageBox.Show(this, "Все поля должны быть заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QuestionsAndAnswers questionAndAnswer = new QuestionsAndAnswers(question, answer, direction, section);
            AppState.Questions.Add(questionAndAnswer);
            UpdateData();
            rowIndex = -1;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show(this, "Пожалуйста, выберите строку щелчком по ней в таблице.","Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AppState.Questions.RemoveAt(rowIndex);
            UpdateData();
            rowIndex = -1;
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            ButtonDelete_Click(sender, e);
            ButtonAdd_Click(sender, e);
            UpdateData();
        }

        private void ButtonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "txt";
            openFileDialog.Filter = "All files|*.txt;*.bin;*.json;*.xml|Текстовые файлы|*.txt|Бинарные файлы|*.bin|JSON файлы|*.json|XML файлы|*.xml";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            SettingsHelper.SaveSettingFile(openFileDialog.FileName);
            try
            {
                LoadFromFile();
                dataGridViewForQandA.Rows.Clear();
                UpdateData();
            }
            catch
            {
                MessageBox.Show(this, "Данный файл не соответствует параметрам, выберите другой.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFromFile()
        {
            AppState.Questions = FileHelper.LoadFromFile(Properties.Settings.Default.FilePath);
        }
    }
}
