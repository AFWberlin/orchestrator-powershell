// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20184.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ODataResponseListLicenseNamedUserDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ODataResponseListLicenseNamedUserDto class.
        /// </summary>
        public ODataResponseListLicenseNamedUserDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ODataResponseListLicenseNamedUserDto class.
        /// </summary>
        public ODataResponseListLicenseNamedUserDto(string odatacontext = default(string), IList<LicenseNamedUserDto> value = default(IList<LicenseNamedUserDto>))
        {
            Odatacontext = odatacontext;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "@odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<LicenseNamedUserDto> Value { get; set; }

    }
}
