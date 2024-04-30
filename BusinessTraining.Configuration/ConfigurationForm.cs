using System.Windows.Forms;
using System.Configuration;
using System;
using System.Xml;
using System.Text;
using System.Security.Cryptography;

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

            string sSourceData = textBoxPassword.Text;
            byte[] tmpSource = UTF8Encoding.UTF8.GetBytes(sSourceData);
            byte[] tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

            string Password = ByteArrayToString(tmpHash);
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

        static string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length - 1; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }
    }
}
