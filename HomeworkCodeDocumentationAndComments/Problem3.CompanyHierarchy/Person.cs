using System;
using Problem3.CompanyHierarchy.Interfaces;

namespace Problem3.CompanyHierarchy
{
    public abstract class Person : IPerson
    {
        private string id;
        private string firstName;
        private string lastName;

        protected Person(string id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string ID
        {
            get { return this.id; }
            set
            {
                if (value.Length < 10)
                {
                    throw new ArgumentException("ID cannot be smaller than 10 characters");
                }
                this.id = value;
            }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be empty space");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be empty space");
                }
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}\nID: {1}\nFirst Name: {2}\nLast Name: {3}\n", this.GetType().Name, this.ID,
                this.FirstName, this.LastName);
        }
    }
}
