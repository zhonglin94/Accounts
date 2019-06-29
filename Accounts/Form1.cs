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
            string name = NameTextBox.Text;
            string note = NoteTextBox.Text;
            string content = ContentTextBox.Text;
            DateTime occuredTime = OccuredTimePicker.Value;

        }
        private Category reflectCategory(string category)
        {
            if(category.ToUpper() == "SPENDING")
                return Category.Spending;
            if (category.ToUpper() == "INCOME")
                return Category.Income;
            throw new ArgumentException("Invalid category {0}, it should be income or spending", category);
        }
    }
}
