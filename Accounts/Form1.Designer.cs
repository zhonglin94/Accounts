namespace Accounts
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
            this.OccuredTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AddItem = new System.Windows.Forms.Button();
            this.LoadHistoryButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.HistoryListBox = new System.Windows.Forms.ListBox();
            this.AddNewItemBox.SuspendLayout();
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
            this.CategoryLabel.Click += new System.EventHandler(this.Category_Click);
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Location = new System.Drawing.Point(22, 125);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(44, 13);
            this.ContentLabel.TabIndex = 2;
            this.ContentLabel.Text = "Content";
            // 
            // NoteLabel
            // 
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.Location = new System.Drawing.Point(22, 166);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(30, 13);
            this.NoteLabel.TabIndex = 3;
            this.NoteLabel.Text = "Note";
            // 
            // OccuredTimeLabel
            // 
            this.OccuredTimeLabel.AutoSize = true;
            this.OccuredTimeLabel.Location = new System.Drawing.Point(22, 207);
            this.OccuredTimeLabel.Name = "OccuredTimeLabel";
            this.OccuredTimeLabel.Size = new System.Drawing.Size(71, 13);
            this.OccuredTimeLabel.TabIndex = 4;
            this.OccuredTimeLabel.Text = "OccuredTime";
            // 
            // AddNewItemBox
            // 
            this.AddNewItemBox.Controls.Add(this.OccuredTimePicker);
            this.AddNewItemBox.Controls.Add(this.CategoryListBox);
            this.AddNewItemBox.Controls.Add(this.NoteTextBox);
            this.AddNewItemBox.Controls.Add(this.ContentTextBox);
            this.AddNewItemBox.Controls.Add(this.NameTextBox);
            this.AddNewItemBox.Controls.Add(this.OccuredTimeLabel);
            this.AddNewItemBox.Controls.Add(this.NameLabel);
            this.AddNewItemBox.Controls.Add(this.NoteLabel);
            this.AddNewItemBox.Controls.Add(this.CategoryLabel);
            this.AddNewItemBox.Controls.Add(this.ContentLabel);
            this.AddNewItemBox.Location = new System.Drawing.Point(64, 60);
            this.AddNewItemBox.Name = "AddNewItemBox";
            this.AddNewItemBox.Size = new System.Drawing.Size(235, 234);
            this.AddNewItemBox.TabIndex = 5;
            this.AddNewItemBox.TabStop = false;
            this.AddNewItemBox.Text = "Add an Item";
            // 
            // OccuredTimePicker
            // 
            this.OccuredTimePicker.CustomFormat = "dd-MM-yyyy";
            this.OccuredTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OccuredTimePicker.Location = new System.Drawing.Point(99, 203);
            this.OccuredTimePicker.Name = "OccuredTimePicker";
            this.OccuredTimePicker.Size = new System.Drawing.Size(101, 20);
            this.OccuredTimePicker.TabIndex = 9;
            this.OccuredTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.Items.AddRange(new object[] {
            "Spending",
            "Income"});
            this.CategoryListBox.Location = new System.Drawing.Point(100, 75);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(100, 30);
            this.CategoryListBox.TabIndex = 8;
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Location = new System.Drawing.Point(100, 163);
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.Size = new System.Drawing.Size(100, 20);
            this.NoteTextBox.TabIndex = 7;
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Location = new System.Drawing.Point(100, 122);
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(100, 20);
            this.ContentTextBox.TabIndex = 6;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(100, 40);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 5;
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(136, 338);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(75, 23);
            this.AddItem.TabIndex = 6;
            this.AddItem.Text = "Add item";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // LoadHistoryButton
            // 
            this.LoadHistoryButton.Location = new System.Drawing.Point(497, 338);
            this.LoadHistoryButton.Name = "LoadHistoryButton";
            this.LoadHistoryButton.Size = new System.Drawing.Size(75, 23);
            this.LoadHistoryButton.TabIndex = 11;
            this.LoadHistoryButton.Text = "Load history";
            this.LoadHistoryButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(616, 338);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Delete item";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // HistoryListBox
            // 
            this.HistoryListBox.FormattingEnabled = true;
            this.HistoryListBox.Location = new System.Drawing.Point(398, 69);
            this.HistoryListBox.Name = "HistoryListBox";
            this.HistoryListBox.Size = new System.Drawing.Size(346, 225);
            this.HistoryListBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HistoryListBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.LoadHistoryButton);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.AddNewItemBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AddNewItemBox.ResumeLayout(false);
            this.AddNewItemBox.PerformLayout();
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
        private System.Windows.Forms.ListBox CategoryListBox;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button LoadHistoryButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DateTimePicker OccuredTimePicker;
        private System.Windows.Forms.ListBox HistoryListBox;
    }
}

