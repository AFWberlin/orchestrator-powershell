// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20181.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class HeartbeatDto
    {
        /// <summary>
        /// Initializes a new instance of the HeartbeatDto class.
        /// </summary>
        public HeartbeatDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HeartbeatDto class.
        /// </summary>
        /// <param name="robotState">Possible values include: 'Available',
        /// 'Busy', 'Disconnected', 'Unknown'</param>
        /// <param name="jobState">Possible values include: 'Pending',
        /// 'Running', 'Stopping', 'Terminating', 'Faulted', 'Successful',
        /// 'Stopped'</param>
        public HeartbeatDto(string robotKey = default(string), HeartbeatDtoRobotState? robotState = default(HeartbeatDtoRobotState?), HeartbeatDtoJobState? jobState = default(HeartbeatDtoJobState?), string jobKey = default(string), string info = default(string))
        {
            RobotKey = robotKey;
            RobotState = robotState;
            JobState = jobState;
            JobKey = jobKey;
            Info = info;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "robotKey")]
        public string RobotKey { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Available', 'Busy',
        /// 'Disconnected', 'Unknown'
        /// </summary>
        [JsonProperty(PropertyName = "robotState")]
        public HeartbeatDtoRobotState? RobotState { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Pending', 'Running',
        /// 'Stopping', 'Terminating', 'Faulted', 'Successful', 'Stopped'
        /// </summary>
        [JsonProperty(PropertyName = "jobState")]
        public HeartbeatDtoJobState? JobState { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "jobKey")]
        public string JobKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "info")]
        public string Info { get; set; }

    }
}
