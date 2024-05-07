using BusinessTraining.Notifications;
using System;
using System.IO;
using System.Windows.Forms;

namespace BusinessTraining
{
    public partial class AuthorizationForm : Form
    {
        private const string QuestionsFile = "QuestionsFile.json";
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
            textBoxCompanyBranch.Text = SettingsHelper.GetSettingCompanyBranch();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private async void ButtonEnter_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
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
                var filePathforQuestions = Path.Combine(Application.LocalUserAppDataPath, QuestionsFile);
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
            var filePath = Path.Combine(Application.LocalUserAppDataPath, QuestionsFile);
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

        private void PictureBoxOpenedEye_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxOpenedEye.Visible = false;
            pictureBoxClosedEye.Visible = true;
        }

        private void PictureBoxClosedEye_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxOpenedEye.Visible = true;
            pictureBoxClosedEye.Visible = false;
        }

        private void TextBoxCompanyBranch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                e.SuppressKeyPress = true; // Предотвращение удаления текста
            }
        }

        private void TextBoxCompanyBranch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // Блокировать ввод с клавиатуры
        }
    }
}
