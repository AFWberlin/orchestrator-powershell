// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class LicenseStatsModel
    {
        /// <summary>
        /// Initializes a new instance of the LicenseStatsModel class.
        /// </summary>
        public LicenseStatsModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LicenseStatsModel class.
        /// </summary>
        /// <param name="robotType">Possible values include: 'NonProduction',
        /// 'Attended', 'Unattended', 'Development'</param>
        public LicenseStatsModel(LicenseStatsModelRobotType? robotType = default(LicenseStatsModelRobotType?), long? count = default(long?), System.DateTime? timestamp = default(System.DateTime?))
        {
            RobotType = robotType;
            Count = count;
            Timestamp = timestamp;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'NonProduction', 'Attended',
        /// 'Unattended', 'Development'
        /// </summary>
        [JsonProperty(PropertyName = "robotType")]
        public LicenseStatsModelRobotType? RobotType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public System.DateTime? Timestamp { get; set; }

    }
}
