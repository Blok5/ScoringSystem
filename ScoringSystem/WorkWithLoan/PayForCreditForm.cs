using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ScoringSystem.WorkWithLoan {
    /// <summary>
    /// Form PayForCreditForm need for pay for credit
    /// </summary>
    public partial class PayForCreditForm :Form {

        /// <summary>
        /// property connection need for connection to db
        /// </summary>
        public static SqlConnection connection;
        private static string todayDate;
        private static int id;
        private static int id_credit;
        /// <summary>
        /// class constructor
        /// </summary>
        public PayForCreditForm() {
            
            try {
                InitializeComponent();
                connection = new SqlConnection(Properties.Settings.Default.BankConnectionString);
                connection.Open();
            } catch (Exception ex) {

                MessageBox.Show(ex.Message + ' ' + ex.Source);
            }
        }

        private void PayForCreditForm_Load(object sender, EventArgs e) {
            
            this.mansTableAdapter.Fill(this.bankDataSet.Mans);

            
            todayDate = DateTime.Now.ToString("d");
            payDateLabel.Text = todayDate;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
            infoAboutCreditListBox.Items.Clear();
            comboBox1.Items.Clear();
            try {
                string sqlQuery = "select c.summ, c.dateBegin, c.dateEnd, c.id, m.id from dbo.Credit c " +
                    "join dbo.Mans m on m.id = c.id_client where m.fullName = '" +
                    comboBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows) {
                    while (dr.Read()) {
                        
                        infoAboutCreditListBox.Items.Add("Кредит номер: " + dr[3].ToString() +
                            " Сумма кредита: " + dr[0].ToString());
                        infoAboutCreditListBox.Items.Add("Выдан с: " + dr[1].ToString() +
                            " до: " + dr[2].ToString());
                        id = Convert.ToInt32(dr[4]);
                        comboBox1.Items.Add(dr[3].ToString());
                    }
                    
                    dr.Close();
                   
                } else {
                    infoAboutCreditListBox.Items.Add("У данного физ. лица не существует кредитов");
                    dr.Close();
                }
            } catch (Exception ex) {

                MessageBox.Show(ex.Message + ' ' + ex.Source);
            } 
        }

        private void backToMainMenuButton_Click(object sender, EventArgs e) {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }

        private void PayButton_Click(object sender, EventArgs e) {
            try {
                decimal paid = 0;
                string sqlQuery = "insert into dbo.CreditParts (id_credit, datePay, summ) " +
                    "values (@id_credit, @datePay, @summ);";
                    
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);

                cmd.Parameters.AddWithValue("@id_credit", Convert.ToInt32(comboBox1.Text));
                cmd.Parameters.AddWithValue("@datePay", todayDate);
                cmd.Parameters.AddWithValue("@summ", Convert.ToDecimal(sumTextBox.Text));

                cmd.ExecuteNonQuery();
                
                sqlQuery = "select alreadyPaid from dbo.Credit where id_client = " + id + " and id = " + 
                    comboBox1.Text + ";";
                MessageBox.Show(comboBox1.Text);
                cmd = new SqlCommand(sqlQuery, connection);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read()) {
                    paid = Convert.ToDecimal(dr[0]);
                }
                paid += Convert.ToDecimal(sumTextBox.Text);
                dr.Close();

                sqlQuery = "update dbo.Credit SET [alreadyPaid] = @alreadyPaid where id_client = " + id +
                    " and id= " + comboBox1.Text;

                cmd = new SqlCommand(sqlQuery, connection);
                
                cmd.Parameters.AddWithValue("@alreadyPaid", paid);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Данные успешно добавлены!");

                this.Hide();
                MainMenu mm = new MainMenu();
                mm.Show();

            } catch (Exception ex) {

                MessageBox.Show(ex.Message + ' ' + ex.Source);
            }

        }
    }
}
