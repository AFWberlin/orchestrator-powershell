// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20182.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SingleValueNode
    {
        /// <summary>
        /// Initializes a new instance of the SingleValueNode class.
        /// </summary>
        public SingleValueNode()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SingleValueNode class.
        /// </summary>
        /// <param name="kind">Possible values include: 'None', 'Constant',
        /// 'Convert', 'NonResourceRangeVariableReference', 'BinaryOperator',
        /// 'UnaryOperator', 'SingleValuePropertyAccess',
        /// 'CollectionPropertyAccess', 'SingleValueFunctionCall', 'Any',
        /// 'CollectionNavigationNode', 'SingleNavigationNode',
        /// 'SingleValueOpenPropertyAccess', 'SingleResourceCast', 'All',
        /// 'CollectionResourceCast', 'ResourceRangeVariableReference',
        /// 'SingleResourceFunctionCall', 'CollectionFunctionCall',
        /// 'CollectionResourceFunctionCall', 'NamedFunctionParameter',
        /// 'ParameterAlias', 'EntitySet', 'KeyLookup', 'SearchTerm',
        /// 'CollectionOpenPropertyAccess', 'CollectionComplexNode',
        /// 'SingleComplexNode', 'Count'</param>
        public SingleValueNode(IEdmTypeReference typeReference = default(IEdmTypeReference), SingleValueNodeKind? kind = default(SingleValueNodeKind?))
        {
            TypeReference = typeReference;
            Kind = kind;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TypeReference")]
        public IEdmTypeReference TypeReference { get; private set; }

        /// <summary>
        /// Gets possible values include: 'None', 'Constant', 'Convert',
        /// 'NonResourceRangeVariableReference', 'BinaryOperator',
        /// 'UnaryOperator', 'SingleValuePropertyAccess',
        /// 'CollectionPropertyAccess', 'SingleValueFunctionCall', 'Any',
        /// 'CollectionNavigationNode', 'SingleNavigationNode',
        /// 'SingleValueOpenPropertyAccess', 'SingleResourceCast', 'All',
        /// 'CollectionResourceCast', 'ResourceRangeVariableReference',
        /// 'SingleResourceFunctionCall', 'CollectionFunctionCall',
        /// 'CollectionResourceFunctionCall', 'NamedFunctionParameter',
        /// 'ParameterAlias', 'EntitySet', 'KeyLookup', 'SearchTerm',
        /// 'CollectionOpenPropertyAccess', 'CollectionComplexNode',
        /// 'SingleComplexNode', 'Count'
        /// </summary>
        [JsonProperty(PropertyName = "Kind")]
        public SingleValueNodeKind? Kind { get; private set; }

    }
}
