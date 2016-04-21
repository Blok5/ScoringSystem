using System;
using System.Windows.Forms;
using System.Data.SqlClient;
//TODO: Add the ability to add credit data to database

namespace ScoringSystem.WorkWithLoan {

    /// <summary>
    /// Form AssessTheCreditworthinessForm show result neural network
    /// </summary>
    public partial class AssessTheCreditworthinessForm :Form {

        /// <summary>
        /// credit target in correct format for neural network
        /// </summary>
        public static int creditTarget;
        /// <summary>
        /// Saving account in correct format for neural network
        /// </summary>
        public static int savingAccount;
        /// <summary>
        /// other deptors property in correct format for neural network
        /// </summary>
        public static int otherDebtors;
        /// <summary>
        /// other installment property in correct format for neural network
        /// </summary>
        public static int otherInstallment;
        /// <summary>
        /// housing property in correct format for neural network
        /// </summary>
        public static int housing;
        /// <summary>
        /// Count of credit property in correct format for neural network
        /// </summary>
        public static int sum;
        /// <summary>
        /// Credit issuance date
        /// </summary>
        public static DateTime from;
        /// <summary>
        /// Latest date for payment of the credit
        /// </summary>
        public static DateTime toDate;

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="credTr">credit target in correct format for neural network</param>
        /// <param name="saveAcc">Saving account in correct format for neural network</param>
        /// <param name="othDeb">other deptors property in correct format for neural network</param>
        /// <param name="othInst">other installment property in correct format for neural network</param>
        /// <param name="hous">housing property in correct format for neural network</param>
        /// <param name="s">Count of credit property in correct format for neural network</param>
        public AssessTheCreditworthinessForm(int credTr, int saveAcc, int othDeb,
            int othInst, int hous, int s) {
            creditTarget = credTr;
            savingAccount = saveAcc;
            otherDebtors = othDeb;
            otherInstallment = othInst;
            housing = hous;
            sum = s;
            InitializeComponent();
        }


        private void AssessTheCreditworthinessForm_Load(object sender, EventArgs e) {

            float[] checkCredit = getCheckCreditArray();

            string result = NeuralNetwork.NeuralNetwork.assessCreditworth(checkCredit);

            o1Label.Text = NeuralNetwork.NeuralNetwork.o1.ToString();
            o2Label.Text = NeuralNetwork.NeuralNetwork.o2.ToString();

            resultLabel.Text = result;

            creditSumLabel.Text = "Кредит на сумму: " + (sum * 100).ToString() + " р.";
            creditPeriodLabel.Text = "На " + CurrentCreditData.period + " мес.";
            from = DateTime.Now;
            fromLabel.Text = "С " + from.Date.ToString("d");
            toDate = from.AddDays(CurrentCreditData.period * 30);
            toLabel.Text = "По " + toDate.Date.ToString("d");

        }

        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
            EnterEdditionalInformationForm eeif = new EnterEdditionalInformationForm();
            eeif.Show();
        }

