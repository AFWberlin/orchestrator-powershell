// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20183.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class IEdmNavigationSource
    {
        /// <summary>
        /// Initializes a new instance of the IEdmNavigationSource class.
        /// </summary>
        public IEdmNavigationSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IEdmNavigationSource class.
        /// </summary>
        public IEdmNavigationSource(IList<IEdmNavigationPropertyBinding> navigationPropertyBindings = default(IList<IEdmNavigationPropertyBinding>), IEdmPathExpression path = default(IEdmPathExpression), IEdmType type = default(IEdmType), string name = default(string))
        {
            NavigationPropertyBindings = navigationPropertyBindings;
            Path = path;
            Type = type;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "NavigationPropertyBindings")]
        public IList<IEdmNavigationPropertyBinding> NavigationPropertyBindings { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Path")]
        public IEdmPathExpression Path { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public IEdmType Type { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; private set; }

    }
}
