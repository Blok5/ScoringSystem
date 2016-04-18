using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ScoringSystem.WorkWithLoan {
    public partial class GetALoanForm :Form {

        public GetALoanForm() {
            InitializeComponent();
        }

        private void GetALoanForm_Load(object sender, EventArgs e) {

        }
        /// <summary>
        /// событие searchButton_Click выводит данные поиска в ListBox и 
        /// заносит найденные данные в класс current Data для дальнейшего использования
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e) {
            CurrentClientData.cleanData();
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.BankConnectionString;
            try {
                connection.Open();
                resultListBox.Items.Clear();

                string sqlCommand = "select birthDate, sex, education, income, familyIncome, outcome, personalStatus, " +
                    " creditHistory, foreignWorker, name, surname from dbo.Mans " +
                   "where name = '" + searchNameTextBox.Text + "' and surname = '" + searchSurnametextBox.Text + "'";

                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows) {

                    resultListBox.Items.Add("Личная информация:");

                    while (dr.Read()) {

                        CurrentClientData.birthDate = dr[0].ToString();
                        CurrentClientData.sex = dr[1].ToString();
                        CurrentClientData.education = dr[2].ToString();
                        CurrentClientData.income = Convert.ToInt32(dr[3]);
                        CurrentClientData.familyIncome = Convert.ToInt32(dr[4]);
                        CurrentClientData.outcome = Convert.ToInt32(dr[5]);
                        CurrentClientData.personalStatus = dr[6].ToString();
                        CurrentClientData.creditHistory = dr[7].ToString();
                        CurrentClientData.foreignWorker = Convert.ToBoolean(dr[8]);
                        CurrentClientData.name = dr[9].ToString();
                        CurrentClientData.surname = dr[10].ToString();

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

                    sqlCommand = "select x.co, v.id_mark, v.productionDate, v.id_man, v.price, v.number " +
                        "from dbo.Vehicle as v, " +
                        "(select count(*) as co from dbo.Vehicle " +
                        "GROUP BY id_man) as x JOIN dbo.Mans as man ON man.name = '" +
                        searchNameTextBox.Text + "' and man.surname = '" + searchSurnametextBox.Text + "'";

                    cmd = new SqlCommand(sqlCommand, connection);
                    dr = cmd.ExecuteReader();

                    resultListBox.Items.Add("");
                    resultListBox.Items.Add("Транспортные средства:");

                    bool checkCreate = false;
                    int i = 0;

                    while (dr.Read()) {

                        if (checkCreate == false) {
                            CurrentClientData.vehicles = new VehicleData[Convert.ToInt32(Convert.ToInt32(dr[0]))];
                            checkCreate = true;
                        }

                        CurrentClientData.vehicles[i] = new VehicleData();
                        CurrentClientData.vehicles[i].id_mark = Convert.ToInt32(dr[1]);
                        CurrentClientData.vehicles[i].price = Convert.ToDecimal(dr[4]);
                        CurrentClientData.vehicles[i].productionDate = dr[2].ToString();
                        CurrentClientData.vehicles[i].number = dr[5].ToString();

                        resultListBox.Items.Add("Марка: " + dr[1].ToString() + " Цена:" + dr[4].ToString() + " руб.");
                        resultListBox.Items.Add("Возраст: " + dr[2].ToString());
                        ++i;
                    }

                    dr.Close();

                    sqlCommand = "select r.type, r.location, r.price, r.square, r.location, x.co, r.dateBuy from dbo.RealEstate as r, " +
                    "(select count(*) as co from dbo.RealEstate " +
                    "GROUP BY id_man) as x JOIN dbo.Mans as man ON man.name = '" +
                    searchNameTextBox.Text + "' and man.surname = '" + searchSurnametextBox.Text + "'";

                    cmd = new SqlCommand(sqlCommand, connection);
                    dr = cmd.ExecuteReader();

                    resultListBox.Items.Add("");
                    resultListBox.Items.Add("Недвижимость:");

                    i = 0;
                    checkCreate = false;
                    while (dr.Read()) {
                        if (checkCreate == false) {
                            CurrentClientData.realEstates = new RealEstateData[Convert.ToInt32(dr[5])];
                            checkCreate = true;
                        }
                        CurrentClientData.realEstates[i] = new RealEstateData();
                        CurrentClientData.realEstates[i].type = dr[0].ToString();
                        CurrentClientData.realEstates[i].location = Convert.ToInt32(dr[4]);
                        CurrentClientData.realEstates[i].price = Convert.ToDecimal(dr[2]);
                        CurrentClientData.realEstates[i].square = Convert.ToInt32(dr[3]);
                        CurrentClientData.realEstates[i].dateBuy = dr[6].ToString();

                        resultListBox.Items.Add("Тип: " + dr[0].ToString() + " Расположение: " + dr[1].ToString());
                        resultListBox.Items.Add("Цена: " + dr[2].ToString() + " руб. Площадь: " + dr[3].ToString() + " м. кв.");
                        ++i;
                    }
                    dr.Close();

                    sqlCommand = "select c.phone, c.mail, x.co from dbo.Contacts as c, " +
                    "(select count(*) as co from dbo.Contacts " +
                    "GROUP BY id_man) as x JOIN dbo.Mans as man ON man.name = '" +
                    searchNameTextBox.Text + "' and man.surname = '" + searchSurnametextBox.Text + "'";

                    cmd = new SqlCommand(sqlCommand, connection);
                    dr = cmd.ExecuteReader();

                    resultListBox.Items.Add("");
                    resultListBox.Items.Add("Контактные данные: ");

                    i = 0;
                    checkCreate = false;

                    while (dr.Read()) {
                        if (checkCreate == false) {
                            CurrentClientData.contacts = new ContactData[Convert.ToInt32(dr[2])];
                            checkCreate = true;
                        }
                        CurrentClientData.contacts[i] = new ContactData();
                        CurrentClientData.contacts[i].phone = dr[0].ToString();
                        CurrentClientData.contacts[i].mail = dr[1].ToString();

                        resultListBox.Items.Add("Телефон: " + dr[0].ToString() + " Электронная почта: " + dr[1].ToString());
                        ++i;
                    }
                    dr.Close();

                    sqlCommand = "select w.name, w.position, w.workDuration from dbo.Work as w " +
                        "JOIN dbo.Mans as man ON man.name = '" +
                        searchNameTextBox.Text + "' and man.surname = '" + searchSurnametextBox.Text + "'";

                    cmd = new SqlCommand(sqlCommand, connection);
                    dr = cmd.ExecuteReader();

                    resultListBox.Items.Add("");
                    resultListBox.Items.Add("Информация о работе: ");

                    i = 0;
                    while (dr.Read()) {
                        CurrentClientData.work = new WorkData();
                        CurrentClientData.work.name = dr[0].ToString();
                        CurrentClientData.work.position = dr[1].ToString();
                        CurrentClientData.work.workDuration = Convert.ToInt32(dr[2]);

                        resultListBox.Items.Add("Телефон: " + dr[0].ToString() + " Электронная почта: " + dr[1].ToString());
                        resultListBox.Items.Add("Продолжительность работы: " + dr[2].ToString() + " мес.");
                        ++i;
                    }

                    dr.Close();

                    sqlCommand = "select c.checkingAccount, c.entryDate from dbo.Clients as c " +
                        "JOIN dbo.Mans as man ON man.name = '" +
                        searchNameTextBox.Text + "' and man.surname = '" + searchSurnametextBox.Text + "'";

                    cmd = new SqlCommand(sqlCommand, connection);
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows) {
                        resultListBox.Items.Add("");
                        resultListBox.Items.Add("Информация о клиенте: ");
                        while (dr.Read()) {

                            CurrentClientData.checkingAccount = Convert.ToDecimal(dr[0]);

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

        private void nextButton_Click(object sender, EventArgs e) {
            this.Hide();
            EnterEdditionalInformationForm eeif = new EnterEdditionalInformationForm();
            eeif.Show();
        }
    }
}
