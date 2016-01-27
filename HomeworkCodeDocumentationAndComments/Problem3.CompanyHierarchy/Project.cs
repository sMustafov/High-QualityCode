using System;
using Problem3.CompanyHierarchy.Interfaces;

namespace Problem3.CompanyHierarchy
{
    public class Project : IProject
    {
        private string name;
        private DateTime startDate;
        private string details;
        private State state;

        public Project(string name, DateTime startDate, string details, State state)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
            this.State = State.open;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be empty space");
                }
                this.name = value;
            }
        }

        public DateTime StartDate { get; set; }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be empty space");
                }
                this.details = value;
            }
        }

        public State State { get; set; }

        public void CloseProject()
        {
            this.State = State.closed;
        }
    }
}