        /// <summary>
        /// Function getCheckCreditArray create a array for neuralNetwark with credit's and client's info
        /// in currect format for neural network
        /// </summary>
        /// <returns>Array with information about credit and client in correct format</returns>
        private float[] getCheckCreditArray () {

            float[] checkCredit = new float[20]; //Empty array with 20 properties

            //1 Status of existing checking account
            if (CurrentClientData.bankClient == true) {
                if (CurrentClientData.checkingAccount < 0) {
                    checkCredit[0] = 1;
                } else if (CurrentClientData.checkingAccount >= 0 && CurrentClientData.checkingAccount < 20000) {
                    checkCredit[0] = 2;
                } else if (CurrentClientData.checkingAccount >= 20000) {
                    checkCredit[0] = 3;
                }
            } else {
                checkCredit[0] = 4;
            }

            //2 Duration in month
            checkCredit[1] = CurrentCreditData.period;

            //3 Credit history
            if (CurrentClientData.creditHistory == "Не брал кредитов / Все кредиты выплачены вовремя") {
                checkCredit[2] = 0;
            } else if (CurrentClientData.creditHistory == "Все кредиты в этом банке выплачены вовремя") {
                checkCredit[2] = 1;
            } else if (CurrentClientData.creditHistory == "Существуют кредиты, которые выплачиваются вовремя до сих пор") {
                checkCredit[2] = 2;
            } else if (CurrentClientData.creditHistory == "Были задержки в погашении в прошлом") {
                checkCredit[2] = 3;
            } else if (CurrentClientData.creditHistory == "Критический счет / Существуют кредиты в другом банке") {
                checkCredit[2] = 4;
            }

            //4 Purpose
            checkCredit[3] = creditTarget;

            //5 Credit amount
            checkCredit[4] = sum;

            //6 Savings account/bonds
            checkCredit[5] = savingAccount;

            //7 Present employment since
            if (CurrentClientData.work.workDuration == 0) {
                checkCredit[6] = 1;
            } else if (CurrentClientData.work.workDuration < 12) {
                checkCredit[6] = 2;
            } else if (CurrentClientData.work.workDuration >= 12 && CurrentClientData.work.workDuration < 48) {
                checkCredit[6] = 3;
            } else if (CurrentClientData.work.workDuration >= 48 && CurrentClientData.work.workDuration < 84) {
                checkCredit[6] = 4;
            } else if (CurrentClientData.work.workDuration >= 84) {
                checkCredit[6] = 5;
            }

            //8 Installment rate in percentage of disposable income
            checkCredit[7] = CurrentCreditData.installmentRate;

            //9 Personal status and sex
            if (CurrentClientData.sex == "М" && CurrentClientData.personalStatus == "Разведен/Живем раздельно") {
                checkCredit[8] = 1;
            } else if (CurrentClientData.sex == "Ж" && CurrentClientData.personalStatus == "Разведена/Живем раздельно/Замужем") {
                checkCredit[8] = 2;
            } else if (CurrentClientData.sex == "М" && CurrentClientData.personalStatus == "Один") {
                checkCredit[8] = 3;
            } else if (CurrentClientData.sex == "М" && CurrentClientData.personalStatus == "Женат/Вдовец") {
                checkCredit[8] = 4;
            } else if (CurrentClientData.sex == "Ж" && CurrentClientData.personalStatus == "Одинока") {
                checkCredit[8] = 5;
            }

            //10 Other debtors / guarantors
            checkCredit[9] = otherDebtors;

            //11 Present residence since
            checkCredit[10] = CurrentCreditData.presentResidenceSince;

            //12  Property
            bool forAtr12 = true;
            if (CurrentClientData.realEstates != null) {
                checkCredit[11] = 1;
                forAtr12 = false;
            } else if (false) {
                checkCredit[11] = 2;
                forAtr12 = false;
            } else if (CurrentClientData.vehicles != null && forAtr12 == true) {
                checkCredit[11] = 3;
                forAtr12 = false;
            } else if (forAtr12 == true) {
                checkCredit[11] = 4;
            }
            
            DateTime bd = DateTime.Parse(CurrentClientData.birthDate);

            DateTime today = DateTime.Today;
            int age = today.Year - bd.Year;
            //13 Age in year

            if (bd > today.AddYears(-age))
                age--;
            checkCredit[12] = age;

            //14 Other installment plans 
            checkCredit[13] = otherInstallment;

            //15 Housing
            checkCredit[14] = housing;

            //16 Number of existing credits at this bank
            checkCredit[15] = CurrentCreditData.numberOfExistingCredits;

            //17 Job
            if (CurrentClientData.work.position == "Безработный / Не квалифицированный сотрудник") {
                checkCredit[16] = 1;
            } else if (CurrentClientData.work.position == "Не квалифицированный сотрудник") {
                checkCredit[16] = 2;
            } else if (CurrentClientData.work.position == "Квалифицированный сотрудник / Чиновник") {
                checkCredit[16] = 3;
            } else if (CurrentClientData.work.position == "Управляющий / Работающий на себя/ Высококвалифицированный сотрудник / Сотрудник") {
                checkCredit[16] = 4;
            }

            //18 Number of people being liable to provide maintenance for
            checkCredit[17] = CurrentCreditData.numberOfMaintenance;

            //19     Telephone
            if (CurrentClientData.contacts.Length == 0) {
                checkCredit[18] = 1;
            } else {
                checkCredit[18] = 2;
            }

            //20 foreign worker
            if (CurrentClientData.foreignWorker == true) {
                checkCredit[19] = 1;
            } else {
                checkCredit[19] = 2;
            }

            return checkCredit;
        }

        private void approveButton_Click(object sender, EventArgs e) {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Properties.Settings.Default.BankConnectionString;

            try {
                connection.Open();

                string SqlQuery = "insert into dbo.Credit (summ, dateBegin, dateEnd, alreadyPaid, " +
                    "id_client, isComplited) values (@summ, @dateBegin, @dateEnd, @alreadyPaid, @id_client, @isComplited);";

                SqlCommand command = new SqlCommand(SqlQuery, connection);

                from.ToString("yyyy-MM-dd");
                toDate.ToString("yyyy-MM-dd");

                command.Parameters.AddWithValue("@summ", sum * 100);
                command.Parameters.AddWithValue("@dateBegin", from);
                command.Parameters.AddWithValue("@dateEnd", toDate);
                command.Parameters.AddWithValue("@alreadyPaid", 0);
                command.Parameters.AddWithValue("@id_client", CurrentClientData.id);
                command.Parameters.AddWithValue("@isComplited", false);

                command.ExecuteNonQuery();

                MessageBox.Show("Данные о кредите успешно добавлены в базу данных!");

                this.Hide();
                MainMenu mm = new MainMenu();
                mm.Show();

            } catch (Exception) {
                MessageBox.Show("Ошибка в базе данных");             
            } finally {
                connection.Close();
            }


}
    }    
}
