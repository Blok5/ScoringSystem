namespace ScoringSystem {
    partial class MainMenu {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.openWorkWithDBForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openWorkWithDBForm
            // 
            this.openWorkWithDBForm.Location = new System.Drawing.Point(13, 63);
            this.openWorkWithDBForm.Name = "openWorkWithDBForm";
            this.openWorkWithDBForm.Size = new System.Drawing.Size(259, 23);
            this.openWorkWithDBForm.TabIndex = 0;
            this.openWorkWithDBForm.Text = "Работа с базой данных";
            this.openWorkWithDBForm.UseVisualStyleBackColor = true;
            this.openWorkWithDBForm.Click += new System.EventHandler(this.openWorkWithDBForm_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.openWorkWithDBForm);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openWorkWithDBForm;
    }
}

