// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20191.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ODataResponseListUserLoginAttemptDto
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ODataResponseListUserLoginAttemptDto class.
        /// </summary>
        public ODataResponseListUserLoginAttemptDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ODataResponseListUserLoginAttemptDto class.
        /// </summary>
        public ODataResponseListUserLoginAttemptDto(string odatacontext = default(string), IList<UserLoginAttemptDto> value = default(IList<UserLoginAttemptDto>))
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
        public IList<UserLoginAttemptDto> Value { get; set; }

    }
}
