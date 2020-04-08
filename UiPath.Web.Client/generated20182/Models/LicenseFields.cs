// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20182.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LicenseFields
    {
        /// <summary>
        /// Initializes a new instance of the LicenseFields class.
        /// </summary>
        public LicenseFields()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LicenseFields class.
        /// </summary>
        public LicenseFields(long? unattended = default(long?), long? attended = default(long?), long? nonProduction = default(long?), long? development = default(long?))
        {
            Unattended = unattended;
            Attended = attended;
            NonProduction = nonProduction;
            Development = development;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Unattended")]
        public long? Unattended { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Attended")]
        public long? Attended { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NonProduction")]
        public long? NonProduction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Development")]
        public long? Development { get; set; }

    }
}
