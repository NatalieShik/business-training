using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BusinessTraining
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            //if (SettingsHelper.ConfigurationIsFine())
            //{
            //    MessageBox.Show("Отсутвуют настройки конфигурации.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Close();
            //}
            labelCompanyBranch.Text = "Адрес!!"; // TODO: прописать филиал
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string surname = textBoxSurname.Text.Trim();
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname))
            {
                MessageBox.Show("Введите имя и фамилию.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AppState.UserName = $"{textBoxName.Text} {textBoxSurname.Text}";
            if (checkBoxIsUserManager.Checked) //если пользователь хочет сказать, что он админ
            {
                if (String.IsNullOrEmpty(textBoxPassword.Text))
                {
                    MessageBox.Show("Введите пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SettingsHelper.SaveSettingIsManager(true);
                // TODO: адрес файла или иная концепция
                //using (StreamReader reader = new StreamReader("")) 
                //{
                //    string line = reader.ReadLine(); // Читаем хеш-код из файла
                //    if (line != null)
                //    {
                //        int savedHashCode;
                //        if (int.TryParse(line, out savedHashCode)) // Пытаемся преобразовать считанный хеш-код из строки в целое число
                //        {
                //            if (savedHashCode == textBoxPassword.Text.GetHashCode()) // Сравниваем считанный хеш-код с введенным
                //            {
                //                MessageBox.Show("Вы вошли как менеджер филиала.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            }
                //            else
                //            {
                //                MessageBox.Show("Пароли не совпадают.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //                return;
                //            }
                //        }
                //    }
                //}
            }
            if (SettingsHelper.GetSettingIsManager())
            {
                var filePathforQuestions = Path.Combine(Application.LocalUserAppDataPath, Properties.Settings.Default.QuestionsFile);
                AppState.Questions = FileHelper.LoadFromFileOrCreateNew(filePathforQuestions);

                TableForm table = new TableForm();
                Hide();
                table.FormClosed += Table_FormClosed;
                table.Show();
            }
            else
            {
                MainForm main = new MainForm();
                Hide();
                main.FormClosed += Main_FormClosed;
                main.Show();
            }
        }

        private void Table_FormClosed(object sender, FormClosedEventArgs e)
        {
            var filePath = Path.Combine(Application.LocalUserAppDataPath, Properties.Settings.Default.QuestionsFile);
            FileHelper.SaveToFile(filePath, AppState.Questions);
            SettingsHelper.SaveSettingIsManager(false);
            Close();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            SettingsHelper.SaveSettingAtempt(true);
            Close();
        }
    }
}
