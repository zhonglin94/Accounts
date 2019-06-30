using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsLibrary.Extensions
{
    public static class Extensions
    {
        public static bool IsSameMonthOfSameYear(this DateTime dateTime, DateTime targetDateTime)
        {
            return dateTime.Year == targetDateTime.Year && dateTime.Month == targetDateTime.Month;
        }

        public static bool ValidateEmpty(this TextBox textBox)
        {
            if (null == textBox.Text || "" == textBox.Text)
                return false;
            return true;
        }
        public static bool ValidateUniqeName(this TextBox textBox)
        {
            Accounts account = DataAccessService.ReadAccountItems();
            if(account != null)
            {
                foreach(Item item in account)
                {
                    if (item.Name.ToUpper() == textBox.Text.ToUpper())
                        return false;
                }
            }
            return true;
        }
        public static bool ValidatePositiveNumber(this TextBox textBox)
        {
            if (textBox.Text !="" && Convert.ToDouble(textBox.Text) <= 0)
                return false;
            return true;
        }

        public static bool ValidateEmpty(this ComboBox textBox)
        {
            if (null == textBox.Text || "" == textBox.Text)
                return false;
            return true;
        }

        public static bool ValidateEmpty(this DateTimePicker dateTimePicker )
        {
            if (null == dateTimePicker)
                return false;
            return true;
        }





    }
}
