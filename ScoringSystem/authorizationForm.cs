using System;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace ScoringSystem {

    public partial class authorizationForm :Form {

        static int tryEnter = 3;
            
        public authorizationForm() {
            InitializeComponent();
        }

        private void authorizationForm_Load(object sender, EventArgs e) {
            // данная строка кода позволяет загрузить данные в таблицу "bankDataSet.Role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.bankDataSet.Role);

        }

        private void exitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void enterButton_Click(object sender, EventArgs e) {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.BankConnectionString;
            try {
                ;
                connection.Open();
                string role = accountComboBox.Text;
                string checkPass = "";
                string sqlCommand = "select password from dbo.Role where role ='" + role + "'";
                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read()) {
                    checkPass = dr[0].ToString();
                }

                if (GetHashString(passwordTextBox.Text) == checkPass && checkPass != "") {
                    currentClient.role = role;
                    this.Hide();
                    MainMenu mm = new MainMenu();
                    mm.Show();
                } else {
                    --tryEnter;
                    informationLabel.Text = "Неверный пароль, попробуйте еще раз!\nОсталось: " +
                        tryEnter + " попыток";
                    passwordTextBox.Text = "";
                    accountComboBox.Text = "";
                }
                if (tryEnter == 0) {
                    Application.Exit();
                }
            } catch {
                MessageBox.Show(string.Format("Ошибка в Базе Данных"));
            } finally {
                connection.Close();
            }
            

        }

        string GetHashString(string pass) {
            byte[] bytes = Encoding.Unicode.GetBytes(pass);

            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();

            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = string.Empty;

            //формируем одну цельную строку из массива  
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);

            return hash;
        }
    }
}
