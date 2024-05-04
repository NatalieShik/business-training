using System;
using System.Windows.Forms;

namespace BusinessTraining
{
    public partial class GetPasswordForm : Form
    {
        public GetPasswordForm()
        {
            InitializeComponent();
        }

        private void buttonVerifyPassword_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxPassword.Text))
                return;

            if (!BCrypt.Net.BCrypt.Verify(textBoxPassword.Text, SettingsHelper.GetSettingPasswordHash()))
            {
                MessageBox.Show("Неверный пароль.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
