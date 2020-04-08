// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Stores data sent when processing of an existing or a new item starts.
    /// </summary>
    public partial class TransactionDataDto
    {
        /// <summary>
        /// Initializes a new instance of the TransactionDataDto class.
        /// </summary>
        public TransactionDataDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TransactionDataDto class.
        /// </summary>
        /// <param name="name">The name of the queue in which to search for the
        /// next item or in which to insert the item before marking it as
        /// InProgress and sending it to the robot.</param>
        /// <param name="robotIdentifier">The unique key identifying the robot
        /// that sent the request.</param>
        /// <param name="specificContent">If not null a new item will be added
        /// to the queue with this content before being moved to InProgress
        /// state and returned to the robot for processing.
        /// &lt;para /&gt;If null the next available item in the list will be
        /// moved to InProgress state and returned to the robot for
        /// processing.</param>
        /// <param name="deferDate">The earliest date and time at which the
        /// item is available for processing. If empty the item can be
        /// processed as soon as possible.</param>
        /// <param name="dueDate">The latest date and time at which the item
        /// should be processed. If empty the item can be processed at any
        /// given time.</param>
        /// <param name="reference">An optional, user-specified value for queue
        /// item identification.</param>
        /// <param name="referenceFilterOption">Declares the strategy used to
        /// filter the Reference value. Possible values include: 'Equals',
        /// 'StartsWith'</param>
        public TransactionDataDto(string name = default(string), System.Guid? robotIdentifier = default(System.Guid?), IDictionary<string, object> specificContent = default(IDictionary<string, object>), System.DateTime? deferDate = default(System.DateTime?), System.DateTime? dueDate = default(System.DateTime?), string reference = default(string), TransactionDataDtoReferenceFilterOption? referenceFilterOption = default(TransactionDataDtoReferenceFilterOption?))
        {
            Name = name;
            RobotIdentifier = robotIdentifier;
            SpecificContent = specificContent;
            DeferDate = deferDate;
            DueDate = dueDate;
            Reference = reference;
            ReferenceFilterOption = referenceFilterOption;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the queue in which to search for the next
        /// item or in which to insert the item before marking it as InProgress
        /// and sending it to the robot.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the unique key identifying the robot that sent the
        /// request.
        /// </summary>
        [JsonProperty(PropertyName = "RobotIdentifier")]
        public System.Guid? RobotIdentifier { get; set; }

        /// <summary>
        /// Gets or sets if not null a new item will be added to the queue with
        /// this content before being moved to InProgress state and returned to
        /// the robot for processing.
        /// &amp;lt;para /&amp;gt;If null the next available item in the list
        /// will be moved to InProgress state and returned to the robot for
        /// processing.
        /// </summary>
        [JsonProperty(PropertyName = "SpecificContent")]
        public IDictionary<string, object> SpecificContent { get; set; }

        /// <summary>
        /// Gets or sets the earliest date and time at which the item is
        /// available for processing. If empty the item can be processed as
        /// soon as possible.
        /// </summary>
        [JsonProperty(PropertyName = "DeferDate")]
        public System.DateTime? DeferDate { get; set; }

        /// <summary>
        /// Gets or sets the latest date and time at which the item should be
        /// processed. If empty the item can be processed at any given time.
        /// </summary>
        [JsonProperty(PropertyName = "DueDate")]
        public System.DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets an optional, user-specified value for queue item
        /// identification.
        /// </summary>
        [JsonProperty(PropertyName = "Reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets declares the strategy used to filter the Reference
        /// value. Possible values include: 'Equals', 'StartsWith'
        /// </summary>
        [JsonProperty(PropertyName = "ReferenceFilterOption")]
        public TransactionDataDtoReferenceFilterOption? ReferenceFilterOption { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Reference != null)
            {
                if (Reference.Length > 128)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "Reference", 128);
                }
                if (Reference.Length < 0)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Reference", 0);
                }
            }
        }
    }
}
