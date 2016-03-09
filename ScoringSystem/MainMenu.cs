using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoringSystem {
    public partial class MainMenu :Form {
        public MainMenu() {
            InitializeComponent();
        }

        private void openWorkWithDBForm_Click(object sender, EventArgs e) {
            this.Hide();
            WorkWithDB.WorkWithDBForm workWDB = new WorkWithDB.WorkWithDBForm();
            workWDB.Show();
            
        }
    }
}
