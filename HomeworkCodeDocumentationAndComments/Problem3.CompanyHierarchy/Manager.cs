using System;
using System.Collections.Generic;
using Problem3.CompanyHierarchy.Interfaces;

namespace Problem3.CompanyHierarchy
{
    public class Manager : Employee, IEmployee
    {
        public Manager(string id, string firstName, string lastName, double salary, Department department, ISet<Employee> employees = null)
           : base(id, firstName, lastName, salary, department)
        {
            this.Employees = employees ?? new HashSet<Employee>();
        }

        public ISet<Employee> Employees { get; set; }

        public void AddEmployees(ISet<Employee> employees)
        {
            foreach (var employee in employees)
            {
                this.Employees.Add(employee);
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Employees to manage: {0}\n", this.Employees.Count);
        }
    }
}
