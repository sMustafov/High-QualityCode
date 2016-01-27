namespace Problem3.CompanyHierarchy.Interfaces
{
    using System;

    /// <summary>
    /// Project interface.
    /// </summary>
    public interface IProject
    {
        /// <summary>
        /// Gets and sets the name of the project.
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Gets and sets the starting project.
        /// </summary>
        DateTime StartDate { get; set; }
        /// <summary>
        /// Gets and sets the datails.
        /// </summary>
        string Details { get; set; }
        /// <summary>
        /// Gets and sets the projects state.
        /// </summary>
        State State { get; set; }
        /// <summary>
        /// Clese the project.
        /// </summary>
        void CloseProject();
    }
}
