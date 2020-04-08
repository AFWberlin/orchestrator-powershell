// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ToggleRoleParameters
    {
        /// <summary>
        /// Initializes a new instance of the ToggleRoleParameters class.
        /// </summary>
        public ToggleRoleParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ToggleRoleParameters class.
        /// </summary>
        public ToggleRoleParameters(bool toggle, string role = default(string))
        {
            Role = role;
            Toggle = toggle;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "toggle")]
        public bool Toggle { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
