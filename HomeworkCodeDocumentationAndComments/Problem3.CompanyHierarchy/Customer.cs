using System;
using Problem3.CompanyHierarchy.Interfaces;

namespace Problem3.CompanyHierarchy
{
    public class Customer : Person, ICustomer
    {
        private double purchasesAmount;

        public Customer(string id, string firstName, string lastName, double purchasesAmount) : base(id, firstName, lastName)
        {
            
        }

        public double PurchasesAmount
        {
            get { return this.purchasesAmount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The purchases amount cannot be negative");
                }
                this.purchasesAmount = value;
            }
        }

        public void  AddPurchasePrice(double purchasePrice)
        {
            this.purchasesAmount += purchasePrice;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("Purchases amount: {0}", this.PurchasesAmount);
        }
    } 
}
