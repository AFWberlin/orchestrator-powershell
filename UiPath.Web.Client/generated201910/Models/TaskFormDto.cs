// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Dto for task form
    /// </summary>
    public partial class TaskFormDto
    {
        /// <summary>
        /// Initializes a new instance of the TaskFormDto class.
        /// </summary>
        public TaskFormDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskFormDto class.
        /// </summary>
        /// <param name="formLayout">Task Form Layout json</param>
        /// <param name="data">Task form data json</param>
        /// <param name="action">Task form action</param>
        /// <param name="actionLabel">Task form action label</param>
        /// <param name="status">Gets the status of this task. Possible values
        /// include: 'Unassigned', 'Pending', 'Completed'</param>
        /// <param name="assignedToUserId">Gets the id of the user to which
        /// task is assigned</param>
        public TaskFormDto(object formLayout = default(object), object data = default(object), string action = default(string), string actionLabel = default(string), TaskFormDtoStatus? status = default(TaskFormDtoStatus?), long? assignedToUserId = default(long?), long? id = default(long?))
        {
            FormLayout = formLayout;
            Data = data;
            Action = action;
            ActionLabel = actionLabel;
            Status = status;
            AssignedToUserId = assignedToUserId;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets task Form Layout json
        /// </summary>
        [JsonProperty(PropertyName = "formLayout")]
        public object FormLayout { get; set; }

        /// <summary>
        /// Gets or sets task form data json
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; }

        /// <summary>
        /// Gets or sets task form action
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        /// <summary>
        /// Gets or sets task form action label
        /// </summary>
        [JsonProperty(PropertyName = "actionLabel")]
        public string ActionLabel { get; set; }

        /// <summary>
        /// Gets the status of this task. Possible values include:
        /// 'Unassigned', 'Pending', 'Completed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public TaskFormDtoStatus? Status { get; set; }

        /// <summary>
        /// Gets the id of the user to which task is assigned
        /// </summary>
        [JsonProperty(PropertyName = "assignedToUserId")]
        public long? AssignedToUserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long? Id { get; set; }

    }
}
