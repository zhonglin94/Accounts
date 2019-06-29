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
            string[] elements = Regex.Split(row.Trim(), @"\s+");
            string name = elements[0];
            Category category = Utils.ReflectCategory(elements[1]);
            double amount = Convert.ToDouble(elements[2]);
            Currency currency = Utils.ReflectCurrency(elements[3]);
            string content = elements[4];
            string note = elements[5];
            int year = Convert.ToInt32(elements[6]);
            int month = Convert.ToInt32(elements[7]);
            int day = Convert.ToInt32(elements[8]);
            DateTime occuredTime = new DateTime(year, month, day);

            return new Item(name, category, amount, currency, note, content, occuredTime);
        }
    }

}
