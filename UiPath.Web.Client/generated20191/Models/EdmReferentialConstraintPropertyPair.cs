// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20191.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class EdmReferentialConstraintPropertyPair
    {
        /// <summary>
        /// Initializes a new instance of the
        /// EdmReferentialConstraintPropertyPair class.
        /// </summary>
        public EdmReferentialConstraintPropertyPair()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// EdmReferentialConstraintPropertyPair class.
        /// </summary>
        public EdmReferentialConstraintPropertyPair(IEdmStructuralProperty dependentProperty = default(IEdmStructuralProperty), IEdmStructuralProperty principalProperty = default(IEdmStructuralProperty))
        {
            DependentProperty = dependentProperty;
            PrincipalProperty = principalProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DependentProperty")]
        public IEdmStructuralProperty DependentProperty { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrincipalProperty")]
        public IEdmStructuralProperty PrincipalProperty { get; private set; }

    }
}
