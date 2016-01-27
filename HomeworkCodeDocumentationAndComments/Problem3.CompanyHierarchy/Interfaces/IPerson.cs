namespace Problem3.CompanyHierarchy.Interfaces
{
    /// <summary>
    /// Person interface
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// Gets of sets the persons ID.
        /// </summary>
        string ID { get; set; }
        /// <summary>
        /// Gets ot sets persons first name.
        /// </summary>
        string FirstName { get; set; }
        /// <summary>
        /// Gets ot sets persons last name.
        /// </summary>
        string LastName { get; set; }
        /// <summary>
        /// Persons information to string.
        /// </summary>
        /// <returns>String with persons information.</returns>
        string ToString();
    }
}
