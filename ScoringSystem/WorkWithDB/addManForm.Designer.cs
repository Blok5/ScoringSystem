namespace ScoringSystem.WorkWithDB {
    partial class addManForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.exitButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.birthPlaceTextBox = new System.Windows.Forms.TextBox();
            this.homeTextBox = new System.Windows.Forms.TextBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.birthPlaceLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.educationComboBox = new System.Windows.Forms.ComboBox();
            this.educationLabel = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.streetComboBox = new System.Windows.Forms.ComboBox();
            this.streetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.housingTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Назад";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(197, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(12, 38);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(196, 20);
            this.surnameTextBox.TabIndex = 3;
            // 
            // birthPlaceTextBox
            // 
            this.birthPlaceTextBox.Location = new System.Drawing.Point(12, 90);
            this.birthPlaceTextBox.Name = "birthPlaceTextBox";
            this.birthPlaceTextBox.Size = new System.Drawing.Size(196, 20);
            this.birthPlaceTextBox.TabIndex = 5;
            // 
            // homeTextBox
            // 
            this.homeTextBox.Location = new System.Drawing.Point(313, 38);
            this.homeTextBox.Name = "homeTextBox";
            this.homeTextBox.Size = new System.Drawing.Size(54, 20);
            this.homeTextBox.TabIndex = 6;
            // 
            // sexComboBox
            // 
            this.sexComboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.sexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.sexComboBox.Location = new System.Drawing.Point(313, 11);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(54, 21);
            this.sexComboBox.TabIndex = 7;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(215, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(29, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Имя";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(215, 41);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(56, 13);
            this.surnameLabel.TabIndex = 9;
            this.surnameLabel.Text = "Фамилия";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(215, 67);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(86, 13);
            this.birthDateLabel.TabIndex = 10;
            this.birthDateLabel.Text = "Дата рождения";
            // 
            // birthPlaceLabel
            // 
            this.birthPlaceLabel.AutoSize = true;
            this.birthPlaceLabel.Location = new System.Drawing.Point(215, 93);
            this.birthPlaceLabel.Name = "birthPlaceLabel";
            this.birthPlaceLabel.Size = new System.Drawing.Size(92, 13);
            this.birthPlaceLabel.TabIndex = 11;
            this.birthPlaceLabel.Text = "Место рождения";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(373, 15);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(27, 13);
            this.sexLabel.TabIndex = 12;
            this.sexLabel.Text = "Пол";
            // 
            // educationComboBox
            // 
            this.educationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.educationComboBox.FormattingEnabled = true;
            this.educationComboBox.Items.AddRange(new object[] {
            "Ученая степень",
            "Несколько высших",
            "Высшее",
            "Незаконченное высшее",
            "Среднее специальное",
            "Среднее",
            "Ниже среднего"});
            this.educationComboBox.Location = new System.Drawing.Point(12, 116);
            this.educationComboBox.Name = "educationComboBox";
            this.educationComboBox.Size = new System.Drawing.Size(196, 21);
            this.educationComboBox.TabIndex = 13;
            // 
            // educationLabel
            // 
            this.educationLabel.AutoSize = true;
            this.educationLabel.Location = new System.Drawing.Point(215, 119);
            this.educationLabel.Name = "educationLabel";
            this.educationLabel.Size = new System.Drawing.Size(75, 13);
            this.educationLabel.TabIndex = 14;
            this.educationLabel.Text = "Образование";
            // 
            // cityComboBox
            // 
            this.cityComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cityComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cityComboBox.DataSource = this.citiesBindingSource;
            this.cityComboBox.DisplayMember = "city";
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(12, 144);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(196, 21);
            this.cityComboBox.TabIndex = 15;
            this.cityComboBox.ValueMember = "id";
            // 
            // streetComboBox
            // 
            this.streetComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.streetComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.streetComboBox.DataSource = this.streetsBindingSource;
            this.streetComboBox.DisplayMember = "street";
            this.streetComboBox.FormattingEnabled = true;
            this.streetComboBox.Location = new System.Drawing.Point(12, 171);
            this.streetComboBox.Name = "streetComboBox";
            this.streetComboBox.Size = new System.Drawing.Size(196, 21);
            this.streetComboBox.TabIndex = 16;
            this.streetComboBox.ValueMember = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Город";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Улица";
            // 
            // housingTextBox
            // 
            this.housingTextBox.Location = new System.Drawing.Point(313, 64);
            this.housingTextBox.Name = "housingTextBox";
            this.housingTextBox.Size = new System.Drawing.Size(54, 20);
            this.housingTextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Дом";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Строение";
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Location = new System.Drawing.Point(12, 64);
            this.birthDateTimePicker.MaxDate = new System.DateTime(2016, 3, 9, 0, 0, 0, 0);
            this.birthDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(196, 20);
            this.birthDateTimePicker.TabIndex = 22;
            this.birthDateTimePicker.Value = new System.DateTime(2016, 3, 9, 0, 0, 0, 0);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(348, 226);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 23;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click_1);
            // 
            // addManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 261);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.birthDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.housingTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.streetComboBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.educationLabel);
            this.Controls.Add(this.educationComboBox);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.birthPlaceLabel);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.homeTextBox);
            this.Controls.Add(this.birthPlaceTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.exitButton);
            this.Name = "addManForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить человека";
            this.Load += new System.EventHandler(this.addManForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.streetsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox birthPlaceTextBox;
        private System.Windows.Forms.TextBox homeTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label birthPlaceLabel;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.ComboBox educationComboBox;
        private System.Windows.Forms.Label educationLabel;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.ComboBox streetComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox housingTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private System.Windows.Forms.BindingSource streetsBindingSource;
        private System.Windows.Forms.Button nextButton;
    }
}