namespace Problem3.CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;
    /// <summary>
    /// The sales Employee interface.
    /// </summary>
    interface ISalesEmployee
    {
        /// <summary>
        /// Set from the sales which can be get or set.
        /// </summary>
        ISet<Sale> Sales { get; set; }
        /// <summary>
        /// Add sales into Set.
        /// </summary>
        /// <param name="sales">The sales which is going to be added.</param>
        void AddSales(ISet<Sale> sales);
        /// <summary>
        /// Employees sales information to string.
        /// </summary>
        /// <returns>The String with information.</returns>
        string ToString();
    }
}
