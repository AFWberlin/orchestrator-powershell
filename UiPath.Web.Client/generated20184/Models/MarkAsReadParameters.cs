// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20184.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MarkAsReadParameters
    {
        /// <summary>
        /// Initializes a new instance of the MarkAsReadParameters class.
        /// </summary>
        public MarkAsReadParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MarkAsReadParameters class.
        /// </summary>
        public MarkAsReadParameters(IList<string> ids)
        {
            Ids = ids;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ids")]
        public IList<string> Ids { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Ids == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Ids");
            }
        }
    }
}
