using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoringSystem.InformationAboutClients {
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
    }
}
