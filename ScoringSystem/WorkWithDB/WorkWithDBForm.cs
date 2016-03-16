using System;
using System.Windows.Forms;

namespace ScoringSystem.WorkWithDB {
    public partial class WorkWithDBForm :Form {
        public WorkWithDBForm() {
            InitializeComponent();
        }

        private void addManForm_Click(object sender, EventArgs e) {
            this.Hide();
            AddManForm amf = new AddManForm();
            amf.Show();
        }
    }
}
