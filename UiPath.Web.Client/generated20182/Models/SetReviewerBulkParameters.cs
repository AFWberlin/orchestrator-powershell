// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20182.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class SetReviewerBulkParameters
    {
        /// <summary>
        /// Initializes a new instance of the SetReviewerBulkParameters class.
        /// </summary>
        public SetReviewerBulkParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SetReviewerBulkParameters class.
        /// </summary>
        public SetReviewerBulkParameters(long userId, IList<LongVersionedEntity> queueItems = default(IList<LongVersionedEntity>))
        {
            UserId = userId;
            QueueItems = queueItems;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public long UserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queueItems")]
        public IList<LongVersionedEntity> QueueItems { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
