// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20183.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class RobotCommand
    {
        /// <summary>
        /// Initializes a new instance of the RobotCommand class.
        /// </summary>
        public RobotCommand()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RobotCommand class.
        /// </summary>
        /// <param name="robotKey">Target robot</param>
        /// <param name="robotType">Possible values include: 'NonProduction',
        /// 'Attended', 'Unattended', 'Development'</param>
        public RobotCommand(string robotKey = default(string), string username = default(string), string robotName = default(string), RobotCommandRobotType? robotType = default(RobotCommandRobotType?), long? machineId = default(long?), bool? hasLicense = default(bool?), IDictionary<string, object> executionSettings = default(IDictionary<string, object>), Command data = default(Command))
        {
            RobotKey = robotKey;
            Username = username;
            RobotName = robotName;
            RobotType = robotType;
            MachineId = machineId;
            HasLicense = hasLicense;
            ExecutionSettings = executionSettings;
            Data = data;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets target robot
        /// </summary>
        [JsonProperty(PropertyName = "robotKey")]
        public string RobotKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "robotName")]
        public string RobotName { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'NonProduction', 'Attended',
        /// 'Unattended', 'Development'
        /// </summary>
        [JsonProperty(PropertyName = "robotType")]
        public RobotCommandRobotType? RobotType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "machineId")]
        public long? MachineId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hasLicense")]
        public bool? HasLicense { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "executionSettings")]
        public IDictionary<string, object> ExecutionSettings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public Command Data { get; set; }

    }
}
