namespace Problem3.CompanyHierarchy.Interfaces
{
    /// <summary>
    /// Employee interface.
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Gets and sets employees salary.
        /// </summary>
        double Salary { get; set; }
        /// <summary>
        /// Gets and sets employees department.
        /// </summary>
        Department Department { get; set; }
        /// <summary>
        /// Employees information.
        /// </summary>
        /// <returns>The information about the employee.</returns>
        string ToString();
    }
}
