using System;
using Problem3.CompanyHierarchy.Interfaces;

namespace Problem3.CompanyHierarchy
{
    public class Sale : ISale
    {
        private string name;
        private DateTime date;
        private double price;

        public Sale(string name, DateTime date, double price)
        {
            this.Name = name;
            this.Date = date;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name cannot be empty space");
                }
                this.name = value;
            }
        }

        public DateTime Date { get; set; }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be negative");
                }
                this.price = value;
            }
        }

    }
}
