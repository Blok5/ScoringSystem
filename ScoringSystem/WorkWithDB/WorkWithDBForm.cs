using System;
using System.Windows.Forms;

namespace ScoringSystem.WorkWithDB {
    /// <summary>
    /// Форма, включающас формы для работы с базой данных
    /// </summary>
    public partial class WorkWithDBForm :Form {
        public WorkWithDBForm() {
            InitializeComponent();
        }

        private void addManForm_Click(object sender, EventArgs e) {
            this.Hide();
            AddManForm amf = new AddManForm();
            amf.Show();
        }

        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }
    }
}
