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
            labelCompanyBranch.Text = "Адрес!!"; // TODO: прописать текст какой филиал
            if (String.IsNullOrEmpty(SettingsHelper.GetSettingCompanyBranch()))
            {
                MessageBox.Show("Отсутвуют настройки конфигурации.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxSurname.Text))
            {
                MessageBox.Show("Введите имя фамилию.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
            MainForm main = new MainForm();
            Hide();
            main.FormClosed += Main_FormClosed;
            main.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            SettingsHelper.SaveSettingIsManager(false);
            Close();
        }
    }
}
