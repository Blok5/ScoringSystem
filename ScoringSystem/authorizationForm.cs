using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ScoringSystem {

    public partial class authorizationForm :Form {

        static public string connectionString = "Data Source=IGOR_PC;Initial Catalog=BankDB;Integrated Security=True";
        static int tryEnter = 3;
            
        public authorizationForm() {
            InitializeComponent();
        }

        private void authorizationForm_Load(object sender, EventArgs e) {

            string sqlCommand = "select role from dbo.Role";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sqlCommand, connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read()) {
                accountComboBox.Items.Add(dr[0]);
            }

        }

        private void exitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void enterButton_Click(object sender, EventArgs e) {
            string role = accountComboBox.Text;
            string pass = passwordTextBox.Text;
            string checkPass = "";
            string sqlCommand = "select password from dbo.Role where role ='" + role + "'";                            

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(sqlCommand, connection);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) {
                checkPass = dr[0].ToString();
            }

            if (pass == checkPass && checkPass != "") {
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

        }
    }
}
