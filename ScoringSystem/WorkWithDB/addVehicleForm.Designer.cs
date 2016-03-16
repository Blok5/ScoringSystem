namespace ScoringSystem.WorkWithDB {
    partial class AddVehicleForm {
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
            this.markComboBox = new System.Windows.Forms.ComboBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.markLabel = new System.Windows.Forms.Label();
            this.bankDataSet = new ScoringSystem.BankDataSet();
            this.marksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marksTableAdapter = new ScoringSystem.BankDataSetTableAdapters.MarksTableAdapter();
            this.priceLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.rubLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.priceTextBox1 = new System.Windows.Forms.TextBox();
            this.ageLabel1 = new System.Windows.Forms.Label();
            this.ageTextBox1 = new System.Windows.Forms.TextBox();
            this.yearLabel1 = new System.Windows.Forms.Label();
            this.numberLabel1 = new System.Windows.Forms.Label();
            this.markComboBox1 = new System.Windows.Forms.ComboBox();
            this.numberTextBox1 = new System.Windows.Forms.TextBox();
            this.priceLabel1 = new System.Windows.Forms.Label();
            this.markLabel1 = new System.Windows.Forms.Label();
            this.rubLabel1 = new System.Windows.Forms.Label();
            this.nextbutton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.marksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // markComboBox
            // 
            this.markComboBox.DataSource = this.marksBindingSource;
            this.markComboBox.DisplayMember = "mark";
            this.markComboBox.FormattingEnabled = true;
            this.markComboBox.Location = new System.Drawing.Point(74, 18);
            this.markComboBox.Name = "markComboBox";
            this.markComboBox.Size = new System.Drawing.Size(168, 21);
            this.markComboBox.TabIndex = 0;
            this.markComboBox.ValueMember = "id";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(74, 46);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(168, 20);
            this.priceTextBox.TabIndex = 1;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(74, 73);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(168, 20);
            this.numberTextBox.TabIndex = 2;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(74, 99);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(168, 20);
            this.ageTextBox.TabIndex = 3;
            // 
            // markLabel
            // 
            this.markLabel.AutoSize = true;
            this.markLabel.Location = new System.Drawing.Point(6, 21);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(40, 13);
            this.markLabel.TabIndex = 4;
            this.markLabel.Text = "Марка";
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marksBindingSource
            // 
            this.marksBindingSource.DataMember = "Marks";
            this.marksBindingSource.DataSource = this.bankDataSet;
            // 
            // marksTableAdapter
            // 
            this.marksTableAdapter.ClearBeforeFill = true;
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
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(6, 76);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(63, 13);
            this.numberLabel.TabIndex = 6;
            this.numberLabel.Text = "Рег. номер";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(6, 102);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(49, 13);
            this.ageLabel.TabIndex = 7;
            this.ageLabel.Text = "Возраст";
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
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(247, 102);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(24, 13);
            this.yearLabel.TabIndex = 9;
            this.yearLabel.Text = "лет";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(this.ageLabel);
            this.groupBox1.Controls.Add(this.ageTextBox);
            this.groupBox1.Controls.Add(this.yearLabel);
            this.groupBox1.Controls.Add(this.numberLabel);
            this.groupBox1.Controls.Add(this.markComboBox);
            this.groupBox1.Controls.Add(this.numberTextBox);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.markLabel);
            this.groupBox1.Controls.Add(this.rubLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 129);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Транспорт 1";
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.priceTextBox1);
            this.groupBox2.Controls.Add(this.ageLabel1);
            this.groupBox2.Controls.Add(this.ageTextBox1);
            this.groupBox2.Controls.Add(this.yearLabel1);
            this.groupBox2.Controls.Add(this.numberLabel1);
            this.groupBox2.Controls.Add(this.markComboBox1);
            this.groupBox2.Controls.Add(this.numberTextBox1);
            this.groupBox2.Controls.Add(this.priceLabel1);
            this.groupBox2.Controls.Add(this.markLabel1);
            this.groupBox2.Controls.Add(this.rubLabel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 129);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Транспорт 2";
            this.groupBox2.Visible = false;
            // 
            // priceTextBox1
            // 
            this.priceTextBox1.Location = new System.Drawing.Point(74, 46);
            this.priceTextBox1.Name = "priceTextBox1";
            this.priceTextBox1.Size = new System.Drawing.Size(168, 20);
            this.priceTextBox1.TabIndex = 1;
            // 
            // ageLabel1
            // 
            this.ageLabel1.AutoSize = true;
            this.ageLabel1.Location = new System.Drawing.Point(6, 102);
            this.ageLabel1.Name = "ageLabel1";
            this.ageLabel1.Size = new System.Drawing.Size(49, 13);
            this.ageLabel1.TabIndex = 7;
            this.ageLabel1.Text = "Возраст";
            // 
            // ageTextBox1
            // 
            this.ageTextBox1.Location = new System.Drawing.Point(74, 99);
            this.ageTextBox1.Name = "ageTextBox1";
            this.ageTextBox1.Size = new System.Drawing.Size(168, 20);
            this.ageTextBox1.TabIndex = 3;
            // 
            // yearLabel1
            // 
            this.yearLabel1.AutoSize = true;
            this.yearLabel1.Location = new System.Drawing.Point(247, 102);
            this.yearLabel1.Name = "yearLabel1";
            this.yearLabel1.Size = new System.Drawing.Size(24, 13);
            this.yearLabel1.TabIndex = 9;
            this.yearLabel1.Text = "лет";
            // 
            // numberLabel1
            // 
            this.numberLabel1.AutoSize = true;
            this.numberLabel1.Location = new System.Drawing.Point(6, 76);
            this.numberLabel1.Name = "numberLabel1";
            this.numberLabel1.Size = new System.Drawing.Size(63, 13);
            this.numberLabel1.TabIndex = 6;
            this.numberLabel1.Text = "Рег. номер";
            // 
            // markComboBox1
            // 
            this.markComboBox1.DataSource = this.marksBindingSource1;
            this.markComboBox1.DisplayMember = "mark";
            this.markComboBox1.FormattingEnabled = true;
            this.markComboBox1.Location = new System.Drawing.Point(74, 18);
            this.markComboBox1.Name = "markComboBox1";
            this.markComboBox1.Size = new System.Drawing.Size(168, 21);
            this.markComboBox1.TabIndex = 0;
            this.markComboBox1.ValueMember = "id";
            // 
            // numberTextBox1
            // 
            this.numberTextBox1.Location = new System.Drawing.Point(74, 73);
            this.numberTextBox1.Name = "numberTextBox1";
            this.numberTextBox1.Size = new System.Drawing.Size(168, 20);
            this.numberTextBox1.TabIndex = 2;
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
            // markLabel1
            // 
            this.markLabel1.AutoSize = true;
            this.markLabel1.Location = new System.Drawing.Point(6, 21);
            this.markLabel1.Name = "markLabel1";
            this.markLabel1.Size = new System.Drawing.Size(40, 13);
            this.markLabel1.TabIndex = 4;
            this.markLabel1.Text = "Марка";
            // 
            // rubLabel1
            // 
            this.rubLabel1.AutoSize = true;
            this.rubLabel1.Location = new System.Drawing.Point(248, 49);
            this.rubLabel1.Name = "rubLabel1";
            this.rubLabel1.Size = new System.Drawing.Size(16, 13);
            this.rubLabel1.TabIndex = 8;
            this.rubLabel1.Text = " ₽";
            // 
            // nextbutton
            // 
            this.nextbutton.Location = new System.Drawing.Point(217, 311);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(75, 23);
            this.nextbutton.TabIndex = 12;
            this.nextbutton.Text = "Далее";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 311);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // marksBindingSource1
            // 
            this.marksBindingSource1.DataMember = "Marks";
            this.marksBindingSource1.DataSource = this.bankDataSet;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(217, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 342);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "addVehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить транспорт";
            this.Load += new System.EventHandler(this.addVehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox markComboBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label markLabel;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource marksBindingSource;
        private BankDataSetTableAdapters.MarksTableAdapter marksTableAdapter;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label rubLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox priceTextBox1;
        private System.Windows.Forms.Label ageLabel1;
        private System.Windows.Forms.TextBox ageTextBox1;
        private System.Windows.Forms.Label yearLabel1;
        private System.Windows.Forms.Label numberLabel1;
        private System.Windows.Forms.ComboBox markComboBox1;
        private System.Windows.Forms.TextBox numberTextBox1;
        private System.Windows.Forms.Label priceLabel1;
        private System.Windows.Forms.Label markLabel1;
        private System.Windows.Forms.Label rubLabel1;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.BindingSource marksBindingSource1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
    }
}