// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20194.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class IEdmReferentialConstraint
    {
        /// <summary>
        /// Initializes a new instance of the IEdmReferentialConstraint class.
        /// </summary>
        public IEdmReferentialConstraint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IEdmReferentialConstraint class.
        /// </summary>
        public IEdmReferentialConstraint(IList<EdmReferentialConstraintPropertyPair> propertyPairs = default(IList<EdmReferentialConstraintPropertyPair>))
        {
            PropertyPairs = propertyPairs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PropertyPairs")]
        public IList<EdmReferentialConstraintPropertyPair> PropertyPairs { get; private set; }

    }
}
