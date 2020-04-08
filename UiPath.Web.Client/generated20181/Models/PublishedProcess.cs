// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20181.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PublishedProcess
    {
        /// <summary>
        /// Initializes a new instance of the PublishedProcess class.
        /// </summary>
        public PublishedProcess()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PublishedProcess class.
        /// </summary>
        public PublishedProcess(string activationKey = default(string), string processName = default(string), System.Guid? processKey = default(System.Guid?), string packageId = default(string), string packageVersion = default(string))
        {
            ActivationKey = activationKey;
            ProcessName = processName;
            ProcessKey = processKey;
            PackageId = packageId;
            PackageVersion = packageVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activationKey")]
        public string ActivationKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processName")]
        public string ProcessName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processKey")]
        public System.Guid? ProcessKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "packageId")]
        public string PackageId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "packageVersion")]
        public string PackageVersion { get; set; }

    }
}
