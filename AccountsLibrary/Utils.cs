using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLibrary
{
    public static class Utils
    {
        public static  Category ReflectCategory(string category)
        {
            if (category.ToUpper() == "SPENDING")
                return Category.Spending;
            return Category.Income;
        }
        public static Currency ReflectCurrency(string currency)
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
    }
}
