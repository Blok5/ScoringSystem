﻿namespace ScoringSystem.WorkWithLoan {
    partial class AssessTheCreditworthinessForm {
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
            this.backButton = new System.Windows.Forms.Button();
            this.approveButton = new System.Windows.Forms.Button();
            this.refuseButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.o2Label = new System.Windows.Forms.Label();
            this.o1Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.creditPeriodLabel = new System.Windows.Forms.Label();
            this.creditSumLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 299);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // approveButton
            // 
            this.approveButton.Location = new System.Drawing.Point(251, 298);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(75, 23);
            this.approveButton.TabIndex = 3;
            this.approveButton.Text = "Одобрить";
            this.approveButton.UseVisualStyleBackColor = true;
            this.approveButton.Click += new System.EventHandler(this.approveButton_Click);
            // 
            // refuseButton
            // 
            this.refuseButton.Location = new System.Drawing.Point(170, 299);
            this.refuseButton.Name = "refuseButton";
            this.refuseButton.Size = new System.Drawing.Size(75, 23);
            this.refuseButton.TabIndex = 4;
            this.refuseButton.Text = "Отказать";
            this.refuseButton.UseVisualStyleBackColor = true;
            this.refuseButton.Click += new System.EventHandler(this.refuseButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(6, 89);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 5;
            // 
            // o2Label
            // 
            this.o2Label.AutoSize = true;
            this.o2Label.Location = new System.Drawing.Point(155, 42);
            this.o2Label.Name = "o2Label";
            this.o2Label.Size = new System.Drawing.Size(0, 13);
            this.o2Label.TabIndex = 6;
            // 
            // o1Label
            // 
            this.o1Label.AutoSize = true;
            this.o1Label.Location = new System.Drawing.Point(6, 42);
            this.o1Label.Name = "o1Label";
            this.o1Label.Size = new System.Drawing.Size(0, 13);
            this.o1Label.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Отношение к классу 1 (да):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Отношение к классу 2 (нет):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Решение:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.resultLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.o2Label);
            this.groupBox1.Controls.Add(this.o1Label);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 129);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результат работы нейронной сети:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Общее решение:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toLabel);
            this.groupBox2.Controls.Add(this.fromLabel);
            this.groupBox2.Controls.Add(this.creditPeriodLabel);
            this.groupBox2.Controls.Add(this.creditSumLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о кредите";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(132, 44);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(0, 13);
            this.toLabel.TabIndex = 3;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(7, 44);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(0, 13);
            this.fromLabel.TabIndex = 2;
            // 
            // creditPeriodLabel
            // 
            this.creditPeriodLabel.AutoSize = true;
            this.creditPeriodLabel.Location = new System.Drawing.Point(197, 20);
            this.creditPeriodLabel.Name = "creditPeriodLabel";
            this.creditPeriodLabel.Size = new System.Drawing.Size(0, 13);
            this.creditPeriodLabel.TabIndex = 1;
            // 
            // creditSumLabel
            // 
            this.creditSumLabel.AutoSize = true;
            this.creditSumLabel.Location = new System.Drawing.Point(7, 20);
            this.creditSumLabel.Name = "creditSumLabel";
            this.creditSumLabel.Size = new System.Drawing.Size(0, 13);
            this.creditSumLabel.TabIndex = 0;
            // 
            // AssessTheCreditworthinessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 334);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.refuseButton);
            this.Controls.Add(this.approveButton);
            this.Controls.Add(this.backButton);
            this.Name = "AssessTheCreditworthinessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Группа кредитоспособности";
            this.Load += new System.EventHandler(this.AssessTheCreditworthinessForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button approveButton;
        private System.Windows.Forms.Button refuseButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label o2Label;
        private System.Windows.Forms.Label o1Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label creditPeriodLabel;
        private System.Windows.Forms.Label creditSumLabel;
    }
}