using System;
using System.Windows.Forms;

namespace ScoringSystem.WorkWithDB {
    /// <summary>
    /// Класс AddWorkForm открывает форму для добавления информации о работе,
    /// на которой работает клиент
    /// </summary>
    public partial class AddWorkForm :Form {
        public AddWorkForm() {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
            AddRealEstateForm aref = new AddRealEstateForm();
            aref.Show();
        }

        /// <summary>
        /// Метод nextButton_Click пытается добавить инф-ю о работе клиенту.
        /// При успехе открывает AddRelationsForm форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e) {
            try {
                CurrentClientData.addWork(nameTextBox.Text, positionComboBox.Text, 
                    Convert.ToInt32(workDurationComboBox));

                AddRelationsForm arf = new AddRelationsForm();
                this.Hide();
                arf.Show();

            } catch (Exception ex) {

                MessageBox.Show(ex.Message + ex.Source);
            }
        }
    }
}
