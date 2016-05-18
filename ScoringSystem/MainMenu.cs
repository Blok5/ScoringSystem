using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ScoringSystem {

    
    /// <summary>
    /// MainMenu form open main user interface
    /// </summary>
    public partial class MainMenu :Form {
        /// <summary>
        /// Class constructor
        /// </summary>
        /// 
        
        public MainMenu() {
            InitializeComponent();
            
        }

        private void openWorkWithDBForm_Click(object sender, EventArgs e) {
            this.Hide();
            WorkWithDB.WorkWithDBForm workWDB = new WorkWithDB.WorkWithDBForm();
            workWDB.Show();         
        }

        private void MainMenu_Load(object sender, EventArgs e) {

            
            helloLabel.Text = "Здравствуйте " + currentClient.role + "!";

            string sqlCmd = "select button, " + currentClient.role + " from dbo.isVisibility";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.BankConnectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand(sqlCmd, connection);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) {

                Console.WriteLine(dr[0].ToString());

                Control ctn = this.Controls[dr[0].ToString()];
                if (ctn != null) {
                    ctn.Visible = Convert.ToBoolean(dr[1]);
                }
            }
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Разработал: Симаков Игорь\nГруппа: ИУ5-83");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void informationAboutClientButton_Click(object sender, EventArgs e) {
            InformationAboutClients.InformationAboutClients iac = new InformationAboutClients.InformationAboutClients();
            this.Hide();
            iac.Show();
        }

        private void workWithNeuralNetworkButton_Click(object sender, EventArgs e) {
            this.Hide();
            WorkWithLoan.PayForCreditForm pfcf = new WorkWithLoan.PayForCreditForm();
            pfcf.Show();
        }

        private void openAssessTheCreditworthinessFormBatton_Click(object sender, EventArgs e) {
            this.Hide();
            WorkWithLoan.GetALoanForm galf = new WorkWithLoan.GetALoanForm();
            galf.Show();
        }
    }
}
