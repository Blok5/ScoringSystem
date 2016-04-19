using System;
using System.Windows.Forms;

namespace ScoringSystem.WorkWithLoan {

    /// <summary>
    /// Form AssessTheCreditworthinessForm show result neural network
    /// </summary>
    public partial class AssessTheCreditworthinessForm :Form {
      
        public static int creditTarget;
        public static int savingAccount;
        public static int otherDebtors;
        public static int otherInstallment;
        public static int housing;
        public static int sum;

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
            //MessageBox.Show(CurrentClientData.checkingAccount.ToString() + ' ' +
            //    CurrentCreditData.period.ToString() + ' ' +
            //    CurrentClientData.creditHistory.ToString() + ' ' +
            //    creditTarget.ToString() + ' ' + sum.ToString() + ' ' +
            //    savingAccount.ToString() + ' ' + CurrentClientData.work.workDuration.ToString() + ' ' +
            //    CurrentCreditData.installmentRate.ToString() + ' ' + CurrentClientData.sex + ' ' +
            //    CurrentClientData.personalStatus + ' ' + otherDebtors.ToString() + ' ' +
            //    CurrentCreditData.presentResidenceSince.ToString() + ' ' +
            //    CurrentClientData.realEstates[0].type.ToString() + ' ' +
            //    CurrentClientData.birthDate.ToString() + ' ' + otherInstallment.ToString() + ' ' +
            //    housing.ToString() + ' ' + CurrentCreditData.numberOfExistingCredits.ToString() + ' ' +
            //    CurrentClientData.work.position.ToString() + ' ' +
            //    CurrentCreditData.numberOfMaintenance.ToString() + ' ' + CurrentClientData.contacts[0].phone.ToString() + ' ' +
            //    CurrentClientData.foreignWorker.ToString());

            float[] checkCredit = new float[20];

            //1 Status of existing checking account
            if (CurrentClientData.checkingAccount < 0) {
                checkCredit[0] = 1;
            } else if (CurrentClientData.checkingAccount >= 0 && CurrentClientData.checkingAccount < 20000) {
                checkCredit[0] = 2;
            } else if (CurrentClientData.checkingAccount >= 20000) {
                checkCredit[0] = 3;
            } else if (CurrentClientData.checkingAccount == null) {
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
            MessageBox.Show(CurrentClientData.birthDate.ToString());
            DateTime bd = DateTime.Parse(CurrentClientData.birthDate);
            MessageBox.Show(bd.ToString());

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

            string result = NeuralNetwork.NeuralNetwork.assessCreditworth(checkCredit);

            o1Label.Text = NeuralNetwork.NeuralNetwork.o1.ToString();
            o2Label.Text = NeuralNetwork.NeuralNetwork.o2.ToString();

            resultLabel.Text = result;

        }

        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
            EnterEdditionalInformationForm eeif = new EnterEdditionalInformationForm();
            eeif.Show();
        }
    }    
}
