// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20184.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IEdmSchemaElement
    {
        /// <summary>
        /// Initializes a new instance of the IEdmSchemaElement class.
        /// </summary>
        public IEdmSchemaElement()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IEdmSchemaElement class.
        /// </summary>
        /// <param name="schemaElementKind">Possible values include: 'None',
        /// 'TypeDefinition', 'Term', 'Action', 'EntityContainer',
        /// 'Function'</param>
        public IEdmSchemaElement(IEdmSchemaElementSchemaElementKind? schemaElementKind = default(IEdmSchemaElementSchemaElementKind?), string namespaceProperty = default(string), string name = default(string))
        {
            SchemaElementKind = schemaElementKind;
            NamespaceProperty = namespaceProperty;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets possible values include: 'None', 'TypeDefinition', 'Term',
        /// 'Action', 'EntityContainer', 'Function'
        /// </summary>
        [JsonProperty(PropertyName = "SchemaElementKind")]
        public IEdmSchemaElementSchemaElementKind? SchemaElementKind { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Namespace")]
        public string NamespaceProperty { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; private set; }

    }
}
