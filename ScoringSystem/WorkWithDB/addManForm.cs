using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ScoringSystem.WorkWithDB {
    public partial class addManForm :Form {

        public addManForm() {
            InitializeComponent();
        }

        private void addManForm_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet.Streets". При необходимости она может быть перемещена или удалена.
            this.streetsTableAdapter.Fill(this.bankDataSet.Streets);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet.Cities". При необходимости она может быть перемещена или удалена.
            this.citiesTableAdapter.Fill(this.bankDataSet.Cities);

        }

        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
            WorkWithDBForm wwdb = new WorkWithDBForm();
            wwdb.Show();
        }

        private void nextButton_Click_1(object sender, EventArgs e) {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.BankConnectionString)) 
            {
                using (SqlCommand command = new SqlCommand()) {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "insert into Mans (name, surname, birthDate, " +
                        "id_birthPlace, sex, education, id_city, id_street, home, housing) VALUES " +
                        "(@name, @surname, @birthDate, @id_birthPlace, @sex, @education, " +
                        "@id_city, @id_street, @home, @housing)";

                    birthDateTimePicker.CustomFormat = "yyyy-MM-dd";
                    birthDateTimePicker.Format = DateTimePickerFormat.Custom;

                    command.Parameters.AddWithValue("@name", nameTextBox.Text);
                    command.Parameters.AddWithValue("@surname", surnameTextBox.Text);
                    command.Parameters.AddWithValue("@birthDate", birthDateTimePicker.Text);
                    command.Parameters.AddWithValue("@id_birthPlace", birthPlaceComboBox.SelectedValue);
                    command.Parameters.AddWithValue("@sex", sexComboBox.Text);
                    command.Parameters.AddWithValue("@education", educationComboBox.Text);
                    command.Parameters.AddWithValue("@id_city", cityComboBox.SelectedValue);
                    command.Parameters.AddWithValue("@id_street", streetComboBox.SelectedValue);
                    command.Parameters.AddWithValue("@home", homeTextBox.Text);
                    command.Parameters.AddWithValue("@housing", housingTextBox.Text);                   

                    try {
                        connection.Open();
                        command.ExecuteNonQuery();
                        informationLabel.Text = "Данные успешно добавлены";
                    } catch (Exception ex) {
                        MessageBox.Show(string.Format("Ошибка в Базе Данных"));
                        MessageBox.Show(ex.Message);
                    } finally {
                        connection.Close();
                    }

                }
            }
        }
    }
}
