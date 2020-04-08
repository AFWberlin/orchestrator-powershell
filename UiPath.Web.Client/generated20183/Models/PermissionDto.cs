// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20183.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Stores information about an application permission and role
    /// association.
    /// </summary>
    public partial class PermissionDto
    {
        /// <summary>
        /// Initializes a new instance of the PermissionDto class.
        /// </summary>
        public PermissionDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PermissionDto class.
        /// </summary>
        /// <param name="name">The name of the application permission.</param>
        /// <param name="isGranted">States if a user associated with the role
        /// will be allowed or denied to perform the actions governed by the
        /// permission.</param>
        /// <param name="roleId">The Id of the role associated with the
        /// permission.</param>
        public PermissionDto(string name = default(string), bool? isGranted = default(bool?), int? roleId = default(int?), long? id = default(long?))
        {
            Name = name;
            IsGranted = isGranted;
            RoleId = roleId;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the application permission.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets states if a user associated with the role will be
        /// allowed or denied to perform the actions governed by the
        /// permission.
        /// </summary>
        [JsonProperty(PropertyName = "IsGranted")]
        public bool? IsGranted { get; set; }

        /// <summary>
        /// Gets or sets the Id of the role associated with the permission.
        /// </summary>
        [JsonProperty(PropertyName = "RoleId")]
        public int? RoleId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

    }
}
