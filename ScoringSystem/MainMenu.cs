using System;
using System.Windows.Forms;

namespace ScoringSystem {
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
            helloLabel.Text = "Здравствуйте " + currentClient.role + "!";
        }
    }
}
