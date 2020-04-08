// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IEdmType
    {
        /// <summary>
        /// Initializes a new instance of the IEdmType class.
        /// </summary>
        public IEdmType()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IEdmType class.
        /// </summary>
        /// <param name="typeKind">Possible values include: 'None',
        /// 'Primitive', 'Entity', 'Complex', 'Collection', 'EntityReference',
        /// 'Enum', 'TypeDefinition', 'Untyped', 'Path'</param>
        public IEdmType(IEdmTypeTypeKind? typeKind = default(IEdmTypeTypeKind?))
        {
            TypeKind = typeKind;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets possible values include: 'None', 'Primitive', 'Entity',
        /// 'Complex', 'Collection', 'EntityReference', 'Enum',
        /// 'TypeDefinition', 'Untyped', 'Path'
        /// </summary>
        [JsonProperty(PropertyName = "TypeKind")]
        public IEdmTypeTypeKind? TypeKind { get; private set; }

    }
}
