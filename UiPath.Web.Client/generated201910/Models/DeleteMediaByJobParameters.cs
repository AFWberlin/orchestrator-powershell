// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DeleteMediaByJobParameters
    {
        /// <summary>
        /// Initializes a new instance of the DeleteMediaByJobParameters class.
        /// </summary>
        public DeleteMediaByJobParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeleteMediaByJobParameters class.
        /// </summary>
        public DeleteMediaByJobParameters(long jobId)
        {
            JobId = jobId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "jobId")]
        public long JobId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
