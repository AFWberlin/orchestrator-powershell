// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ODataResponseListKeyValuePairStringString
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ODataResponseListKeyValuePairStringString class.
        /// </summary>
        public ODataResponseListKeyValuePairStringString()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ODataResponseListKeyValuePairStringString class.
        /// </summary>
        public ODataResponseListKeyValuePairStringString(string odatacontext = default(string), IList<KeyValuePairStringString> value = default(IList<KeyValuePairStringString>))
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
        public IList<KeyValuePairStringString> Value { get; set; }

    }
}
