using BusinessTraining.Configuration.Logic;
using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace BusinessTraining.Configuration
{
    public partial class ConfigurationForm : Form
    {
        private System.Configuration.Configuration config;
        private const string PseudoPassword = "●●●●●●●";
        private bool IsResetted = false;

        public ConfigurationForm()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxVerifyPassword.UseSystemPasswordChar = true;
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            if (SettingsHelper.GetSettingFirstLaunch() == false)
            {
                labelConfiguration.Text = "Конфигурация выбрана";
                if (!File.Exists(SettingsHelper.GetSettingConfigFilePath()))
                {
                    SettingsHelper.SaveSettingConfigFilePath(String.Empty);
                    SettingsHelper.SaveSettingFirstLaunch(true);
                    ConfigurationForm_Load(sender, e);
                    return;
                }

                AddHelpOnLabelConfiguration(true);
                config = ConfigurationManager.OpenExeConfiguration(SettingsHelper.GetSettingConfigFilePath());
                if (config.HasFile == false)
                {
                    SettingsHelper.SaveSettingFirstLaunch(true);
                    ConfigurationForm_Load(sender, e);
                    return;
                }
                FillFields();
            }
            else
            {
                AddHelpOnLabelConfiguration(false);
                buttonBuildConfig.Enabled = false;
                labelConfiguration.Text = "Конфигурация не выбрана";
            }
        }

        private void ButtonChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Multiselect = false,
                Title = "Выберите программу, конфигурацию которой хотите изменить",
                Filter = "Программа (*.exe)|*.exe"
            };

            if (DialogResult.OK != fileDialog.ShowDialog())
                return;

            if (fileDialog.FileName.EndsWith("BusinessTraining.exe"))
            {
                SettingsHelper.SaveSettingConfigFilePath(fileDialog.FileName);
                labelConfiguration.Text = "Конфигурация выбрана";
                buttonBuildConfig.Enabled = true;
            }
            else
            {
                MessageBox.Show(this, "Выберите файл BusinessTraining.exe", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            config = ConfigurationManager.OpenExeConfiguration(SettingsHelper.GetSettingConfigFilePath());
            if (config.HasFile == false)
            {
                MessageBox.Show(this, "У приложения отсутвует конфигурация.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FillFields();
            AddHelpOnLabelConfiguration(true);
            SettingsHelper.SaveSettingFirstLaunch(false);
        }

        private void ButtonBuildConfig_Click(object sender, EventArgs e)
        {
            if (FieldsAreNotFine())
                return;

            CheckStatus passwordStatus = ValidationHelper.CheckPassword(textBoxPassword.Text, PseudoPassword);
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

            if (textBoxPassword.Text != textBoxVerifyPassword.Text)
            {
                MessageBox.Show(this, "Пароли должны совпадать.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string CompanyBranch = textBoxCompanyBranch.Text;
            string BotToken = CryptoHelper.Encrypt(textBoxBotToken.Text);
            string ChatId = CryptoHelper.Encrypt(textBoxChatId.Text);
            config.SetSettingValue("CompanyBranch", CompanyBranch);
            config.SetSettingValue("BotToken", BotToken);
            config.SetSettingValue("ChatId", ChatId);

            if(textBoxPassword.Text != PseudoPassword)
            {
                string Password = CryptoHelper.GetPasswordHash(textBoxPassword.Text);
                config.SetSettingValue("PasswordHash", Password);
            }

            // Сохраняем изменения в конфигурационном файле
            config.Save(ConfigurationSaveMode.Modified);

            // Перезагружаем конфигурацию приложения
            ConfigurationManager.RefreshSection("applicationSettings");
            MessageBox.Show(this, "Конфигурация приложения была успешно создана.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FillFields()
        {
            textBoxCompanyBranch.Text = config.GetSettingValue("CompanyBranch");
            textBoxBotToken.Text = CryptoHelper.Decrypt(config.GetSettingValue("BotToken"));
            textBoxChatId.Text = CryptoHelper.Decrypt(config.GetSettingValue("ChatId"));
            if (String.IsNullOrWhiteSpace(textBoxCompanyBranch.Text) || String.IsNullOrWhiteSpace(textBoxBotToken.Text)|| String.IsNullOrWhiteSpace(textBoxChatId.Text))
            {
                textBoxPassword.Text = String.Empty;
                textBoxVerifyPassword.Text = String.Empty;
            }
            else
            {
                textBoxPassword.Text = PseudoPassword;
                textBoxVerifyPassword.Text = PseudoPassword;
                pictureBoxClosedEye.Visible = false;
                pictureBoxOpenedEye.Visible = false;
            }
        }

        private void AddHelpOnLabelConfiguration(bool configChoosen)
        {
            ToolTip toolTip = new ToolTip();
            if (configChoosen)
                toolTip.SetToolTip(labelConfiguration, SettingsHelper.GetSettingConfigFilePath() + ".config");
            else
                toolTip.SetToolTip(labelConfiguration, "Выберите конфигурацию");
        }

        private void PictureBoxClosedEye_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxOpenedEye.Visible = true;
            pictureBoxClosedEye.Visible = false;
        }

        private void PictureBoxOpenedEye_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxOpenedEye.Visible = false;
            pictureBoxClosedEye.Visible = true;
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            pictureBoxClosedEye.Visible = true;
            pictureBoxOpenedEye.Visible = true;
            if (textBoxPassword.Text != PseudoPassword && !IsResetted)
            {
                textBoxPassword.Text = string.Empty;
                textBoxVerifyPassword.Text = string.Empty;
                IsResetted = true;
            }
        }
    }
}
