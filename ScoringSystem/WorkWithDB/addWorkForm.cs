using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoringSystem.WorkWithDB {
    public partial class addWorkForm :Form {
        public addWorkForm() {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
            addRealEstateForm aref = new addRealEstateForm();
            aref.Show();
        }

        private void nextButton_Click(object sender, EventArgs e) {
            try {
                CurrentData.addWork(nameTextBox.Text, positionComboBox.Text, workDurationComboBox.Text);

                addRelationsForm arf = new addRelationsForm();
                this.Hide();
                arf.Show();

            } catch (Exception ex) {

                MessageBox.Show(ex.Message + ex.Source);
            }
        }
    }
}
