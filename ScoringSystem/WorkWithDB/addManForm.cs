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


        }

        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
            WorkWithDBForm wwdb = new WorkWithDBForm();
            wwdb.Show();
        }

        private void nextButton_Click_1(object sender, EventArgs e) {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.BankConnectionString;

            try {
                connection.Open();
            } catch {
                MessageBox.Show(string.Format("Ошибка в Базе Данных"));
            } finally {
                connection.Close();
            }
            birthDateTimePicker.CustomFormat = "yyyy-MM-dd";
            birthDateTimePicker.Format = DateTimePickerFormat.Custom;

            using (SqlCommand command = new SqlCommand()) {
                //command.CommandType = CommandType.Text;
                //command.CommandText = "insert into Mans (name, surname, birthDate, birthPlace";
            }
        }
    }
}
