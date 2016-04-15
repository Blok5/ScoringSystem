using System;
using System.Windows.Forms;

namespace ScoringSystem.WorkWithDB {
    /// <summary>
    /// Класс AddManForm открывает форму для добавления нового клиента
    /// </summary>
    public partial class AddManForm :Form {

        public AddManForm() {
            InitializeComponent();
            this.sexComboBox.SelectedIndexChanged += new System.EventHandler(this.sexComboBox_SelectedIndexChanged);

            this.homeTextBox.Text = Convert.ToString(0);
            this.housingTextBox.Text = Convert.ToString(0);
            this.incomeTextBox.Text = Convert.ToString(0);
            this.familyIncomeTextBox.Text = Convert.ToString(0);
            this.outcomeTextBox.Text = Convert.ToString(0);
        }

        private void addManForm_Load(object sender, EventArgs e) {
            this.streetsTableAdapter.Fill(this.bankDataSet.Streets);           
            this.citiesTableAdapter.Fill(this.bankDataSet.Cities);

        }

        private void sexComboBox_SelectedIndexChanged(object sender, EventArgs e) {
                personalStatusComboBox.Items.Clear();
            if (sexComboBox.SelectedIndex == 0) {               
                personalStatusComboBox.Items.Add("Разведен/Живем раздельно");
                personalStatusComboBox.Items.Add("Один");
                personalStatusComboBox.Items.Add("Женат/Вдовец");
            } else {
                personalStatusComboBox.Items.Add("Разведена/Живем раздельно/Замужем");
                personalStatusComboBox.Items.Add("Одинока");
            }
        }

        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
            WorkWithDBForm wwdb = new WorkWithDBForm();
            wwdb.Show();
        }
        
        private void nextButton_Click_1(object sender, EventArgs e) {
            
            try {
                birthDateTimePicker.CustomFormat = "yyyy-MM-dd";
                birthDateTimePicker.Format = DateTimePickerFormat.Custom;

                CurrentData.name = nameTextBox.Text;
                CurrentData.surname = surnameTextBox.Text;
                CurrentData.id_birthPlace = birthPlaceComboBox.SelectedIndex;
                CurrentData.id_city = cityComboBox.SelectedIndex;
                CurrentData.id_street = streetComboBox.SelectedIndex;
                CurrentData.home = Convert.ToInt32(homeTextBox.Text);
                CurrentData.education = educationComboBox.Text;
                CurrentData.birthDate = birthDateTimePicker.Text;
                CurrentData.sex = sexComboBox.Text;
                CurrentData.income = Convert.ToDecimal(incomeTextBox.Text);
                CurrentData.familyIncome = Convert.ToDecimal(familyIncomeTextBox.Text);
                CurrentData.outcome = Convert.ToDecimal(outcomeTextBox.Text);
                CurrentData.personalStatus = personalStatusComboBox.Text;
                CurrentData.creditHistory = creditHistoryComboBox.Text;

                if (housingTextBox.Text == "") {
                    CurrentData.housing = 0;
                } else {
                    CurrentData.housing = Convert.ToInt32(housingTextBox.Text);
                }

                AddContactsForm acf = new AddContactsForm();
                this.Hide();
                acf.Show();

            } catch (Exception ex) {

                MessageBox.Show(ex.Message + ex.Source);
                
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Разработал: Симаков Игорь\nГруппа: ИУ5-83");
        }

    }
}
