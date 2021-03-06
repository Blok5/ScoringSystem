﻿using System;
using System.Windows.Forms;

namespace ScoringSystem.WorkWithDB {
    /// <summary>
    /// Класс AddVehicleForm открывает форму для добавления транспортного средства
    /// </summary>
    public partial class AddVehicleForm :Form {

        public AddVehicleForm() {
            InitializeComponent();
        }

        private void addVehicleForm_Load(object sender, EventArgs e) {
            
            this.marksTableAdapter.Fill(this.bankDataSet.Marks);
        }

        private void backButton_Click(object sender, EventArgs e) {
            this.Hide();
            AddManForm amf = new AddManForm();
            amf.Show();
        }

        /// <summary>
        /// Пытается добавить транспортное средство к клиенту.
        /// При успехе открывает AddRealEstate форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextbutton_Click(object sender, EventArgs e) {

            try {          

                if (groupBox2.Visible == true) {

                    VehicleData[] vd = new VehicleData[2];

                    for (int i = 0; i <= 1; i++) {
                        vd[i] = new VehicleData();
                    }
                    productionDateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    productionDateTimePicker1.Format = DateTimePickerFormat.Custom;
                    productionDateTimePicker2.CustomFormat = "yyyy-MM-dd";
                    productionDateTimePicker2.Format = DateTimePickerFormat.Custom;
                    vd[0].productionDate = productionDateTimePicker1.Text.ToString();
                    vd[0].id_mark = markComboBox.SelectedIndex + 1;
                    vd[0].number = numberTextBox.Text;
                    vd[0].price = Convert.ToInt32(priceTextBox.Text);

                    vd[1].productionDate = productionDateTimePicker2.Text.ToString();
                    vd[1].id_mark = markComboBox1.SelectedIndex + 1;
                    vd[1].number = numberTextBox1.Text;
                    vd[1].price = Convert.ToInt32(priceTextBox1.Text);

                    CurrentClientData.addVehicle(vd,2);

                } else if (groupBox2.Visible == false && groupBox1.Visible==true) {
                    VehicleData[] vd = new VehicleData[1];
                    productionDateTimePicker1.CustomFormat = "yyyy-MM-dd";
                    productionDateTimePicker1.Format = DateTimePickerFormat.Custom;
                    vd[0] = new VehicleData();
                                  
                    vd[0].productionDate = productionDateTimePicker1.Text.ToString();
                    vd[0].id_mark = markComboBox.SelectedIndex + 1;
                    vd[0].number = numberTextBox.Text;
                    vd[0].price = Convert.ToInt32(priceTextBox.Text);

                    CurrentClientData.addVehicle(vd,1);

                }      
                
                AddRealEstateForm reform = new AddRealEstateForm();
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

        private void priceTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            string errorMsg;

            if (!Validation.isNumberValue(priceTextBox.Text, out errorMsg)) {
                e.Cancel = true;
                priceTextBox.Select(0, Text.Length);

                this.errorProvider1.SetError(priceTextBox, errorMsg);
            }
        }

        private void priceTextBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            string errorMsg;

            if (!Validation.isNumberValue(priceTextBox1.Text, out errorMsg)) {
                e.Cancel = true;
                priceTextBox1.Select(0, Text.Length);

                this.errorProvider1.SetError(priceTextBox1, errorMsg);
            }
        }

        private void priceTextBox_Validated(object sender, EventArgs e) {
            errorProvider1.SetError(priceTextBox, "");
        }

        private void priceTextBox1_Validated(object sender, EventArgs e) {
            errorProvider1.SetError(priceTextBox1, "");
        }
    }
}
