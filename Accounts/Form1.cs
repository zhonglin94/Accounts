using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountsLibrary;
using AccountsLibrary.Extensions;

namespace Accounts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Category_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            if (!ValidateUserInputs())
                return;
            string name = NameTextBox.Text;
            string note = NoteTextBox.Text;
            string content = ContentTextBox.Text;
            Category category = this.ReflectCategory(CategoryComboBox.Text);
            double amount = Convert.ToDouble(AmountTextBox.Text);
            Currency currency = this.ReflectCurrency(CurrencyComboBox.Text);
            DateTime occuredTime = OccuredTimePicker.Value;
            Item item = new Item(name, category, amount, currency, occuredTime);

        }
        private Category ReflectCategory(string category)
        {
            if(category.ToUpper() == "SPENDING")
                return Category.Spending;
            return Category.Income;    
        }
        private Currency ReflectCurrency(string currency)
        {
            switch (currency.ToUpper())
            {
                case "RMB":
                    return Currency.RMB;
                case "USD":
                    return Currency.USD;
                case "EUR":
                    return Currency.EUR;
                default:
                    return Currency.RMB;
            }

        }

        private bool ValidateUserInputs()
        {
            int failedCount = 0;
            if (!NameTextBox.ValidateEmpty())
            {
                NameTextBox.BackColor =Color.OrangeRed;
                NameTextBox.Focus();
                failedCount++;
            }
            if (!AmountTextBox.ValidateEmpty())
            {
                AmountTextBox.BackColor =Color.OrangeRed;
                AmountTextBox.Focus();
                failedCount++;
            }
            if (!CategoryComboBox.ValidateEmpty())
            {
                CategoryComboBox.BackColor =Color.OrangeRed;
                CategoryComboBox.Focus();
                failedCount++;
            }
            if (!CurrencyComboBox.ValidateEmpty())
            {
                CurrencyComboBox.BackColor =Color.OrangeRed;
                CurrencyComboBox.Focus();
                failedCount++;
            }
            if (!OccuredTimePicker.ValidateEmpty())
            {
                OccuredTimePicker.BackColor = Color.OrangeRed;
                OccuredTimePicker.Focus();
                failedCount++;
            }
            if (failedCount > 0)
                return false;
            else
                return true;
        }
        

        private void AmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (AmountTextBox.ValidateEmpty())
                AmountTextBox.BackColor = System.Drawing.Color.White;
            if(!char.IsDigit(e.KeyChar))
                MessageBox.Show("Only numeric number is supported ");
            
        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (AmountTextBox.ValidateEmpty())
                AmountTextBox.BackColor = System.Drawing.Color.White;

        }

        private void NoteTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextBox.ValidateEmpty())
                NameTextBox.BackColor = System.Drawing.Color.White;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.ValidateEmpty())
                CategoryComboBox.BackColor = System.Drawing.Color.White;

        }

        private void CurrencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrencyComboBox.ValidateEmpty())
                CurrencyComboBox.BackColor = System.Drawing.Color.White;

        }

        private void AmountTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
