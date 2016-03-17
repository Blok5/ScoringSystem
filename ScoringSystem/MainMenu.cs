using System;
using System.Windows.Forms;

namespace ScoringSystem {

    /// <summary>
    /// Класс MainMenu открывает форму с главным меню приложения
    /// </summary>
    public partial class MainMenu :Form {
        public MainMenu() {
            InitializeComponent();
        }

        private void openWorkWithDBForm_Click(object sender, EventArgs e) {
            this.Hide();
            WorkWithDB.WorkWithDBForm workWDB = new WorkWithDB.WorkWithDBForm();
            workWDB.Show();         
        }

        private void MainMenu_Load(object sender, EventArgs e) {
            helloLabel.Text = "Здравствуйте " + СurrentClient.role + "!";
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Разработал: Симаков Игорь\nГруппа: ИУ5-83");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void informationAboutClientButton_Click(object sender, EventArgs e) {
            InformationAboutClients.InformationAboutClients iac = new InformationAboutClients.InformationAboutClients();
            this.Hide();
            iac.Show();
        }
    }
}
