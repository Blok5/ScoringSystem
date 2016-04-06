using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ScoringSystem.InformationAboutClients {
    /// <summary>
    /// Форма для вывода информации о кредите 
    /// </summary>
    public partial class InfoAboutCreditForm :Form {
        public InfoAboutCreditForm() {
            InitializeComponent();
        }

        private void InfoAboutCreditForm_Load(object sender, EventArgs e) {

        }

        /// <summary>
        /// Событие, которое при нажатии на кнопку выводит информацию о человеке
        /// который вписан в поля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void searchButton_Click(object sender, EventArgs e) {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.BankConnectionString;
            try {
                connection.Open();
                resultListBox.Items.Clear();

                int ID = 0; // айдишник для клиента

                string sqlCommand = "select id, name, surname from dbo.Mans " +
                   "where name = '" + nameTextBox.Text + "' and surname = '" + surnameTextBox.Text + "'";

                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows) {
                    while (dr.Read()) {
                        ID = Convert.ToInt32(dr[0]);
                    }

                    dr.Close();
                    sqlCommand = "select id_man from dbo.Clients as c " +
                        "where c.id_man = '" + ID + "'";
                    cmd = new SqlCommand(sqlCommand, connection);
                    dr = cmd.ExecuteReader();
                    
                    if (dr.HasRows) {

                        dr.Close();
                        sqlCommand = "select summ, dateBegin, dateEnd, alreadyPaid, id from dbo.Credit";
                        cmd = new SqlCommand(sqlCommand, connection);
                        dr = cmd.ExecuteReader();

                        while (dr.Read()) {
                            ID = Convert.ToInt32(dr[4]);
                            resultListBox.Items.Add("Сумма: " + dr[0].ToString());
                            resultListBox.Items.Add("От: " + dr[1].ToString() + " До " + dr[2].ToString());
                            resultListBox.Items.Add("Выплатил: " + dr[3].ToString());
                        }
                        dr.Close();

                        sqlCommand = "select id_credit, datePay, summ from dbo.CreditParts " +
                            "where id_credit = '" + ID + "'";
                        cmd = new SqlCommand(sqlCommand, connection);
                        dr = cmd.ExecuteReader();

                        while (dr.Read()) {
                            resultListBox.Items.Add("");
                            resultListBox.Items.Add("Дата платежа: " + dr[1].ToString() + " Сумма: " + dr[2].ToString());
                        }
                        dr.Close();
                        
                    } else {
                        resultListBox.Items.Add("Этот человек не является клиентом банка");
                    }
                } else {
                    resultListBox.Items.Add("Человек не найден");
                }

                
            } catch (Exception ex){
                MessageBox.Show(ex.Message + ' ' + ex.Source);
            } finally {
                connection.Close();
            }
        }

        /// <summary>
        /// Событие, при нажатии на которое форма скрывается и открывается прошлая
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
            InformationAboutClients iac = new InformationAboutClients();
            iac.Show();
        }
    }
}