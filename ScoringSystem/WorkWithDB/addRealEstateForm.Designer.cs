namespace ScoringSystem.WorkWithDB {
    partial class AddRealEstateForm {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new ScoringSystem.BankDataSet();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.squareLabel = new System.Windows.Forms.Label();
            this.squareTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.dateBuyLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.rubLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.locationComboBox1 = new System.Windows.Forms.ComboBox();
            this.citiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.squareLabel1 = new System.Windows.Forms.Label();
            this.squareTextBox1 = new System.Windows.Forms.TextBox();
            this.priceTextBox1 = new System.Windows.Forms.TextBox();
            this.dateBuyLabel1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.locationLabel1 = new System.Windows.Forms.Label();
            this.typeComboBox1 = new System.Windows.Forms.ComboBox();
            this.priceLabel1 = new System.Windows.Forms.Label();
            this.typeLabel1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.citiesTableAdapter = new ScoringSystem.BankDataSetTableAdapters.CitiesTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.locationComboBox);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.squareLabel);
            this.groupBox1.Controls.Add(this.squareTextBox);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.dateBuyLabel);
            this.groupBox1.Controls.Add(this.yearLabel);
            this.groupBox1.Controls.Add(this.locationLabel);
            this.groupBox1.Controls.Add(this.typeComboBox);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.typeLabel);
            this.groupBox1.Controls.Add(this.rubLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 157);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Недвижимость 1";
            this.groupBox1.Visible = false;
            // 
            // locationComboBox
            // 
            this.locationComboBox.DataSource = this.citiesBindingSource;
            this.locationComboBox.DisplayMember = "city";
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(114, 72);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(168, 21);
            this.locationComboBox.TabIndex = 13;
            this.locationComboBox.ValueMember = "id";
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.bankDataSet;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(114, 99);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker.TabIndex = 12;
            // 
            // squareLabel
            // 
            this.squareLabel.AutoSize = true;
            this.squareLabel.Location = new System.Drawing.Point(6, 128);
            this.squareLabel.Name = "squareLabel";
            this.squareLabel.Size = new System.Drawing.Size(54, 13);
            this.squareLabel.TabIndex = 11;
            this.squareLabel.Text = "Площадь";
            // 
            // squareTextBox
            // 
            this.squareTextBox.Location = new System.Drawing.Point(114, 125);
            this.squareTextBox.Name = "squareTextBox";
            this.squareTextBox.Size = new System.Drawing.Size(168, 20);
            this.squareTextBox.TabIndex = 10;
            this.squareTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.squareTextBox_Validating);
            this.squareTextBox.Validated += new System.EventHandler(this.squareTextBox_Validated);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(114, 46);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(168, 20);
            this.priceTextBox.TabIndex = 1;
            this.priceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.priceTextBox_Validating);
            this.priceTextBox.Validated += new System.EventHandler(this.priceTextBox_Validated);
            // 
            // dateBuyLabel
            // 
            this.dateBuyLabel.AutoSize = true;
            this.dateBuyLabel.Location = new System.Drawing.Point(6, 102);
            this.dateBuyLabel.Name = "dateBuyLabel";
            this.dateBuyLabel.Size = new System.Drawing.Size(99, 13);
            this.dateBuyLabel.TabIndex = 7;
            this.dateBuyLabel.Text = "Год приобретения";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(285, 102);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(24, 13);
            this.yearLabel.TabIndex = 9;
            this.yearLabel.Text = "лет";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(6, 76);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(100, 13);
            this.locationLabel.TabIndex = 6;
            this.locationLabel.Text = "Местонахождение";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DisplayMember = "mark";
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Квартира",
            "Комната",
            "Дом",
            "Земельный участок"});
            this.typeComboBox.Location = new System.Drawing.Point(114, 18);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(168, 21);
            this.typeComboBox.TabIndex = 0;
            this.typeComboBox.ValueMember = "id";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(6, 49);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(62, 13);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Стоимость";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(6, 21);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(61, 13);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.Text = "Тип жилья";
            // 
            // rubLabel
            // 
            this.rubLabel.AutoSize = true;
            this.rubLabel.Location = new System.Drawing.Point(248, 49);
            this.rubLabel.Name = "rubLabel";
            this.rubLabel.Size = new System.Drawing.Size(16, 13);
            this.rubLabel.TabIndex = 8;
            this.rubLabel.Text = " ₽";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.locationComboBox1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.squareLabel1);
            this.groupBox2.Controls.Add(this.squareTextBox1);
            this.groupBox2.Controls.Add(this.priceTextBox1);
            this.groupBox2.Controls.Add(this.dateBuyLabel1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.locationLabel1);
            this.groupBox2.Controls.Add(this.typeComboBox1);
            this.groupBox2.Controls.Add(this.priceLabel1);
            this.groupBox2.Controls.Add(this.typeLabel1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 157);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Недвижимость 2";
            this.groupBox2.Visible = false;
            // 
            // locationComboBox1
            // 
            this.locationComboBox1.DataSource = this.citiesBindingSource1;
            this.locationComboBox1.DisplayMember = "city";
            this.locationComboBox1.FormattingEnabled = true;
            this.locationComboBox1.Location = new System.Drawing.Point(114, 72);
            this.locationComboBox1.Name = "locationComboBox1";
            this.locationComboBox1.Size = new System.Drawing.Size(168, 21);
            this.locationComboBox1.TabIndex = 14;
            this.locationComboBox1.ValueMember = "id";
            // 
            // citiesBindingSource1
            // 
            this.citiesBindingSource1.DataMember = "Cities";
            this.citiesBindingSource1.DataSource = this.bankDataSet;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // squareLabel1
            // 
            this.squareLabel1.AutoSize = true;
            this.squareLabel1.Location = new System.Drawing.Point(6, 128);
            this.squareLabel1.Name = "squareLabel1";
            this.squareLabel1.Size = new System.Drawing.Size(54, 13);
            this.squareLabel1.TabIndex = 11;
            this.squareLabel1.Text = "Площадь";
            // 
            // squareTextBox1
            // 
            this.squareTextBox1.Location = new System.Drawing.Point(114, 125);
            this.squareTextBox1.Name = "squareTextBox1";
            this.squareTextBox1.Size = new System.Drawing.Size(168, 20);
            this.squareTextBox1.TabIndex = 10;
            this.squareTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.squareTextBox1_Validating);
            this.squareTextBox1.Validated += new System.EventHandler(this.squareTextBox1_Validated);
            // 
            // priceTextBox1
            // 
            this.priceTextBox1.Location = new System.Drawing.Point(114, 46);
            this.priceTextBox1.Name = "priceTextBox1";
            this.priceTextBox1.Size = new System.Drawing.Size(168, 20);
            this.priceTextBox1.TabIndex = 1;
            this.priceTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.priceTextBox1_Validating);
            this.priceTextBox1.Validated += new System.EventHandler(this.priceTextBox1_Validated);
            // 
            // dateBuyLabel1
            // 
            this.dateBuyLabel1.AutoSize = true;
            this.dateBuyLabel1.Location = new System.Drawing.Point(6, 102);
            this.dateBuyLabel1.Name = "dateBuyLabel1";
            this.dateBuyLabel1.Size = new System.Drawing.Size(99, 13);
            this.dateBuyLabel1.TabIndex = 7;
            this.dateBuyLabel1.Text = "Год приобретения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "лет";
            // 
            // locationLabel1
            // 
            this.locationLabel1.AutoSize = true;
            this.locationLabel1.Location = new System.Drawing.Point(6, 76);
            this.locationLabel1.Name = "locationLabel1";
            this.locationLabel1.Size = new System.Drawing.Size(100, 13);
            this.locationLabel1.TabIndex = 6;
            this.locationLabel1.Text = "Местонахождение";
            // 
            // typeComboBox1
            // 
            this.typeComboBox1.DisplayMember = "mark";
            this.typeComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox1.FormattingEnabled = true;
            this.typeComboBox1.Items.AddRange(new object[] {
            "Квартира",
            "Комната",
            "Дом",
            "Земельный участок"});
            this.typeComboBox1.Location = new System.Drawing.Point(114, 18);
            this.typeComboBox1.Name = "typeComboBox1";
            this.typeComboBox1.Size = new System.Drawing.Size(168, 21);
            this.typeComboBox1.TabIndex = 0;
            this.typeComboBox1.ValueMember = "id";
            // 
            // priceLabel1
            // 
            this.priceLabel1.AutoSize = true;
            this.priceLabel1.Location = new System.Drawing.Point(6, 49);
            this.priceLabel1.Name = "priceLabel1";
            this.priceLabel1.Size = new System.Drawing.Size(62, 13);
            this.priceLabel1.TabIndex = 5;
            this.priceLabel1.Text = "Стоимость";
            // 
            // typeLabel1
            // 
            this.typeLabel1.AutoSize = true;
            this.typeLabel1.Location = new System.Drawing.Point(6, 21);
            this.typeLabel1.Name = "typeLabel1";
            this.typeLabel1.Size = new System.Drawing.Size(61, 13);
            this.typeLabel1.TabIndex = 4;
            this.typeLabel1.Text = "Тип жилья";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = " ₽";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(251, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 367);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Location = new System.Drawing.Point(252, 367);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(75, 23);
            this.nextbutton.TabIndex = 17;
            this.nextbutton.Text = "Далее";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddRealEstateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 400);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddRealEstateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление недвижимости";
            this.Load += new System.EventHandler(this.addRealEstateForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label dateBuyLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label rubLabel;
        private System.Windows.Forms.Label squareLabel;
        private System.Windows.Forms.TextBox squareTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label squareLabel1;
        private System.Windows.Forms.TextBox squareTextBox1;
        private System.Windows.Forms.TextBox priceTextBox1;
        private System.Windows.Forms.Label dateBuyLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label locationLabel1;
        private System.Windows.Forms.ComboBox typeComboBox1;
        private System.Windows.Forms.Label priceLabel1;
        private System.Windows.Forms.Label typeLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.ComboBox locationComboBox1;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private BankDataSetTableAdapters.CitiesTableAdapter citiesTableAdapter;
        private System.Windows.Forms.BindingSource citiesBindingSource1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}