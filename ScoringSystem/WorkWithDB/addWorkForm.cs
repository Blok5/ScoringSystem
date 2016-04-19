using System;
using System.Windows.Forms;

namespace ScoringSystem.WorkWithDB {
    /// <summary>
    /// AddWorkForm - form for add work information in client data
    /// </summary>
    public partial class AddWorkForm :Form {
        /// <summary>
        /// Class constructor
        /// </summary>
        public AddWorkForm() {
            InitializeComponent();

        }

        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
            AddRealEstateForm aref = new AddRealEstateForm();
            aref.Show();
        }

        private void nextButton_Click(object sender, EventArgs e) {
            try {
                CurrentClientData.addWork(nameTextBox.Text, positionComboBox.Text, 
                    Convert.ToInt32(workDurationTextBox.Text));

                AddRelationsForm arf = new AddRelationsForm();
                this.Hide();
                arf.Show();

            } catch (Exception ex) {

                MessageBox.Show(ex.Message + ex.Source);
            }
        }

        private void workDurationTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            string errorMsg;

            if (!Validation.isNumberValue(workDurationTextBox.Text, out errorMsg)) {
                e.Cancel = true;
                workDurationTextBox.Select(0, Text.Length);

                this.errorProvider1.SetError(workDurationTextBox, errorMsg);
            }
        }

    }
}
