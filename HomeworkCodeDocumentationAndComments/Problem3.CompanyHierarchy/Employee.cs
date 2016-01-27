using System;
using Problem3.CompanyHierarchy.Interfaces;

namespace Problem3.CompanyHierarchy
{
    public abstract class Employee : Person, IEmployee
    {
        private double salary;
        private Department department;

        public Employee(string id, string firstName, string lastName, double salary, Department department) 
        : base (id,firstName,lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public double Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The salary cannot be negative");
                }
                this.salary = value;
            }
        }

        public Department Department { get; set; }

        public override string ToString()
        {
            return base.ToString() + String.Format("Salary: {0}\nDepartment: {1}\n", this.Salary, this.Department);
        }
    }
}
