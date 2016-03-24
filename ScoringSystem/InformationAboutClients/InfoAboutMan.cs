using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ScoringSystem.InformationAboutClients {
    public partial class InfoAboutMan :Form {
        public InfoAboutMan() {
            InitializeComponent();
        }

        private void InfoAboutMan_Load(object sender, EventArgs e) {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Разработал: Симаков Игорь\nГруппа: ИУ5-83");
        }

        private void searchButton_Click(object sender, EventArgs e) {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.BankConnectionString;
            try {
                connection.Open();
                resultListBox.Items.Clear();

                string sqlCommand = "select birthDate, sex, education, income, familyIncome, outcome from dbo.Mans " +
                   "where name = '" + searchNameTextBox.Text + "' and surname = '" + searchSurnametextBox.Text + "'";

                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                resultListBox.Items.Add("Личная информация:");

                while (dr.Read()) {
                    resultListBox.Items.Add("Дата рождения: " + dr[0].ToString() + " Пол:" + dr[1].ToString());
                    resultListBox.Items.Add("Образование: " + dr[2].ToString());
                    resultListBox.Items.Add("Доход: " + dr[3].ToString() + " руб." +
                    "Семейные доход: " + dr[4].ToString() + " руб.");
                    resultListBox.Items.Add("Расход: " + dr[4].ToString() + " руб.");
                }

                dr.Close();

                sqlCommand = "select mark.mark, v.price, v.age " + 
                    "from dbo.Vehicle as v " +
                    "JOIN dbo.Marks as mark ON mark.id = v.id_mark " +
                    "JOIN dbo.Mans as man  ON v.id_man = man.id  where name ='" + 
                    searchNameTextBox.Text + "' and surname = '" + searchSurnametextBox.Text + "'";

                cmd = new SqlCommand(sqlCommand, connection);
                dr = cmd.ExecuteReader();

                resultListBox.Items.Add("");
                resultListBox.Items.Add("Транспортные средства:");

                while (dr.Read()) {
                    resultListBox.Items.Add("Марка: " + dr[0].ToString() + " Цена:" + dr[1].ToString() + " руб.");
                    resultListBox.Items.Add("Возраст: " + dr[2].ToString());
                }

                dr.Close();

                sqlCommand = "select r.type, c.city, r.price, r.square from dbo.RealEstate as r " +
                "JOIN dbo.Cities as c ON c.id = r.location " +
                "JOIN dbo.Mans as man ON r.id_man = man.id where man.name = '" +
                searchNameTextBox.Text + "' and surname = '" + searchSurnametextBox.Text + "'";

                cmd = new SqlCommand(sqlCommand, connection);
                dr = cmd.ExecuteReader();

                resultListBox.Items.Add("");
                resultListBox.Items.Add("Недвижимость:");

                while (dr.Read()) {
                    resultListBox.Items.Add("Тип: " + dr[0].ToString() + " Расположение: " + dr[1].ToString());
                    resultListBox.Items.Add("Цена: " + dr[2].ToString() + " руб. Площадь: " + dr[3].ToString() + " м. кв.");
                }
                dr.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Source + ex.Message);
            } finally {
                connection.Close();
            }
        }
    }
}
