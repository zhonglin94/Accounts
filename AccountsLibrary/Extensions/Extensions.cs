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
