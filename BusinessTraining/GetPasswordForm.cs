using System;
using System.Windows.Forms;

namespace BusinessTraining
{
    public partial class GetPasswordForm : Form
    {
        public GetPasswordForm()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void ButtonVerifyPassword_Click(object sender, EventArgs e)
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
    }
}
