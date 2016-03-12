using System;
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

        private void nextbutton_Click(object sender, EventArgs e) {

            try {
                vehicleData[] vd = new vehicleData[2];

                if (groupBox2.Visible == true) {

                    for (int i = 0; i <= 1; i++) {
                        vd[i] = new vehicleData();
                    }
                    vd[0].age = Convert.ToInt32(ageTextBox.Text);
                    vd[0].id_mark = markComboBox.SelectedIndex;
                    vd[0].number = numberTextBox.Text;
                    vd[0].price = Convert.ToInt32(priceTextBox.Text);

                    vd[1].age = Convert.ToInt32(ageTextBox1.Text);
                    vd[1].id_mark = markComboBox1.SelectedIndex;
                    vd[1].number = numberTextBox1.Text;
                    vd[1].price = Convert.ToInt32(priceTextBox1.Text);

                    currentData.addVehicle(vd,2);

                } else {
                    vd[0] = new vehicleData();
                                  
                    vd[0].age = Convert.ToInt32(ageTextBox.Text);
                    vd[0].id_mark = markComboBox.SelectedIndex;
                    vd[0].number = numberTextBox.Text;
                    vd[0].price = Convert.ToInt32(priceTextBox.Text);

                    currentData.addVehicle(vd,1);
                }             

                addRealEstateForm reform = new addRealEstateForm();
                this.Hide();
                reform.Show();

            } catch (Exception ex) {
                MessageBox.Show("Введите корректные данные\n" + ex.Message);
            }

        }

        private void addButton_Click(object sender, EventArgs e) {
            
            if (groupBox1.Visible==true) {
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

    }
}
