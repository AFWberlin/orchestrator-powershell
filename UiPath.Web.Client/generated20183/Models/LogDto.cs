// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20183.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Logs generated by Robots and execution reports. Can be stored in
    /// ElasticSearch and/or to a local SQL database.
    /// &lt;para /&gt;Note: The endpoint for this type is /odata/RobotLogs URL.
    /// </summary>
    public partial class LogDto
    {
        /// <summary>
        /// Initializes a new instance of the LogDto class.
        /// </summary>
        public LogDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LogDto class.
        /// </summary>
        /// <param name="level">Defines the log severity. Possible values
        /// include: 'Trace', 'Debug', 'Info', 'Warn', 'Error', 'Fatal'</param>
        /// <param name="windowsIdentity">The name of the user that performed
        /// the action that was logged.</param>
        /// <param name="processName">The name of the process.</param>
        /// <param name="timeStamp">The exact date and time the action was
        /// performed.</param>
        /// <param name="message">The log message. This can also be a message
        /// logged through the Log Message activity in UiPath Studio.</param>
        /// <param name="jobKey">The key of the job running the process that
        /// generated the log, if any.</param>
        /// <param name="rawMessage">A JSON format message containing all the
        /// above fields.</param>
        /// <param name="robotName">The name of the Robot that generated the
        /// log.</param>
        /// <param name="machineId">The Id of the Machine on which the Robot
        /// that generated the log is running.</param>
        public LogDto(LogDtoLevel? level = default(LogDtoLevel?), string windowsIdentity = default(string), string processName = default(string), System.DateTime? timeStamp = default(System.DateTime?), string message = default(string), System.Guid? jobKey = default(System.Guid?), string rawMessage = default(string), string robotName = default(string), long? machineId = default(long?), long? id = default(long?))
        {
            Level = level;
            WindowsIdentity = windowsIdentity;
            ProcessName = processName;
            TimeStamp = timeStamp;
            Message = message;
            JobKey = jobKey;
            RawMessage = rawMessage;
            RobotName = robotName;
            MachineId = machineId;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets defines the log severity. Possible values include:
        /// 'Trace', 'Debug', 'Info', 'Warn', 'Error', 'Fatal'
        /// </summary>
        [JsonProperty(PropertyName = "Level")]
        public LogDtoLevel? Level { get; set; }

        /// <summary>
        /// Gets or sets the name of the user that performed the action that
        /// was logged.
        /// </summary>
        [JsonProperty(PropertyName = "WindowsIdentity")]
        public string WindowsIdentity { get; set; }

        /// <summary>
        /// Gets or sets the name of the process.
        /// </summary>
        [JsonProperty(PropertyName = "ProcessName")]
        public string ProcessName { get; set; }

        /// <summary>
        /// Gets or sets the exact date and time the action was performed.
        /// </summary>
        [JsonProperty(PropertyName = "TimeStamp")]
        public System.DateTime? TimeStamp { get; set; }

        /// <summary>
        /// Gets or sets the log message. This can also be a message logged
        /// through the Log Message activity in UiPath Studio.
        /// </summary>
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the key of the job running the process that generated
        /// the log, if any.
        /// </summary>
        [JsonProperty(PropertyName = "JobKey")]
        public System.Guid? JobKey { get; set; }

        /// <summary>
        /// Gets or sets a JSON format message containing all the above fields.
        /// </summary>
        [JsonProperty(PropertyName = "RawMessage")]
        public string RawMessage { get; set; }

        /// <summary>
        /// Gets or sets the name of the Robot that generated the log.
        /// </summary>
        [JsonProperty(PropertyName = "RobotName")]
        public string RobotName { get; set; }

        /// <summary>
        /// Gets or sets the Id of the Machine on which the Robot that
        /// generated the log is running.
        /// </summary>
        [JsonProperty(PropertyName = "MachineId")]
        public long? MachineId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

    }
}
