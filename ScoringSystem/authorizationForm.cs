using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


    }
}
