namespace Problem3.CompanyHierarchy.Interfaces
{
    using System;

    /// <summary>
    /// The sales inteface.
    /// </summary>
    public interface ISale
    {
        /// <summary>
        /// Gets or sets the name of the sale.
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        DateTime Date { get; set; }
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        double Price { get; set; }
    }
}
