// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class WebhookSimpleJobDto
    {
        /// <summary>
        /// Initializes a new instance of the WebhookSimpleJobDto class.
        /// </summary>
        public WebhookSimpleJobDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebhookSimpleJobDto class.
        /// </summary>
        /// <param name="state">Possible values include: 'Pending', 'Running',
        /// 'Stopping', 'Terminating', 'Faulted', 'Successful',
        /// 'Stopped'</param>
        public WebhookSimpleJobDto(long? id = default(long?), System.Guid? key = default(System.Guid?), WebhookSimpleJobDtoState? state = default(WebhookSimpleJobDtoState?), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string info = default(string), object outputArguments = default(object), WebhookSimpleRobotDto robot = default(WebhookSimpleRobotDto), WebhookSimpleReleaseDto release = default(WebhookSimpleReleaseDto))
        {
            Id = id;
            Key = key;
            State = state;
            StartTime = startTime;
            EndTime = endTime;
            Info = info;
            OutputArguments = outputArguments;
            Robot = robot;
            Release = release;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public System.Guid? Key { get; private set; }

        /// <summary>
        /// Gets possible values include: 'Pending', 'Running', 'Stopping',
        /// 'Terminating', 'Faulted', 'Successful', 'Stopped'
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public WebhookSimpleJobDtoState? State { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StartTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EndTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Info")]
        public string Info { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OutputArguments")]
        public object OutputArguments { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Robot")]
        public WebhookSimpleRobotDto Robot { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Release")]
        public WebhookSimpleReleaseDto Release { get; private set; }

    }
}
