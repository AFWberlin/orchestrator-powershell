// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20191.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class IEdmModel
    {
        /// <summary>
        /// Initializes a new instance of the IEdmModel class.
        /// </summary>
        public IEdmModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IEdmModel class.
        /// </summary>
        public IEdmModel(IList<IEdmSchemaElement> schemaElements = default(IList<IEdmSchemaElement>), IList<IEdmVocabularyAnnotation> vocabularyAnnotations = default(IList<IEdmVocabularyAnnotation>), IList<IEdmModel> referencedModels = default(IList<IEdmModel>), IList<string> declaredNamespaces = default(IList<string>), object directValueAnnotationsManager = default(object), IEdmEntityContainer entityContainer = default(IEdmEntityContainer))
        {
            SchemaElements = schemaElements;
            VocabularyAnnotations = vocabularyAnnotations;
            ReferencedModels = referencedModels;
            DeclaredNamespaces = declaredNamespaces;
            DirectValueAnnotationsManager = directValueAnnotationsManager;
            EntityContainer = entityContainer;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SchemaElements")]
        public IList<IEdmSchemaElement> SchemaElements { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "VocabularyAnnotations")]
        public IList<IEdmVocabularyAnnotation> VocabularyAnnotations { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferencedModels")]
        public IList<IEdmModel> ReferencedModels { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DeclaredNamespaces")]
        public IList<string> DeclaredNamespaces { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DirectValueAnnotationsManager")]
        public object DirectValueAnnotationsManager { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityContainer")]
        public IEdmEntityContainer EntityContainer { get; private set; }

    }
}
