namespace Problem3.CompanyHierarchy.Interfaces
{
    /// <summary>
    /// Customer interface.
    /// </summary>
    public interface ICustomer
    {
        /// <summary>
        /// Gets and sets the purchased amount of the costumer.
        /// </summary>
        double PurchasesAmount { get; set; }
        /// <summary>
        /// Adding of purchased products.
        /// </summary>
        /// <param name="purchasePrice">The price of the purchased product which will be added.</param>
        void AddPurchasePrice(double purchasePrice);
        /// <summary>
        /// Information about the customer.
        /// </summary>
        /// <returns>String with information about the costumer.</returns>
        string ToString();
    }
}
