namespace ScoringSystem.WorkWithLoan {
    partial class PayForCreditForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.infoAboutCreditListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.payDateLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bankDataSet = new ScoringSystem.BankDataSet();
            this.mansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mansTableAdapter = new ScoringSystem.BankDataSetTableAdapters.MansTableAdapter();
            this.PayButton = new System.Windows.Forms.Button();
            this.backToMainMenuButton = new System.Windows.Forms.Button();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mansBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Физ. лицо";
            // 
            // infoAboutCreditListBox
            // 
            this.infoAboutCreditListBox.FormattingEnabled = true;
            this.infoAboutCreditListBox.Location = new System.Drawing.Point(12, 69);
            this.infoAboutCreditListBox.Name = "infoAboutCreditListBox";
            this.infoAboutCreditListBox.Size = new System.Drawing.Size(286, 95);
            this.infoAboutCreditListBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Информация о кредитах:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DisplayMember = "fullName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 183);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите номер кредита:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Сумма оплаты";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "руб.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Дата оплаты:";
            // 
            // payDateLabel
            // 
            this.payDateLabel.AutoSize = true;
            this.payDateLabel.Location = new System.Drawing.Point(186, 226);
            this.payDateLabel.Name = "payDateLabel";
            this.payDateLabel.Size = new System.Drawing.Size(0, 13);
            this.payDateLabel.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.mansBindingSource;
            this.comboBox2.DisplayMember = "fullName";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(286, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.ValueMember = "id";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mansBindingSource
            // 
            this.mansBindingSource.DataMember = "Mans";
            this.mansBindingSource.DataSource = this.bankDataSet;
            // 
            // mansTableAdapter
            // 
            this.mansTableAdapter.ClearBeforeFill = true;
            // 
            // PayButton
            // 
            this.PayButton.Location = new System.Drawing.Point(215, 256);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(82, 32);
            this.PayButton.TabIndex = 12;
            this.PayButton.Text = "Оплатить";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // backToMainMenuButton
            // 
            this.backToMainMenuButton.Location = new System.Drawing.Point(12, 256);
            this.backToMainMenuButton.Name = "backToMainMenuButton";
            this.backToMainMenuButton.Size = new System.Drawing.Size(82, 32);
            this.backToMainMenuButton.TabIndex = 13;
            this.backToMainMenuButton.Text = "Отменить";
            this.backToMainMenuButton.UseVisualStyleBackColor = true;
            this.backToMainMenuButton.Click += new System.EventHandler(this.backToMainMenuButton_Click);
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(12, 223);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(100, 20);
            this.sumTextBox.TabIndex = 14;
            // 
            // PayForCreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 300);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.backToMainMenuButton);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.payDateLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.infoAboutCreditListBox);
            this.Controls.Add(this.label1);
            this.Name = "PayForCreditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оплатить кредит";
            this.Load += new System.EventHandler(this.PayForCreditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mansBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox infoAboutCreditListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label payDateLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource mansBindingSource;
        private BankDataSetTableAdapters.MansTableAdapter mansTableAdapter;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Button backToMainMenuButton;
        private System.Windows.Forms.TextBox sumTextBox;
    }
}