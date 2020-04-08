// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20184.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IEdmVocabularyAnnotation
    {
        /// <summary>
        /// Initializes a new instance of the IEdmVocabularyAnnotation class.
        /// </summary>
        public IEdmVocabularyAnnotation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IEdmVocabularyAnnotation class.
        /// </summary>
        public IEdmVocabularyAnnotation(string qualifier = default(string), IEdmTerm term = default(IEdmTerm), object target = default(object), IEdmExpression value = default(IEdmExpression))
        {
            Qualifier = qualifier;
            Term = term;
            Target = target;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Qualifier")]
        public string Qualifier { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Term")]
        public IEdmTerm Term { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Target")]
        public object Target { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Value")]
        public IEdmExpression Value { get; private set; }

    }
}
