using System;
using System.Windows.Forms;

namespace ScoringSystem.WorkWithDB {
    /// <summary>
    /// Класс AddRealEstateForm открывает форму для добавления 
    /// недвижимости к клиенту
    /// </summary>
    public partial class AddRealEstateForm :Form {
        public AddRealEstateForm() {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e) {
            AddVehicleForm avf = new AddVehicleForm();
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

        /// <summary>
        /// При нажатии пытается добавить данные к клиенту. 
        /// При успехе открывает AddWorkForm форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Параметр с событиями</param>
        private void nextbutton_Click(object sender, EventArgs e) {

            try {
                //2 vehicles case
                if (groupBox2.Visible == true) {
                    RealEstateData[] red = new RealEstateData[2];

                    for (int i = 0; i < 2; i++) {
                        red[i] = new RealEstateData();
                    }

                    dateTimePicker.CustomFormat = "yyyy-MM-dd";
                    dateTimePicker.Format = DateTimePickerFormat.Custom;

                    red[0].dateBuy = dateTimePicker.Text;
                    red[0].location = locationComboBox.SelectedIndex;
                    red[0].price = Convert.ToDecimal(priceTextBox.Text);
                    red[0].square = Convert.ToInt32(squareTextBox.Text);
                    red[0].type = typeComboBox.Text;

                    red[1].dateBuy = dateTimePicker1.Text;
                    red[1].location = locationComboBox1.SelectedIndex;
                    red[1].price = Convert.ToDecimal(priceTextBox1.Text);
                    red[1].square = Convert.ToInt32(squareTextBox1.Text);
                    red[1].type = typeComboBox1.Text;

                    CurrentData.addRealEstate(red, 2);

                //1 vehicle case
                } else if (groupBox2.Visible == false && groupBox1.Visible == true) {
                    RealEstateData[] red = new RealEstateData[1];
                    red[0] = new RealEstateData();

                    red[0].dateBuy = dateTimePicker.Text;
                    red[0].location = locationComboBox.SelectedIndex;
                    red[0].price = Convert.ToDecimal(priceTextBox.Text);
                    red[0].square = Convert.ToInt32(squareTextBox.Text);
                    red[0].type = typeComboBox.Text;

                    CurrentData.addRealEstate(red, 1);
                }

                AddWorkForm awf = new AddWorkForm();
                this.Hide();
                awf.Show();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message + ex.Source);
                
            }

            
        }

        private void addRealEstateForm_Load(object sender, EventArgs e) {
            // данная строка кода позволяет загрузить данные в таблицу "bankDataSet.Cities". При необходимости она может быть перемещена или удалена.
            this.citiesTableAdapter.Fill(this.bankDataSet.Cities);

        }
    }
}
