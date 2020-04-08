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

    /// <summary>
    /// Stores information about a named-user license (attended/development).
    /// </summary>
    public partial class LicenseNamedUserDto
    {
        /// <summary>
        /// Initializes a new instance of the LicenseNamedUserDto class.
        /// </summary>
        public LicenseNamedUserDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LicenseNamedUserDto class.
        /// </summary>
        /// <param name="key">The license key.</param>
        /// <param name="userName">The Robot's UserName.</param>
        /// <param name="lastLoginDate">The last date when the Robot acquired a
        /// license.</param>
        /// <param name="machinesCount">Total number of machines where a robot
        /// with UserName is defined.</param>
        /// <param name="isLicensed">If the license is in use.</param>
        /// <param name="activeRobotId">The Id of the Robot that uses the
        /// license.</param>
        /// <param name="machineNames">The Machine names of the defined
        /// Robot.</param>
        /// <param name="activeMachineNames">The Machine names of the connected
        /// and licensed Robot.</param>
        public LicenseNamedUserDto(string key = default(string), string userName = default(string), System.DateTime? lastLoginDate = default(System.DateTime?), int? machinesCount = default(int?), bool? isLicensed = default(bool?), long? activeRobotId = default(long?), IList<string> machineNames = default(IList<string>), IList<string> activeMachineNames = default(IList<string>))
        {
            Key = key;
            UserName = userName;
            LastLoginDate = lastLoginDate;
            MachinesCount = machinesCount;
            IsLicensed = isLicensed;
            ActiveRobotId = activeRobotId;
            MachineNames = machineNames;
            ActiveMachineNames = activeMachineNames;
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
        /// Gets or sets the Robot's UserName.
        /// </summary>
        [JsonProperty(PropertyName = "UserName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the last date when the Robot acquired a license.
        /// </summary>
        [JsonProperty(PropertyName = "LastLoginDate")]
        public System.DateTime? LastLoginDate { get; set; }

        /// <summary>
        /// Gets or sets total number of machines where a robot with UserName
        /// is defined.
        /// </summary>
        [JsonProperty(PropertyName = "MachinesCount")]
        public int? MachinesCount { get; set; }

        /// <summary>
        /// Gets or sets if the license is in use.
        /// </summary>
        [JsonProperty(PropertyName = "IsLicensed")]
        public bool? IsLicensed { get; set; }

        /// <summary>
        /// Gets or sets the Id of the Robot that uses the license.
        /// </summary>
        [JsonProperty(PropertyName = "ActiveRobotId")]
        public long? ActiveRobotId { get; set; }

        /// <summary>
        /// Gets or sets the Machine names of the defined Robot.
        /// </summary>
        [JsonProperty(PropertyName = "MachineNames")]
        public IList<string> MachineNames { get; set; }

        /// <summary>
        /// Gets or sets the Machine names of the connected and licensed Robot.
        /// </summary>
        [JsonProperty(PropertyName = "ActiveMachineNames")]
        public IList<string> ActiveMachineNames { get; set; }

    }
}
