// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20183.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Stores data about a version of the various versions of the process
    /// associated with a certain release.
    /// &lt;para /&gt;If a certain version is associated on and off with a
    /// release a new ReleaseVersion object is created for each association.
    /// </summary>
    public partial class ReleaseVersionDto
    {
        /// <summary>
        /// Initializes a new instance of the ReleaseVersionDto class.
        /// </summary>
        public ReleaseVersionDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReleaseVersionDto class.
        /// </summary>
        /// <param name="releaseId">The Id of the parent release.</param>
        /// <param name="versionNumber">The version of process associated with
        /// the release.</param>
        /// <param name="creationTime">The date and time when the version was
        /// associated with the release.</param>
        public ReleaseVersionDto(long releaseId, string versionNumber, System.DateTime? creationTime = default(System.DateTime?), long? id = default(long?))
        {
            ReleaseId = releaseId;
            VersionNumber = versionNumber;
            CreationTime = creationTime;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Id of the parent release.
        /// </summary>
        [JsonProperty(PropertyName = "ReleaseId")]
        public long ReleaseId { get; set; }

        /// <summary>
        /// Gets or sets the version of process associated with the release.
        /// </summary>
        [JsonProperty(PropertyName = "VersionNumber")]
        public string VersionNumber { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the version was associated with
        /// the release.
        /// </summary>
        [JsonProperty(PropertyName = "CreationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (VersionNumber == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VersionNumber");
            }
        }
    }
}
