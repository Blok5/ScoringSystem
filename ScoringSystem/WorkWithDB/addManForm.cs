using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoringSystem.WorkWithDB {
    public partial class addManForm :Form {
        public addManForm() {
            InitializeComponent();
        }

        private void addManForm_Load(object sender, EventArgs e) {
            birthDateTimePicker.CustomFormat = "yyyy-MM-dd";
            birthDateTimePicker.Format = DateTimePickerFormat.Custom;
        }

        private void exitButton_Click(object sender, EventArgs e) {
            this.Hide();
            WorkWithDBForm wwdb = new WorkWithDBForm();
            wwdb.Show();
        }
    }
}
