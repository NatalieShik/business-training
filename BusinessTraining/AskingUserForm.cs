using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BusinessTraining
{
    public partial class AskingUserForm : Form
    {
        public AskingUserForm()
        {
            InitializeComponent();
        }

        private void AskingUserForm_Load(object sender, System.EventArgs e)
        {
            foreach (var item in AppState.Questions)
            {
                if (!comboBoxDirection.Items.Contains(item.Direction))
                    comboBoxDirection.Items.Add(item.Direction);
            }
        }

        private void ComboBoxDirection_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            checkedListBoxSections.Items.Clear();
            foreach (var item in AppState.Questions.Where(x => x.Direction == comboBoxDirection.Text))
                if (!checkedListBoxSections.Items.Contains(item.Section))
                    checkedListBoxSections.Items.Add(item.Section);
        }

        private void ButtonOpen_Click(object sender, System.EventArgs e)
        {
            List<string> checkedSections = new List<string>();
            this.Hide();
            if (checkedListBoxSections.CheckedItems.Count == 0)
            {
                MessageBox.Show(this, "Вы не указали нужные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
                return;
            }

            foreach (var itemChecked in checkedListBoxSections.CheckedItems)
                checkedSections.Add(itemChecked.ToString());

            using (PreparationForm preparation = new PreparationForm(comboBoxDirection.Text, checkedSections))
            {
                preparation.ShowDialog();
            }
            this.Show();
        }

        private void ButtonBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
