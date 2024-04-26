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
            if (SettingsHelper.GetFirstLaunchSetting())
            {
                checkBoxIsUserManager.Checked = true;
                checkBoxIsUserManager.Visible = false;
            }
            else
            {
                labelFirstLaunch.Visible = false;
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text) || String.IsNullOrEmpty(textBoxSurname.Text) || String.IsNullOrEmpty(comboBoxCompanyBranch.Text))
            {
                MessageBox.Show("Введите имя, фамилию и выберите филиал.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkBoxIsUserManager.Checked)
            {
                if (String.IsNullOrEmpty(textBoxPassword.Text))
                {
                    MessageBox.Show("Введите пароль.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (SettingsHelper.GetFirstLaunchSetting())
                {
                    int passwordHashCode = textBoxPassword.Text.GetHashCode(); // Получаем хэш-код пароля
                    //using (StreamWriter writer = new StreamWriter(Path.Combine(Application.LocalUserAppDataPath, Properties.Settings.Default.LaunchFile)))
                    //{
                    //    writer.WriteLine(passwordHashCode); // Записываем хэш-код пароля в файл
                    //}
                    SettingsHelper.SaveFirstLaunchSetting();
                }
                else
                {
            //        using (StreamReader reader = new StreamReader(Path.Combine(Application.LocalUserAppDataPath, Properties.Settings.Default.LaunchFile)))
            //        {
            //            string line = reader.ReadLine(); // Читаем хеш-код из файла
            //            if (line != null)
            //            {
            //                int savedHashCode;
            //                if (int.TryParse(line, out savedHashCode)) // Пытаемся преобразовать считанный хеш-код из строки в целое число
            //                {
            //                    if (savedHashCode == textBoxPassword.Text.GetHashCode()) // Сравниваем считанный хеш-код с введенным
            //                    {
            //                        MessageBox.Show("Вы вошли как менеджер филиала.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                    }
            //                    else
            //                    {
            //                        MessageBox.Show("Пароли не совпадают.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                        return;
            //                    }
            //                }
            //            }
            //        }
                }
            }
            MainForm main = new MainForm();
            Hide();
            main.FormClosed += Main_FormClosed;
            main.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
