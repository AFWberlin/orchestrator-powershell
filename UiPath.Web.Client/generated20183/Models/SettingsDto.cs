// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20183.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Used to store various predefined application configurations like time
    /// zone or account e-mail information.
    /// </summary>
    public partial class SettingsDto
    {
        /// <summary>
        /// Initializes a new instance of the SettingsDto class.
        /// </summary>
        public SettingsDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SettingsDto class.
        /// </summary>
        /// <param name="name">The name of a specific setting (e.g.
        /// Abp.Net.Mail.DefaultFromAddress).</param>
        /// <param name="value">The value assigned to a specific setting (e.g.
        /// admin@mydomain.com).</param>
        /// <param name="scope">The scope of a specific setting. Possible
        /// values include: 'Application', 'Tenant', 'User', 'All'</param>
        public SettingsDto(string name, string value = default(string), SettingsDtoScope? scope = default(SettingsDtoScope?), string id = default(string))
        {
            Name = name;
            Value = value;
            Scope = scope;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of a specific setting (e.g.
        /// Abp.Net.Mail.DefaultFromAddress).
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value assigned to a specific setting (e.g.
        /// admin@mydomain.com).
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the scope of a specific setting. Possible values
        /// include: 'Application', 'Tenant', 'User', 'All'
        /// </summary>
        [JsonProperty(PropertyName = "Scope")]
        public SettingsDtoScope? Scope { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

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
