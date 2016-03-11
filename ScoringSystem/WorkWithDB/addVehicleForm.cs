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
    public partial class addVehicleForm :Form {
        public addVehicleForm() {
            InitializeComponent();
        }

        private void addVehicleForm_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDataSet.Marks". При необходимости она может быть перемещена или удалена.
            this.marksTableAdapter.Fill(this.bankDataSet.Marks);

        }

        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
            addManForm amf = new addManForm();
            amf.Show();
        }
    }
}
