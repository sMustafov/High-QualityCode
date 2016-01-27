namespace Problem3.CompanyHierarchy.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Developer interface.
    /// </summary>
    public interface IDeveloper
    {
        /// <summary>
        /// Gets and sets the developers projects.
        /// </summary>
        ISet<Project> Projects { get; set; }
        /// <summary>
        /// Adding the projects of the developer to set.
        /// </summary>
        /// <param name="projects">The projects to add.</param>
        void AddProjects(ISet<Project> projects);
        /// <summary>
        /// Developers information.
        /// </summary>
        /// <returns>String with the developers information</returns>
        string ToString();
    }
}
