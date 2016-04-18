using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoringSystem.WorkWithLoan {
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
        //1 30 2 2 3622 4 5 4 2 1 4 2 57 3 1 2 3 1 2 1
        private void AssessTheCreditworthinessForm_Load(object sender, EventArgs e) {
            MessageBox.Show(CurrentClientData.checkingAccount.ToString() + ' ' +
                CurrentCreditData.period.ToString() + ' ' +
                CurrentClientData.creditHistory.ToString() + ' ' +
                creditTarget.ToString() + ' ' + sum.ToString() + ' ' +
                savingAccount.ToString() + ' ' + CurrentClientData.work.workDuration.ToString() + ' ' +
                CurrentCreditData.installmentRate.ToString() + ' ' + CurrentClientData.sex + ' ' +
                CurrentClientData.personalStatus + ' ' + otherDebtors.ToString() + ' ' +
                CurrentCreditData.presentResidenceSince.ToString() + ' ' +
                CurrentClientData.realEstates[0].type.ToString() + ' ' +
                CurrentClientData.birthDate.ToString() + ' ' + otherInstallment.ToString() + ' ' +
                housing.ToString() + ' ' + CurrentCreditData.numberOfExistingCredits.ToString() + ' ' +
                CurrentClientData.work.position.ToString() + ' ' +
                CurrentCreditData.numberOfMaintenance.ToString() + ' ' + CurrentClientData.contacts[0].phone.ToString() + ' ' +
                CurrentClientData.foreignWorker.ToString());
                
        }
    }
    
}
