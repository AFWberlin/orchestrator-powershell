// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20191.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class WebhookSimpleUserDto
    {
        /// <summary>
        /// Initializes a new instance of the WebhookSimpleUserDto class.
        /// </summary>
        public WebhookSimpleUserDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebhookSimpleUserDto class.
        /// </summary>
        /// <param name="userName">The name used to login to
        /// Orchestrator.</param>
        /// <param name="domain">The domain from which the user is
        /// imported</param>
        /// <param name="fullName">The full name of the person constructed with
        /// the format Name Surname.</param>
        /// <param name="emailAddress">The e-mail address associated with the
        /// user.</param>
        /// <param name="type">The user type. Possible values include: 'User',
        /// 'Robot'</param>
        /// <param name="isActive">States if the user is active or not. An
        /// inactive user cannot login to Orchestrator.</param>
        /// <param name="lastLoginTime">The date and time when the user last
        /// logged in, or null if the user never logged in.</param>
        /// <param name="creationTime">The date and time when the user was
        /// created.</param>
        /// <param name="authenticationSource">The source which authenticated
        /// this user.</param>
        public WebhookSimpleUserDto(long? id = default(long?), string userName = default(string), string domain = default(string), string fullName = default(string), string emailAddress = default(string), WebhookSimpleUserDtoType? type = default(WebhookSimpleUserDtoType?), bool? isActive = default(bool?), System.DateTime? lastLoginTime = default(System.DateTime?), System.DateTime? creationTime = default(System.DateTime?), string authenticationSource = default(string))
        {
            Id = id;
            UserName = userName;
            Domain = domain;
            FullName = fullName;
            EmailAddress = emailAddress;
            Type = type;
            IsActive = isActive;
            LastLoginTime = lastLoginTime;
            CreationTime = creationTime;
            AuthenticationSource = authenticationSource;
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
        /// Gets the name used to login to Orchestrator.
        /// </summary>
        [JsonProperty(PropertyName = "UserName")]
        public string UserName { get; private set; }

        /// <summary>
        /// Gets the domain from which the user is imported
        /// </summary>
        [JsonProperty(PropertyName = "Domain")]
        public string Domain { get; private set; }

        /// <summary>
        /// Gets the full name of the person constructed with the format Name
        /// Surname.
        /// </summary>
        [JsonProperty(PropertyName = "FullName")]
        public string FullName { get; private set; }

        /// <summary>
        /// Gets the e-mail address associated with the user.
        /// </summary>
        [JsonProperty(PropertyName = "EmailAddress")]
        public string EmailAddress { get; private set; }

        /// <summary>
        /// Gets the user type. Possible values include: 'User', 'Robot'
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public WebhookSimpleUserDtoType? Type { get; private set; }

        /// <summary>
        /// Gets states if the user is active or not. An inactive user cannot
        /// login to Orchestrator.
        /// </summary>
        [JsonProperty(PropertyName = "IsActive")]
        public bool? IsActive { get; private set; }

        /// <summary>
        /// Gets the date and time when the user last logged in, or null if the
        /// user never logged in.
        /// </summary>
        [JsonProperty(PropertyName = "LastLoginTime")]
        public System.DateTime? LastLoginTime { get; private set; }

        /// <summary>
        /// Gets the date and time when the user was created.
        /// </summary>
        [JsonProperty(PropertyName = "CreationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets the source which authenticated this user.
        /// </summary>
        [JsonProperty(PropertyName = "AuthenticationSource")]
        public string AuthenticationSource { get; private set; }

    }
}
