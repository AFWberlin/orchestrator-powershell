// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20191.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class WebhookRobotDto
    {
        /// <summary>
        /// Initializes a new instance of the WebhookRobotDto class.
        /// </summary>
        public WebhookRobotDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebhookRobotDto class.
        /// </summary>
        /// <param name="type">Possible values include: 'NonProduction',
        /// 'Attended', 'Unattended', 'Development'</param>
        /// <param name="hostingType">Possible values include: 'Standard',
        /// 'Floating'</param>
        public WebhookRobotDto(long? id = default(long?), string name = default(string), long? machineId = default(long?), string machineName = default(string), string description = default(string), string version = default(string), string userName = default(string), WebhookRobotDtoType? type = default(WebhookRobotDtoType?), WebhookRobotDtoHostingType? hostingType = default(WebhookRobotDtoHostingType?), IList<WebhookEnvironmentDto> environments = default(IList<WebhookEnvironmentDto>), IDictionary<string, object> executionSettings = default(IDictionary<string, object>))
        {
            Id = id;
            Name = name;
            MachineId = machineId;
            MachineName = machineName;
            Description = description;
            Version = version;
            UserName = userName;
            Type = type;
            HostingType = hostingType;
            Environments = environments;
            ExecutionSettings = executionSettings;
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
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MachineId")]
        public long? MachineId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MachineName")]
        public string MachineName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Version")]
        public string Version { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserName")]
        public string UserName { get; private set; }

        /// <summary>
        /// Gets possible values include: 'NonProduction', 'Attended',
        /// 'Unattended', 'Development'
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public WebhookRobotDtoType? Type { get; private set; }

        /// <summary>
        /// Gets possible values include: 'Standard', 'Floating'
        /// </summary>
        [JsonProperty(PropertyName = "HostingType")]
        public WebhookRobotDtoHostingType? HostingType { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Environments")]
        public IList<WebhookEnvironmentDto> Environments { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ExecutionSettings")]
        public IDictionary<string, object> ExecutionSettings { get; private set; }

    }
}
