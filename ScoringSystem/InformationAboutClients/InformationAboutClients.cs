using System;
using System.Windows.Forms;

namespace ScoringSystem.InformationAboutClients {

    /// <summary>
    /// Форма, которая открывает другие формы для вывода всякой информации о 
    /// клиенте и тд
    /// </summary>
    public partial class InformationAboutClients :Form {
        public InformationAboutClients() {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Разработал: Симаков Игорь\nГруппа: ИУ5-83");
        }

        private void openInfoAboutManFormButton_Click(object sender, EventArgs e) {
            InfoAboutMan iam = new InfoAboutMan();
            this.Hide();
            iam.Show();
        }

        private void infoAboutCreditButton_Click(object sender, EventArgs e) {
            this.Hide();
            InfoAboutCreditForm iacf = new InfoAboutCreditForm();
            iacf.Show();
        }
    }
}
