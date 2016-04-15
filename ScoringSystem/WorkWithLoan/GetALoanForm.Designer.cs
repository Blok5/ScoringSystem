namespace ScoringSystem.WorkWithLoan {
    partial class GetALoanForm {
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
            this.searchButton = new System.Windows.Forms.Button();
            this.searchNameTextBox = new System.Windows.Forms.TextBox();
            this.searchSurnametextBox = new System.Windows.Forms.TextBox();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(362, 8);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 39);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchNameTextBox
            // 
            this.searchNameTextBox.Location = new System.Drawing.Point(12, 27);
            this.searchNameTextBox.Name = "searchNameTextBox";
            this.searchNameTextBox.Size = new System.Drawing.Size(177, 20);
            this.searchNameTextBox.TabIndex = 1;
            // 
            // searchSurnametextBox
            // 
            this.searchSurnametextBox.Location = new System.Drawing.Point(195, 27);
            this.searchSurnametextBox.Name = "searchSurnametextBox";
            this.searchSurnametextBox.Size = new System.Drawing.Size(161, 20);
            this.searchSurnametextBox.TabIndex = 2;
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.Location = new System.Drawing.Point(13, 56);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.ScrollAlwaysVisible = true;
            this.resultListBox.Size = new System.Drawing.Size(424, 225);
            this.resultListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фамилия";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(362, 295);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 39);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Завершить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GetALoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 338);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.searchSurnametextBox);
            this.Controls.Add(this.searchNameTextBox);
            this.Controls.Add(this.searchButton);
            this.Name = "GetALoanForm";
            this.Text = "Выдача кредита";
            this.Load += new System.EventHandler(this.GetALoanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchNameTextBox;
        private System.Windows.Forms.TextBox searchSurnametextBox;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button button2;
    }
}