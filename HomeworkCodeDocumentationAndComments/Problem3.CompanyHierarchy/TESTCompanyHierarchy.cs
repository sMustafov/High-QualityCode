using System;
using System.Collections.Generic;

namespace Problem3.CompanyHierarchy
{
    class TESTCompanyHierarchy
    {
        static void Main()
        {
            Manager manager1 = new Manager("00mm11mm00", "Gergana", "Georgieva", 2000, Department.Accounting);
            Manager manager2 = new Manager("00mm22mm00", "Pesho", "Petrov", 1980, Department.Marketing);
            Manager manager3 = new Manager("00mm33mm00", "Ivan", "Ivanov", 1850, Department.Production);
            Manager manager4 = new Manager("00mm44mm00", "Toshko", "Todorov", 1770, Department.Sales);

            SalesEmployee salesEmployee1 = new SalesEmployee("00se11se00", "Angel", "Angelov", 1950, Department.Accounting);
            SalesEmployee salesEmployee2 = new SalesEmployee("00se22se00", "Kirilka", "Kirova", 1840, Department.Marketing);
            SalesEmployee salesEmployee3 = new SalesEmployee("00se33se00", "Petq", "Petkova", 1690, Department.Production);
            SalesEmployee salesEmployee4 = new SalesEmployee("00se44se00", "Ivanka", "Todorova", 1580, Department.Sales);

            Developer developer1 = new Developer("00dd11dd00", "Dimitur", "Dimitrov", 1830, Department.Accounting);
            Developer developer2 = new Developer("00dd22dd00", "Alex", "Angelova", 1770, Department.Marketing);
            Developer developer3 = new Developer("00dd33dd00", "Maria", "Markova", 1650, Department.Production);
            Developer developer4 = new Developer("00dd44dd00", "Svetlin", "Kirilov", 1590, Department.Sales);


            Sale sale = new Sale("laptop", DateTime.Now, 1200);
            Project project1 = new Project("OOP", DateTime.Now ,"OOP course",State.open);
            Project project2 = new Project("Java", DateTime.Now, "Java course", State.closed);

            manager2.AddEmployees(new HashSet<Employee> { salesEmployee1, developer3,developer2,salesEmployee2 });
            salesEmployee2.AddSales(new HashSet<Sale> { sale });
            developer3.AddProjects(new HashSet<Project> { project1,project2 });

            List<Employee> employees = new List<Employee>()
            {
                manager1,
                manager2,
                manager3,
                manager4,
                salesEmployee1,
                salesEmployee2,
                salesEmployee3,
                salesEmployee4,
                developer1,
                developer2,
                developer3,
                developer4
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
