using System;
using System.Data.SqlClient;
using System.Windows.Forms;

// TODO: Добавить вывод всех родственных связей этого человекаы

namespace ScoringSystem.InformationAboutClients {

    /// <summary>
    /// Форма для вывода всей информации о человеке
    /// </summary>
    public partial class InfoAboutMan :Form {
        /// <summary>
        /// Class constructor
        /// </summary>
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

        /// <summary>
        /// Событие, при срабатывании которое выводит всю информацию в listBox 
        /// о человеке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e) {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.BankConnectionString;
            try {
                connection.Open();
                resultListBox.Items.Clear();

                string sqlCommand = "select birthDate, sex, education, income, familyIncome, outcome, personalStatus, " +
                    " creditHistory, foreignWorker, name, surname, id from dbo.Mans " +
                   "where name = '" + searchNameTextBox.Text + "' and surname = '" + searchSurnametextBox.Text + "'";

                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows) {

                    resultListBox.Items.Add("Личная информация:");

                    while (dr.Read()) {
                        resultListBox.Items.Add("Имя: " + dr[9].ToString() + " Фамилия: " + dr[10].ToString());
                        resultListBox.Items.Add(" Дата рождения: " + dr[0].ToString() + " Пол:" + dr[1].ToString());
                        resultListBox.Items.Add("Образование: " + dr[2].ToString());
                        resultListBox.Items.Add("Доход: " + dr[3].ToString() + " руб." +
                        "Семейные доход: " + dr[4].ToString() + " руб.");
                        resultListBox.Items.Add("Расход: " + dr[5].ToString() + " руб.");
                        resultListBox.Items.Add("Семейное положение: " + dr[6].ToString());
                        resultListBox.Items.Add("Кредитная история: " + dr[7].ToString());
                        resultListBox.Items.Add("Иностранный работник: " + dr[8]);
                    }

                    dr.Close();

                    sqlCommand = "SELECT inner_veh.col, v.number, v.price, v.productionDate, v.id_mark FROM dbo.Vehicle as v " +
                    "JOIN (SELECT id_man as id_m, COUNT(*) as col FROM dbo.Vehicle GROUP BY id_man) as inner_veh " +
                    "ON v.id_man=inner_veh.id_m  " +
                    "JOIN dbo.Mans as man ON id_m = man.id WHERE man.name = '" +
                    searchNameTextBox.Text + "' and man.surname = '" + searchSurnametextBox.Text + "'";

                    cmd = new SqlCommand(sqlCommand, connection);
                    dr = cmd.ExecuteReader();

                    resultListBox.Items.Add("");
                    resultListBox.Items.Add("Транспортные средства:");

                    while (dr.Read()) {
                        resultListBox.Items.Add("Марка: " + dr[4].ToString() + " Цена:" + dr[2].ToString() + " руб.");
                        resultListBox.Items.Add("Возраст: " + dr[3].ToString());
                    }

                    dr.Close();

                    sqlCommand = "SELECT inner_real.col, r.dateBuy, r.location,r.price, r.square, r.type FROM dbo.RealEstate as r " +
                    "JOIN (SELECT id_man as id_m, COUNT(*) as col FROM dbo.RealEstate GROUP BY id_man) as inner_real " +
                    "ON r.id_man=inner_real.id_m " +
                    "JOIN dbo.Mans as man ON id_m = man.id WHERE man.name = '" +
                    searchNameTextBox.Text + "' and man.surname = '" + searchSurnametextBox.Text + "'";

                    cmd = new SqlCommand(sqlCommand, connection);
                    dr = cmd.ExecuteReader();

                    resultListBox.Items.Add("");
                    resultListBox.Items.Add("Недвижимость:");

                    while (dr.Read()) {
                        resultListBox.Items.Add("Тип: " + dr[5].ToString() + " Расположение: " + dr[2].ToString());
                        resultListBox.Items.Add("Цена: " + dr[3].ToString() + " руб. Площадь: " + dr[4].ToString() + " м. кв.");
                        resultListBox.Items.Add("Дата покупки: " + dr[1].ToString());
                    }
                    dr.Close();

                    sqlCommand = "SELECT inner_cont.col, c.phone, c.mail FROM dbo.Contacts as c " +
                    "JOIN (SELECT id_man as id_m, COUNT(*) as col FROM dbo.Contacts GROUP BY id_man) as inner_cont " +
                    "ON c.id_man=inner_cont.id_m " +
                    "JOIN dbo.Mans as man ON id_m = man.id WHERE man.name = '" +
                    searchNameTextBox.Text + "' and man.surname = '" + searchSurnametextBox.Text + "'";

                    cmd = new SqlCommand(sqlCommand, connection);
                    dr = cmd.ExecuteReader();

                    resultListBox.Items.Add("");
                    resultListBox.Items.Add("Контактные данные: ");

                    while (dr.Read()) {
                        resultListBox.Items.Add("Телефон: " + dr[1].ToString() + " Электронная почта: " + dr[2].ToString());
                    }
                    dr.Close();

                    sqlCommand = "select w.name, w.position, w.workDuration from dbo.Work as w " +
                        "JOIN dbo.Mans as man ON man.id = w.id WHERE man.name = '" +
                        searchNameTextBox.Text + "' and man.surname = '" + searchSurnametextBox.Text + "'";

                    cmd = new SqlCommand(sqlCommand, connection);
                    dr = cmd.ExecuteReader();

                    resultListBox.Items.Add("");
                    resultListBox.Items.Add("Информация о работе: ");

                    while (dr.Read()) {
                        resultListBox.Items.Add("Название организации: " + dr[0].ToString() + " Должность: " + dr[1].ToString());
                        resultListBox.Items.Add("Продолжительность работы: " + dr[2].ToString() + " мес.");
                    }

                    dr.Close();

                    sqlCommand = "select c.checkingAccount, c.entryDate from dbo.Clients as c " +
                        "JOIN dbo.Mans as man ON man.id = c.id WHERE man.name = '" +
                        searchNameTextBox.Text + "' and man.surname = '" + searchSurnametextBox.Text + "'";

                    cmd = new SqlCommand(sqlCommand, connection);
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows) {
                        resultListBox.Items.Add("");
                        resultListBox.Items.Add("Информация о клиенте: ");
                        while (dr.Read()) {
                            resultListBox.Items.Add("Состояние счета: " + dr[0].ToString());

                        }

                        dr.Close();
                    } else {
                        resultListBox.Items.Add("");
                        resultListBox.Items.Add("Не является клиентом банка!");
                    }
                } else {
                    resultListBox.Items.Add("Клиент не найден");
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.Source + ex.Message);
            } finally {

                connection.Close();
            }
        }


        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
            InformationAboutClients iac = new InformationAboutClients();
            iac.Show();
        }
    }
}
