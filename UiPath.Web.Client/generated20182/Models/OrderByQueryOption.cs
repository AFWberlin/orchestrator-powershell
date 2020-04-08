// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20182.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class OrderByQueryOption
    {
        /// <summary>
        /// Initializes a new instance of the OrderByQueryOption class.
        /// </summary>
        public OrderByQueryOption()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrderByQueryOption class.
        /// </summary>
        public OrderByQueryOption(ODataQueryContext context = default(ODataQueryContext), IList<OrderByNode> orderByNodes = default(IList<OrderByNode>), string rawValue = default(string), object validator = default(object), OrderByClause orderByClause = default(OrderByClause))
        {
            Context = context;
            OrderByNodes = orderByNodes;
            RawValue = rawValue;
            Validator = validator;
            OrderByClause = orderByClause;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Context")]
        public ODataQueryContext Context { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrderByNodes")]
        public IList<OrderByNode> OrderByNodes { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RawValue")]
        public string RawValue { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Validator")]
        public object Validator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "OrderByClause")]
        public OrderByClause OrderByClause { get; private set; }

    }
}
