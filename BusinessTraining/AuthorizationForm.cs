using System;
using System.IO;
using System.Windows.Forms;

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
            if (!SettingsHelper.ConfigurationIsNotFine())
            {
                MessageBox.Show("Отсутвуют настройки конфигурации.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            labelCompanyBranch.Text = SettingsHelper.GetSettingCompanyBranch();
        }

        private async void buttonEnter_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string surname = textBoxSurname.Text.Trim();
            if (String.IsNullOrWhiteSpace(name) || String.IsNullOrWhiteSpace(surname))
            {
                MessageBox.Show("Введите имя и фамилию.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AppState.UserName = $"{textBoxName.Text} {textBoxSurname.Text}";
            if (checkBoxIsUserManager.Checked) //если пользователь хочет сказать, что он админ
            {
                if (String.IsNullOrWhiteSpace(textBoxPassword.Text))
                {
                    MessageBox.Show("Введите пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(!BCrypt.Net.BCrypt.Verify(textBoxPassword.Text, SettingsHelper.GetSettingPasswordHash()))
                {
                    MessageBox.Show("Неверный пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SettingsHelper.SaveSettingIsManager(true);
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

            string status = "обычного пользователя";
            if (SettingsHelper.GetSettingIsManager())
                status = "менеджера";
            try 
            { 
                TelegramHelper sendMessage = new TelegramHelper(SettingsHelper.GetSettingBotToken(), SettingsHelper.GetSettingChatId());
                await sendMessage.SendMessageAsync($"Был выполнен вход в систему сотрудником {AppState.UserName} из " +
                    $"филиала по адресу {SettingsHelper.GetSettingCompanyBranch()}. Вход был произведен в статусе {status}.");
            }
            catch
            {
                SettingsHelper.SaveSettingNoNetwork(true);
            }
        }

        private void Table_FormClosed(object sender, FormClosedEventArgs e)
        {
            var filePath = Path.Combine(Application.LocalUserAppDataPath, Properties.Settings.Default.QuestionsFile);
            FileHelper.SaveToFile(filePath, AppState.Questions);
            SettingsHelper.SaveSettingIsManager(false);
            SettingsHelper.SaveSettingNoNetwork(false);
            Close();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            SettingsHelper.SaveSettingAtempt(true);
            SettingsHelper.SaveSettingNoNetwork(false);
            Close();
        }
    }
}
