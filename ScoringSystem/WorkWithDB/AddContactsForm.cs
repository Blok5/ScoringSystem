using System;
using System.Windows.Forms;

namespace ScoringSystem.WorkWithDB {
    public partial class AddContactsForm :Form {
        public AddContactsForm() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Hide();
            AddManForm amf = new AddManForm();
            amf.Show();
        }

        private void nextButton_Click(object sender, EventArgs e) {

            try {
                ContactData[] cd = new ContactData[1];
                cd[0] = new ContactData();
                cd[0].phone = phoneTextBox.Text;
                cd[0].mail = mailTextBox.Text;

                CurrentClientData.addContact(cd);

                AddVehicleForm avf = new AddVehicleForm();
                this.Hide();
                avf.Show();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message + " " + ex.Source);             
            }

        }

        private void phoneTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            string errorMsg;

            if (!Validation.isPhoneNumber(phoneTextBox.Text, out errorMsg)) {
                e.Cancel = true;
                phoneTextBox.Select(0, Text.Length);

                errorProvider1.SetError(phoneTextBox, errorMsg);
            }
        }
    }
}
