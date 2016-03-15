using System;
using System.Windows.Forms;

namespace ScoringSystem.WorkWithDB {
    public partial class addManForm :Form {

        public addManForm() {
            InitializeComponent();
        }

        private void addManForm_Load(object sender, EventArgs e) {
            
            this.streetsTableAdapter.Fill(this.bankDataSet.Streets);
           
            this.citiesTableAdapter.Fill(this.bankDataSet.Cities);

        }

        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
            WorkWithDBForm wwdb = new WorkWithDBForm();
            wwdb.Show();
        }

        private void nextButton_Click_1(object sender, EventArgs e) {
            //using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.BankConnectionString)) 
            //{
            //    using (SqlCommand command = new SqlCommand()) {
                    //command.Connection = connection;
                    //command.CommandType = CommandType.Text;
                    //command.CommandText = "insert into Mans (name, surname, birthDate, " +
                    //    "id_birthPlace, sex, education, id_city, id_street, home, housing) VALUES " +
                    //    "(@name, @surname, @birthDate, @id_birthPlace, @sex, @education, " +
                    //    "@id_city, @id_street, @home, @housing)";

            
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

                if (housingTextBox.Text == "") {
                    CurrentData.housing = 0;
                } else {
                    CurrentData.housing = Convert.ToInt32(housingTextBox.Text);
                }

                addVehicleForm avf = new addVehicleForm();
                this.Hide();
                avf.Show();

            } catch (Exception ex) {

                MessageBox.Show(ex.Message + ex.Source);
                
            }



            //command.Parameters.AddWithValue("@name", nameTextBox.Text);
            //command.Parameters.AddWithValue("@surname", surnameTextBox.Text);
            //command.Parameters.AddWithValue("@birthDate", birthDateTimePicker.Text);
            //command.Parameters.AddWithValue("@id_birthPlace", birthPlaceComboBox.SelectedValue);
            //command.Parameters.AddWithValue("@sex", sexComboBox.Text);
            //command.Parameters.AddWithValue("@education", educationComboBox.Text);
            //command.Parameters.AddWithValue("@id_city", cityComboBox.SelectedValue);
            //command.Parameters.AddWithValue("@id_street", streetComboBox.SelectedValue);
            //command.Parameters.AddWithValue("@home", homeTextBox.Text);
            //command.Parameters.AddWithValue("@housing", housingTextBox.Text);                   

            //try {
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //    informationLabel.Text = "Данные успешно добавлены";
            //} catch (Exception ex) {
            //    MessageBox.Show(string.Format("Ошибка в Базе Данных"));
            //    MessageBox.Show(ex.Message);
            //} finally {
            //    connection.Close();
            //}

            // }
            // }
        }
    }
}
