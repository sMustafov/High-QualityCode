namespace Problem3.CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;
    /// <summary>
    /// Manager interface.
    /// </summary>
    public interface IManager
    {
        /// <summary>
        /// Set with the employees of the manager.
        /// </summary>
        ISet<Employee> Employees { get; set; }
        /// <summary>
        /// Adding of the employee.
        /// </summary>
        /// <param name="employees">Employee which will be added to the set.</param>
        void AddEmployee(ISet<Employee> employees);
        /// <summary>
        /// Information about the manager.
        /// </summary>
        /// <returns>String with information for the manager and his employees.</returns>
        string ToString();
    }
}
