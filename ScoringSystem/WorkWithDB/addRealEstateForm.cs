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
    public partial class addRealEstateForm :Form {
        public addRealEstateForm() {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e) {
            addVehicleForm avf = new addVehicleForm();
            this.Hide();
            avf.Show();
        }

        private void addButton_Click(object sender, EventArgs e) {
            if (groupBox1.Visible == true) {
                groupBox2.Show();
            } else {
                groupBox1.Show();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if (groupBox2.Visible == true) {
                groupBox2.Hide();
            } else {
                groupBox1.Hide();
            }
        }

        private void nextbutton_Click(object sender, EventArgs e) {

        }
    }
}
