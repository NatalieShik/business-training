using System;
using System.Configuration;
using System.Windows.Forms;

namespace BusinessTraining.Configuration
{
    public partial class ConfigurationForm : Form
    {
        const int MinPasswordLength = 6;
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void buttonBuildConfig_Click(object sender, EventArgs e)
        {
            if(FieldsAreNotFine())
                return;

            CheckStatus passwordStatus = CheckPassword(textBoxPassword.Text);
            if (passwordStatus == CheckStatus.WrongLength)
            {
                MessageBox.Show(this, "Пароль должен состоять не меньше, чем из 6 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            else if (passwordStatus == CheckStatus.SymbolsProblem)
            {
                MessageBox.Show(this, "Пароль должен содержать прописные и заглавные буквы, а также цифры.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string Password = BCrypt.Net.BCrypt.HashPassword(textBoxPassword.Text);
            string CompanyBranch = textBoxCompanyBranch.Text;
            string BotToken = CryptoHelper.Encrypt(textBoxBotToken.Text);
            string ChatId = CryptoHelper.Encrypt(textBoxChatId.Text);
            string path;

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Программа (*.exe)|*.exe";
            if (DialogResult.OK == fileDialog.ShowDialog())
                path = fileDialog.FileName;
            else return;

            var config = ConfigurationManager.OpenExeConfiguration(path);
            if (config.HasFile == false)
                return;

            config.SetSettingValue("CompanyBranch", CompanyBranch);
            config.SetSettingValue("PasswordHash", Password);
            config.SetSettingValue("BotToken", BotToken);
            config.SetSettingValue("ChatId", ChatId);

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

        private CheckStatus CheckPassword(string password)
        {
            if (password.Length < MinPasswordLength)
                return CheckStatus.WrongLength;
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
                return CheckStatus.SymbolsProblem;
            return CheckStatus.Success;
        }
    }
}
