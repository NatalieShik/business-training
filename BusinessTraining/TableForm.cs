using BusinessTraining.FilesManager;
using System;
using System.Collections.Generic;
using System.Linq;
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
            if (AppState.Questions.Count == 0)
                buttonExport.Enabled = false;
            else
                buttonExport.Enabled = true;

            dataGridViewForQandA.RowCount = AppState.Questions.Count;
            foreach (var question in AppState.Questions)
            {
                dataGridViewForQandA.Rows[i].Cells[0].Value = question.Question;
                dataGridViewForQandA.Rows[i].Cells[1].Value = question.Answer;
                dataGridViewForQandA.Rows[i].Cells[2].Value = string.Join(Environment.NewLine, question.WrongAnswers);
                dataGridViewForQandA.Rows[i].Cells[3].Value = question.Direction;
                dataGridViewForQandA.Rows[i].Cells[4].Value = question.Section;
                i++;
            }
        }

        private void DataGridViewForQandA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridViewForQandA.Rows[e.RowIndex];
            textBoxQuestion.Text = row.Cells[0].Value.ToString();
            textBoxAnswer.Text = row.Cells[1].Value.ToString();
            textBoxWrongAnswers.Text = row.Cells[2].Value.ToString();
            textBoxDirection.Text = row.Cells[3].Value.ToString();
            textBoxSection.Text = row.Cells[4].Value.ToString();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string question = textBoxQuestion.Text.Trim();
            string answer = textBoxAnswer.Text.Trim();
            List<string> wrongAnswers = textBoxWrongAnswers.Text
                .Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string direction = textBoxDirection.Text.Trim();
            string section = textBoxSection.Text.Trim();
            if (String.IsNullOrEmpty(question) || String.IsNullOrEmpty(answer) || String.IsNullOrEmpty(direction) || String.IsNullOrEmpty(section) || wrongAnswers.Count == 0)
            {
                MessageBox.Show(this, "Все поля должны быть заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            QuestionsAndAnswers questionAndAnswer = new QuestionsAndAnswers(question, answer, wrongAnswers, direction, section);
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

        private void ButtonImport_Click(object sender, EventArgs e)
        {
            string fileName;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.DefaultExt = "docx";
                openFileDialog.Filter = "Все файлы|*.training;*.txt;*.json;*.docx|Зашифрованные файлы|*.training|Текстовые файлы|*.txt|JSON файлы|*.json|Microsoft Word файлы|*.docx";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                fileName = openFileDialog.FileName;
            }
            try
            {
                LoadFromFile(fileName);
                dataGridViewForQandA.Rows.Clear();
                UpdateData();
            }
            catch
            {
                MessageBox.Show(this, "Данный файл не соответствует параметрам, выберите другой.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFromFile(string filePath)
        {
            AppState.Questions = FileHelper.LoadFromFile(filePath);
        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {
            if (AppState.Questions.Count == 0)
                return;
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.DefaultExt = "training";
                saveFileDialog.Filter = "Все файлы|*.training;*.txt;*.json;*.docx|Зашифрованные файлы|*.training|Текстовые файлы|*.txt|JSON файлы|*.json|Microsoft Word файлы|*.docx";
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                FileHelper.SaveToFile(saveFileDialog.FileName, AppState.Questions);
                MessageBox.Show(this, "Файл успешно сохранен.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }
    }
}
