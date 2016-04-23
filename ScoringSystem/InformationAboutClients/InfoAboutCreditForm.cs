using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ScoringSystem.InformationAboutClients {
    /// <summary>
    /// Форма для вывода информации о кредите 
    /// </summary>
    public partial class InfoAboutCreditForm :Form {
        /// <summary>
        /// Class constructor
        /// </summary>
        public InfoAboutCreditForm() {
            InitializeComponent();
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

                string sqlQuery = "select c.summ, c.dateBegin, c.dateEnd, c.alreadyPaid from dbo.Credit c " +
                        "join dbo.Mans man ON man.id = c.id_client " +
                        "where man.name = '" + nameTextBox.Text + "' and surname = '" + surnameTextBox.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader dr = cmd.ExecuteReader();
                    
                if (dr.HasRows) {

                    while (dr.Read()) {
                        resultListBox.Items.Add("Сумма: " + dr[0].ToString());
                        resultListBox.Items.Add("От: " + dr[1].ToString() + " До " + dr[2].ToString());
                        resultListBox.Items.Add("Выплатил: " + dr[3].ToString());
                        }
                    dr.Close();
                        
                } else {
                    resultListBox.Items.Add("Нет кредитов");
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