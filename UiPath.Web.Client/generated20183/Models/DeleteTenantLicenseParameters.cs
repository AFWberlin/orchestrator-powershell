// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20183.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DeleteTenantLicenseParameters
    {
        /// <summary>
        /// Initializes a new instance of the DeleteTenantLicenseParameters
        /// class.
        /// </summary>
        public DeleteTenantLicenseParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeleteTenantLicenseParameters
        /// class.
        /// </summary>
        public DeleteTenantLicenseParameters(int tenantId)
        {
            TenantId = tenantId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public int TenantId { get; set; }

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
