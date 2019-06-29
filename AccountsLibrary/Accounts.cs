using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountsLibrary.Extensions;

namespace AccountsLibrary
{
    public class Accounts:IEnumerable
    {
        private List<Item> accounts = new List<Item>();
        // Indexer
        public Item this [int index]
        {
            get => accounts[index];
            set => accounts[index]=value;
        }

        public void Add(Item item)
        {
            accounts.Add(item);
        }
        public void Remove(int index)
        {
            accounts.RemoveAt(index);
        }
        public Money TotalRevenue(DateTime time)
        {
            Money revenue = new Money(0);
            foreach (Item item in accounts)
            {
                if (item.OccuredTime.Month == time.Month)
                {
                    if (item.Category == Category.Spending)
                        revenue -= item.Amount;
                    if (item.Category == Category.Income)
                        revenue += item.Amount;
                }
            }
            return revenue;
        }
        public delegate bool FilterHandler(Item item);
        public Money TotalIncome(DateTime time)
        {
            return Calculate(item => time.IsSameMonthOfSameYear(item.OccuredTime) && item.IsIncome());
        }
        public Money TotalExpenditure(DateTime time)
        {
            return Calculate(item => time.IsSameMonthOfSameYear(item.OccuredTime) && item.IsSpending());
        }
        private Money Calculate(FilterHandler filter)
        {
            Money total = new Money(0);
            foreach (Item item in accounts)
            {
                if (filter(item))
                    total += item.Amount;
            }
            return total;
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)accounts).GetEnumerator();
        }
    }
}
