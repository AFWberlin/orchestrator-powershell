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
    /// Defines the resources such as assets or robots for a Credential Store.
    /// </summary>
    public partial class CredentialStoreResourceDto
    {
        /// <summary>
        /// Initializes a new instance of the CredentialStoreResourceDto class.
        /// </summary>
        public CredentialStoreResourceDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CredentialStoreResourceDto class.
        /// </summary>
        /// <param name="type">Possible values include: 'AssetCredential',
        /// 'RobotCredential'</param>
        public CredentialStoreResourceDto(string name, CredentialStoreResourceDtoType type, long? id = default(long?))
        {
            Name = name;
            Type = type;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'AssetCredential',
        /// 'RobotCredential'
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public CredentialStoreResourceDtoType Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

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
