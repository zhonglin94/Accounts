﻿namespace AccountsUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.OccuredTimeLabel = new System.Windows.Forms.Label();
            this.AddNewItemBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.OccuredTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.RequiredIndicator = new System.Windows.Forms.Label();
            this.AddItem = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.HistoryListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TotalExpendTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.TotalIncomeTextBox = new System.Windows.Forms.TextBox();
            this.TotalIncomeLabel = new System.Windows.Forms.Label();
            this.SelectedMonthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TotalRevenueTextBox = new System.Windows.Forms.TextBox();
            this.SelectedTimeLabel = new System.Windows.Forms.Label();
            this.TotalRevenueLabel = new System.Windows.Forms.Label();
            this.TotalExpendLabel = new System.Windows.Forms.Label();
            this.AddNewItemBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(22, 40);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(22, 82);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category";
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Location = new System.Drawing.Point(22, 166);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(44, 13);
            this.ContentLabel.TabIndex = 2;
            this.ContentLabel.Text = "Content";
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Location = new System.Drawing.Point(22, 207);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(30, 13);
            this.NoteLabel.TabIndex = 3;
            this.NoteLabel.Text = "Note";
            // 
            // OccuredTimeLabel
            // 
            this.OccuredTimeLabel.AutoSize = true;
            this.OccuredTimeLabel.Location = new System.Drawing.Point(22, 248);
            this.OccuredTimeLabel.Name = "OccuredTimeLabel";
            this.OccuredTimeLabel.Size = new System.Drawing.Size(71, 13);
            this.OccuredTimeLabel.TabIndex = 4;
            this.OccuredTimeLabel.Text = "OccuredTime";
            // 
            // AddNewItemBox
            // 
            this.AddNewItemBox.Controls.Add(this.label2);
            this.AddNewItemBox.Controls.Add(this.label1);
            this.AddNewItemBox.Controls.Add(this.CurrencyComboBox);
            this.AddNewItemBox.Controls.Add(this.CategoryComboBox);
            this.AddNewItemBox.Controls.Add(this.AmountTextBox);
            this.AddNewItemBox.Controls.Add(this.AmountLabel);
            this.AddNewItemBox.Controls.Add(this.OccuredTimePicker);
            this.AddNewItemBox.Controls.Add(this.NoteTextBox);
            this.AddNewItemBox.Controls.Add(this.ContentTextBox);
            this.AddNewItemBox.Controls.Add(this.NameTextBox);
            this.AddNewItemBox.Controls.Add(this.OccuredTimeLabel);
            this.AddNewItemBox.Controls.Add(this.NameLabel);
            this.AddNewItemBox.Controls.Add(this.NoteLabel);
            this.AddNewItemBox.Controls.Add(this.CategoryLabel);
            this.AddNewItemBox.Controls.Add(this.ContentLabel);
            this.AddNewItemBox.Controls.Add(this.RequiredIndicator);
            this.AddNewItemBox.Location = new System.Drawing.Point(19, 39);
            this.AddNewItemBox.Name = "AddNewItemBox";
            this.AddNewItemBox.Size = new System.Drawing.Size(246, 285);
            this.AddNewItemBox.TabIndex = 5;
            this.AddNewItemBox.TabStop = false;
            this.AddNewItemBox.Text = "Add an Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(218, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(218, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "*";
            // 
            // CurrencyComboBox
            // 
            this.CurrencyComboBox.FormattingEnabled = true;
            this.CurrencyComboBox.Items.AddRange(new object[] {
            "RMB",
            "USD",
            "EUR"});
            this.CurrencyComboBox.Location = new System.Drawing.Point(168, 120);
            this.CurrencyComboBox.Name = "CurrencyComboBox";
            this.CurrencyComboBox.Size = new System.Drawing.Size(50, 21);
            this.CurrencyComboBox.TabIndex = 15;
            this.CurrencyComboBox.SelectedIndexChanged += new System.EventHandler(this.CurrencyComboBox_SelectedIndexChanged);
            this.CurrencyComboBox.SelectedIndex = 0;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Income",
            "Spending"});
            this.CategoryComboBox.Location = new System.Drawing.Point(99, 79);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(119, 21);
            this.CategoryComboBox.TabIndex = 14;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            this.CategoryComboBox.SelectedIndex = 0;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(99, 121);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(63, 20);
            this.AmountTextBox.TabIndex = 11;
            this.AmountTextBox.TextChanged += new System.EventHandler(this.AmountTextBox_TextChanged_1);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(22, 124);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(43, 13);
            this.AmountLabel.TabIndex = 10;
            this.AmountLabel.Text = "Amount";
            // 
            // OccuredTimePicker
            // 
            this.OccuredTimePicker.CustomFormat = "dd-MM-yyyy";
            this.OccuredTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OccuredTimePicker.Location = new System.Drawing.Point(99, 244);
            this.OccuredTimePicker.Name = "OccuredTimePicker";
            this.OccuredTimePicker.Size = new System.Drawing.Size(119, 20);
            this.OccuredTimePicker.TabIndex = 9;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(100, 204);
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(118, 20);
            this.NoteTextBox.TabIndex = 7;
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Location = new System.Drawing.Point(100, 163);
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(118, 20);
            this.ContentTextBox.TabIndex = 6;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(100, 40);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(118, 20);
            this.NameTextBox.TabIndex = 5;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // RequiredIndicator
            // 
            this.RequiredIndicator.AutoSize = true;
            this.RequiredIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequiredIndicator.ForeColor = System.Drawing.Color.Red;
            this.RequiredIndicator.Location = new System.Drawing.Point(218, 42);
            this.RequiredIndicator.Name = "RequiredIndicator";
            this.RequiredIndicator.Size = new System.Drawing.Size(15, 20);
            this.RequiredIndicator.TabIndex = 16;
            this.RequiredIndicator.Text = "*";
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(278, 139);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(53, 23);
            this.AddItem.TabIndex = 6;
            this.AddItem.Text = "Add";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(278, 185);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(53, 23);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // HistoryListBox
            // 
            this.HistoryListBox.FormattingEnabled = true;
            this.HistoryListBox.HorizontalScrollbar = true;
            this.HistoryListBox.Location = new System.Drawing.Point(343, 49);
            this.HistoryListBox.Name = "HistoryListBox";
            this.HistoryListBox.ScrollAlwaysVisible = true;
            this.HistoryListBox.Size = new System.Drawing.Size(322, 277);
            this.HistoryListBox.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TotalExpendTextBox);
            this.groupBox1.Controls.Add(this.CalculateButton);
            this.groupBox1.Controls.Add(this.TotalIncomeTextBox);
            this.groupBox1.Controls.Add(this.TotalIncomeLabel);
            this.groupBox1.Controls.Add(this.SelectedMonthTimePicker);
            this.groupBox1.Controls.Add(this.TotalRevenueTextBox);
            this.groupBox1.Controls.Add(this.SelectedTimeLabel);
            this.groupBox1.Controls.Add(this.TotalRevenueLabel);
            this.groupBox1.Controls.Add(this.TotalExpendLabel);
            this.groupBox1.Location = new System.Drawing.Point(682, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 285);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Analysis";
            // 
            // TotalExpendTextBox
            // 
            this.TotalExpendTextBox.Location = new System.Drawing.Point(100, 87);
            this.TotalExpendTextBox.Name = "TotalExpendTextBox";
            this.TotalExpendTextBox.Size = new System.Drawing.Size(79, 20);
            this.TotalExpendTextBox.TabIndex = 18;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(69, 233);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 17;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // TotalIncomeTextBox
            // 
            this.TotalIncomeTextBox.Location = new System.Drawing.Point(99, 130);
            this.TotalIncomeTextBox.Name = "TotalIncomeTextBox";
            this.TotalIncomeTextBox.Size = new System.Drawing.Size(80, 20);
            this.TotalIncomeTextBox.TabIndex = 11;
            // 
            // TotalIncomeLabel
            // 
            this.TotalIncomeLabel.AutoSize = true;
            this.TotalIncomeLabel.Location = new System.Drawing.Point(22, 133);
            this.TotalIncomeLabel.Name = "TotalIncomeLabel";
            this.TotalIncomeLabel.Size = new System.Drawing.Size(68, 13);
            this.TotalIncomeLabel.TabIndex = 10;
            this.TotalIncomeLabel.Text = "Total income";
            // 
            // SelectedMonthTimePicker
            // 
            this.SelectedMonthTimePicker.CustomFormat = "MM-yyyy";
            this.SelectedMonthTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SelectedMonthTimePicker.Location = new System.Drawing.Point(99, 174);
            this.SelectedMonthTimePicker.Name = "SelectedMonthTimePicker";
            this.SelectedMonthTimePicker.Size = new System.Drawing.Size(80, 20);
            this.SelectedMonthTimePicker.TabIndex = 9;
            // 
            // TotalRevenueTextBox
            // 
            this.TotalRevenueTextBox.Location = new System.Drawing.Point(100, 40);
            this.TotalRevenueTextBox.Name = "TotalRevenueTextBox";
            this.TotalRevenueTextBox.Size = new System.Drawing.Size(79, 20);
            this.TotalRevenueTextBox.TabIndex = 5;
            // 
            // SelectedTimeLabel
            // 
            this.SelectedTimeLabel.AutoSize = true;
            this.SelectedTimeLabel.Location = new System.Drawing.Point(10, 177);
            this.SelectedTimeLabel.Name = "SelectedTimeLabel";
            this.SelectedTimeLabel.Size = new System.Drawing.Size(80, 13);
            this.SelectedTimeLabel.TabIndex = 4;
            this.SelectedTimeLabel.Text = "Occured month";
            // 
            // TotalRevenueLabel
            // 
            this.TotalRevenueLabel.AutoSize = true;
            this.TotalRevenueLabel.Location = new System.Drawing.Point(22, 40);
            this.TotalRevenueLabel.Name = "TotalRevenueLabel";
            this.TotalRevenueLabel.Size = new System.Drawing.Size(73, 13);
            this.TotalRevenueLabel.TabIndex = 0;
            this.TotalRevenueLabel.Text = "Total revenue";
            // 
            // TotalExpendLabel
            // 
            this.TotalExpendLabel.AutoSize = true;
            this.TotalExpendLabel.Location = new System.Drawing.Point(22, 87);
            this.TotalExpendLabel.Name = "TotalExpendLabel";
            this.TotalExpendLabel.Size = new System.Drawing.Size(69, 13);
            this.TotalExpendLabel.TabIndex = 1;
            this.TotalExpendLabel.Text = "Total expend";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 382);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HistoryListBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.AddNewItemBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AddNewItemBox.ResumeLayout(false);
            this.AddNewItemBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.Label NoteLabel;
        private System.Windows.Forms.Label OccuredTimeLabel;
        private System.Windows.Forms.GroupBox AddNewItemBox;
        private System.Windows.Forms.TextBox NoteTextBox;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DateTimePicker OccuredTimePicker;
        private System.Windows.Forms.ListBox HistoryListBox;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.ComboBox CurrencyComboBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TotalIncomeTextBox;
        private System.Windows.Forms.Label TotalIncomeLabel;
        private System.Windows.Forms.DateTimePicker SelectedMonthTimePicker;
        private System.Windows.Forms.TextBox TotalRevenueTextBox;
        private System.Windows.Forms.Label SelectedTimeLabel;
        private System.Windows.Forms.Label TotalRevenueLabel;
        private System.Windows.Forms.Label TotalExpendLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label RequiredIndicator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalExpendTextBox;
    }
}

