// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Data type used to return Dictionary(string, string)
    /// </summary>
    public partial class ResponseDictionaryDto
    {
        /// <summary>
        /// Initializes a new instance of the ResponseDictionaryDto class.
        /// </summary>
        public ResponseDictionaryDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResponseDictionaryDto class.
        /// </summary>
        public ResponseDictionaryDto(IList<string> keys = default(IList<string>), IList<string> values = default(IList<string>))
        {
            Keys = keys;
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Keys")]
        public IList<string> Keys { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Values")]
        public IList<string> Values { get; set; }

    }
}
