namespace ScoringSystem.WorkWithDB {
    partial class WorkWithDBForm {
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
            this.openAddManForm = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openAddManForm
            // 
            this.openAddManForm.Location = new System.Drawing.Point(12, 47);
            this.openAddManForm.Name = "openAddManForm";
            this.openAddManForm.Size = new System.Drawing.Size(259, 23);
            this.openAddManForm.TabIndex = 0;
            this.openAddManForm.Text = "Добавить человека";
            this.openAddManForm.UseVisualStyleBackColor = true;
            this.openAddManForm.Click += new System.EventHandler(this.addManForm_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 226);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // WorkWithDBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.openAddManForm);
            this.Name = "WorkWithDBForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа с БД";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openAddManForm;
        private System.Windows.Forms.Button backButton;
    }
}