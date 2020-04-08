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

    /// <summary>
    /// Stores audit information about any action performed in Orchestrator.
    /// </summary>
    public partial class AuditLogDto
    {
        /// <summary>
        /// Initializes a new instance of the AuditLogDto class.
        /// </summary>
        public AuditLogDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AuditLogDto class.
        /// </summary>
        /// <param name="serviceName">The name of the Orchestrator service that
        /// performed a given action in the system.</param>
        /// <param name="methodName">The name of the service method that
        /// performed a given action in the system.</param>
        /// <param name="parameters">JSON representation of the method
        /// parameters and their values for the given action.</param>
        /// <param name="executionTime">The date and time when the action was
        /// performed.</param>
        /// <param name="action">The action performed (create, update, delete
        /// etc). Possible values include: 'Unknown', 'Create', 'Update',
        /// 'Delete', 'StartJob', 'StopJob', 'Associate', 'Upload',
        /// 'ChangeStatus', 'Import', 'ChangePassword', 'Register', 'Toggle',
        /// 'ResetPassword', 'PasswordResetAttempt'</param>
        /// <param name="component">The component for which the action was
        /// performed. Possible values include: 'Unknown', 'Assets',
        /// 'Environments', 'Processes', 'Queues', 'Robots', 'Roles',
        /// 'Schedules', 'Users', 'Comments', 'Units', 'Jobs', 'Settings',
        /// 'Packages', 'License', 'Tenant', 'Machines', 'Libraries'</param>
        /// <param name="displayName">The display name of the resource acted
        /// on, usually Name</param>
        /// <param name="entityId">The Id of the resource acted on</param>
        /// <param name="operationText">User friendly description of the
        /// change, e.g. "User X created robot Y"</param>
        /// <param name="userName">UserName that sent the request</param>
        /// <param name="userType">The type of user that sent the request.
        /// Possible values include: 'User', 'Robot'</param>
        /// <param name="entities">Audit entity details collection</param>
        /// <param name="userIsDeleted">Marks whether the users that did the
        /// action was deleted in the meantime</param>
        public AuditLogDto(string serviceName = default(string), string methodName = default(string), string parameters = default(string), System.DateTime? executionTime = default(System.DateTime?), AuditLogDtoAction? action = default(AuditLogDtoAction?), AuditLogDtoComponent? component = default(AuditLogDtoComponent?), string displayName = default(string), long? entityId = default(long?), string operationText = default(string), string userName = default(string), AuditLogDtoUserType? userType = default(AuditLogDtoUserType?), IList<AuditLogEntityDto> entities = default(IList<AuditLogEntityDto>), long? userId = default(long?), bool? userIsDeleted = default(bool?), long? id = default(long?))
        {
            ServiceName = serviceName;
            MethodName = methodName;
            Parameters = parameters;
            ExecutionTime = executionTime;
            Action = action;
            Component = component;
            DisplayName = displayName;
            EntityId = entityId;
            OperationText = operationText;
            UserName = userName;
            UserType = userType;
            Entities = entities;
            UserId = userId;
            UserIsDeleted = userIsDeleted;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the Orchestrator service that performed a
        /// given action in the system.
        /// </summary>
        [JsonProperty(PropertyName = "ServiceName")]
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or sets the name of the service method that performed a given
        /// action in the system.
        /// </summary>
        [JsonProperty(PropertyName = "MethodName")]
        public string MethodName { get; set; }

        /// <summary>
        /// Gets or sets JSON representation of the method parameters and their
        /// values for the given action.
        /// </summary>
        [JsonProperty(PropertyName = "Parameters")]
        public string Parameters { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the action was performed.
        /// </summary>
        [JsonProperty(PropertyName = "ExecutionTime")]
        public System.DateTime? ExecutionTime { get; set; }

        /// <summary>
        /// Gets or sets the action performed (create, update, delete etc).
        /// Possible values include: 'Unknown', 'Create', 'Update', 'Delete',
        /// 'StartJob', 'StopJob', 'Associate', 'Upload', 'ChangeStatus',
        /// 'Import', 'ChangePassword', 'Register', 'Toggle', 'ResetPassword',
        /// 'PasswordResetAttempt'
        /// </summary>
        [JsonProperty(PropertyName = "Action")]
        public AuditLogDtoAction? Action { get; set; }

        /// <summary>
        /// Gets or sets the component for which the action was performed.
        /// Possible values include: 'Unknown', 'Assets', 'Environments',
        /// 'Processes', 'Queues', 'Robots', 'Roles', 'Schedules', 'Users',
        /// 'Comments', 'Units', 'Jobs', 'Settings', 'Packages', 'License',
        /// 'Tenant', 'Machines', 'Libraries'
        /// </summary>
        [JsonProperty(PropertyName = "Component")]
        public AuditLogDtoComponent? Component { get; set; }

        /// <summary>
        /// Gets or sets the display name of the resource acted on, usually
        /// Name
        /// </summary>
        [JsonProperty(PropertyName = "DisplayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the Id of the resource acted on
        /// </summary>
        [JsonProperty(PropertyName = "EntityId")]
        public long? EntityId { get; set; }

        /// <summary>
        /// Gets or sets user friendly description of the change, e.g. "User X
        /// created robot Y"
        /// </summary>
        [JsonProperty(PropertyName = "OperationText")]
        public string OperationText { get; set; }

        /// <summary>
        /// Gets or sets userName that sent the request
        /// </summary>
        [JsonProperty(PropertyName = "UserName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the type of user that sent the request. Possible
        /// values include: 'User', 'Robot'
        /// </summary>
        [JsonProperty(PropertyName = "UserType")]
        public AuditLogDtoUserType? UserType { get; set; }

        /// <summary>
        /// Gets or sets audit entity details collection
        /// </summary>
        [JsonProperty(PropertyName = "Entities")]
        public IList<AuditLogEntityDto> Entities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "UserId")]
        public long? UserId { get; set; }

        /// <summary>
        /// Gets or sets marks whether the users that did the action was
        /// deleted in the meantime
        /// </summary>
        [JsonProperty(PropertyName = "UserIsDeleted")]
        public bool? UserIsDeleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

    }
}
