﻿namespace ScoringSystem.InformationAboutClients {
    partial class InformationAboutClients {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInfoAboutManFormButton = new System.Windows.Forms.Button();
            this.infoAboutCreditButton = new System.Windows.Forms.Button();
            this.backToMainMenuButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 3;
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
            // openInfoAboutManFormButton
            // 
            this.openInfoAboutManFormButton.Location = new System.Drawing.Point(13, 56);
            this.openInfoAboutManFormButton.Name = "openInfoAboutManFormButton";
            this.openInfoAboutManFormButton.Size = new System.Drawing.Size(259, 23);
            this.openInfoAboutManFormButton.TabIndex = 4;
            this.openInfoAboutManFormButton.Text = "Посмотреть информацию о человеке";
            this.openInfoAboutManFormButton.UseVisualStyleBackColor = true;
            this.openInfoAboutManFormButton.Click += new System.EventHandler(this.openInfoAboutManFormButton_Click);
            // 
            // infoAboutCreditButton
            // 
            this.infoAboutCreditButton.Location = new System.Drawing.Point(13, 86);
            this.infoAboutCreditButton.Name = "infoAboutCreditButton";
            this.infoAboutCreditButton.Size = new System.Drawing.Size(259, 23);
            this.infoAboutCreditButton.TabIndex = 5;
            this.infoAboutCreditButton.Text = "Информация о кредите";
            this.infoAboutCreditButton.UseVisualStyleBackColor = true;
            this.infoAboutCreditButton.Click += new System.EventHandler(this.infoAboutCreditButton_Click);
            // 
            // backToMainMenuButton
            // 
            this.backToMainMenuButton.Location = new System.Drawing.Point(13, 226);
            this.backToMainMenuButton.Name = "backToMainMenuButton";
            this.backToMainMenuButton.Size = new System.Drawing.Size(75, 23);
            this.backToMainMenuButton.TabIndex = 6;
            this.backToMainMenuButton.Text = "Назад";
            this.backToMainMenuButton.UseVisualStyleBackColor = true;
            this.backToMainMenuButton.Click += new System.EventHandler(this.backToMainMenuButton_Click);
            // 
            // InformationAboutClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.backToMainMenuButton);
            this.Controls.Add(this.infoAboutCreditButton);
            this.Controls.Add(this.openInfoAboutManFormButton);
            this.Controls.Add(this.menuStrip1);
            this.Name = "InformationAboutClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о клиентах";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.Button openInfoAboutManFormButton;
        private System.Windows.Forms.Button infoAboutCreditButton;
        private System.Windows.Forms.Button backToMainMenuButton;
    }
}