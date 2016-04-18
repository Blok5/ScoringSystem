using System;
using System.Windows.Forms;

namespace ScoringSystem.WorkWithLoan {
    public partial class EnterEdditionalInformationForm :Form {
        public EnterEdditionalInformationForm() {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
            GetALoanForm galf = new GetALoanForm();
            galf.Show();
        }

        private void EnterEdditionalInformationForm_Load(object sender, EventArgs e) {
            
        }

        private void nextButton_Click(object sender, EventArgs e) {
            try {
                CurrentCreditData.period = Convert.ToInt32(creditPeriodTextBox.Text);
                CurrentCreditData.sum = Convert.ToDecimal(creditSummTextBox.Text);
                CurrentCreditData.target = creditTargetComboBox.Text; //from 0 to 4
                CurrentCreditData.savingAcc = savingAccountComboBox.Text;
                CurrentCreditData.otherDebtors = otherDebtorsComboBox.Text;
                CurrentCreditData.otherInstallment = otherInstallmentComboBox.Text;
                CurrentCreditData.housing = housingComboBox.Text;
                CurrentCreditData.numberOfExistingCredits = Convert.ToInt32(numberOfExistingCreditsTextBox.Text);
                CurrentCreditData.installmentRate = Convert.ToInt32(installmentRateTextBox.Text);
                CurrentCreditData.presentResidenceSince = Convert.ToInt32(presentResidenceSinceTextBox.Text);
                CurrentCreditData.numberOfMaintenance = Convert.ToInt32(numberOfMaintenanceTextBox.Text);

                MessageBox.Show(creditTargetComboBox.SelectedIndex.ToString());
                AssessTheCreditworthinessForm atcf = new AssessTheCreditworthinessForm(creditTargetComboBox.SelectedIndex,
                    savingAccountComboBox.SelectedIndex + 1, otherDebtorsComboBox.SelectedIndex + 1, 
                    otherInstallmentComboBox.SelectedIndex + 1, housingComboBox.SelectedIndex + 1,
                    Convert.ToInt32(CurrentCreditData.sum/100));

                this.Hide();
                atcf.Show();

            } catch (Exception ex) {

                MessageBox.Show(ex.Message + ' ' + ex.Source + ' ' + ex.TargetSite);
            }
}
    }
}
