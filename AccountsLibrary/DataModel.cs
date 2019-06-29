using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLibrary
{
    public enum Category
    {
        Spending,
        Income
    }

    public enum Currency
    {
        RMB,
        USD,
        EUR
    }

    public class Money
    {
        public double Value;
        public Currency Currency;

        // Constructor
        public Money(double value)
        {
            Value = value;
            Currency = Currency.RMB;
        }
        public Money(double value, Currency currency)
        {
            Value = value;
            Currency = currency;
        }

        public static Money operator +(Money value1, Money value2)
        {
            double totalValue = value1.ValueInRMB + value2.ValueInRMB;
            return new Money(totalValue);
        }
        public static Money operator -(Money value1, Money value2)
        {
            double totalValue = value1.ValueInRMB - value2.ValueInRMB;
            return new Money(totalValue);
        }

        private double ValueInRMB
        {
            get
            {
                return Value * getExchangeRate(this.Currency);
            }
        }
        private double getExchangeRate(Currency currency)
        {
            switch (currency)
            {
                // the exchange rate should be taken from the Internet dynamically
                case Currency.EUR:
                    return 7.76;
                case Currency.USD:
                    return 6.92;
                case Currency.RMB:
                    return 1;
                default:
                    throw new ArgumentException("The currency stype should be EUR, USD, or RMB");
            }
        }

        public override string ToString()
        {
            if (Currency != Currency.RMB)
                return $"{Value} {Currency} ({ValueInRMB} RMB)";
            else
                return $"{Value} {Currency}";

        }

        public class Item
        {
            protected string Name { get; set; }
            public Category Category { get; set; }
            protected string Content { get; set; }
            protected string Note { get; set; }
            public Money Money;
            public DateTime OccuredTime;

            private string categoryType
            {
                get => Category == Category.Spending ? "-" : "+";
            }

            // Constructor
            public Item(string name, Category itemCategory, double amount) : this(name, itemCategory, amount, Currency.RMB, "None", "None", DateTime.Now) { }
            public Item(string name, Category itemCategory, double amount, Currency currency) : this(name, itemCategory, amount, currency, "None", "None", DateTime.Now) { }
            public Item(string name, Category itemCategory, double amount, Currency currency, string content) : this(name, itemCategory, amount, currency, content, "None", DateTime.Now) { }
            public Item(string name, Category itemCategory, double amount, Currency currency, string content, string note) : this(name, itemCategory, amount, currency, content, note, DateTime.Now) { }
            public Item(string name, Category itemCategory, double amount, DateTime occuredTime) : this(name, itemCategory, amount, Currency.RMB, "None", "None", occuredTime) { }
            public Item(string name, Category itemCategory, double amount, Currency currency, DateTime occuredTime) : this(name, itemCategory, amount, currency, "None", "None", occuredTime) { }
            public Item(string name, Category itemCategory, double amount, Currency currency, string content, string note, DateTime occuredTime)
            {
                if (name == "" && name == null)
                {
                    throw new ArgumentException("The input item name is not valid");
                }
                if (itemCategory != Category.Income && itemCategory != Category.Spending)
                {
                    throw new ArgumentException("The item category should be either spending or income");
                }
                if (amount == 0)
                {
                    throw new ArgumentException("The amount should not be zero");

                }

                this.Name = name;
                this.Category = itemCategory;
                this.Content = content;
                this.Note = note;
                this.Money = new Money(amount, currency);
                this.OccuredTime = occuredTime;
            }
            public override string ToString()
            {
                return $"{Name} {categoryType}{Money.ToString()}: Content: {Content} | Note: {Note} | occuredTime: {OccuredTime.ToString("MMMM dd, yyyy")} ";
            }
        }
    }

    public class Item
    {
        protected string Name { get; set; }
        public Category Category { get; set; }
        protected string Content { get; set; }
        protected string Note { get; set; }
        public Money Amount;
        public DateTime OccuredTime;

        private string categoryType
        {
            get => Category == Category.Spending ? "-" : "+";
        }

        // Constructor
        public Item(string name, Category itemCategory, double amount) : this(name, itemCategory, amount, Currency.RMB, "None", "None", DateTime.Now) { }
        public Item(string name, Category itemCategory, double amount, Currency currency) : this(name, itemCategory, amount, currency, "None", "None", DateTime.Now) { }
        public Item(string name, Category itemCategory, double amount, Currency currency, string content) : this(name, itemCategory, amount, currency, content, "None", DateTime.Now) { }
        public Item(string name, Category itemCategory, double amount, Currency currency, string content, string note) : this(name, itemCategory, amount, currency, content, note, DateTime.Now) { }
        public Item(string name, Category itemCategory, double amount, DateTime occuredTime) : this(name, itemCategory, amount, Currency.RMB, "None", "None", occuredTime) { }
        public Item(string name, Category itemCategory, double amount, Currency currency, DateTime occuredTime) : this(name, itemCategory, amount, currency, "None", "None", occuredTime) { }
        public Item(string name, Category itemCategory, double amount, Currency currency, string content, string note, DateTime occuredTime)
        {
            if (name == "" && name == null)
            {
                throw new ArgumentException("The input item name is not valid");
            }
            if (itemCategory != Category.Income && itemCategory != Category.Spending)
            {
                throw new ArgumentException("The item category should be either spending or income");
            }
            if (amount == 0)
            {
                throw new ArgumentException("The amount should not be zero");

            }

            this.Name = name;
            this.Category = itemCategory;
            this.Content = content;
            this.Note = note;
            this.Amount = new Money(amount, currency);
            this.OccuredTime = occuredTime;
        }
        public override string ToString()
        {
            return $"{Name} {categoryType}{Amount.ToString()}: Content: {Content} | Note: {Note} | occuredTime: {OccuredTime.ToString("MMMM dd, yyyy")} ";
        }

        public bool IsSpending()
        {
            return Category == Category.Spending;
        }

        public bool IsIncome()
        {
            return Category == Category.Income;
        }
    }
}
