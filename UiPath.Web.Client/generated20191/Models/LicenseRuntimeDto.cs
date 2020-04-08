// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20191.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Stores information about a runtime license (unattended/non-production).
    /// </summary>
    public partial class LicenseRuntimeDto
    {
        /// <summary>
        /// Initializes a new instance of the LicenseRuntimeDto class.
        /// </summary>
        public LicenseRuntimeDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LicenseRuntimeDto class.
        /// </summary>
        /// <param name="key">The license key.</param>
        /// <param name="machineId">The Machine's Id.</param>
        /// <param name="machineName">The Machine's Name.</param>
        /// <param name="runtimes">Maximum number of runtimes.</param>
        /// <param name="robotsCount">Total number of Robots.</param>
        /// <param name="executingCount">How many Robots acquired a
        /// license.</param>
        /// <param name="isOnline">If the machine is online.</param>
        /// <param name="isLicensed">If the machine is licensed.</param>
        /// <param name="enabled">If the machine is allowed to consume
        /// licenses.</param>
        public LicenseRuntimeDto(string key = default(string), long? machineId = default(long?), string machineName = default(string), int? runtimes = default(int?), int? robotsCount = default(int?), int? executingCount = default(int?), bool? isOnline = default(bool?), bool? isLicensed = default(bool?), bool? enabled = default(bool?))
        {
            Key = key;
            MachineId = machineId;
            MachineName = machineName;
            Runtimes = runtimes;
            RobotsCount = robotsCount;
            ExecutingCount = executingCount;
            IsOnline = isOnline;
            IsLicensed = isLicensed;
            Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the license key.
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the Machine's Id.
        /// </summary>
        [JsonProperty(PropertyName = "MachineId")]
        public long? MachineId { get; set; }

        /// <summary>
        /// Gets or sets the Machine's Name.
        /// </summary>
        [JsonProperty(PropertyName = "MachineName")]
        public string MachineName { get; set; }

        /// <summary>
        /// Gets or sets maximum number of runtimes.
        /// </summary>
        [JsonProperty(PropertyName = "Runtimes")]
        public int? Runtimes { get; set; }

        /// <summary>
        /// Gets or sets total number of Robots.
        /// </summary>
        [JsonProperty(PropertyName = "RobotsCount")]
        public int? RobotsCount { get; set; }

        /// <summary>
        /// Gets or sets how many Robots acquired a license.
        /// </summary>
        [JsonProperty(PropertyName = "ExecutingCount")]
        public int? ExecutingCount { get; set; }

        /// <summary>
        /// Gets or sets if the machine is online.
        /// </summary>
        [JsonProperty(PropertyName = "IsOnline")]
        public bool? IsOnline { get; set; }

        /// <summary>
        /// Gets or sets if the machine is licensed.
        /// </summary>
        [JsonProperty(PropertyName = "IsLicensed")]
        public bool? IsLicensed { get; set; }

        /// <summary>
        /// Gets or sets if the machine is allowed to consume licenses.
        /// </summary>
        [JsonProperty(PropertyName = "Enabled")]
        public bool? Enabled { get; set; }

    }
}
