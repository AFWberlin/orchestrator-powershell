// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Task Catalog entity for Creating or Updating Task Catalog
    /// </summary>
    public partial class TaskCatalogRequest
    {
        /// <summary>
        /// Initializes a new instance of the TaskCatalogRequest class.
        /// </summary>
        public TaskCatalogRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskCatalogRequest class.
        /// </summary>
        /// <param name="name">Name of the Task Catalog.</param>
        /// <param name="description">Description of this task catalog.</param>
        public TaskCatalogRequest(string name, string description = default(string))
        {
            Name = name;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the Task Catalog.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets description of this task catalog.
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
