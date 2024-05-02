using System;
using System.Configuration;
using System.Windows.Forms;

namespace BusinessTraining.Configuration
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void buttonBuildConfig_Click(object sender, EventArgs e)
        {
            if(FieldsAreNotFine())
                return;

            int passwordStatus = CheckPassword(textBoxPassword.Text);
            if (passwordStatus == 1)
            {
                MessageBox.Show("Пароль должен состоять не меньше, чем из 6 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            else if (passwordStatus == 2)
            {
                MessageBox.Show("Пароль должен содержать прописные и заглавные буквы, а также цифры.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Password = BCrypt.Net.BCrypt.HashPassword(textBoxPassword.Text);
            string CompanyBranch = textBoxCompanyBranch.Text;
            string BotToken = textBoxBotToken.Text;
            string ChatId = textBoxChatId.Text;
            string path;

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Программа (*.exe)|*.exe";
            if (DialogResult.OK == fileDialog.ShowDialog())
                path = fileDialog.FileName;
            else return;

            var config = ConfigurationManager.OpenExeConfiguration(path);
            if (config.HasFile == false)
                return;

            ((ClientSettingsSection)config.SectionGroups["applicationSettings"].Sections[0])
                .Settings.Get("CompanyBranch").Value = ConfigHelper.UpdateSetting(CompanyBranch);
            ((ClientSettingsSection)config.SectionGroups["applicationSettings"].Sections[0])
                .Settings.Get("PasswordHash").Value = ConfigHelper.UpdateSetting(Password);
            ((ClientSettingsSection)config.SectionGroups["applicationSettings"].Sections[0])
                .Settings.Get("BotToken").Value = ConfigHelper.UpdateSetting(BotToken);
            ((ClientSettingsSection)config.SectionGroups["applicationSettings"].Sections[0])
                .Settings.Get("ChatId").Value = ConfigHelper.UpdateSetting(ChatId);

            // Сохраняем изменения в конфигурационном файле
            config.Save(ConfigurationSaveMode.Modified);

            // Перезагружаем конфигурацию приложения
            ConfigurationManager.RefreshSection("applicationSettings");
            MessageBox.Show("Конфигурация приложения была успешно создана.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool FieldsAreNotFine()
        {
            if (String.IsNullOrWhiteSpace(textBoxPassword.Text) || String.IsNullOrWhiteSpace(textBoxCompanyBranch.Text)
                || String.IsNullOrWhiteSpace(textBoxBotToken.Text) || String.IsNullOrWhiteSpace(textBoxChatId.Text))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else { return false; }
        }

        private int CheckPassword(string password)
        {
            if (password.Length < 6)
                return 1;
            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    hasUpperCase = true;
                else if (char.IsLower(c))
                    hasLowerCase = true;
                else if (char.IsDigit(c))
                    hasDigit = true;
            }
            if (!hasUpperCase || !hasLowerCase || !hasDigit)
                return 2;
            return 0;
        }
    }
}
