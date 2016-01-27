using System;
using System.Collections.Generic;
using Problem3.CompanyHierarchy.Interfaces;

namespace Problem3.CompanyHierarchy
{
    public class Developer : RegularEmployee, IDeveloper
    {
        public Developer(string id, string firstName, string lastName, double salary, Department department, ISet<Project> projects = null)
            : base(id, firstName, lastName, salary, department)
        {
            this.Projects = projects ?? new HashSet<Project>();
        }

        public ISet<Project> Projects { get; set; }

        public void AddProjects(ISet<Project> projects)
        {
            foreach (var project in projects)
            {
                this.Projects.Add(project);
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Number of projects: {0}\n", this.Projects.Count);
        }
    }
}
