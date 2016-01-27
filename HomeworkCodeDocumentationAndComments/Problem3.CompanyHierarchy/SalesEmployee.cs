using System;
using System.Collections.Generic;
using Problem3.CompanyHierarchy.Interfaces;

namespace Problem3.CompanyHierarchy
{
    public class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        public SalesEmployee(string id, string firstName, string lastName, double salary, Department department, ISet<Sale> sales = null)
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales ?? new HashSet<Sale>();
        }

        public ISet<Sale> Sales { get; set; }

        public void AddSales(ISet<Sale> sales)
        {
            foreach (var sale in sales)
            {
                this.Sales.Add(sale);
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Number of sales: {0}\n", this.Sales.Count);
        }
    }
}
