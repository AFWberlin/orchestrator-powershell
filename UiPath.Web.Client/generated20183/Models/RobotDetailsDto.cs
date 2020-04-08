// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20183.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RobotDetailsDto
    {
        /// <summary>
        /// Initializes a new instance of the RobotDetailsDto class.
        /// </summary>
        public RobotDetailsDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RobotDetailsDto class.
        /// </summary>
        /// <param name="robotKey">The Robot key.</param>
        /// <param name="user">The Robot username.</param>
        /// <param name="machineName">The name of the machine a Robot is hosted
        /// on.</param>
        /// <param name="machineId">The Machine Id.</param>
        /// <param name="robotName">The Robot name.</param>
        /// <param name="robotType">The Robot type. Possible values include:
        /// 'NonProduction', 'Attended', 'Unattended', 'Development'</param>
        /// <param name="hasLicense">Whether the Robot is licensed or
        /// not</param>
        /// <param name="tenantId">The Tenant's Id.</param>
        /// <param name="organizationUnitId">The OrganizationUnit's Id.</param>
        public RobotDetailsDto(string robotKey = default(string), string user = default(string), string machineName = default(string), long? machineId = default(long?), string robotName = default(string), RobotDetailsDtoRobotType? robotType = default(RobotDetailsDtoRobotType?), bool? hasLicense = default(bool?), int? tenantId = default(int?), long? organizationUnitId = default(long?), long? id = default(long?))
        {
            RobotKey = robotKey;
            User = user;
            MachineName = machineName;
            MachineId = machineId;
            RobotName = robotName;
            RobotType = robotType;
            HasLicense = hasLicense;
            TenantId = tenantId;
            OrganizationUnitId = organizationUnitId;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Robot key.
        /// </summary>
        [JsonProperty(PropertyName = "robotKey")]
        public string RobotKey { get; set; }

        /// <summary>
        /// Gets or sets the Robot username.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

        /// <summary>
        /// Gets or sets the name of the machine a Robot is hosted on.
        /// </summary>
        [JsonProperty(PropertyName = "machineName")]
        public string MachineName { get; set; }

        /// <summary>
        /// Gets or sets the Machine Id.
        /// </summary>
        [JsonProperty(PropertyName = "machineId")]
        public long? MachineId { get; set; }

        /// <summary>
        /// Gets or sets the Robot name.
        /// </summary>
        [JsonProperty(PropertyName = "robotName")]
        public string RobotName { get; set; }

        /// <summary>
        /// Gets or sets the Robot type. Possible values include:
        /// 'NonProduction', 'Attended', 'Unattended', 'Development'
        /// </summary>
        [JsonProperty(PropertyName = "robotType")]
        public RobotDetailsDtoRobotType? RobotType { get; set; }

        /// <summary>
        /// Gets or sets whether the Robot is licensed or not
        /// </summary>
        [JsonProperty(PropertyName = "hasLicense")]
        public bool? HasLicense { get; set; }

        /// <summary>
        /// Gets or sets the Tenant's Id.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public int? TenantId { get; set; }

        /// <summary>
        /// Gets or sets the OrganizationUnit's Id.
        /// </summary>
        [JsonProperty(PropertyName = "organizationUnitId")]
        public long? OrganizationUnitId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long? Id { get; set; }

    }
}
