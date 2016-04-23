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
            this.helloLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationAboutClientButton = new System.Windows.Forms.Button();
            this.payTheCreditButton = new System.Windows.Forms.Button();
            this.openAssessTheCreditworthinessFormBatton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openWorkWithDBForm
            // 
            this.openWorkWithDBForm.Location = new System.Drawing.Point(15, 64);
            this.openWorkWithDBForm.Name = "openWorkWithDBForm";
            this.openWorkWithDBForm.Size = new System.Drawing.Size(257, 23);
            this.openWorkWithDBForm.TabIndex = 0;
            this.openWorkWithDBForm.Text = "Работа с базой данных";
            this.openWorkWithDBForm.UseVisualStyleBackColor = true;
            this.openWorkWithDBForm.Click += new System.EventHandler(this.openWorkWithDBForm_Click);
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Location = new System.Drawing.Point(12, 30);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(77, 13);
            this.helloLabel.TabIndex = 1;
            this.helloLabel.Text = "Здравствуйте";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.referenceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem.Text = "Выйти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // referenceToolStripMenuItem
            // 
            this.referenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem});
            this.referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
            this.referenceToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.referenceToolStripMenuItem.Text = "Справка";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutProgramToolStripMenuItem.Text = "О программе";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // informationAboutClientButton
            // 
            this.informationAboutClientButton.Location = new System.Drawing.Point(15, 94);
            this.informationAboutClientButton.Name = "informationAboutClientButton";
            this.informationAboutClientButton.Size = new System.Drawing.Size(257, 23);
            this.informationAboutClientButton.TabIndex = 3;
            this.informationAboutClientButton.Text = "Информация о клиентах";
            this.informationAboutClientButton.UseVisualStyleBackColor = true;
            this.informationAboutClientButton.Click += new System.EventHandler(this.informationAboutClientButton_Click);
            // 
            // payTheCreditButton
            // 
            this.payTheCreditButton.Location = new System.Drawing.Point(12, 156);
            this.payTheCreditButton.Name = "payTheCreditButton";
            this.payTheCreditButton.Size = new System.Drawing.Size(257, 23);
            this.payTheCreditButton.TabIndex = 4;
            this.payTheCreditButton.Text = "Оплатить кредит";
            this.payTheCreditButton.UseVisualStyleBackColor = true;
            this.payTheCreditButton.Click += new System.EventHandler(this.workWithNeuralNetworkButton_Click);
            // 
            // openAssessTheCreditworthinessFormBatton
            // 
            this.openAssessTheCreditworthinessFormBatton.Location = new System.Drawing.Point(15, 124);
            this.openAssessTheCreditworthinessFormBatton.Name = "openAssessTheCreditworthinessFormBatton";
            this.openAssessTheCreditworthinessFormBatton.Size = new System.Drawing.Size(257, 23);
            this.openAssessTheCreditworthinessFormBatton.TabIndex = 5;
            this.openAssessTheCreditworthinessFormBatton.Text = "Выдача кредита";
            this.openAssessTheCreditworthinessFormBatton.UseVisualStyleBackColor = true;
            this.openAssessTheCreditworthinessFormBatton.Click += new System.EventHandler(this.openAssessTheCreditworthinessFormBatton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.openAssessTheCreditworthinessFormBatton);
            this.Controls.Add(this.payTheCreditButton);
            this.Controls.Add(this.informationAboutClientButton);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.openWorkWithDBForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openWorkWithDBForm;
        private System.Windows.Forms.Label helloLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.Button informationAboutClientButton;
        private System.Windows.Forms.Button payTheCreditButton;
        private System.Windows.Forms.Button openAssessTheCreditworthinessFormBatton;
    }
}

