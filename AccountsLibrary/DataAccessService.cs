using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AccountsLibrary

{
    public static class DataAccessService
    {
        public static void SaveAccountItems(Accounts account)
        {
            string workingDirectory = Path.Combine(Path.GetDirectoryName(typeof(DataAccessService).Assembly.Location), "Database");
            string filePath = Path.Combine(workingDirectory, "AccountItems.txt");

            using (StreamWriter sw = new StreamWriter(filePath)) {
                foreach(Item item in account)
                {
                    sw.WriteLine(item.ToSaveString());
                }
            }
            //string json = JsonConvert.SerializeObject(account);
            //File.WriteAllText(filePath, json);
        }

        public static Accounts ReadAccountItems()
        {
            Accounts account = new Accounts();
            string workingDirectory = Path.Combine(Path.GetDirectoryName(typeof(DataAccessService).Assembly.Location), "Database");
            string filePath = Path.Combine(workingDirectory, "AccountItems.txt");
            if (!File.Exists(filePath))
                return account;
            using (StreamReader sr = new StreamReader(filePath))
            {
                string[] rows = Regex.Split(sr.ReadToEnd(), @"\r\n");
                
                for (int i = 0; i < rows.Length - 1; i++)
                {
                    Item item = ParseItem(rows[i]);
                    account.Add(item);
                }
            }
            return account;

        }
        private static Item ParseItem(string row)
        {
            string divider = "|";
            int iter = 0;

            string[] elements = Regex.Split(row.Trim(), @"\s+");

            string name = "";
            string categoryStr = "";
            string amountStr = "";
            string currencyStr = "";
            string content = "";
            string note = "";
            string yearStr = "";
            string monthStr = "";
            string dayStr = "";
            for (int i = 0; i <elements.Length; i++)
            {
                if (elements[i] == divider)
                {
                    iter++;
                    i++;
                }               
                if(iter ==0)
                    name += elements[i];
                if (iter == 1)
                    categoryStr += elements[i];
                if (iter ==2)
                    amountStr += elements[i];
                if (iter == 3)
                    currencyStr += elements[i];
                if (iter == 4)
                    note += (elements[i] + " ");
                if (iter == 5)
                    content += (elements[i] + " ");
                if (iter == 6)
                    yearStr += elements[i];
                if (iter == 7)
                    monthStr += elements[i];
                if (iter == 8)
                    dayStr += elements[i];
            }
            Category category = Utils.ReflectCategory(categoryStr);
            double amount = Convert.ToDouble(amountStr);
            Currency currency = Utils.ReflectCurrency(currencyStr);
            int year = Convert.ToInt32(yearStr);
            int month = Convert.ToInt32(monthStr);
            int day = Convert.ToInt32(dayStr);
            DateTime occuredTime = new DateTime(year, month, day);

            return new Item(name, category, amount, currency, note, content, occuredTime);
        }
    }

}
