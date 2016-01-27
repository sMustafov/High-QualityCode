using System;

namespace Problem3.CompanyHierarchy
{
    public class RegularEmployee : Employee
    {
        public RegularEmployee(string id, string firstName, string lastName, double salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
            
        }
    }
}
